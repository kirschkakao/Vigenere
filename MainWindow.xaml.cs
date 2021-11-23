using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Vigenere
{
    public partial class MainWindow : Window
    {
        //---------------------------------------------------
        //--Basic objects------------------------------------
        //---------------------------------------------------
        #region initializing of basic objects
        FrontendVariables FV = new FrontendVariables();
        public FrontendVariables GetFV { get { return FV; } }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            //---------------------------------------------------
            //--Bindings-----------------------------------------
            //---------------------------------------------------
            #region Bindings
            Binding binding_TBInputtext = new Binding("sInputtext");
            binding_TBInputtext.Source = FV;
            binding_TBInputtext.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBox_TextInput.SetBinding(TextBox.TextProperty, binding_TBInputtext);

            Binding binding_TBOutputtext = new Binding("sOutputtext");
            binding_TBOutputtext.Source = FV;
            binding_TBOutputtext.Mode = BindingMode.OneWay;
            TextBox_TextOutput.SetBinding(TextBox.TextProperty, binding_TBOutputtext);
            TextBox_TextDecrypt.SetBinding(TextBox.TextProperty, binding_TBOutputtext);

            Binding binding_TBKey = new Binding("sKey");
            binding_TBKey.Source = FV;
            binding_TBKey.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBox_Key.SetBinding(TextBox.TextProperty, binding_TBKey);
            TextBox_Key_Derived.SetBinding(TextBox.TextProperty, binding_TBKey);

            Binding binding_CBMode = new Binding("sMode");
            binding_CBMode.Source = FV;
            binding_CBMode.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            ComboBox_KryptDirection.SetBinding(ComboBox.TextProperty, binding_CBMode);

            Binding binding_TBPhiVector = new Binding("sPhiVec");
            binding_TBPhiVector.Source = FV;
            binding_TBPhiVector.Mode = BindingMode.OneWay;
            binding_TBPhiVector.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBox_Phi_Vector.SetBinding(TextBox.TextProperty, binding_TBPhiVector);

            Binding binding_TBPhiLen = new Binding("iPhiLen");
            binding_TBPhiLen.Source = FV;
            binding_TBPhiLen.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBox_Phi_Length.SetBinding(TextBox.TextProperty, binding_TBPhiLen);

            Binding binding_TBKeyLen = new Binding("iKeyLen");
            binding_TBKeyLen.Source = FV;
            binding_TBKeyLen.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBox_Key_Length.SetBinding(TextBox.TextProperty, binding_TBKeyLen);
            #endregion
        }
    }
}
