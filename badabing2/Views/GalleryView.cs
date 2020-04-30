using System;
using Eto.Forms;
using Eto.Drawing;
using System.IO;

namespace badabing2.Views
{
    public class GalleryView : Eto.Forms.Panel
    {

        public GalleryView(MainForm parent) 
        {
            var backButton = new Button 
            { 
                Text = "Back",
                Width = 200,
                Height = 60,
                Font = new Font(FontFamilies.Sans, 10, FontStyle.None),
            };
            backButton.Click += (sender, e) => {
                parent.preferencesView.Visible = false;
                parent.galleryView.Visible = false;
                parent.welcomeView.Visible = true;

            };
            Content = new StackLayout 
            {
                Items = 
                {
                    backButton                    
                }
            };
        }

    }
}
