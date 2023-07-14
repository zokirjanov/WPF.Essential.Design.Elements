using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Essential.Design.Elements.Themes;

namespace WPF.Essential.Design.Elements
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Tg_Btn.IsChecked = false;
		}

		// Start: MenuLeft PopupButton //
		private void btnHome_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnHome;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Home";
			}
		}

		private void btnHome_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void btnDashboard_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnDashboard;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Dashboard";
			}
		}

		private void btnDashboard_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void btnProductStock_MouseEnter(object sender, MouseEventArgs e)
		{
			
		}

		private void btnProductStock_MouseLeave(object sender, MouseEventArgs e)
		{

		}

		private void btnOrderList_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void btnOrderList_MouseLeave(object sender, MouseEventArgs e)
		{

		}

		private void btnBilling_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void btnBilling_MouseLeave(object sender, MouseEventArgs e)
		{

		}

		private void btnPointOfSale_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void btnPointOfSale_MouseLeave(object sender, MouseEventArgs e)
		{

		}

		private void btnSecurity_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void btnSecurity_MouseLeave(object sender, MouseEventArgs e)
		{

		}
		private void btnSetting_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void btnSetting_MouseLeave(object sender, MouseEventArgs e)
		{

		}
		// End: MenuLeft PopupButton //

		// Start: Button Close | Restore | Minimize 
		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnRestore_Click(object sender, RoutedEventArgs e)
		{
			if (WindowState == WindowState.Normal)
				WindowState = WindowState.Maximized;
			else
				WindowState = WindowState.Normal;
		}

		private void btnMinimize_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}
		// End: Button Close | Restore | Minimize

		private void btnHome_Click(object sender, RoutedEventArgs e)
		{
			fContainer.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
		}

		private void btnDashboard_Click(object sender, RoutedEventArgs e)
		{
			fContainer.Navigate(new System.Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
		}

		private void chips_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnProducts;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Products";
			}
		}

		private void chips_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void toggle_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnProductStock;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Product Stock";
			}
		}

		private void toggle_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void tabs_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnOrderList;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Order List";
			}
		}

		private void tabs_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void slider_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnBilling;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Billing";
			}
		}

		private void slider_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void ratingbar_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnPointOfSale;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Poin Of Sale";
			}
		}

		private void ratingbar_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void combobox_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnSecurity;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Security";
			}
		}

		private void combobox_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private void fields_MouseEnter(object sender, MouseEventArgs e)
		{
			if (Tg_Btn.IsChecked == false)
			{
				Popup.PlacementTarget = btnSetting;
				Popup.Placement = PlacementMode.Right;
				Popup.IsOpen = true;
				Header.PopupText.Text = "Setting";
			}
		}

		private void fields_MouseLeave(object sender, MouseEventArgs e)
		{
			Popup.Visibility = Visibility.Collapsed;
			Popup.IsOpen = false;
		}

		private bool _isDarkTheme = false;
		public bool IsDarkTheme
		{
			get { return _isDarkTheme; }
			set
			{
				_isDarkTheme = value;
				UpdateTheme();
			}
		}

		private void UpdateTheme()
		{
			var dictionary = new ResourceDictionary();
			dictionary.Source = new Uri(IsDarkTheme ? "DarkTheme.xaml" : "LightTheme.xaml", UriKind.Relative);
			Application.Current.Resources.MergedDictionaries[0] = dictionary;
		}

		private void Themes_Click(object sender, RoutedEventArgs e)
		{
			if (Themes.IsChecked == true)
				ThemeController.SetTheme(ThemeController.ThemeTypes.Light);
			else
				ThemeController.SetTheme(ThemeController.ThemeTypes.Dark);
		}

    }
}
