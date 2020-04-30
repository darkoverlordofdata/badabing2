using System;
using Eto.Forms;
using Eto.Drawing;
using System.IO;
using badabing2.Views;

namespace badabing2
{
	public partial class MainForm : Form
	{
		public WelcomeView welcomeView;
		public PreferencesView preferencesView;
		public GalleryView galleryView;	


		public MainForm()
		{
			welcomeView = new WelcomeView(this);
			preferencesView = new PreferencesView(this);
			galleryView = new GalleryView(this);

			Title = "badabing";
			ClientSize = new Size(720, 480);
			Content = new StackLayout
			{
				Orientation = Orientation.Vertical,
				HorizontalContentAlignment = HorizontalAlignment.Center,
				Spacing = 5,
				Padding = new Padding(10),
				Items = { welcomeView, preferencesView, galleryView }
			};
			
			preferencesView.Visible = false;
			galleryView.Visible = false;
		}
	}
}
