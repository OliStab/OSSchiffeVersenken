﻿#pragma checksum "..\..\PlayerShipSetup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B8DF56A254E78BCF8BF4750767962EAE808BDDF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using SchiffeVersenken;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SchiffeVersenken {
    
    
    /// <summary>
    /// PlayerShipSetup
    /// </summary>
    public partial class PlayerShipSetup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenue;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Up;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Down;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Left;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PlayerShipSetup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Right;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SchiffeVersenken;component/playershipsetup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayerShipSetup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.MainMenue = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\PlayerShipSetup.xaml"
            this.MainMenue.Click += new System.Windows.RoutedEventHandler(this.MainMenue_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Up = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\PlayerShipSetup.xaml"
            this.BTN_Up.Click += new System.Windows.RoutedEventHandler(this.BTN_Up_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Down = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\PlayerShipSetup.xaml"
            this.BTN_Down.Click += new System.Windows.RoutedEventHandler(this.BTN_Down_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Left = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\PlayerShipSetup.xaml"
            this.BTN_Left.Click += new System.Windows.RoutedEventHandler(this.BTN_Left_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_Right = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\PlayerShipSetup.xaml"
            this.BTN_Right.Click += new System.Windows.RoutedEventHandler(this.BTN_Right_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
