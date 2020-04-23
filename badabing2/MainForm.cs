using System;
using Eto.Forms;
using Eto.Drawing;
using System.IO;

namespace badabing2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Title = "badabing";
			ClientSize = new Size(720, 480);

			/**
			 * Content helpers
			 */
			var aboutButton = new Button 
			{ 
				Text = "About",
				ImagePosition = ButtonImagePosition.Left,
				Image = new Bitmap("Assets/help-about.png"),
				Width = 200,
				Height = 80,
				Font = new Font("SANS-SERIF", 12, FontStyle.Bold),
			};
			aboutButton.Click += (sender, e) => new AboutDialog().ShowDialog(this);
			
			var preferencesButton = new Button 
			{ 
				Text = "Preferences",	
				ImagePosition = ButtonImagePosition.Left,
				Image = new Bitmap("Assets/preferences-desktop.png"),
				Width = 200,
				Height = 80,
				Font = new Font("SANS-SERIF", 12, FontStyle.Bold),
			};

			var galleryButton = new Button 
			{ 
				Text = "Gallery",
				ImagePosition = ButtonImagePosition.Left,
				Image = new Bitmap("Assets/preferences-desktop-wallpaper.png"),
				Width = 200,
				Height = 80,
				Font = new Font("SANS-SERIF", 12, FontStyle.Bold),
			};

			var downloadButton = new Button 
			{ 
				Text = "Download",
				ImagePosition = ButtonImagePosition.Left,
				Image = new Bitmap("Assets/emblem-downloads.png"),
				Width = 200,
				Height = 80,
				Font = new Font("SANS-SERIF", 12, FontStyle.Bold),
			};

			Content = new StackLayout
			{
				Orientation 				= Orientation.Vertical,
				HorizontalContentAlignment 	= HorizontalAlignment.Center,
				Spacing 					= 5,
				Padding 					= new Padding(10),
				Items =
				{
					new StackLayoutItem ( aboutButton ),
					new StackLayoutItem ( preferencesButton ),
					new StackLayoutItem ( galleryButton ),
					new StackLayoutItem ( downloadButton ),
				}
			};

		}
	}
}
