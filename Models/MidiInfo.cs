using System;
using System.IO;
using System.Text;
using Sanford.Multimedia.Midi;

namespace Genshin_Lyre_Midi_Tool.Models
{
    /// <summary>
    /// Midi文件整合信息
    /// </summary>
   public class MidiInfo:IDisposable
    {
        public FileInfo FileInfo { get; set; }

        public string FileName => FileInfo.Name;

        public MidiInfo(string filePath)
        {
            FileInfo = new FileInfo(filePath);
            Sequence = new Sequence();
            Sequence.LoadCompleted += Sequence_LoadCompleted;
            StateChangedEvent += _StateChangedEvent;
            StateChangingEvent += _StateChangingEvent;
            Sequencer = new Sequencer(){Sequence = Sequence};
            State = MidiInfoSate.Loading;
            Sequence.LoadAsync(FileInfo.FullName);
        }
        public event EventHandler StateLoadingEvent;

        public event EventHandler StateIdleEvent;

        public event EventHandler StateWaitingEvent;

        public event EventHandler StatePlayingEvent;

        public event EventHandler StatePausedEvent;

        public event EventHandler StateChangedEvent;

        public event EventHandler PlayingStopEvent;

        public event EventHandler<MidiInfoSate> StateChangingEvent;
        public Sequence Sequence { get; set; }
        public Sequencer Sequencer { get; set; }
        public MidiInfoSate State
        {
            get => _state;
            set
            {
                StateChangingEvent?.Invoke(this, value);
                switch (value)
                {
                    case MidiInfoSate.Idle:
                        if (_state == MidiInfoSate.Playing)
                        {
                            PlayingStopEvent?.Invoke(this, EventArgs.Empty);
                        }
                        break;
                    case MidiInfoSate.Paused:
                        PlayingStopEvent?.Invoke(this, EventArgs.Empty);
                        break;
                }
                _state = value;
                switch (_state)
                {
                    case MidiInfoSate.Loading:
                        StateLoadingEvent?.Invoke(this, EventArgs.Empty);
                        break;
                    case MidiInfoSate.Idle:
                        StateIdleEvent?.Invoke(this, EventArgs.Empty);
                        break;
                    case MidiInfoSate.Waiting:
                        StateWaitingEvent?.Invoke(this, EventArgs.Empty);
                        break;
                    case MidiInfoSate.Playing:
                        StatePlayingEvent?.Invoke(this, EventArgs.Empty);
                        break;
                    case MidiInfoSate.Paused:
                        StatePausedEvent?.Invoke(this, EventArgs.Empty);
                        break;
                }
                StateChangedEvent?.Invoke(this, EventArgs.Empty);
            }
        }
        private void _StateChangedEvent(object sender, EventArgs e)
        {
            switch (State)
            {
                case MidiInfoSate.Idle:
                case MidiInfoSate.Paused:
                    Sequencer.Stop();
                    break;
            }
        }
        private void _StateChangingEvent(object sender, MidiInfoSate newValue)
        {
            switch (newValue)
            {
                case MidiInfoSate.Playing:
                    if (_state == MidiInfoSate.Paused)
                    {
                        Sequencer.Continue();
                    }
                    else
                    {
                        Sequencer.Start();
                    }
                    break;
                case MidiInfoSate.Idle:
                    if (_state == MidiInfoSate.Playing)
                    {
                        StateChangedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    break;
                case MidiInfoSate.Paused:
                    StateChangedEvent?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
        private MidiInfoSate _state;
        public StringBuilder MacroText { get; set; }
        private void Sequence_LoadCompleted(object sender, EventArgs e)
        {
            State = MidiInfoSate.Idle;
        }
        public void Dispose()
        {
            Sequencer?.Dispose();
            Sequence?.Dispose();
        }
    }
    public enum MidiInfoSate
    {
        Loading,Idle, Waiting, Playing, Paused
    }
}
