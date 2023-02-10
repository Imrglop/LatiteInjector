﻿using System.Windows;
using System.Windows.Input;
using LatiteInjector.Utils;

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
            if (!MainWindow.IsMinecraftRunning)
                DiscordPresence.DiscordClient.UpdateState("Idling in the client");
            if (MainWindow.IsMinecraftRunning)
                DiscordPresence.DiscordClient.UpdateState($"Playing Minecraft {Updater.GetSelectedVersion()}");
        }

        private void WindowToolbar_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
    }
}
