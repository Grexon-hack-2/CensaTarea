using FormCustomer.CapaEntidad;
using FormCustomer.CapaNegocio;
using System.Reflection;

namespace FormCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OFDImage.Filter = "Archivos de imagen | *.jpg;, *.png;, *.jpeg;";

            try
            {
                if (OFDImage.ShowDialog() == DialogResult.OK)
                {
                    string ruta = OFDImage.FileName;
                    PBImage.Image = System.Drawing.Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (PBImage.Image != null)
            {
                string rutaImage = OFDImage.FileName;
                string directoryPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                string destinationFolder = Path.Combine(directoryPath, "imagenes");

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);

                }

                string destinationPicture = Path.Combine(destinationFolder, Guid.NewGuid().ToString() + Path.GetExtension(rutaImage));
                File.Copy(rutaImage, destinationPicture, true);

                try
                {
                    CustomerModel model = new()
                    {
                        ID = Guid.NewGuid(),
                        Name = textBox1.Text,
                        LastName = textBox2.Text,
                        Picture = destinationPicture
                    };

                    LogicBussines logicBussines = new();
                    logicBussines.AddDataCustomer(model);
                    cleanForm();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else
            {
                MessageBox.Show("The Picture is required data");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new LogicBussines().UploadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleanForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            PBImage.Image = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customerForm = new();

            AddOwnedForm(customerForm);

            customerForm.idCustomer.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            customerForm.nameCustomer.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            customerForm.LastNameCustomer.Text = dataGridView1.CurrentRow.Cells["last_Name"].Value.ToString();

            var ruta = dataGridView1.CurrentRow.Cells["Picture"]?.Value;
            customerForm.PictureCustomer.Image = System.Drawing.Image.FromFile((string)ruta);
            customerForm.rutaImage = ruta.ToString();
            customerForm.ShowDialog();

            if (customerForm.IsDeleted || customerForm.IsUpdated)
            {
                loadData();
            }

        }
    }
}
