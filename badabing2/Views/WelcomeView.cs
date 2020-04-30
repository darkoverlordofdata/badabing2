using System;
using Eto.Forms;
using Eto.Drawing;
using System.IO;

namespace badabing2.Views
{
    public class WelcomeView : Eto.Forms.Panel
    {

        public WelcomeView(MainForm parent) {
			var aboutButton = new Button 
			{ 
				Text = "About",
				ImagePosition = ButtonImagePosition.Left,
				Image = Bitmap.FromResource("badabing2.Assets.help-about.png"),
				Width = 200,
				Height = 60,
				Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
			};
			aboutButton.Click += (sender, e) => new Dialogs.About().ShowModal(parent);
			// AboutDialog().ShowDialog(this);
			
			var preferencesButton = new Button 
			{ 
				Text = "Preferences",	
				ImagePosition = ButtonImagePosition.Left,
				Image = Bitmap.FromResource("badabing2.Assets.preferences-desktop.png"),
				Width = 200,
				Height = 60,
				Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
			};
			preferencesButton.Click += (sender, e) => {
				parent.welcomeView.Visible = false;
				parent.galleryView.Visible = false;
				parent.preferencesView.Visible = true;
			};

			var galleryButton = new Button 
			{ 
				Text = "Gallery",
				ImagePosition = ButtonImagePosition.Left,
				Image = Bitmap.FromResource("badabing2.Assets.preferences-desktop-wallpaper.png"),
				Width = 200,
				Height = 60,
				Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
			};
			galleryButton.Click += (sender, e) => {
				parent.welcomeView.Visible = false;
				parent.galleryView.Visible = true;
				parent.preferencesView.Visible = false;
			};

			var downloadButton = new Button 
			{ 
				Text = "Download",
				ImagePosition = ButtonImagePosition.Left,
				Image = Bitmap.FromResource("badabing2.Assets.emblem-downloads.png"),
				Width = 200,
				Height = 80,
				Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
			};
			downloadButton.Click += (sender, e) => {
				
			};

			Content = new StackLayout
			{
				Orientation = Orientation.Vertical,
				HorizontalContentAlignment = HorizontalAlignment.Center,
				Spacing = 5,
				Padding = new Padding(10),
				Items =
				{
					new Label 
					{ 
						Text = "BadaBing", 
						Height = 40,
						Font = new Font(FontFamilies.Sans, 12, FontStyle.Bold),
						VerticalAlignment = VerticalAlignment.Bottom,
					},
					new Label 
					{ 
						Text = "Daily Wallpaper from https://bing.wallpaper.pics/",
						Height = 40,
						Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
					},
					new StackLayoutItem ( aboutButton ),
					new StackLayoutItem ( preferencesButton ),
					new StackLayoutItem ( galleryButton ),
					new StackLayoutItem ( downloadButton ),
				}
			};

        }
        
    }
}
