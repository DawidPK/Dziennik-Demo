// Updated by XamlIntelliSenseFileGenerator 13.10.2022 11:27:49
#pragma checksum "..\..\uczenn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0866FF01EA7FDB6B2C6BC3C3C5736306084AA42E77EAE43F9AFAC2A3642D9F6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Klasy;
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


namespace Klasy
{


    /// <summary>
    /// Uczen
    /// </summary>
    public partial class Uczen : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Klasy;component/uczenn.xaml", System.UriKind.Relative);

#line 1 "..\..\uczenn.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.nUczName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.nUczSurN = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.kobieta = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 4:
                    this.mezczyzna = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 5:
                    this.N = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.ComboSzklUczn = ((System.Windows.Controls.ComboBox)(target));

#line 17 "..\..\uczenn.xaml"
                    this.ComboSzklUczn.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.shol_SelectionChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.Nn = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 8:
                    this.ComboKllUczn = ((System.Windows.Controls.ComboBox)(target));

#line 19 "..\..\uczenn.xaml"
                    this.ComboKllUczn.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);

#line default
#line hidden
                    return;
                case 9:

#line 20 "..\..\uczenn.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addUczn);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

