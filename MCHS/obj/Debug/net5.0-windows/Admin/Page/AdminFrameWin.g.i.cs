﻿#pragma checksum "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CB9DB8CA6B14EDF700FC550D96142C367C3A9FD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MCHS.Admin.Page;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MCHS.Admin.Page {
    
    
    /// <summary>
    /// AdminFrameWin
    /// </summary>
    public partial class AdminFrameWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MyFrame;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Profile_Btn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JobTitle_Btn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rank_Btn;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MCHS;component/admin/page/adminframewin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MyFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.Profile_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
            this.Profile_Btn.Click += new System.Windows.RoutedEventHandler(this.Profile_Btn_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.JobTitle_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
            this.JobTitle_Btn.Click += new System.Windows.RoutedEventHandler(this.JobTitle_Btn_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Rank_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
            this.Rank_Btn.Click += new System.Windows.RoutedEventHandler(this.Rank_Btn_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\..\Admin\Page\AdminFrameWin.xaml"
            this.Close_btn.Click += new System.Windows.RoutedEventHandler(this.Close_btn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

