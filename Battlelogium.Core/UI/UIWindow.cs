﻿using Battlelogium.ThirdParty.Animator;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Battlelogium.Core.Utilities;

namespace Battlelogium.Core.UI
{
    /// <summary>
    /// Provides methods that interact with the Window only, rather than the user interface as a whole.
    /// </summary>
    public partial class UIWindow : Window
    {
        public MouseButtonEventHandler rightDragBtnDown;
        public MouseEventHandler rightDragMove;

        public Battlelog battlelog;
        public Animator loadingIcon;
        public UICore uiCore;
        public Config config;
        public Grid mainGrid;

        public UIWindow()
        {
            this.SourceInitialized += (s, e) => this.HideWindowButtons();

        }

       
    }
}
