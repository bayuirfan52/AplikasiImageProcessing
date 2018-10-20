namespace PCDApps2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_atas = new System.Windows.Forms.Panel();
            this.form_button_panel = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_kiri = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Bonus_Tab_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Proses_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_kanan = new System.Windows.Forms.Panel();
            this.Putar_Kanan = new System.Windows.Forms.Button();
            this.Putar_Kiri = new System.Windows.Forms.Button();
            this.value_viewer_brightness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slider_brightness = new System.Windows.Forms.TrackBar();
            this.foto = new System.Windows.Forms.PictureBox();
            this.panel_atas.SuspendLayout();
            this.form_button_panel.SuspendLayout();
            this.panel_kiri.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_kanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.panel_atas.Controls.Add(this.form_button_panel);
            this.panel_atas.Controls.Add(this.label1);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(1234, 46);
            this.panel_atas.TabIndex = 0;
            // 
            // form_button_panel
            // 
            this.form_button_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.form_button_panel.Controls.Add(this.close_button);
            this.form_button_panel.Controls.Add(this.minimize_button);
            this.form_button_panel.Location = new System.Drawing.Point(1142, 0);
            this.form_button_panel.Name = "form_button_panel";
            this.form_button_panel.Size = new System.Drawing.Size(92, 46);
            this.form_button_panel.TabIndex = 4;
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.BackgroundImage = global::PCDApps2.Properties.Resources.close;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(49, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(43, 46);
            this.close_button.TabIndex = 1;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.BackgroundImage = global::PCDApps2.Properties.Resources.minimize;
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Location = new System.Drawing.Point(0, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(43, 46);
            this.minimize_button.TabIndex = 3;
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mirroring Image Manipulator";
            // 
            // panel_kiri
            // 
            this.panel_kiri.BackColor = System.Drawing.Color.White;
            this.panel_kiri.Controls.Add(this.button3);
            this.panel_kiri.Controls.Add(this.Bonus_Tab_Button);
            this.panel_kiri.Controls.Add(this.button2);
            this.panel_kiri.Controls.Add(this.Proses_button);
            this.panel_kiri.Controls.Add(this.reset_button);
            this.panel_kiri.Controls.Add(this.button1);
            this.panel_kiri.Controls.Add(this.import_button);
            this.panel_kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_kiri.Location = new System.Drawing.Point(0, 46);
            this.panel_kiri.Name = "panel_kiri";
            this.panel_kiri.Size = new System.Drawing.Size(200, 537);
            this.panel_kiri.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Save_Click);
            // 
            // Bonus_Tab_Button
            // 
            this.Bonus_Tab_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.Bonus_Tab_Button.FlatAppearance.BorderSize = 0;
            this.Bonus_Tab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bonus_Tab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus_Tab_Button.ForeColor = System.Drawing.Color.White;
            this.Bonus_Tab_Button.Location = new System.Drawing.Point(0, 303);
            this.Bonus_Tab_Button.Name = "Bonus_Tab_Button";
            this.Bonus_Tab_Button.Size = new System.Drawing.Size(200, 45);
            this.Bonus_Tab_Button.TabIndex = 5;
            this.Bonus_Tab_Button.Text = "Bonus";
            this.Bonus_Tab_Button.UseVisualStyleBackColor = false;
            this.Bonus_Tab_Button.Click += new System.EventHandler(this.Bonus_Tab_Button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rotasi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Rotasi_Tab_Click);
            // 
            // Proses_button
            // 
            this.Proses_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.Proses_button.FlatAppearance.BorderSize = 0;
            this.Proses_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proses_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proses_button.ForeColor = System.Drawing.Color.White;
            this.Proses_button.Location = new System.Drawing.Point(0, 87);
            this.Proses_button.Name = "Proses_button";
            this.Proses_button.Size = new System.Drawing.Size(200, 45);
            this.Proses_button.TabIndex = 3;
            this.Proses_button.Text = "Mirroring";
            this.Proses_button.UseVisualStyleBackColor = false;
            this.Proses_button.Click += new System.EventHandler(this.Proses_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.reset_button.FlatAppearance.BorderSize = 0;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(0, 354);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(200, 45);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Brightness";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Brightness_Tab_Click);
            // 
            // import_button
            // 
            this.import_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.import_button.FlatAppearance.BorderSize = 0;
            this.import_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_button.ForeColor = System.Drawing.Color.White;
            this.import_button.Location = new System.Drawing.Point(0, 36);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(200, 45);
            this.import_button.TabIndex = 0;
            this.import_button.Text = "Import";
            this.import_button.UseVisualStyleBackColor = false;
            this.import_button.Click += new System.EventHandler(this.Import_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel_kanan);
            this.panel3.Controls.Add(this.foto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 537);
            this.panel3.TabIndex = 2;
            // 
            // panel_kanan
            // 
            this.panel_kanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_kanan.Controls.Add(this.Putar_Kanan);
            this.panel_kanan.Controls.Add(this.Putar_Kiri);
            this.panel_kanan.Controls.Add(this.value_viewer_brightness);
            this.panel_kanan.Controls.Add(this.label2);
            this.panel_kanan.Controls.Add(this.slider_brightness);
            this.panel_kanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_kanan.Location = new System.Drawing.Point(745, 0);
            this.panel_kanan.Name = "panel_kanan";
            this.panel_kanan.Size = new System.Drawing.Size(289, 537);
            this.panel_kanan.TabIndex = 1;
            this.panel_kanan.Visible = false;
            // 
            // Putar_Kanan
            // 
            this.Putar_Kanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.Putar_Kanan.FlatAppearance.BorderSize = 0;
            this.Putar_Kanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Putar_Kanan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Putar_Kanan.ForeColor = System.Drawing.Color.White;
            this.Putar_Kanan.Location = new System.Drawing.Point(152, 188);
            this.Putar_Kanan.Name = "Putar_Kanan";
            this.Putar_Kanan.Size = new System.Drawing.Size(125, 45);
            this.Putar_Kanan.TabIndex = 6;
            this.Putar_Kanan.Text = "Putar Kanan";
            this.Putar_Kanan.UseVisualStyleBackColor = false;
            this.Putar_Kanan.Click += new System.EventHandler(this.Putar_Kanan_Click);
            // 
            // Putar_Kiri
            // 
            this.Putar_Kiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.Putar_Kiri.FlatAppearance.BorderSize = 0;
            this.Putar_Kiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Putar_Kiri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Putar_Kiri.ForeColor = System.Drawing.Color.White;
            this.Putar_Kiri.Location = new System.Drawing.Point(13, 188);
            this.Putar_Kiri.Name = "Putar_Kiri";
            this.Putar_Kiri.Size = new System.Drawing.Size(125, 45);
            this.Putar_Kiri.TabIndex = 5;
            this.Putar_Kiri.Text = "Putar Kiri";
            this.Putar_Kiri.UseVisualStyleBackColor = false;
            this.Putar_Kiri.Click += new System.EventHandler(this.Putar_Kiri_Click);
            // 
            // value_viewer_brightness
            // 
            this.value_viewer_brightness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.value_viewer_brightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.value_viewer_brightness.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_viewer_brightness.Location = new System.Drawing.Point(198, 98);
            this.value_viewer_brightness.MaxLength = 2;
            this.value_viewer_brightness.Name = "value_viewer_brightness";
            this.value_viewer_brightness.Size = new System.Drawing.Size(42, 23);
            this.value_viewer_brightness.TabIndex = 2;
            this.value_viewer_brightness.Text = "0";
            this.value_viewer_brightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brightness Value";
            // 
            // slider_brightness
            // 
            this.slider_brightness.Location = new System.Drawing.Point(34, 127);
            this.slider_brightness.Maximum = 20;
            this.slider_brightness.Minimum = -20;
            this.slider_brightness.Name = "slider_brightness";
            this.slider_brightness.Size = new System.Drawing.Size(223, 56);
            this.slider_brightness.TabIndex = 0;
            this.slider_brightness.Tag = "";
            this.slider_brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_brightness.Scroll += new System.EventHandler(this.Slider_brightness_Scroll);
            // 
            // foto
            // 
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foto.Location = new System.Drawing.Point(0, 0);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(746, 537);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 583);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_kiri);
            this.Controls.Add(this.panel_atas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mirroring Image Manipulator";
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            this.form_button_panel.ResumeLayout(false);
            this.form_button_panel.PerformLayout();
            this.panel_kiri.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_kanan.ResumeLayout(false);
            this.panel_kanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_kiri;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_kanan;
        private System.Windows.Forms.Panel form_button_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slider_brightness;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox value_viewer_brightness;
        private System.Windows.Forms.Button Proses_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Putar_Kiri;
        private System.Windows.Forms.Button Putar_Kanan;
        private System.Windows.Forms.Button Bonus_Tab_Button;
        private System.Windows.Forms.Button button3;
    }
}

