﻿#pragma checksum "c:\users\paulv_000\documents\visual studio 2012\Projects\mindHub\mindHub\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7912F60F71250AF7E58F3D08B3649ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace mindHub {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.TextBlock PageSlogan;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image character;
        
        internal System.Windows.Controls.TextBox uNametxt;
        
        internal System.Windows.Controls.TextBox passtxt;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/mindHub;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.PageSlogan = ((System.Windows.Controls.TextBlock)(this.FindName("PageSlogan")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.character = ((System.Windows.Controls.Image)(this.FindName("character")));
            this.uNametxt = ((System.Windows.Controls.TextBox)(this.FindName("uNametxt")));
            this.passtxt = ((System.Windows.Controls.TextBox)(this.FindName("passtxt")));
        }
    }
}

