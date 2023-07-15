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



		/// <summary>
		/// /////////	Theme Modes
		/// </summary>
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

        private void Tg_Btn_Click(object sender, RoutedEventArgs e)
        {
			if(Tg_Btn.IsChecked == true)
			{
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0;
                animation.To = -90;
                animation.RepeatBehavior = new RepeatBehavior(1);
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(animation);
                Storyboard.SetTargetName(animation, "PanelRotation");
                Storyboard.SetTargetProperty(animation, new PropertyPath("Angle"));

                storyboard.Begin(this);
            }
			else
			{
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = -90;
                animation.To = 0;
                animation.RepeatBehavior = new RepeatBehavior(1);
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(animation);
                Storyboard.SetTargetName(animation, "PanelRotation");
                Storyboard.SetTargetProperty(animation, new PropertyPath("Angle"));

                storyboard.Begin(this);
            }
        }

		private void btnSetting_Click(object sender, RoutedEventArgs e)
		{
			//topbarParent.Visibility = Visibility.Visible;

			// Create the DoubleAnimationUsingKeyFrames object
			DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();
			animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
			animation.AutoReverse = false;
			animation.RepeatBehavior = new RepeatBehavior(1);

			// Create the EasingDoubleKeyFrames
			EasingDoubleKeyFrame keyFrame1 = new EasingDoubleKeyFrame();
			keyFrame1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero);
			keyFrame1.Value = -topBar.ActualHeight;
			EasingDoubleKeyFrame keyFrame2 = new EasingDoubleKeyFrame();
			keyFrame2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3));
			keyFrame2.Value = 0;
			animation.KeyFrames.Add(keyFrame1);
			animation.KeyFrames.Add(keyFrame2);

			// Create the Storyboard object
			Storyboard sb = new Storyboard();
			sb.Children.Add(animation);
			//sb.Completed += SlideDownStoryboard_Completed;

			// Start the storyboard on the topBar Grid
			topBar.RenderTransform = new TranslateTransform();
			Storyboard.SetTargetProperty(animation, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.Y)"));
			Storyboard.SetTarget(animation, topBar);
			sb.Begin();
		}

		private void ToggleButton_Click(object sender, RoutedEventArgs e)
		{
			if (barToggle.IsChecked == true)
			{
				var storyboard = new Storyboard();
				var doubleAnimation = new DoubleAnimation
				{
					From = 0,
					To = 300,
					Duration = TimeSpan.FromSeconds(0.3),
					EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
				};
				Storyboard.SetTargetName(doubleAnimation, "topBar");
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(FrameworkElement.HeightProperty));
				storyboard.Children.Add(doubleAnimation);

				storyboard.Begin(topBar);
			}
			else
			{
				var storyboard = new Storyboard();
				var doubleAnimation = new DoubleAnimation
				{
					From = 300,
					To = 0,
					Duration = TimeSpan.FromSeconds(0.3),
					EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
				};
				Storyboard.SetTargetName(doubleAnimation, "topBar");
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(FrameworkElement.HeightProperty));
				storyboard.Children.Add(doubleAnimation);

				storyboard.Begin(topBar);
			}
		}
	}
}
