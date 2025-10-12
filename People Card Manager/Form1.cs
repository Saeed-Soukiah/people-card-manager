/*
- Project: People Card Manager
- Author: Saeed Soukiah
- Date: 2025-10-12
 */
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Initialize UI components
        }

        // Handles adding a new person entry
        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                // Get and trim the ID input
                string id = IDtextBox.Text.Trim();

                // Validate that all fields are filled
                if (string.IsNullOrWhiteSpace(id) ||
                    string.IsNullOrWhiteSpace(NametextBox.Text) ||
                    string.IsNullOrWhiteSpace(AddresstextBox.Text))
                {
                    MessageBox.Show("All fields must be filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read existing data to check for duplicate ID
                string strcheck = File.Exists("Data.txt") ? File.ReadAllText("Data.txt") : string.Empty;

                if (strcheck.Contains(id + ";"))
                {
                    // ID already exists, show warning
                    MessageBox.Show("ID already exists.");
                    IDtextBox.Focus();
                    IDtextBox.SelectAll();
                }
                else
                {
                    // Prepare person data and append to file
                    string person = $"{id};{NametextBox.Text};{AddresstextBox.Text}";
                    File.AppendAllText("Data.txt", person + Environment.NewLine);

                    // Ensure the image directory exists
                    Directory.CreateDirectory("img");

                    // Validate that an image is selected
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("Please select an image before adding a person.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Save the image to the img directory
                    pictureBox1.Image.Save(Path.Combine("img", $"{id}.jpg"));
                    MessageBox.Show("Person is Added");

                    // Clear all textboxes
                    foreach (Control c in this.Controls.OfType<TextBox>())
                    {
                        c.Text = "";
                    }

                    // Clear the image from the PictureBox
                    pictureBox1.Image = new PictureBox().Image;
                    IDtextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles searching for a person by ID, Name, or Address
        private void Find_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Trim() != "")
            {
                string line = "";
                bool found = false;
                using (StreamReader sr = new StreamReader("Data.txt"))
                {
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] parts = line.Split(';');
                            // Search by ID
                            if (parts[0] == IDtextBox.Text.Trim())
                            {
                                IDtextBox.Text = parts[0];
                                NametextBox.Text = parts[1];
                                AddresstextBox.Text = parts[2];
                                string mypath = "img/" + parts[0] + ".jpg";
                                if (File.Exists(mypath))
                                {
                                    pictureBox1.Image = Image.FromFile(mypath);
                                }
                                found = true;
                                break;
                            }
                            // Search by Name
                            if (parts[1] == NametextBox.Text)
                            {
                                IDtextBox.Text = parts[0];
                                NametextBox.Text = parts[1];
                                AddresstextBox.Text = parts[2];
                                found = true;
                                break;
                            }
                            // Search by Address
                            if (parts[2] == AddresstextBox.Text)
                            {
                                IDtextBox.Text = parts[0];
                                NametextBox.Text = parts[1];
                                AddresstextBox.Text = parts[2];
                                found = true;
                                break;
                            }
                        }
                    } while (line != null && !found);
                }
                if (!found)
                {
                    // Show message if not found
                    MessageBox.Show("ID not found.");
                    IDtextBox.Focus();
                    IDtextBox.SelectAll();
                }
            }
            else
            {
                // Prompt user to enter an ID
                MessageBox.Show("Please enter an ID to search for.");
                IDtextBox.Focus();
            }
        }

        // Handles closing the application
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Tooltip popup event (currently unused)
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        // Shows all persons in a DataGridView table with images
        private void ShowAll_Click(object sender, EventArgs e)
        {
            using var form2 = new Form
            {
                Text = "All Persons",
                Size = this.Size,
                Font = this.Font,
                StartPosition = FormStartPosition.CenterParent
            };

            // Create and configure DataGridView
            var dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                RowTemplate = { Height = 60 },
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White
            };

            // Add columns: Image, ID, Name, Address
            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Address", "Address");

            form2.Controls.Add(dataGridView);

            // Wire up the CellClick event to show image on click
            dataGridView.CellClick += DataGridView_CellClick;

            try
            {
                if (File.Exists("Data.txt"))
                {
                    var imgDir = "img";
                    foreach (var line in File.ReadLines("Data.txt"))
                    {
                        var parts = line.Split(';');
                        if (parts.Length == 3)
                        {
                            string id = parts[0];
                            string name = parts[1];
                            string address = parts[2];
                            string imgPath = Path.Combine(imgDir, $"{id}.jpg");
                            Image img = null;
                            // Load image if it exists
                            if (File.Exists(imgPath))
                            {
                                using var tempImg = Image.FromFile(imgPath);
                                img = new Bitmap(tempImg); // Avoid file lock
                            }
                            // Add row to DataGridView
                            dataGridView.Rows.Add(img, id, name, address);
                        }
                    }
                }
                else
                {
                    // Show message if no data found
                    MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            form2.ShowDialog();
        }

        // Handles clicking on an image cell to show it in a larger window
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            // Only proceed if image column is clicked and row is valid
            if (dgv == null || e.RowIndex < 0 || e.ColumnIndex != 0)
                return;

            var img = dgv.Rows[e.RowIndex].Cells[0].Value as Image;
            if (img != null)
            {
                // Show the image in a new form with a zoomed PictureBox
                var imgForm = new Form
                {
                    Text = "Person Image",
                    Size = new Size(600, 400),
                    StartPosition = FormStartPosition.CenterParent
                };
                var pb = new PictureBox
                {
                    Image = img,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                imgForm.Controls.Add(pb);
                imgForm.ShowDialog();
            }
        }

        // Handles selecting a picture and displaying it in the main PictureBox
        private void SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Assign the selected image to the main PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Show error message if image loading fails
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ID_Click(object sender, EventArgs e)
        {
            
        }
    }
}