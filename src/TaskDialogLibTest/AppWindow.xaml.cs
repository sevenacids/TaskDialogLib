﻿/***************************************************************************************************
 *
 *  Flatcode Task Dialog Library Test Application
 *  Copyright © 2014 Flatcode.net. All Rights Reserved.
 *
 *  File:
 *    AppWindow.xaml.cs
 *  Purpose:
 *    Test application window XAML code-behind.
 *  Authors:
 *    Florian Schneidereit <florian.schneidereit@outlook.com>
 *
 *  This library is free software; you can redistribute it and/or modify it under the terms of
 *  the GNU Lesser General Public License as published by the Free Software Foundation; either
 *  version 2.1 of the License, or (at your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License along with this
 *  library; if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
 *  Boston, MA  02110-1301  USA
 *
 **************************************************************************************************/

#region Using Directives

using System;
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

#endregion

#region Using Directives: Flatcode

using Flatcode.Presentation;

#endregion

namespace TaskDialogLibTest
{
	public partial class AppWindow : Window
	{
		#region Constructors

		public AppWindow()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods: Event Handler

		void ShowTestTaskDialogButton_Click(object sender, RoutedEventArgs e)
		{
			XamlTaskDialog xamlTaskDialog = new XamlTaskDialog();
			TaskDialogResult result = xamlTaskDialog.ShowModal(this);
			MessageBox.Show(result.ToString(), "Task Dialog Result");
		}

		#endregion
	}
}
