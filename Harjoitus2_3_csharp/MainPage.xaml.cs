using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Harjoitus2_3_csharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selectedValue1 = ((ListBoxItem)listBox.SelectedItem).Content.ToString();
            Debug.WriteLine(selectedValue1);
            int num1 = Convert.ToInt16(selectedValue1);
            String value = num1.ToString();
            textBlock1.Text = value;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selectedValue2 = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
            Debug.WriteLine(selectedValue2);
 
            int num2 = Convert.ToInt16(selectedValue2);
            String value = num2.ToString();
            textBlock2.Text = value;
        }
    }
}
