using FormCustomer.CapaEntidad;
using FormCustomer.CapaNegocio;
using System.Reflection;

namespace FormCustomer
{
    public partial class Customer : Form
    {
        public bool IsUpdated { get; private set; } = false;
        public bool IsDeleted { get; private set; } = false;
        private bool IsNewImage { get; set; } = false;
        private readonly LogicBussines logicBussines = new();
        public string rutaImage { get; set; }
        public Customer()
        {
            InitializeComponent();
        }

        // Delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (logicBussines.DeleteService(idCustomer.Text))
            {
                MessageBox.Show($"Customer {nameCustomer.Text} has been successfully deleted");

                this.IsDeleted = true;

                this.Close();
            }
        }

        // Update
        private void button1_Click(object sender, EventArgs e)
        {
            string destinationPicture = "";
            if (IsNewImage)
            {
                string rutaImage = ofCustomer.FileName;
                string directoryPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                string destinationFolder = Path.Combine(directoryPath, "imagenes");

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);

                }

                destinationPicture = Path.Combine(destinationFolder, Guid.NewGuid().ToString() + Path.GetExtension(rutaImage));

                File.Copy(rutaImage, destinationPicture, true);

            }

            CustomerModel model = new()
            {
                Name = nameCustomer.Text,
                LastName = LastNameCustomer.Text,
                Picture = IsNewImage ? destinationPicture : rutaImage,
            };

            if (logicBussines.UpdateService(model, idCustomer.Text))
            {
                this.IsUpdated = true;
                this.Close();
                MessageBox.Show($"The user {model.Name} has been successfully updated");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ofCustomer.FileName = rutaImage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofCustomer.Filter = "Archivos de imagen | *.jpg;, *.png;, *.jpeg;";

            try
            {
                if (ofCustomer.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ofCustomer.FileName;
                    PictureCustomer.Image = System.Drawing.Image.FromFile(ruta);
                    this.IsNewImage = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
