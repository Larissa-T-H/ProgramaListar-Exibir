using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo($@"E:\Imagem\pasta1\");
                FileInfo[] arquivos = directory.GetFiles("*");

                foreach (FileInfo file in arquivos)
                {
                    listBox.Items.Add(file.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile(@"E:\Imagem\pasta1\" + listBox.SelectedItem);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
