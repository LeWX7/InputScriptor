using System.ComponentModel;
using System.Runtime.CompilerServices;
using SmartClicker.Resources.Localization;

namespace SmartClicker.Models
{
    public class ClickBlock : INotifyPropertyChanged
    {
        private string _mouseButton = "Л_КМ";
        private string _clickType = Strings.Click;
        private int _targetX;
        private int _targetY;
        private int _clickInterval;
        private int _stepScore;
        private int _randomOfDelay;
        private string _note;

        public string MouseButton
        {
            get => _mouseButton;
            set { _mouseButton = value; OnPropertyChanged(); }
        }

        public IList<string> ClickTypeOptions { get; } =
        new List<string>
        {
            Strings.Click,
            Strings.Press,
            Strings.Move
        };
        public string ClickType
        {
            get => _clickType;
            set { _clickType = value; OnPropertyChanged(); }
        }

        public int TargetX
        {
            get => _targetX;
            set { _targetX = value; OnPropertyChanged(); }
        }

        public int TargetY
        {
            get => _targetY;
            set { _targetY = value; OnPropertyChanged(); }
        }

        public int ClickInterval
        {
            get => _clickInterval;
            set { _clickInterval = value; OnPropertyChanged(); }
        }

        public int StepScore
        {
            get => _stepScore;
            set { _stepScore = value; OnPropertyChanged(); }
        }

        public int RandomOfDelay
        {
            get => _randomOfDelay;
            set { _randomOfDelay = value; OnPropertyChanged(); }
        }

        public string Note
        {
            get => _note;
            set { _note = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
