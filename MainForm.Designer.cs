using MaterialSkin.Controls;

namespace Genshin_Lyre_Midi_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.openMidi = new System.Windows.Forms.TabPage();
            this.saveMidiButton = new MaterialSkin.Controls.MaterialButton();
            this.openMidiButton = new MaterialSkin.Controls.MaterialButton();
            this.refreshMidiListButton = new MaterialSkin.Controls.MaterialButton();
            this.midiFileList = new MaterialSkin.Controls.MaterialListView();
            this.fileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.openFolderButton = new MaterialSkin.Controls.MaterialButton();
            this.midiFolderPathTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.editTrack = new System.Windows.Forms.TabPage();
            this.previewAndPlay = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.stopButton = new MaterialSkin.Controls.MaterialButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.playButton = new MaterialSkin.Controls.MaterialButton();
            this.pianoControl1 = new Sanford.Multimedia.Midi.UI.PianoControl();
            this.settingsAndAbout = new System.Windows.Forms.TabPage();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.openMidi.SuspendLayout();
            this.previewAndPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.openMidi);
            this.materialTabControl1.Controls.Add(this.editTrack);
            this.materialTabControl1.Controls.Add(this.previewAndPlay);
            this.materialTabControl1.Controls.Add(this.settingsAndAbout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.IconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(894, 444);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialTabControl1_Selecting);
            // 
            // openMidi
            // 
            this.openMidi.Controls.Add(this.saveMidiButton);
            this.openMidi.Controls.Add(this.openMidiButton);
            this.openMidi.Controls.Add(this.refreshMidiListButton);
            this.openMidi.Controls.Add(this.midiFileList);
            this.openMidi.Controls.Add(this.folderLabel);
            this.openMidi.Controls.Add(this.openFolderButton);
            this.openMidi.Controls.Add(this.midiFolderPathTextBox);
            this.openMidi.ImageKey = "baseline_music_note_white_24dp.png";
            this.openMidi.Location = new System.Drawing.Point(4, 31);
            this.openMidi.Name = "openMidi";
            this.openMidi.Padding = new System.Windows.Forms.Padding(3);
            this.openMidi.Size = new System.Drawing.Size(886, 409);
            this.openMidi.TabIndex = 0;
            this.openMidi.Text = "openMidi";
            this.openMidi.UseVisualStyleBackColor = true;
            // 
            // saveMidiButton
            // 
            this.saveMidiButton.AutoSize = false;
            this.saveMidiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveMidiButton.Depth = 0;
            this.saveMidiButton.DrawShadows = true;
            this.saveMidiButton.Enabled = false;
            this.saveMidiButton.HighEmphasis = true;
            this.saveMidiButton.Icon = null;
            this.saveMidiButton.Location = new System.Drawing.Point(556, 335);
            this.saveMidiButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveMidiButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveMidiButton.Name = "saveMidiButton";
            this.saveMidiButton.Size = new System.Drawing.Size(131, 39);
            this.saveMidiButton.TabIndex = 6;
            this.saveMidiButton.Text = "SaveMidiButton";
            this.saveMidiButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.saveMidiButton.UseAccentColor = false;
            this.saveMidiButton.UseVisualStyleBackColor = true;
            // 
            // openMidiButton
            // 
            this.openMidiButton.AutoSize = false;
            this.openMidiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openMidiButton.Depth = 0;
            this.openMidiButton.DrawShadows = true;
            this.openMidiButton.HighEmphasis = true;
            this.openMidiButton.Icon = null;
            this.openMidiButton.Location = new System.Drawing.Point(695, 335);
            this.openMidiButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openMidiButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openMidiButton.Name = "openMidiButton";
            this.openMidiButton.Size = new System.Drawing.Size(131, 39);
            this.openMidiButton.TabIndex = 5;
            this.openMidiButton.Text = "OpenMidiButton";
            this.openMidiButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openMidiButton.UseAccentColor = false;
            this.openMidiButton.UseVisualStyleBackColor = true;
            this.openMidiButton.Click += new System.EventHandler(this.openMidiButton_Click);
            // 
            // refreshMidiListButton
            // 
            this.refreshMidiListButton.AutoSize = false;
            this.refreshMidiListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshMidiListButton.Depth = 0;
            this.refreshMidiListButton.DrawShadows = true;
            this.refreshMidiListButton.HighEmphasis = true;
            this.refreshMidiListButton.Icon = null;
            this.refreshMidiListButton.Location = new System.Drawing.Point(12, 335);
            this.refreshMidiListButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.refreshMidiListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshMidiListButton.Name = "refreshMidiListButton";
            this.refreshMidiListButton.Size = new System.Drawing.Size(131, 39);
            this.refreshMidiListButton.TabIndex = 4;
            this.refreshMidiListButton.Text = "RefreshMidiListButton";
            this.refreshMidiListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.refreshMidiListButton.UseAccentColor = true;
            this.refreshMidiListButton.UseVisualStyleBackColor = true;
            this.refreshMidiListButton.Click += new System.EventHandler(this.refreshMidiListButton_Click);
            // 
            // midiFileList
            // 
            this.midiFileList.AutoSizeTable = false;
            this.midiFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.midiFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.midiFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColumn});
            this.midiFileList.Depth = 0;
            this.midiFileList.FullRowSelect = true;
            this.midiFileList.HideSelection = false;
            this.midiFileList.LabelWrap = false;
            this.midiFileList.Location = new System.Drawing.Point(12, 64);
            this.midiFileList.MaximumSize = new System.Drawing.Size(814, 262);
            this.midiFileList.MinimumSize = new System.Drawing.Size(814, 262);
            this.midiFileList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.midiFileList.MouseState = MaterialSkin.MouseState.OUT;
            this.midiFileList.MultiSelect = false;
            this.midiFileList.Name = "midiFileList";
            this.midiFileList.OwnerDraw = true;
            this.midiFileList.ShowGroups = false;
            this.midiFileList.Size = new System.Drawing.Size(814, 262);
            this.midiFileList.TabIndex = 3;
            this.midiFileList.UseCompatibleStateImageBehavior = false;
            this.midiFileList.View = System.Windows.Forms.View.Details;
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.Tag = "";
            this.fileNameColumn.Text = "fileNameColumn";
            this.fileNameColumn.Width = 790;
            // 
            // folderLabel
            // 
            this.folderLabel.Depth = 0;
            this.folderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.folderLabel.Location = new System.Drawing.Point(9, 22);
            this.folderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(71, 23);
            this.folderLabel.TabIndex = 2;
            this.folderLabel.Text = "folderLabel";
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openFolderButton
            // 
            this.openFolderButton.AutoSize = false;
            this.openFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFolderButton.Depth = 0;
            this.openFolderButton.DrawShadows = true;
            this.openFolderButton.HighEmphasis = true;
            this.openFolderButton.Icon = null;
            this.openFolderButton.Location = new System.Drawing.Point(695, 12);
            this.openFolderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openFolderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(131, 39);
            this.openFolderButton.TabIndex = 1;
            this.openFolderButton.Text = "selectFolderButton";
            this.openFolderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openFolderButton.UseAccentColor = false;
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // midiFolderPathTextBox
            // 
            this.midiFolderPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.midiFolderPathTextBox.Depth = 0;
            this.midiFolderPathTextBox.DetectUrls = false;
            this.midiFolderPathTextBox.Enabled = false;
            this.midiFolderPathTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.midiFolderPathTextBox.Location = new System.Drawing.Point(86, 8);
            this.midiFolderPathTextBox.MaxLength = 50;
            this.midiFolderPathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.midiFolderPathTextBox.Multiline = false;
            this.midiFolderPathTextBox.Name = "midiFolderPathTextBox";
            this.midiFolderPathTextBox.ReadOnly = true;
            this.midiFolderPathTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.midiFolderPathTextBox.Size = new System.Drawing.Size(602, 50);
            this.midiFolderPathTextBox.TabIndex = 0;
            this.midiFolderPathTextBox.Text = "";
            this.midiFolderPathTextBox.WordWrap = false;
            // 
            // editTrack
            // 
            this.editTrack.ImageKey = "baseline_edit_white_24dp.png";
            this.editTrack.Location = new System.Drawing.Point(4, 31);
            this.editTrack.Name = "editTrack";
            this.editTrack.Padding = new System.Windows.Forms.Padding(3);
            this.editTrack.Size = new System.Drawing.Size(886, 409);
            this.editTrack.TabIndex = 1;
            this.editTrack.Text = "editTrack";
            this.editTrack.UseVisualStyleBackColor = true;
            // 
            // previewAndPlay
            // 
            this.previewAndPlay.Controls.Add(this.materialLabel3);
            this.previewAndPlay.Controls.Add(this.materialLabel1);
            this.previewAndPlay.Controls.Add(this.stopButton);
            this.previewAndPlay.Controls.Add(this.materialProgressBar1);
            this.previewAndPlay.Controls.Add(this.playButton);
            this.previewAndPlay.Controls.Add(this.pianoControl1);
            this.previewAndPlay.ImageKey = "baseline_piano_white_24dp.png";
            this.previewAndPlay.Location = new System.Drawing.Point(4, 31);
            this.previewAndPlay.Name = "previewAndPlay";
            this.previewAndPlay.Size = new System.Drawing.Size(886, 409);
            this.previewAndPlay.TabIndex = 2;
            this.previewAndPlay.Text = "previewAndPlay";
            this.previewAndPlay.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(90, 48);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(598, 23);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "100000 / 10000000000";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = false;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Depth = 0;
            this.stopButton.DrawShadows = true;
            this.stopButton.HighEmphasis = true;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(695, 57);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(131, 39);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "stopButton";
            this.stopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.stopButton.UseAccentColor = true;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(12, 74);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(676, 5);
            this.materialProgressBar1.TabIndex = 3;
            // 
            // playButton
            // 
            this.playButton.AutoSize = false;
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.Depth = 0;
            this.playButton.DrawShadows = true;
            this.playButton.HighEmphasis = true;
            this.playButton.Icon = null;
            this.playButton.Location = new System.Drawing.Point(695, 6);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.playButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(131, 39);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "playButton";
            this.playButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.playButton.UseAccentColor = false;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pianoControl1
            // 
            this.pianoControl1.HighNoteID = 109;
            this.pianoControl1.Location = new System.Drawing.Point(12, 294);
            this.pianoControl1.LowNoteID = 21;
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Size = new System.Drawing.Size(814, 80);
            this.pianoControl1.TabIndex = 0;
            this.pianoControl1.Text = "pianoControl1";
            // 
            // settingsAndAbout
            // 
            this.settingsAndAbout.ImageKey = "baseline_settings_white_24dp.png";
            this.settingsAndAbout.Location = new System.Drawing.Point(4, 31);
            this.settingsAndAbout.Name = "settingsAndAbout";
            this.settingsAndAbout.Padding = new System.Windows.Forms.Padding(3);
            this.settingsAndAbout.Size = new System.Drawing.Size(886, 409);
            this.settingsAndAbout.TabIndex = 4;
            this.settingsAndAbout.Text = "settingsAndAbout";
            this.settingsAndAbout.UseVisualStyleBackColor = true;
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "baseline_edit_white_24dp.png");
            this.IconList.Images.SetKeyName(1, "baseline_music_note_white_24dp.png");
            this.IconList.Images.SetKeyName(2, "baseline_piano_white_24dp.png");
            this.IconList.Images.SetKeyName(3, "baseline_settings_white_24dp.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(12, 48);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 23);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Playing";
            this.materialLabel3.UseAccent = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.materialTabControl1.ResumeLayout(false);
            this.openMidi.ResumeLayout(false);
            this.previewAndPlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage openMidi;
        private System.Windows.Forms.TabPage editTrack;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.TabPage previewAndPlay;
        private MaterialTextBox midiFolderPathTextBox;
        private MaterialButton openFolderButton;
        private MaterialLabel folderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialButton openMidiButton;
        private MaterialButton refreshMidiListButton;
        private MaterialButton saveMidiButton;
        private System.Windows.Forms.TabPage settingsAndAbout;
        private System.Windows.Forms.ColumnHeader fileNameColumn;
        private MaterialListView midiFileList;
        private Sanford.Multimedia.Midi.UI.PianoControl pianoControl1;
        private MaterialButton playButton;
        private MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private MaterialButton stopButton;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel3;
    }
}