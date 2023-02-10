﻿using System.Windows;
using System.Windows.Input;
using LatiteInjector.Utils;
using static LatiteInjector.MainWindow;

namespace LatiteInjector
{
    /// <summary>
    /// Interaction logic for ChangelogWindow.xaml
    /// </summary>
    public partial class ChangelogWindow
    {
        public ChangelogWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            if (!IsMinecraftRunning)
                DiscordPresence.DiscordClient.UpdateState("Idling in the client");
            DiscordPresence.DiscordClient.UpdateState(
                IsCustomDll
                    ? $"Playing Minecraft {Updater.GetSelectedVersion()} with {CustomDllName}"
                    : $"Playing Minecraft {Updater.GetSelectedVersion()} with Latite");
        }

        private void WindowToolbar_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
    }
}
