﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C7D0DDB7FEFC3204B303C93080375A3E1A1D66D8277D8C223EE4C66978B10DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HshlomResturant;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HshlomResturant {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Options1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView UserOptions;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Darea;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Lout;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Lin;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Options2;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OnLineText;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OffLineText;
        
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
            System.Uri resourceLocater = new System.Uri("/HshlomResturant;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.Options1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.UserOptions = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\Window1.xaml"
            this.UserOptions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UserOptions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Darea = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 4:
            this.Lout = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Window1.xaml"
            this.Lout.Click += new System.Windows.RoutedEventHandler(this.Lout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Lin = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Window1.xaml"
            this.Lin.Click += new System.Windows.RoutedEventHandler(this.Lin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Options2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.OnLineText = ((System.Windows.Controls.TextBlock)(target));
            
            #line 57 "..\..\Window1.xaml"
            this.OnLineText.Loaded += new System.Windows.RoutedEventHandler(this.MainLoad_Load);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OffLineText = ((System.Windows.Controls.TextBlock)(target));
            
            #line 58 "..\..\Window1.xaml"
            this.OffLineText.Loaded += new System.Windows.RoutedEventHandler(this.MainLoad_Load);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
