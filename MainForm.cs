using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Genshin_Lyre_Midi_Tool.Models;
using Genshin_Lyre_Midi_Tool.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Sanford.Multimedia.Midi;

namespace Genshin_Lyre_Midi_Tool
{
    public partial class MainForm : MaterialForm
    {
        #region 转换字符
        private Dictionary<string, int> letter = new Dictionary<string, int>
        {
            { "a", 65},{ "b", 66},{ "c", 67},{ "d", 68},{ "e", 69},{ "f", 70},{ "g", 71},{ "h", 72},{ "i", 73},{ "j", 74},{ "k", 75},{ "l", 76},{ "m", 77},{ "n", 78},{ "o", 79},{ "p", 80},{ "q", 81},{ "r", 82},{ "s", 83},{ "t", 84},{ "u", 85},{ "v", 86},{ "w", 87},{ "x", 88},{ "y", 89},{ "z", 90 }
        };

        public int d { get; set; } = 61;
        private Dictionary<int, string> mapping = new Dictionary<int, string>
        {
            {48, "z"},{ 50, "x"},{ 52, "c"},{ 53, "v"},{ 55, "b"},{ 57, "n"},{ 59, "m"},{ 60, "a"},{ 62, "s"},{ 64, "d"},{ 65, "f"},{ 67, "g"},{ 69, "h"},{ 71, "j"},{ 72, "q"},{ 74, "w"},{ 76, "e"},{ 77, "r"},{ 79, "t"},{ 81, "y"},{ 83, "u"}
        };

        #endregion

        #region MaterialForm变量
        private readonly ComponentResourceManager _languageResourceManager = new ComponentResourceManager(typeof(LanguageResource));
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        #endregion
        /// <summary>
        /// midi文件夹 
        /// </summary>
        private DirectoryInfo midiFolderInfo = new DirectoryInfo("songs");
        /// <summary>
        /// 当前工作midi
        /// </summary>
        private MidiInfo workingMidiInfo;
        /// <summary>
        /// midi输出设备
        /// </summary>
        private OutputDevice outDevice;
        public MainForm()
        {
            //测试其他语言
            // System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            //初始化窗口
            InitializeComponent();
            InitializeLocalization(Controls);
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue500, Primary.LightBlue700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            midiFileList.SmallImageList = new ImageList() {ImageSize = new Size(1, 30)};
            //初始化midi输出设备
            if (OutputDevice.DeviceCount == 0)
            {
                MaterialMessageBox.Show(_languageResourceManager.GetString("NoMidiOutPut"), _languageResourceManager.GetString("Error"));
            }
            else
            {
                try
                {
                    outDevice = new OutputDevice(0);
                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show(ex.ToString(), _languageResourceManager.GetString("Error"));
                }
            }

            //初始化设置
            SelectMidiFolder();
            Text = _languageResourceManager.GetString("NoFile");

        }
            /// <summary>
            /// 选择midi文件夹
            /// </summary>
            /// <param name="newPath"></param>
        private void SelectMidiFolder(string newPath=null)
        {
            if (newPath!=null)
            {
                midiFolderInfo = new DirectoryInfo(newPath);
            }
            if (midiFolderInfo.Exists == false)
            {
                midiFolderInfo.Create();
            }
            midiFolderPathTextBox.Text = midiFolderInfo.FullName;
            midiFileList.Items.Clear();
            foreach (var file in midiFolderInfo.GetFiles())
            {
                midiFileList.Items.Add(new ListViewItem() {Text = file.Name,SubItems = { file.Name}});
            }
        }
         private void OpenMidiFile(string fileName)
         {
             workingMidiInfo = new MidiInfo(midiFolderPathTextBox.Text+"\\"+fileName);
             workingMidiInfo.StateChangedEvent += midiInfo_StateChangedEvent;
             workingMidiInfo.StateIdleEvent += midiInfo_StateIdleEvent;
             workingMidiInfo.StatePlayingEvent += midiInfo_StatePlayingEvent;
             workingMidiInfo.PlayingStopEvent += midi_PlayingStop;
             workingMidiInfo.Sequence.LoadCompleted += sequence_LoadCompleted;
             workingMidiInfo.Sequence.LoadProgressChanged += sequence_LoadProgressChanged;
             workingMidiInfo.Sequencer.ChannelMessagePlayed += sequencer_ChannelMessagePlayed;
             materialTabControl1.Enabled = false;
        }
        /// <summary>
        /// 控件本地化
        /// </summary>
        /// <param name="parent"></param>
        private void InitializeLocalization(Control.ControlCollection parent)
        {
            for (int i = 0; i < parent.Count; i++)
            {
                var control = parent[i];
                _languageResourceManager.ApplyResources(control, control.Text);
                if (control.GetType()==typeof(MaterialListView))
                {
                    var mlv = (MaterialListView) control;
                    for (int j = 0; j < mlv.Columns.Count; j++)
                    {
                        _languageResourceManager.ApplyResources(mlv.Columns[j], mlv.Columns[j].Text);
                    }
                }
                if (control.Controls.Count>0)
                {
                    InitializeLocalization(control.Controls);
                }
            }
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            var  rs = folderBrowserDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                SelectMidiFolder(folderBrowserDialog1.SelectedPath);
            }
        }

