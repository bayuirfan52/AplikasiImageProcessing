using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCDApps2
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog;
        SaveFileDialog saveFile;
        Bitmap temp_bitmap;
        Bitmap bitmap;
        bool tab_right_index;
        string pathFile;
        private int Temp_value;

        public Form1()
        {
            InitializeComponent();
            fileDialog = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            tab_right_index = false;
            pathFile = "";
            Temp_value = 0;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Import_button_Click(object sender, EventArgs e)
        {
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|JPEG/JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = fileDialog.FileName;
                foto.Image = Image.FromFile(pathFile);
            }
        }

        private void Brightness_Tab_Click(object sender, EventArgs e)
        {
            if(tab_right_index == false)
            {
                panel_kanan.Visible = true;
                label2.Visible = true;
                value_viewer_brightness.Visible = true;
                slider_brightness.Visible = true;
                Putar_Kanan.Visible = false;
                Putar_Kiri.Visible = false;
                tab_right_index = true;
            }
            else
            {
                if(Putar_Kiri.Visible == true && Putar_Kanan.Visible == true)
                {
                    Putar_Kanan.Visible = false;
                    Putar_Kiri.Visible = false;
                    label2.Visible = true;
                    value_viewer_brightness.Visible = true;
                    slider_brightness.Visible = true;
                    tab_right_index = true;
                }
                else
                {
                    panel_kanan.Visible = false;
                    slider_brightness.Visible = false;
                    tab_right_index = false;
                }
            }
        }

        private void Slider_brightness_Scroll(object sender, EventArgs e)
        {
            Function_Image_Processing function_Image_Processing = new Function_Image_Processing();
            int value = slider_brightness.Value;
                bitmap = (Bitmap)Bitmap.FromFile(pathFile);
                bitmap = function_Image_Processing.Brightness(bitmap, value);
                foto.Image = bitmap;
            value_viewer_brightness.Text = value.ToString();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)Bitmap.FromFile(pathFile);
            foto.Image = bitmap;
            slider_brightness.Value = 0;
            value_viewer_brightness.Text = slider_brightness.Value.ToString();
            Temp_value = 0;
        }

        private void Proses_button_Click(object sender, EventArgs e)
        {
            Temp_value = 1;
            bitmap = (Bitmap)Bitmap.FromFile(pathFile);
            Function_Image_Processing function = new Function_Image_Processing();
            Bitmap temp_potong_kanan,temp_potong_kiri;
            temp_potong_kanan = function.Pemotongan_Kanan(bitmap);
            temp_potong_kiri = function.Flipping(bitmap);
            temp_potong_kiri = function.Pemotongan_Kiri(temp_potong_kiri);
            temp_bitmap = function.Gabung(temp_potong_kanan,temp_potong_kiri,bitmap);
            foto.Image = temp_bitmap;
        }

        private void Rotasi_Tab_Click(object sender, EventArgs e)
        {
            if (tab_right_index == false)
            {
                panel_kanan.Visible = true;
                Putar_Kanan.Visible = true;
                label2.Visible = false;
                value_viewer_brightness.Visible = false;
                slider_brightness.Visible = false;
                Putar_Kiri.Visible = true;
                tab_right_index = true;
            }
            else
            {
                if(slider_brightness.Visible == true)
                {
                    Putar_Kanan.Visible = true;
                    Putar_Kiri.Visible = true;
                    label2.Visible = false;
                    value_viewer_brightness.Visible = false;
                    slider_brightness.Visible = false;
                    tab_right_index = true;
                }
                else
                {
                    panel_kanan.Visible = false;
                    Putar_Kanan.Visible = false;
                    Putar_Kiri.Visible = false;
                    tab_right_index = false;
                }
            }
        }

        private void Putar_Kanan_Click(object sender, EventArgs e)
        {
            Function_Image_Processing function = new Function_Image_Processing();
            if(Temp_value != 1)
            {
                Temp_value = 1;
                bitmap = (Bitmap)Bitmap.FromFile(pathFile);
                temp_bitmap = function.Rotasi90CW(bitmap);
            }
            else
            {
                bitmap = temp_bitmap;
                temp_bitmap = function.Rotasi90CW(bitmap);
            }
            foto.Image = temp_bitmap;
        }

        private void Putar_Kiri_Click(object sender, EventArgs e)
        {
            Function_Image_Processing function = new Function_Image_Processing();
            if (Temp_value != 1)
            {
                Temp_value = 1;
                bitmap = (Bitmap)Bitmap.FromFile(pathFile);
                temp_bitmap = function.Rotasi90CCW(bitmap);
            }
            else
            {
                bitmap = temp_bitmap;
                temp_bitmap = function.Rotasi90CCW(bitmap);
            }
            foto.Image = temp_bitmap;
        }

        private void Bonus_Tab_Button_Click(object sender, EventArgs e)
        {
            DialogResult DialogMessage = MessageBox.Show("Mode ini akan memberikan kejutan untuk anda!","Persiapan",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(DialogMessage == DialogResult.OK)
            {
                bitmap = (Bitmap)Bitmap.FromFile(pathFile);
                Function_Image_Processing function = new Function_Image_Processing();
                temp_bitmap = function.Mirroring_Langsung(bitmap);
                temp_bitmap = function.Contrast(temp_bitmap);
                foto.Image = temp_bitmap;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFile.Title = "Simpan Gambar";
            saveFile.ShowDialog();
            if(saveFile.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();
                switch (saveFile.FilterIndex)
                {
                    case 1:
                        foto.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        foto.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        foto.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }
    }
}
