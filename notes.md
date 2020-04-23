exit
cp /usr/share/icons/gnome/32x32/actions/help-about.png ./res/images
cp /usr/share/icons/gnome/32x32/categories/preferences-desktop.png ./res/images
cp /usr/share/icons/gnome/32x32/apps/preferences-desktop-wallpaper.png ./res/images
cp /usr/share/icons/gnome/32x32/emblems/emblem-downloads.png ./res/images


dotnet publish -c Release -r win10-x64 /p:PublishSingleFile=true --framework netcoreapp3.1