using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGK1_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitD();
            InitErrorFilter();
            changed = false;
        }

        Bitmap oryginal_image;
        Bitmap average_dithering_image;
        Bitmap ordered_dithering_ver1_image;
        Bitmap ordered_dithering_ver2_image;
        Bitmap error_propagation_image_floyd;
        Bitmap error_propagation_image_burkes;
        Bitmap error_propagation_image_stucky;
        Bitmap popularity_algorithm_image;
        bool changed;

        int[][,] D;
        float[][,] ErrorFilter;
        (int fx, int fy)[] FilterSize;

        private void InitD()
        {
            D = new int[17][,];
            D[2] = new int[2, 2] { { 0, 3 }, { 2, 1 } };
            D[3] = new int[3, 3] { { 6, 1, 5 }, { 8, 0, 2 }, { 4, 3, 7 } };
            D[4] = new int[4, 4];// { { 0, 8, 2, 10 }, { 12, 4, 14, 6 }, { 3, 11, 1, 9 }, { 15, 7, 13, 5 } };
            D[6] = new int[6, 6];// { { 24, 32, 16, 26, 34, 18 }, { 4, 0, 12, 6, 2, 14 }, { 20, 8, 28, 22, 10, 30 }, { 27, 35, 19, 25, 33, 17 }, { 7, 3, 15, 5, 1, 13 }, { 23, 11, 31, 21, 9, 29 } };
            D[8] = new int[8, 8];
            D[12] = new int[12, 12];
            D[16] = new int[16, 16];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    D[4][i, j] = D[2][i, j] * 4;
                    D[4][i + 2, j] = D[2][i, j] * 4 + 2;
                    D[4][i, j + 2] = D[2][i, j] * 4 + 3;
                    D[4][i + 2, j + 2] = D[2][i, j] * 4 + 1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    D[6][i, j] = D[3][i, j] * 4;
                    D[6][i + 3, j] = D[3][i, j] * 4 + 2;
                    D[6][i, j + 3] = D[3][i, j] * 4 + 3;
                    D[6][i + 3, j + 3] = D[3][i, j] * 4 + 1;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    D[8][i, j] = D[4][i, j] * 4;
                    D[8][i + 4, j] = D[4][i, j] * 4 + 2;
                    D[8][i, j + 4] = D[4][i, j] * 4 + 3;
                    D[8][i + 4, j + 4] = D[4][i, j] * 4 + 1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    D[12][i, j] = D[6][i, j] * 4;
                    D[12][i + 6, j] = D[6][i, j] * 4 + 2;
                    D[12][i, j + 6] = D[6][i, j] * 4 + 3;
                    D[12][i + 6, j + 6] = D[6][i, j] * 4 + 1;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    D[16][i, j] = D[8][i, j] * 4;
                    D[16][i + 8, j] = D[8][i, j] * 4 + 2;
                    D[16][i, j + 8] = D[8][i, j] * 4 + 3;
                    D[16][i + 8, j + 8] = D[8][i, j] * 4 + 1;
                }
            }
        }

        private void InitErrorFilter()
        {
            ErrorFilter = new float[3][,];
            ErrorFilter[0] = new float[3, 3] { { 0, 0, 3f / 16f }, { 0, 0, 5f / 16f }, { 0, 7f / 16f, 1f / 16f } };
            ErrorFilter[1] = new float[5, 3] { { 0, 0, 2f / 32 }, { 0, 0, 4f / 32 }, { 0, 0, 8f / 32 }, { 0, 8f / 32, 4f / 32 }, { 0, 4f / 32f, 2f / 32f } };
            ErrorFilter[2] = new float[5, 5] { { 0, 0, 0, 2f / 42f, 1f / 42f }, { 0, 0, 0, 4 / 42f, 2 / 42f }, { 0, 0, 0, 8 / 42f, 4 / 42f }, { 0, 0, 8 / 42f, 4 / 42f, 2 / 42f }, { 0, 0, 4 / 42f, 2 / 42f, 1 / 42f } };

            FilterSize = new (int fx, int fy)[3] { (3, 3), (5, 3), (5, 5) };
        }

        private void ShowOryginalImage()
        {
            if (!(drawing_panel.Image is null))
                drawing_panel.Image.Dispose();
            drawing_panel.Image = new Bitmap(oryginal_image);
        }

        private void ShowAverageDitheringImage()
        {
            if (average_dithering_image is null)
                AverageDithering();
            ShowImage(average_dithering_image);
        }

        private void ShowOrderedDitheringver1Image()
        {
            if (ordered_dithering_ver1_image is null || changed)
            {
                changed = false;
                OrderedDithering(true);
            }
            ShowImage(ordered_dithering_ver1_image);
        }

        private void ShowOrderedDitheringver2Image()
        {
            if (ordered_dithering_ver2_image is null || changed)
            {
                changed = false;
                OrderedDithering(false);
            }
            ShowImage(ordered_dithering_ver2_image);
        }

        private void ShowPopularityImage()
        {
            if (popularity_algorithm_image is null || changed)
            {
                changed = false;
                Popularity();
            }
            ShowImage(popularity_algorithm_image);
        }

        private void ShowErrorPropagationImage()
        {
            if (floyd_steinberg.Checked)
            {
                if (error_propagation_image_floyd is null || changed)
                {
                    changed = false;
                    ErrorPropagation();
                }
                ShowImage(error_propagation_image_floyd);
            }
            if (burkes.Checked)
            {
                if (error_propagation_image_burkes is null || changed)
                {
                    changed = false;
                    ErrorPropagation();
                }
                ShowImage(error_propagation_image_burkes);
            }
            if (stucky.Checked)
            {
                if (error_propagation_image_stucky is null || changed)
                {
                    changed = false;
                    ErrorPropagation();
                }
                ShowImage(error_propagation_image_stucky);
            }
        }

        private void ErrorPropagation()
        {
            var oryginal_copy = new Bitmap(oryginal_image);
            var snoop = new BmpPixelSnoop(oryginal_copy);

           // error_propagation_image = new Bitmap(snoop.Width, snoop.Height);
            BmpPixelSnoop snoop_av; 

            int[] k = new int[3];
            k[0] = int.Parse(color_cout_R.Text);
            k[1] = int.Parse(color_cout_G.Text);
            k[2] = int.Parse(color_cout_B.Text);

            double diff_r = 255f / (k[0] - 1);
            double diff_g = 255f / (k[1] - 1);
            double diff_b = 255f / (k[2] - 1);

            int type = 0;

            if (floyd_steinberg.Checked)
            { type = 0;
                error_propagation_image_floyd = new Bitmap(snoop.Width, snoop.Height);
                snoop_av = new BmpPixelSnoop(error_propagation_image_floyd);
            }
            else if (burkes.Checked)
            {
                type = 1;
                error_propagation_image_burkes = new Bitmap(snoop.Width, snoop.Height);
                snoop_av = new BmpPixelSnoop(error_propagation_image_burkes);
            }
            else 
            {
                type = 2;
                error_propagation_image_stucky = new Bitmap(snoop.Width, snoop.Height);
                snoop_av = new BmpPixelSnoop(error_propagation_image_stucky);
            }

            Color tmp;
            Color aprox;
            Color tmps;
            (float R, float G, float B) ntmps;

            (int R, int G, int B) error;

            for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    tmp = snoop.GetPixel(i, j);
                    aprox = Color.FromArgb(ClosestAprox(diff_r, tmp.R), ClosestAprox(diff_g, tmp.G), ClosestAprox(diff_b, tmp.B));
                    snoop_av.SetPixel(i, j, aprox);
                    error = (tmp.R - aprox.R, tmp.G - aprox.G, tmp.B - aprox.B);

                    for (int g = FilterSize[type].fx / -2; g < FilterSize[type].fx / 2; g++)
                    {
                        for (int l = FilterSize[type].fy / -2; l < FilterSize[type].fy / 2; l++)
                        {
                            if (g + i >= 0 && g + i < snoop.Width && l + j >= 0 && l + j < snoop.Height)
                            {
                                tmps = snoop.GetPixel(g + i, l + j);

                                ntmps = (tmps.R + error.R * ErrorFilter[type][g + FilterSize[type].fx / 2, l + FilterSize[type].fy / 2], tmps.G + error.G * ErrorFilter[type][g + FilterSize[type].fx / 2, l + FilterSize[type].fy / 2], tmps.B + error.B * ErrorFilter[type][g + FilterSize[type].fx / 2, l + FilterSize[type].fy / 2]);

                                ntmps.R = ntmps.R > 255 ? 255 : ntmps.R;
                                ntmps.G = ntmps.G > 255 ? 255 : ntmps.G;
                                ntmps.B = ntmps.B > 255 ? 255 : ntmps.B;

                                ntmps.R = ntmps.R < 0 ? 0 : ntmps.R;
                                ntmps.G = ntmps.G < 0 ? 0 : ntmps.G;
                                ntmps.B = ntmps.B < 0 ? 0 : ntmps.B;

                                snoop.SetPixel(g + i, l + j, Color.FromArgb((int)Math.Round(ntmps.R), (int)Math.Round(ntmps.G), (int)Math.Round(ntmps.B)));
                            }
                        }

                    }
                }
            }

            snoop_av.Dispose();
            snoop.Dispose();
        }

        private void AverageDithering()
        {
            var snoop = new BmpPixelSnoop(oryginal_image);

            //int count_r = colo

            int average_r = 0;
            int average_g = 0;
            int average_b = 0;

            for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    var col = snoop.GetPixel(i, j);
                    average_r += col.R;
                    average_g += col.G;
                    average_b += col.B;
                }
            }

            average_r /= snoop.Width * snoop.Height;
            average_g /= snoop.Width * snoop.Height;
            average_b /= snoop.Width * snoop.Height;

            if (!(average_dithering_image is null))
                average_dithering_image.Dispose();

            average_dithering_image = new Bitmap(snoop.Width, snoop.Height);

            var snoop_av = new BmpPixelSnoop(average_dithering_image);

            for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    var col = snoop.GetPixel(i, j);
                    var res = Color.FromArgb(col.R > average_r ? 255 : 0, col.G > average_g ? 255 : 0, col.B > average_b ? 255 : 0);
                    snoop_av.SetPixel(i, j, res);
                }
            }
            snoop_av.Dispose();
            snoop.Dispose();

        }

        private void OrderedDithering(bool version1)
        {
            int[] k = new int[3];
            k[0] = int.Parse(color_cout_R.Text);
            k[1] = int.Parse(color_cout_G.Text);
            k[2] = int.Parse(color_cout_B.Text);
            int[] n = new int[3];
            Dictionary<Color, int> dict = new Dictionary<Color, int>(); ;
            for (int z = 0; z < 3; z++)
            {
                int tmp = 16;
                for (int i = 2; i < 17; i *= 2)
                {
                    if (i * i * (k[z] - 1) >= 256) { tmp = i; break; }
                }
                for (int i = 3; i < 17; i *= 2)
                {
                    if (i * i * (k[z] - 1) >= 256) { tmp = tmp < i ? tmp : i; break; }
                }
                n[z] = tmp;
            }

            Random rand = new Random();
            var snoop = new BmpPixelSnoop(oryginal_image);
            BmpPixelSnoop snoop_av;
            if (version1)
            {
                ordered_dithering_ver1_image = new Bitmap(snoop.Width, snoop.Height);
                snoop_av = new BmpPixelSnoop(ordered_dithering_ver1_image);
            }
            else
            {
                ordered_dithering_ver2_image = new Bitmap(snoop.Width, snoop.Height);
                snoop_av = new BmpPixelSnoop(ordered_dithering_ver2_image);
            }


            for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    var I = snoop.GetPixel(i, j);
                    int col_r = I.R / (n[0] * n[0]);
                    int re_r = I.R % (n[0] * n[0]);
                    int col_g = I.G / (n[1] * n[1]);
                    int re_g = I.G % (n[1] * n[1]);
                    int col_b = I.B / (n[2] * n[2]);
                    int re_b = I.B % (n[2] * n[2]);

                    if (version1)
                    {
                        if (re_r > D[n[0]][rand.Next(0, n[0]), rand.Next(0, n[0])]) col_r++;
                        if (re_g > D[n[1]][rand.Next(0, n[1]), rand.Next(0, n[1])]) col_g++;
                        if (re_b > D[n[2]][rand.Next(0, n[2]), rand.Next(0, n[2])]) col_b++;
                    }
                    else
                    {
                        if (re_r > D[n[0]][i % n[0], j % n[0]]) col_r++;
                        if (re_g > D[n[1]][i % n[1], j % n[1]]) col_g++;
                        if (re_b > D[n[2]][i % n[2], j % n[2]]) col_b++;
                    }

                    col_r *= n[0] * n[0];
                    col_g *= n[1] * n[1];
                    col_b *= n[2] * n[2];

                    col_r = col_r > 255 ? 255 : col_r;
                    col_g = col_g > 255 ? 255 : col_g;
                    col_b = col_b > 255 ? 255 : col_b;

                    var color = Color.FromArgb(col_r, col_g, col_b);
                    if (!dict.ContainsKey(color))
                        dict.Add(color, 1);

                    snoop_av.SetPixel(i, j, color);
                }
            }
            var c = dict.Count;
            snoop_av.Dispose();
            snoop.Dispose();
        }

        private void Popularity()
        {
            var dict = new Dictionary<Color, int>();

            int color_c = int.Parse(color_cout.Text);

            var snoop = new BmpPixelSnoop(oryginal_image);

            for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    var col = snoop.GetPixel(i, j);
                    if (dict.ContainsKey(col))
                    {
                        dict[col]++;
                    }
                    else
                    {
                        dict.Add(col, 1);
                    }
                }
            }

            var dict_list = dict.ToList();
            dict_list.Sort((a, b) => { return a.Value.CompareTo(b.Value); });

            var col_to_use = dict_list.GetRange(0, color_c <= dict_list.Count ? color_c : dict_list.Count);

            if (!(popularity_algorithm_image is null))
                popularity_algorithm_image.Dispose();

            popularity_algorithm_image = new Bitmap(snoop.Width, snoop.Height);

            var snoop_av = new BmpPixelSnoop(popularity_algorithm_image);
            Parallel.For(0, snoop.Width, i =>

            //for (int i = 0; i < snoop.Width; i++)
            {
                for (int j = 0; j < snoop.Height; j++)
                {
                    var col = snoop.GetPixel(i, j);
                    Color min = col_to_use[0].Key;
                    double minv = ColorDist(col, min);
                    foreach (var c in col_to_use)
                    {
                        var res = ColorDist(col, c.Key);
                        if (res < minv) { minv = res; min = c.Key; }
                    }
                    snoop_av.SetPixel(i, j, min);
                }
            });

            snoop_av.Dispose();
            snoop.Dispose();
        }

        private int ClosestAprox(double diff, int val)
        {
            int div = (int)(val / diff);
            double res = val-(diff*div);

            if (res > diff / 2)
                div++;
            int result = (int)Math.Round(div * diff);
            return result < 255 ? result : 255;
        }

        private double ColorDist(Color a, Color b)
        {
            int diffR = a.R - b.R;
            int diffG = a.G - b.G;
            int diffB = a.B - b.B;
            return Math.Sqrt(diffR * diffR + diffG * diffG + diffB * diffB);
        }

        private void ShowImage(Bitmap image)
        {
            if (!(drawing_panel.Image is null))
                drawing_panel.Image.Dispose();
            drawing_panel.Image = new Bitmap(image);
        }

        private void ClearImages()
        {
            if (!(oryginal_image is null))
                oryginal_image.Dispose();
            if (!(average_dithering_image is null))
                average_dithering_image.Dispose();
            if (!(ordered_dithering_ver1_image is null))
                ordered_dithering_ver1_image.Dispose();
            if (!(ordered_dithering_ver2_image is null))
                ordered_dithering_ver2_image.Dispose();
            if (!(error_propagation_image_floyd is null))
                error_propagation_image_floyd.Dispose();
            if (!(error_propagation_image_burkes is null))
                error_propagation_image_burkes.Dispose();
            if (!(error_propagation_image_stucky is null))
                error_propagation_image_stucky.Dispose();
            if (!(popularity_algorithm_image is null))
                popularity_algorithm_image.Dispose();

            oryginal_image = null;
            average_dithering_image = null;
            ordered_dithering_ver1_image = null;
            ordered_dithering_ver2_image = null;
            error_propagation_image_floyd = null;
            error_propagation_image_burkes = null;
            error_propagation_image_stucky = null;
            popularity_algorithm_image = null;

        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image(.png,.jpg,.bmp)|*.jpg;*.png;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ClearImages();
                oryginal_image = new Bitmap(dialog.FileName);
                oryginal_image = oryginal_image.Clone(new Rectangle(0, 0, oryginal_image.Width, oryginal_image.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                oryginal.Checked = true;
                drawing_panel.Image = new Bitmap(oryginal_image);
            }
        }

        private void ShowColorCount()
        {
            label1.Visible = true;
            color_cout_R.Visible = true;
            label2.Visible = true;
            color_cout_G.Visible = true;
            label3.Visible = true;
            color_cout_B.Visible = true;
        }

        private void HideColorCount()
        {
            label1.Visible = false;
            color_cout_R.Visible = false;
            label2.Visible = false;
            color_cout_G.Visible = false;
            label3.Visible = false;
            color_cout_B.Visible = false;
        }

        private void ShowOneColorCount()
        {
            label4.Visible = true;
            color_cout.Visible = true;
        }

        private void HideOneColorCount()
        {
            label4.Visible = false;
            color_cout.Visible = false;
        }

        private void FilterChanged()
        {
            if (oryginal.Checked)
            {
                HideColorCount();
                HideOneColorCount();
                error_prop_panel.Visible = false;
            }
            if (average_dithering.Checked)
            {
                HideColorCount();
                HideOneColorCount();
                error_prop_panel.Visible = false;
            }
            if (ordered_dithering1.Checked)
            {
                ShowColorCount();
                HideOneColorCount();
                error_prop_panel.Visible = false;
            }
            if (ordered_dithering2.Checked)
            {
                ShowColorCount();
                HideOneColorCount();
                error_prop_panel.Visible = false;
            }
            if (popularity.Checked)
            {
                ShowOneColorCount();
                HideColorCount();
                error_prop_panel.Visible = false;
            }
            if (error_propagation.Checked)
            {
                ShowColorCount();
                HideOneColorCount();
                error_prop_panel.Visible = true;
            }
        }

        private void oryginal_CheckedChanged(object sender, EventArgs e)
        {
            FilterChanged();
        }

        private void show_result_Click(object sender, EventArgs e)
        {
            if (oryginal.Checked)
            {
                ShowOryginalImage();

            }
            if (average_dithering.Checked)
            {
                ShowAverageDitheringImage();

            }
            if (ordered_dithering1.Checked)
            {
                ShowOrderedDitheringver1Image();
            }
            if (ordered_dithering2.Checked)
            {
                ShowOrderedDitheringver2Image();
            }
            if (popularity.Checked)
            {
                ShowPopularityImage();
            }
            if (error_propagation.Checked)
            {
                ShowErrorPropagationImage();
            }
        }

        private void drawing_panel_Click(object sender, EventArgs e)
        {
            Bitmap dupa = new Bitmap(drawing_panel.Image);
            var dict = new Dictionary<Color, int>();
            for (int i = 0; i < dupa.Width; i++)
            {
                for (int j = 0; j < dupa.Height; j++)
                {
                    var col = dupa.GetPixel(i, j);
                    if (!dict.ContainsKey(col))
                        dict.Add(col, 1);
                }
            }
            Text = dict.Count.ToString();
        }

        private void color_cout_R_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

    }
}
