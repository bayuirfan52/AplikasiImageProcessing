using System;
using System.Drawing;

namespace PCDApps2
{
    class Function_Image_Processing
    {
        public Bitmap Brightness(Bitmap bitmap,int value)
        {
            int red, green, blue;
            for(int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i,j); 
                    red = color.R + value;
                    green = color.G + value;
                    blue = color.B + value;
                    red = Cek_Lebih(red);
                    green = Cek_Lebih(green);
                    blue = Cek_Lebih(blue);
                    bitmap.SetPixel(i,j,Color.FromArgb(red, green, blue));                    
                }
            }
            return bitmap;
        }

        int Cek_Lebih(int value)
        {
            if(value > 255)
            {
                value = 255;
            }
            else if(value < 0)
            {
                value = 0;
            }
            return value;
        }

        public Bitmap Rotasi90CW(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width);
            for(int i = 0; i < bitmap.Width; i++)
            {
                for(int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    temp.SetPixel(temp.Width - 1 - j, i, color);
                }
            }
            return temp;
        }

        public Bitmap Rotasi90CCW(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    temp.SetPixel(j, temp.Height - 1 - i, color);
                }
            }
            return temp;
        }

        public Bitmap Flipping(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for(int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    temp.SetPixel(bitmap.Width - 1 - i, j, color);
                }
            }
            return temp;
        }

        public Bitmap Mirroring_Langsung(Bitmap bitmap)
        {
            Bitmap temp = bitmap;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    temp.SetPixel(bitmap.Width - 1 - i, j, color);
                }
            }
            return temp;
        }

        public Bitmap Contrast(Bitmap bitmap)
        {
            int red, green, blue;
            double C = 2;
            int P = 10;
            for(int p = 0; p < bitmap.Width; p++)
            {
                for(int l = 0; l < bitmap.Height; l++)
                {
                    Color color = bitmap.GetPixel(p, l);
                    red = (int)C * (color.R - P) + P;
                    green = (int)C * (color.G - P) + P;
                    blue = (int)C * (color.B - P) + P;
                    red = Cek_Lebih(red);
                    green = Cek_Lebih(green);
                    blue = Cek_Lebih(blue);
                    bitmap.SetPixel(p, l, Color.FromArgb(red, green, blue));
                }
            }
            return bitmap;
        }

        public Bitmap Pemotongan_Kanan(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            int p_half = bitmap.Width / 2;
            int l_half = bitmap.Height / 2;
            int value = 0;
            for(int i = 0; i < bitmap.Width; i++)
            {
                for(int j = 0; j < bitmap.Height; j++)
                {
                    if (i < p_half)
                    {
                        Color color = bitmap.GetPixel(i, j);
                        temp.SetPixel(i, j, color);
                    }
                    else
                    {
                        temp.SetPixel(i, j, Color.FromArgb(value,value,value));
                    }
                }
            }
            return temp;
        }

        public Bitmap Pemotongan_Kiri(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            int p_half = bitmap.Width / 2;
            int l_half = bitmap.Height / 2;
            int value = 0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (i < p_half)
                    {
                        temp.SetPixel(i, j, Color.FromArgb(value, value, value));
                    }
                    else
                    {
                        Color color = bitmap.GetPixel(i, j);
                        temp.SetPixel(i, j, color);
                    }
                }
            }
            return temp;
        }

        public Bitmap Gabung(Bitmap kanan, Bitmap kiri,Bitmap asli)
        {
            Bitmap temp = new Bitmap(asli.Width,asli.Height);
            for(int i = 0; i < temp.Width; i++)
            {
                for(int j = 0; j < temp.Height; j++)
                {
                    Color warna_kiri = kiri.GetPixel(i, j);
                    Color warna_kanan = kanan.GetPixel(i, j);
                    temp.SetPixel(i, j, Color.FromArgb(warna_kanan.R + warna_kiri.R,warna_kanan.G + warna_kiri.G,warna_kanan.B + warna_kiri.B));
                }
            }
            return temp;
        }
    }
}
