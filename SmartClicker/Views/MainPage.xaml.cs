using Microsoft.Maui.Controls;
using SmartClicker.ViewModels;
using SmartClicker.Services;
using System;
using System.Diagnostics;
using SmartClicker.Resources.Localization;

namespace SmartClicker.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        public static void ShowWarning(string message)
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (Application.Current?.MainPage == null) return;

                bool restart = await Application.Current.MainPage.DisplayAlert(
                    "Warning ⚠️",
                    message,
                    "Restart ♻️",
                    "OK"
                );

                if (restart)
                    RestartApp();
            });
        }

        public static void RestartApp()
        {
            var exePath = Environment.ProcessPath; // путь к исполняемому файлу
            Process.Start(exePath);                // запускаем новый процесс
            Environment.Exit(0);                   // завершаем текущее приложение
        }

        // Мягкий перезапуск: пересоздаём главную страницу
        public static void SoftRestartApp()
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Application.Current.MainPage = new MainPage();
            });
        }
    }
}
