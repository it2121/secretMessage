using Steganography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretMessage
{
    public partial class Form1 : Form
    {
        string path = "";
        private Bitmap bmp = null;
        public Form1()
        {
            InitializeComponent();
            b1.FillColor = Color.FromArgb(85, b1.FillColor);
            b1.FillColor2 = Color.FromArgb(85, b1.FillColor2);
            b2.FillColor = Color.FromArgb(85, b2.FillColor);
            b2.FillColor2 = Color.FromArgb(85, b2.FillColor2);

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
        }


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        public void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            bmp = (Bitmap)pictureBox1.Image;

            string text = textbox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (ee.Checked)
            {
                if (keytextbox.Text.Length < 6)
                {
                    MessageBox.Show("Please enter a password with at least 6 characters", "Warning");

                    return;
                }
                else
                {
                    text = Crypto.EncryptStringAES(text, keytextbox.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");



            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

            if (ee.Checked)
            {
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, keytextbox.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }

            textbox.Text = extractedText;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }


            }
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ee_CheckedChanged(object sender, EventArgs e)
        {
            if (ee.Checked)
            {


                keytextbox.Enabled = true;
                key.Enabled = true;

            }
            else
            {



                keytextbox.Enabled = false;
                key.Enabled = false;

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

