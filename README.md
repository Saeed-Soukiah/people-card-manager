# people-card-manager
Project Description:
A simple C# WinForms application for managing a small local directory of people with photos. It stores person records in a plain text file ("Data.txt") using semicolon-delimited fields (ID;Name;Address) and saves photos in an "img" folder keyed by ID (ID.jpg). The app supports adding entries with image capture, searching by ID/Name/Address, listing all records in a DataGridView with thumbnails, and viewing a selected image in a larger dialog.
#Features:
- Add person: validate inputs, prevent duplicate IDs, save record to Data.txt, save selected picture as img/{ID}.jpg.
- Search person: search by ID, Name, or Address; populate form fields and display associated image if present.
- Show all: opens a modal form showing all records in a DataGridView with thumbnail images and click-to-zoom support.
- Select picture: choose an image from disk and show it in the main PictureBox with safe copy semantics to avoid file locks.
- Exit: closes the application.
#Files (expected):
- Form1.cs — main form implementation (contains UI logic shown in the provided code).
- Form1.Designer.cs — WinForms designer file (expected controls: IDtextBox, NametextBox, AddresstextBox, pictureBox1, AddNew button, Find button, ShowAll button, SelectPicture button, Exit button, toolTip1).
- Data.txt — runtime data file generated in application folder.
- img/ — runtime directory for saved images (created automatically).
#Usage:
- Build the project as a typical C# WinForms application targeting .NET Framework or .NET.
- Launch the app, fill ID, Name, Address, select a picture, then click "Add" to store the entry.
- Use the search button to find entries by ID, Name, or Address.
- Use "Show All" to browse all entries with thumbnails and click a thumbnail to view the full image.
#Dependencies and Notes:
- Framework: Windows Forms; compatible with .NET Framework or .NET that supports WinForms and System.Drawing.
- I/O: Data stored in plain text ("Data.txt"); semicolon is the field separator. Fields containing semicolons are not supported by the current format.
- Image handling: Images are copied into the img folder as JPEG to avoid file lock/handle issues. The code disposes temporary Image objects to reduce memory leaks.
