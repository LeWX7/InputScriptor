using CommunityToolkit.Mvvm.ComponentModel;
using SmartClicker.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartClicker.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        //public IList<LanguageItem> Languages { get; } = new List<LanguageItem>
        //{
        //new LanguageItem { Code = "ru", DisplayName = "(RU) Русский" },
        //new LanguageItem { Code = "en", DisplayName = "(EN) English" },
        //new LanguageItem { Code = "de", DisplayName = "(DE) Deutsch" }
        //};

        //private languageitem _selectedlanguage;
        //public languageitem selectedlanguage
        //{
        //    get => _selectedlanguage;
        //    set
        //    {
        //        if (_selectedlanguage != value)
        //        {
        //            _selectedlanguage = value;
        //            onpropertychanged();

        //            if (value != null)
        //            {
        //                preferences.set("applanguage", value.code);
        //                сообщаем пользователю, что требуется перезапуск
        //                 например: showrestartrequired = true;
        //            }
        //        }
        //    }
        //}

        //public SettingsViewModel()
        //{
        //    var saved = Preferences.Get("AppLanguage", "en");
        //    SelectedLanguage = Languages.FirstOrDefault(l => l.Code == saved);
        //}

        private string _selectedUnit;
        public string SelectedUnit
        {
            get => _selectedUnit;
            set { _selectedUnit = value; OnPropertyChanged(); }
        }

        private bool _onCoordinates;
        public bool OnCoordinates
        {
            get => _onCoordinates;
            set { _onCoordinates = value; OnPropertyChanged(); }
        }

        private bool _backMove;
        public bool BackMove
        {
            get => _backMove;
            set { _backMove = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}