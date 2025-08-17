using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartClicker.ViewModels
{
    public class InputViewModel : INotifyPropertyChanged
    {
        private string _blockCountEntry;
        public string BlockCountEntry
        {
            get => _blockCountEntry;
            set { _blockCountEntry = value; OnPropertyChanged(); }
        }

        private string _startOffsetEntry;
        public string StartOffsetEntry
        {
            get => _startOffsetEntry;
            set { _startOffsetEntry = value; OnPropertyChanged(); }
        }

        private string _blockLapEntry;
        public string BlockLapEntry
        {
            get => _blockLapEntry;
            set { _blockLapEntry = value; OnPropertyChanged(); }
        }

        private string _blockDelayEntry;
        public string BlockDelayEntry
        {
            get => _blockDelayEntry;
            set { _blockDelayEntry = value; OnPropertyChanged(); }
        }

        private string _blockQuantityEntry = Convert.ToString(1);
        public string BlockQuantityEntry
        {
            get => _blockQuantityEntry;
            set { _blockQuantityEntry = value; OnPropertyChanged(); }
        }

        private string _randomOfDelay;
        public string RandomOfDelay
        {
            get => _randomOfDelay;
            set { _randomOfDelay = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}