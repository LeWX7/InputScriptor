using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Storage;
using Microsoft.UI.Xaml;
using SmartClicker.Models;
using SmartClicker.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SmartClicker.Resources.Localization;

namespace SmartClicker.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public IList<LanguageItem> Languages { get; } =
        [
            new LanguageItem { DisplayName = "(RU) Русский", Code = "ru" },
            new LanguageItem { DisplayName = "(EN) English", Code = "en" },
            new LanguageItem { DisplayName = "(DE) Deutsch", Code = "de" }
        ];

        private LanguageItem _selectedLanguage;
        public LanguageItem SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                if (_selectedLanguage != value)
                {
                    _selectedLanguage = value;
                    OnPropertyChanged();

                    if (value != null)
                    {
                        Preferences.Set("AppLanguage", value.Code);
                    }
                }
            }
        }

        public IList<string> TimeUnitOptions { get; } =
        new List<string>
        {
            Strings.Milliseconds,
            Strings.Seconds,
            Strings.Minutes,
            Strings.Hours
        };
        private string _selectedUnit;
        public string SelectedUnit
        {
            get => _selectedUnit;
            set { _selectedUnit = value; OnPropertyChanged(); }
        }

        public SettingsViewModel()
        {
            var saved = Preferences.Get("AppLanguage", "en");
            SelectedLanguage = Languages.FirstOrDefault(l => l.Code == saved);

            StandartValuesForPickers();
        }

        async void StandartValuesForPickers()
        {
            await Task.Delay(500);
            SelectedUnit = Strings.Seconds;
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