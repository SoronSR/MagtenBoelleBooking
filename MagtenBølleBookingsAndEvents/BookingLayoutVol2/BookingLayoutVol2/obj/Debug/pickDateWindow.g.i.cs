﻿#pragma checksum "..\..\pickDateWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A042807E3B849FCDA3F411D5DDC3012"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BookingLayoutVol2 {
    
    
    /// <summary>
    /// pickDateWindow
    /// </summary>
    public partial class pickDateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar kalender;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ankomstRadioButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ankomstDato;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton afrejseRadioButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox afrejseDatoTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\pickDateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BookingLayoutVol2;component/pickdatewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\pickDateWindow.xaml"
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
            this.kalender = ((System.Windows.Controls.Calendar)(target));
            
            #line 8 "..\..\pickDateWindow.xaml"
            this.kalender.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Calendar_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ankomstRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.ankomstDato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.afrejseRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.afrejseDatoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\pickDateWindow.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