        private void openMidiButton_Click(object sender, EventArgs e)
        {
            OpenMidiFile(midiFileList.SelectedItems[0].Text);
        }

        private void refreshMidiListButton_Click(object sender, EventArgs e)
        {
            SelectMidiFolder();
        } 
        private void midiInfo_StateChangedEvent(object sender, EventArgs e)
        {
            playButton.Text = _languageResourceManager.GetString(workingMidiInfo.State == MidiInfoSate.Playing ? "Pause" : "playButton.Text");

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            switch (workingMidiInfo.State)
            {
                case MidiInfoSate.Playing:
                    workingMidiInfo.State = MidiInfoSate.Paused;
                    break;
                default:
                    workingMidiInfo.State = MidiInfoSate.Playing;
                    break;
            }
           
        }


        private void sequence_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            materialTabControl1.Enabled = true;
            Text = workingMidiInfo.FileName;
            materialProgressBar1.Value = 0;
            materialProgressBar1.Maximum = workingMidiInfo.Sequence.GetLength();
        }

        private void sequence_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Text = _languageResourceManager.GetString("Loading") + " (" + e.ProgressPercentage + " / 100)";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            workingMidiInfo?.Dispose();
            outDevice?.Dispose();
        }
        private void sequencer_ChannelMessagePlayed(object sender, ChannelMessageEventArgs e)
        {
            pianoControl1.Send(e.Message);

            outDevice.Send(e.Message);
            // Console.WriteLine($"{e.Message.MessageType} - {e.Message.Command} : {e.Message.Data1} {e.Message.Data2} | {e.Message.MidiChannel}");
            // try
            // {
            //     switch (e.Message.Command)
            //     {
            //         case  ChannelCommand.NoteOn :
            //             WindowsAPIHelper.keybd_event((byte)letter[mapping[e.Message.Data1]], 0, 0, 0);
            //             break;
            //         case ChannelCommand.NoteOff:
            //             WindowsAPIHelper.keybd_event((byte)letter[mapping[e.Message.Data1]], 0, 2, 0);
            //             break;
            //     }
            // }
            // catch (Exception exception)
            // {
            // }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            materialProgressBar1.Value = workingMidiInfo.Sequencer.Position;
        }

        private void midi_PlayingStop(object sender, EventArgs e)
        {
            timer1.Stop();
            pianoControl1.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            workingMidiInfo.State = MidiInfoSate.Idle;
        }
        private void midiInfo_StateIdleEvent(object sender, EventArgs e)
        {
            materialProgressBar1.Value = 0;
        } 
        private void midiInfo_StatePlayingEvent(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var whitList = new[] { 0, 3 };
            if ((workingMidiInfo != null && workingMidiInfo.State != MidiInfoSate.Loading)|| whitList.Contains(e.TabPageIndex))
                return;
            e.Cancel = true;
        }
    }
}
