﻿using Microsoft.Maui.Controls;
using SmartClicker.Models;
using SmartClicker.ViewModels;
using SmartClicker.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using Microsoft.Maui.Storage;

namespace SmartClicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var lang = Preferences.Get("AppLanguage", "en");
            var culture = new CultureInfo(lang);

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            SmartClicker.Resources.Localization.Strings.Culture = culture;

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 870;
            window.Height = 525;

            // Получение информации о дисплее
            var displayInfo = DeviceDisplay.MainDisplayInfo;

            // Конвертация ширины и высоты экрана в пиксели
            var screenWidth = displayInfo.Width / displayInfo.Density;
            var screenHeight = displayInfo.Height / displayInfo.Density;

            // Установка координат для правого верхнего угла
            var rightTopX = screenWidth - window.Width;
            var rightTopY = 0;

            window.X = rightTopX;
            window.Y = rightTopY;

            return window;
        }
    }
}