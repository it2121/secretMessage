namespace secretMessage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.b1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.b2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ee = new Guna.UI2.WinForms.Guna2CheckBox();
            this.keytextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.key = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::secretMessage.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(1, 286);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(434, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Animated = true;
            this.b1.AutoRoundedCorners = true;
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BorderColor = System.Drawing.Color.White;
            this.b1.BorderRadius = 14;
            this.b1.BorderThickness = 1;
            this.b1.CheckedState.Parent = this.b1;
            this.b1.CustomImages.Parent = this.b1;
            this.b1.FillColor = System.Drawing.Color.Green;
            this.b1.FillColor2 = System.Drawing.Color.DarkGreen;
            this.b1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.HoverState.Parent = this.b1;
            this.b1.Location = new System.Drawing.Point(72, 461);
            this.b1.Name = "b1";
            this.b1.ShadowDecoration.Parent = this.b1;
            this.b1.Size = new System.Drawing.Size(100, 31);
            this.b1.TabIndex = 2;
            this.b1.Text = "Set Text";
            this.b1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // b2
            // 
            this.b2.Animated = true;
            this.b2.AutoRoundedCorners = true;
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BorderColor = System.Drawing.Color.White;
            this.b2.BorderRadius = 14;
            this.b2.BorderThickness = 1;
            this.b2.CheckedState.Parent = this.b2;
            this.b2.CustomImages.Parent = this.b2;
            this.b2.FillColor = System.Drawing.Color.Green;
            this.b2.FillColor2 = System.Drawing.Color.DarkGreen;
            this.b2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.HoverState.Parent = this.b2;
            this.b2.Location = new System.Drawing.Point(262, 461);
            this.b2.Name = "b2";
            this.b2.ShadowDecoration.Parent = this.b2;
            this.b2.Size = new System.Drawing.Size(100, 31);
            this.b2.TabIndex = 3;
            this.b2.Text = "Get Text";
            this.b2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // textbox
            // 
            this.textbox.Animated = true;
            this.textbox.AutoScroll = true;
            this.textbox.BackColor = System.Drawing.Color.Transparent;
            this.textbox.BorderRadius = 3;
            this.textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox.DefaultText = "";
            this.textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox.DisabledState.Parent = this.textbox;
            this.textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox.FocusedState.Parent = this.textbox;
            this.textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox.HoverState.Parent = this.textbox;
            this.textbox.Location = new System.Drawing.Point(14, 304);
            this.textbox.Name = "textbox";
            this.textbox.PasswordChar = '\0';
            this.textbox.PlaceholderText = "";
            this.textbox.SelectedText = "";
            this.textbox.ShadowDecoration.Parent = this.textbox;
            this.textbox.Size = new System.Drawing.Size(406, 51);
            this.textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(146, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click The Image To browse";
            // 
            // ee
            // 
            this.ee.AutoSize = true;
            this.ee.BackColor = System.Drawing.Color.Transparent;
            this.ee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ee.CheckedState.BorderRadius = 0;
            this.ee.CheckedState.BorderThickness = 0;
            this.ee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ee.Font = new System.Drawing.Font("Roboto", 10F);
            this.ee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ee.Location = new System.Drawing.Point(16, 367);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(129, 21);
            this.ee.TabIndex = 10;
            this.ee.Text = "Encryption(AES)";
            this.ee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ee.UncheckedState.BorderRadius = 0;
            this.ee.UncheckedState.BorderThickness = 0;
            this.ee.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ee.UseVisualStyleBackColor = false;
            this.ee.CheckedChanged += new System.EventHandler(this.ee_CheckedChanged);
            // 
            // keytextbox
            // 
            this.keytextbox.Animated = true;
            this.keytextbox.AutoScroll = true;
            this.keytextbox.BackColor = System.Drawing.Color.Transparent;
            this.keytextbox.BorderRadius = 3;
            this.keytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keytextbox.DefaultText = "";
            this.keytextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keytextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keytextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keytextbox.DisabledState.Parent = this.keytextbox;
            this.keytextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keytextbox.Enabled = false;
            this.keytextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keytextbox.FocusedState.Parent = this.keytextbox;
            this.keytextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keytextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keytextbox.HoverState.Parent = this.keytextbox;
            this.keytextbox.Location = new System.Drawing.Point(16, 421);
            this.keytextbox.Name = "keytextbox";
            this.keytextbox.PasswordChar = '\0';
            this.keytextbox.PlaceholderText = "";
            this.keytextbox.SelectedText = "";
            this.keytextbox.ShadowDecoration.Parent = this.keytextbox;
            this.keytextbox.Size = new System.Drawing.Size(404, 23);
            this.keytextbox.TabIndex = 11;
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Enabled = false;
            this.key.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.key.Location = new System.Drawing.Point(13, 401);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(37, 17);
            this.key.TabIndex = 12;
            this.key.Text = "Key :";
            // 
            // close
            // 
            this.close.AutoRoundedCorners = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderRadius = 6;
            this.close.CheckedState.Parent = this.close;
            this.close.CustomImages.Parent = this.close;
            this.close.FillColor = System.Drawing.Color.DarkRed;
            this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.HoverState.Parent = this.close;
            this.close.Location = new System.Drawing.Point(407, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.TabIndex = 13;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::secretMessage.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.close);
            this.Controls.Add(this.key);
            this.Controls.Add(this.keytextbox);
            this.Controls.Add(this.ee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton b1;
        private Guna.UI2.WinForms.Guna2GradientButton b2;
        private Guna.UI2.WinForms.Guna2TextBox textbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox ee;
        private Guna.UI2.WinForms.Guna2TextBox keytextbox;
        private System.Windows.Forms.Label key;
        private Guna.UI2.WinForms.Guna2Button close;
    }
}

