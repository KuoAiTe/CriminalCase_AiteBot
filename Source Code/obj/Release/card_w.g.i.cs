﻿#pragma checksum "..\..\card_w.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB925643E08A09F0117F122889C5288FDB117735"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace AiteCriminal {
    
    
    /// <summary>
    /// card_w
    /// </summary>
    public partial class card_w : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Get_Report;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Log_Report;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Get_Energy2;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Log_Energy2;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Get_Energy1;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Log_Energy1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Get_Card;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\card_w.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Log_Card;
        
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
            System.Uri resourceLocater = new System.Uri("/AiteCriminal;component/card_w.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\card_w.xaml"
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
            this.Get_Report = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.Log_Report = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.Get_Energy2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.Log_Energy2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.Get_Energy1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.Log_Energy1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.Get_Card = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.Log_Card = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            
            #line 12 "..\..\card_w.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

