﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Essential.Design.Elements.Pages
{
	/// <summary>
	/// Логика взаимодействия для Home.xaml
	/// </summary>
	public partial class Home : Page
	{
		private MainWindow _parent;
		public Home( )
		{
			InitializeComponent();
		}



		private void Button_Click_1(object sender, RoutedEventArgs e)
		{

			_parent.Openbar();
			this.blurFon.Visibility = Visibility.Visible;

		}

		private void blurFon_MouseDown(object sender, MouseButtonEventArgs e)
		{
			_parent.Closebar();
			this.blurFon.Visibility = Visibility.Collapsed;
		}
	}
}
