namespace ProjektGK1_3._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.drawing_panel = new System.Windows.Forms.PictureBox();
            this.error_prop_panel = new System.Windows.Forms.Panel();
            this.stucky = new System.Windows.Forms.RadioButton();
            this.burkes = new System.Windows.Forms.RadioButton();
            this.floyd_steinberg = new System.Windows.Forms.RadioButton();
            this.show_result = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.color_cout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.color_cout_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.color_cout_G = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.color_cout_R = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.popularity = new System.Windows.Forms.RadioButton();
            this.error_propagation = new System.Windows.Forms.RadioButton();
            this.ordered_dithering2 = new System.Windows.Forms.RadioButton();
            this.ordered_dithering1 = new System.Windows.Forms.RadioButton();
            this.average_dithering = new System.Windows.Forms.RadioButton();
            this.oryginal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_panel)).BeginInit();
            this.error_prop_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.drawing_panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.error_prop_panel);
            this.splitContainer1.Panel2.Controls.Add(this.show_result);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.color_cout);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.color_cout_B);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.color_cout_G);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.color_cout_R);
            this.splitContainer1.Panel2.Controls.Add(this.load);
            this.splitContainer1.Panel2.Controls.Add(this.popularity);
            this.splitContainer1.Panel2.Controls.Add(this.error_propagation);
            this.splitContainer1.Panel2.Controls.Add(this.ordered_dithering2);
            this.splitContainer1.Panel2.Controls.Add(this.ordered_dithering1);
            this.splitContainer1.Panel2.Controls.Add(this.average_dithering);
            this.splitContainer1.Panel2.Controls.Add(this.oryginal);
            this.splitContainer1.Size = new System.Drawing.Size(1278, 644);
            this.splitContainer1.SplitterDistance = 1077;
            this.splitContainer1.TabIndex = 0;
            // 
            // drawing_panel
            // 
            this.drawing_panel.BackColor = System.Drawing.Color.White;
            this.drawing_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawing_panel.Location = new System.Drawing.Point(0, 0);
            this.drawing_panel.Name = "drawing_panel";
            this.drawing_panel.Size = new System.Drawing.Size(1077, 644);
            this.drawing_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawing_panel.TabIndex = 0;
            this.drawing_panel.TabStop = false;
            this.drawing_panel.Click += new System.EventHandler(this.drawing_panel_Click);
            // 
            // error_prop_panel
            // 
            this.error_prop_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_prop_panel.Controls.Add(this.stucky);
            this.error_prop_panel.Controls.Add(this.burkes);
            this.error_prop_panel.Controls.Add(this.floyd_steinberg);
            this.error_prop_panel.Location = new System.Drawing.Point(11, 411);
            this.error_prop_panel.Name = "error_prop_panel";
            this.error_prop_panel.Size = new System.Drawing.Size(170, 109);
            this.error_prop_panel.TabIndex = 5;
            this.error_prop_panel.Visible = false;
            // 
            // stucky
            // 
            this.stucky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stucky.AutoSize = true;
            this.stucky.Location = new System.Drawing.Point(14, 65);
            this.stucky.Name = "stucky";
            this.stucky.Size = new System.Drawing.Size(63, 19);
            this.stucky.TabIndex = 0;
            this.stucky.Text = "Stucky";
            this.stucky.UseVisualStyleBackColor = true;
            // 
            // burkes
            // 
            this.burkes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.burkes.AutoSize = true;
            this.burkes.Location = new System.Drawing.Point(14, 40);
            this.burkes.Name = "burkes";
            this.burkes.Size = new System.Drawing.Size(66, 19);
            this.burkes.TabIndex = 0;
            this.burkes.Text = "Burkes";
            this.burkes.UseVisualStyleBackColor = true;
            // 
            // floyd_steinberg
            // 
            this.floyd_steinberg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floyd_steinberg.AutoSize = true;
            this.floyd_steinberg.Checked = true;
            this.floyd_steinberg.Location = new System.Drawing.Point(14, 15);
            this.floyd_steinberg.Name = "floyd_steinberg";
            this.floyd_steinberg.Size = new System.Drawing.Size(137, 19);
            this.floyd_steinberg.TabIndex = 0;
            this.floyd_steinberg.TabStop = true;
            this.floyd_steinberg.Text = "Floyd and Steinberg";
            this.floyd_steinberg.UseVisualStyleBackColor = true;
            // 
            // show_result
            // 
            this.show_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_result.Location = new System.Drawing.Point(14, 589);
            this.show_result.Name = "show_result";
            this.show_result.Size = new System.Drawing.Size(171, 43);
            this.show_result.TabIndex = 4;
            this.show_result.Text = "Pokaż";
            this.show_result.UseVisualStyleBackColor = true;
            this.show_result.Click += new System.EventHandler(this.show_result_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Liczba Kolorów";
            this.label4.Visible = false;
            // 
            // color_cout
            // 
            this.color_cout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_cout.Location = new System.Drawing.Point(11, 368);
            this.color_cout.Name = "color_cout";
            this.color_cout.Size = new System.Drawing.Size(170, 20);
            this.color_cout.TabIndex = 2;
            this.color_cout.Text = "2";
            this.color_cout.Visible = false;
            this.color_cout.TextChanged += new System.EventHandler(this.color_cout_R_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liczba Kolorów B";
            this.label3.Visible = false;
            // 
            // color_cout_B
            // 
            this.color_cout_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_cout_B.Location = new System.Drawing.Point(11, 327);
            this.color_cout_B.Name = "color_cout_B";
            this.color_cout_B.Size = new System.Drawing.Size(170, 20);
            this.color_cout_B.TabIndex = 2;
            this.color_cout_B.Text = "2";
            this.color_cout_B.Visible = false;
            this.color_cout_B.TextChanged += new System.EventHandler(this.color_cout_R_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba Kolorów G";
            this.label2.Visible = false;
            // 
            // color_cout_G
            // 
            this.color_cout_G.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_cout_G.Location = new System.Drawing.Point(11, 286);
            this.color_cout_G.Name = "color_cout_G";
            this.color_cout_G.Size = new System.Drawing.Size(170, 20);
            this.color_cout_G.TabIndex = 2;
            this.color_cout_G.Text = "2";
            this.color_cout_G.Visible = false;
            this.color_cout_G.TextChanged += new System.EventHandler(this.color_cout_R_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba Kolorów R";
            this.label1.Visible = false;
            // 
            // color_cout_R
            // 
            this.color_cout_R.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_cout_R.Location = new System.Drawing.Point(11, 245);
            this.color_cout_R.Name = "color_cout_R";
            this.color_cout_R.Size = new System.Drawing.Size(170, 20);
            this.color_cout_R.TabIndex = 2;
            this.color_cout_R.Text = "2";
            this.color_cout_R.Visible = false;
            this.color_cout_R.TextChanged += new System.EventHandler(this.color_cout_R_TextChanged);
            // 
            // load
            // 
            this.load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.load.Location = new System.Drawing.Point(14, 13);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(170, 45);
            this.load.TabIndex = 1;
            this.load.Text = "Załaduj Obraz";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // popularity
            // 
            this.popularity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popularity.AutoSize = true;
            this.popularity.Location = new System.Drawing.Point(14, 194);
            this.popularity.Name = "popularity";
            this.popularity.Size = new System.Drawing.Size(171, 19);
            this.popularity.TabIndex = 0;
            this.popularity.Text = "Algorytm Popularnościowy";
            this.popularity.UseVisualStyleBackColor = true;
            this.popularity.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // error_propagation
            // 
            this.error_propagation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_propagation.AutoSize = true;
            this.error_propagation.Location = new System.Drawing.Point(14, 169);
            this.error_propagation.Name = "error_propagation";
            this.error_propagation.Size = new System.Drawing.Size(167, 19);
            this.error_propagation.TabIndex = 0;
            this.error_propagation.Text = "Metoda Propagacji Błędu";
            this.error_propagation.UseVisualStyleBackColor = true;
            this.error_propagation.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // ordered_dithering2
            // 
            this.ordered_dithering2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordered_dithering2.AutoSize = true;
            this.ordered_dithering2.Location = new System.Drawing.Point(14, 144);
            this.ordered_dithering2.Name = "ordered_dithering2";
            this.ordered_dithering2.Size = new System.Drawing.Size(152, 19);
            this.ordered_dithering2.TabIndex = 0;
            this.ordered_dithering2.Text = "Ordered Dithering ver2";
            this.ordered_dithering2.UseVisualStyleBackColor = true;
            this.ordered_dithering2.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // ordered_dithering1
            // 
            this.ordered_dithering1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordered_dithering1.AutoSize = true;
            this.ordered_dithering1.Location = new System.Drawing.Point(14, 119);
            this.ordered_dithering1.Name = "ordered_dithering1";
            this.ordered_dithering1.Size = new System.Drawing.Size(152, 19);
            this.ordered_dithering1.TabIndex = 0;
            this.ordered_dithering1.Text = "Ordered Dithering ver1";
            this.ordered_dithering1.UseVisualStyleBackColor = true;
            this.ordered_dithering1.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // average_dithering
            // 
            this.average_dithering.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.average_dithering.AutoSize = true;
            this.average_dithering.Location = new System.Drawing.Point(14, 94);
            this.average_dithering.Name = "average_dithering";
            this.average_dithering.Size = new System.Drawing.Size(125, 19);
            this.average_dithering.TabIndex = 0;
            this.average_dithering.Text = "Average Dithering";
            this.average_dithering.UseVisualStyleBackColor = true;
            this.average_dithering.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // oryginal
            // 
            this.oryginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oryginal.AutoSize = true;
            this.oryginal.Checked = true;
            this.oryginal.Location = new System.Drawing.Point(14, 69);
            this.oryginal.Name = "oryginal";
            this.oryginal.Size = new System.Drawing.Size(121, 19);
            this.oryginal.TabIndex = 0;
            this.oryginal.TabStop = true;
            this.oryginal.Text = "Oryginalny Obraz";
            this.oryginal.UseVisualStyleBackColor = true;
            this.oryginal.CheckedChanged += new System.EventHandler(this.oryginal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawing_panel)).EndInit();
            this.error_prop_panel.ResumeLayout(false);
            this.error_prop_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox drawing_panel;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.RadioButton oryginal;
        private System.Windows.Forms.RadioButton ordered_dithering1;
        private System.Windows.Forms.RadioButton average_dithering;
        private System.Windows.Forms.RadioButton ordered_dithering2;
        private System.Windows.Forms.RadioButton error_propagation;
        private System.Windows.Forms.RadioButton popularity;
        private System.Windows.Forms.TextBox color_cout_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox color_cout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox color_cout_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox color_cout_G;
        private System.Windows.Forms.Button show_result;
        private System.Windows.Forms.Panel error_prop_panel;
        private System.Windows.Forms.RadioButton stucky;
        private System.Windows.Forms.RadioButton burkes;
        private System.Windows.Forms.RadioButton floyd_steinberg;
    }
}

