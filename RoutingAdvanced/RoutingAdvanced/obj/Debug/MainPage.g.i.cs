﻿#pragma checksum "C:\WP_Projects\WP8Examples\WP8MapsExamples\RoutingAdvanced\RoutingAdvanced\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1E94116CF5F960564CCA76B0C2AC1980"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Maps.Controls;
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


namespace RoutingAdvanced {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Button Hplus;
        
        internal System.Windows.Controls.Button Hmins;
        
        internal System.Windows.Controls.Button TrMod;
        
        internal System.Windows.Controls.Button Optim;
        
        internal System.Windows.Controls.Button Rutte;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Maps.Controls.Map map1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RoutingAdvanced;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.Hplus = ((System.Windows.Controls.Button)(this.FindName("Hplus")));
            this.Hmins = ((System.Windows.Controls.Button)(this.FindName("Hmins")));
            this.TrMod = ((System.Windows.Controls.Button)(this.FindName("TrMod")));
            this.Optim = ((System.Windows.Controls.Button)(this.FindName("Optim")));
            this.Rutte = ((System.Windows.Controls.Button)(this.FindName("Rutte")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.map1 = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map1")));
        }
    }
}
