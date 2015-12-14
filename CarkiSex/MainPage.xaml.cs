using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarkiSex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Cards cards =  new Cards();
        public MainPage()
        {
            this.InitializeComponent();
            
            CardList.ItemsSource = cards.getCards();
        }
        private void CardList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            this.Frame.Navigate(typeof(Introduction), CardList.SelectedItem);
        }
    }
}
