#pragma checksum "..\..\..\View\ProcessingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "93B156BE68DACC123DB906DE5A80302097CB2555EE64EB7BF1F1A575BAF6C214"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TestApp.View;


namespace TestApp.View {
    
    
    /// <summary>
    /// ProcessingWindow
    /// </summary>
    public partial class ProcessingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TestApp.View.ProcessingWindow processingWindow;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetData;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetFlow;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMediana;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slValue;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\View\ProcessingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMSort;
        
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
            System.Uri resourceLocater = new System.Uri("/TestApp;component/view/processingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProcessingWindow.xaml"
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
            this.processingWindow = ((TestApp.View.ProcessingWindow)(target));
            return;
            case 2:
            this.btnGetData = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\View\ProcessingWindow.xaml"
            this.btnGetData.Click += new System.Windows.RoutedEventHandler(this.btnGetData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnGetFlow = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\View\ProcessingWindow.xaml"
            this.btnGetFlow.Click += new System.Windows.RoutedEventHandler(this.btnGetFlow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnMediana = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\View\ProcessingWindow.xaml"
            this.btnMediana.Click += new System.Windows.RoutedEventHandler(this.btnMediana_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.slValue = ((System.Windows.Controls.Slider)(target));
            
            #line 102 "..\..\..\View\ProcessingWindow.xaml"
            this.slValue.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slValue_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMSort = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\View\ProcessingWindow.xaml"
            this.btnMSort.Click += new System.Windows.RoutedEventHandler(this.btnMSort_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

