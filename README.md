# Grey-Administration-Manager


Grey-Administration-Manager or GAM is a simple app made with Windows Forms in a day for quickly launching other applications from a single place. Made because one day I was too lazy to navigate to my desired app's folder or search for it using windows search. 

![Screenshot 2021-08-06 224709](https://user-images.githubusercontent.com/50517794/128558036-e7c03058-8b2e-47c0-9b08-b9ad8b862a53.png)

How to Use:

On the left side is the Entry list, an entry consists of:

- The application's name.
- The path to its executable.
- A boolean of whether it will be launched by the top middle "LaunchStartUps" button.

The Entry list contains 39 entries per page. If you create an entry in a full page you will be redirected to the last ( if it has free space ) or a new page, the entry will be there. If you remove the last entry in the page you will be redirected to the previous page if it exists.

Main Panel Buttons:

- Next page opens the next page if it exists.
- Previous page opens the previous page if it exists.
- GAM StartUP Y\N <- This button is a toggle of whether GAM startsup with windows. Y - Starts up, N - Doesn't start up.
- Launch StartUps iterates through all the entries, if an entry has StartUp enabled and has a valid executable path, its .exe is opened.
- Save button serves for editing existing entries.
- AddApp button adds a new entry with the given values.
- Remove button removes the currently selected entry.
- In the provided image the middle field, aka "DeadCore" is where you input the Entrie's title.
- The field near the "Path" label is where you input the directory of the executable, f.e "C:\Games\DeadCore\DeadCore.exe"
- The button near the "StartUp" label toggles whether this entry is launched by the top middle "LaunchStartUps" button.
- The "Launch Application" button runs the executable with the above given path.

Other:

The field in the center bottom is for event messages, for example when you edit / add / remove an entry, other events also exist.
   
