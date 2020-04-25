using System;
using System.Reflection;
using Eto.Drawing;
using Eto.Forms;

namespace badabing2.Dialogs
{
    public class About : Dialog
    {
        public About()
        {
            /* dialog attributes */
            
            this.Title = "About BadaBing";
            this.MinimumSize = new Size(300, 0);
            this.Resizable = false;
            
            /* dialog controls */
            
            var imageView = new ImageView();
            imageView.Image = Icon.FromResource("Icon.ico");
            imageView.Size = new Size(128, 128);
            
            var labelTitle = new Label();
            labelTitle.Text = "BadaBing";
            labelTitle.Font = new Font(FontFamilies.Sans, 16);
            labelTitle.HorizontalAlign = HorizontalAlign.Center;

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var labelVersion = new Label();
            labelVersion.Text = string.Format("Version {0}", version);
            labelVersion.HorizontalAlign = HorizontalAlign.Center;

            var labelDesc = new Label();l
            labelDesc.Text = "Daily Wallpaper from Bing";
            labelDesc.HorizontalAlign = HorizontalAlign.Center;
            
            var labelCopyright = new Label();
            labelCopyright.Text = "Copyright 2020 by Bruce Davidson";
            labelCopyright.HorizontalAlign = HorizontalAlign.Center;
            
            var button = new Button();
            button.Text = "Close";
            button.Click += (sender, e) => Close();
            
            /* dialog layout */
            
            Content = new TableLayout
            {
                Padding = new Padding(10),
                Spacing = new Size(5, 5),
                Rows =
                {
                    imageView, labelTitle, labelDesc, labelVersion, labelCopyright,
                    TableLayout.AutoSized(button, centered: true)
                }
            };

            AbortButton = DefaultButton = button;
        }
    }
}
