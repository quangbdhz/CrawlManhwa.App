﻿#pragma checksum "..\..\..\Views\DetailManhwaView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4ACA5AB1E8942AEE434D3A59477BCD10BE1AC43F0136E9E0EE4FB6DBB891759"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CrawManhwa.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Prism.DryIoc;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
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


namespace CrawManhwa.Views {
    
    
    /// <summary>
    /// DetailManhwaView
    /// </summary>
    public partial class DetailManhwaView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Views\DetailManhwaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrollLvReadManhwa;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\DetailManhwaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Lv_ReadManhwa;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\DetailManhwaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_ChooseChapterManhwa;
        
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
            System.Uri resourceLocater = new System.Uri("/CrawManhwa;component/views/detailmanhwaview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DetailManhwaView.xaml"
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
            this.ScrollLvReadManhwa = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 25 "..\..\..\Views\DetailManhwaView.xaml"
            this.ScrollLvReadManhwa.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.LvOneChapterManhwaScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Lv_ReadManhwa = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.cbx_ChooseChapterManhwa = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\..\Views\DetailManhwaView.xaml"
            this.cbx_ChooseChapterManhwa.DropDownClosed += new System.EventHandler(this.cbx_ChooseChapterManhwa_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 77 "..\..\..\Views\DetailManhwaView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 79 "..\..\..\Views\DetailManhwaView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

