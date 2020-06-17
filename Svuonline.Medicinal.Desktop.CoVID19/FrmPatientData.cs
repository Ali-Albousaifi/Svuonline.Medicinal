using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public partial class FrmPatientData : Form
    {
        public FrmPatientData()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            String ImageLocation = "";
            try
            {
                OpenFileDialog OpenFileDialogObj = new OpenFileDialog();
                OpenFileDialogObj.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png";
                if (OpenFileDialogObj.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = OpenFileDialogObj.FileName;
                    PatientPictureBox.Image = new Bitmap(OpenFileDialogObj.FileName);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطاء أثناء تحميل الصورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
