### People Card Manager

#### Description
A simple, lightweight C# WinForms application to manage a local directory of people with photos. Records are stored in a plain text file using semicolon-delimited fields and photos are saved in an image folder keyed by ID. The app provides quick add/search/browse workflows with safe image handling to avoid file locks.

---

#### Features
- **Add person**  
  Validate inputs, prevent duplicate IDs, append a record to Data.txt, and save a copy of the selected photo as **img/{ID}.jpg**.

- **Search person**  
  Lookup by **ID**, **Name**, or **Address**; populate form fields and display the associated image when available.

- **Show all**  
  Open a modal that lists all records in a DataGridView with thumbnail images and click-to-zoom support.

- **Select picture**  
  Pick an image from disk and display it in the main PictureBox using a safe copy to avoid file locks.

- **Exit**  
  Close the application cleanly, disposing temporary image resources.

---

#### Files
- **Form1.cs** — main form implementation containing UI logic and event handlers.  
- **Form1.Designer.cs** — WinForms designer file; expected controls include **IDtextBox**, **NametextBox**, **AddresstextBox**, **pictureBox1**, **AddNew** button, **Find** button, **ShowAll** button, **SelectPicture** button, **Exit** button, **toolTip1**.  
- **Data.txt** — runtime data file created in the application folder; each line is **ID;Name;Address**.  
- **img/** — runtime directory for saved images; created automatically and contains files like **{ID}.jpg**.

---

#### Usage
1. Build the project as a standard C# WinForms application targeting a .NET runtime that supports WinForms.  
2. Launch the app.  
3. To add an entry: fill **ID**, **Name**, **Address**, select a picture, then click **Add**.  
4. To search: enter an **ID**, **Name**, or **Address** and click **Find**.  
5. To browse all entries: click **Show All**, then click any thumbnail to view the full image.

---

#### Dependencies and Notes
- **Framework**: Windows Forms; compatible with .NET Framework or .NET versions that support WinForms and System.Drawing.  
- **Data format**: Records use semicolon (;) as field separator. Fields containing semicolons are not supported. Consider migrating to CSV or JSON for greater robustness.  
- **Image handling**: Images are saved as JPEG in the **img/** folder after creating an in-memory copy to avoid locking the original file. Temporary Image objects are disposed to reduce memory leaks.  
