﻿#pragma checksum "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8536EE96C369F5B0347A47568636DFED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
<<<<<<< HEAD
//     Runtime Version:4.0.30319.17929
=======
//     Runtime Version:4.0.30319.18408
>>>>>>> b811ef6e96d1a81e5f0f77f4385dd560152d0fa4
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


namespace InvoicePOS.UserControll.TaxManagement {
    
    
    /// <summary>
    /// Window_TaxList
    /// </summary>
    public partial class Window_TaxList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox2;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid1;
        
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
            System.Uri resourceLocater = new System.Uri("/InvoicePOS;component/usercontroll/taxmanagement/window_taxlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
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
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 45 "..\..\..\..\..\UserControll\TaxManagement\Window_TaxList.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Win_grdTex_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

