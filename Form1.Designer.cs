namespace WordPad_Killer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpB_WWK = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.tb_Load = new System.Windows.Forms.TextBox();
            this.tb_save = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cmB_color = new System.Windows.Forms.ComboBox();
            this.lbl_fontstyle = new System.Windows.Forms.Label();
            this.lbl_alignment = new System.Windows.Forms.Label();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_U = new System.Windows.Forms.Button();
            this.bnt_3 = new System.Windows.Forms.Button();
            this.btn_L = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            this.cmB_fontSize = new System.Windows.Forms.ComboBox();
            this.lbl_font = new System.Windows.Forms.Label();
            this.cmB_font = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpB_WWK.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpB_WWK
            // 
            this.grpB_WWK.Controls.Add(this.btn_save);
            this.grpB_WWK.Controls.Add(this.btn_load);
            this.grpB_WWK.Controls.Add(this.tb_Load);
            this.grpB_WWK.Controls.Add(this.tb_save);
            this.grpB_WWK.Controls.Add(this.lbl_color);
            this.grpB_WWK.Controls.Add(this.cmB_color);
            this.grpB_WWK.Controls.Add(this.lbl_fontstyle);
            this.grpB_WWK.Controls.Add(this.lbl_alignment);
            this.grpB_WWK.Controls.Add(this.btn_C);
            this.grpB_WWK.Controls.Add(this.btn_R);
            this.grpB_WWK.Controls.Add(this.btn_U);
            this.grpB_WWK.Controls.Add(this.bnt_3);
            this.grpB_WWK.Controls.Add(this.btn_L);
            this.grpB_WWK.Controls.Add(this.btn_B);
            this.grpB_WWK.Controls.Add(this.lbl_size);
            this.grpB_WWK.Controls.Add(this.cmB_fontSize);
            this.grpB_WWK.Controls.Add(this.lbl_font);
            this.grpB_WWK.Controls.Add(this.cmB_font);
            this.grpB_WWK.Controls.Add(this.richTextBox1);
            this.grpB_WWK.Location = new System.Drawing.Point(0, 2);
            this.grpB_WWK.Name = "grpB_WWK";
            this.grpB_WWK.Size = new System.Drawing.Size(982, 453);
            this.grpB_WWK.TabIndex = 0;
            this.grpB_WWK.TabStop = false;
            this.grpB_WWK.Text = "WordPad Killer";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(888, 52);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_load.Location = new System.Drawing.Point(888, 25);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 17;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // tb_Load
            // 
            this.tb_Load.Location = new System.Drawing.Point(632, 25);
            this.tb_Load.Name = "tb_Load";
            this.tb_Load.Size = new System.Drawing.Size(241, 23);
            this.tb_Load.TabIndex = 15;
            this.tb_Load.TextChanged += new System.EventHandler(this.tb_Load_TextChanged);
            // 
            // tb_save
            // 
            this.tb_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_save.Location = new System.Drawing.Point(632, 52);
            this.tb_save.Name = "tb_save";
            this.tb_save.Size = new System.Drawing.Size(241, 23);
            this.tb_save.TabIndex = 14;
            this.tb_save.TextChanged += new System.EventHandler(this.tb_save_TextChanged);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_color.Location = new System.Drawing.Point(528, 32);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(41, 17);
            this.lbl_color.TabIndex = 13;
            this.lbl_color.Text = "Color";
            // 
            // cmB_color
            // 
            this.cmB_color.FormattingEnabled = true;
            this.cmB_color.Location = new System.Drawing.Point(487, 52);
            this.cmB_color.Name = "cmB_color";
            this.cmB_color.Size = new System.Drawing.Size(121, 23);
            this.cmB_color.TabIndex = 12;
            this.cmB_color.SelectedIndexChanged += new System.EventHandler(this.cmB_color_SelectedIndexChanged);
            // 
            // lbl_fontstyle
            // 
            this.lbl_fontstyle.AutoSize = true;
            this.lbl_fontstyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fontstyle.Location = new System.Drawing.Point(247, 31);
            this.lbl_fontstyle.Name = "lbl_fontstyle";
            this.lbl_fontstyle.Size = new System.Drawing.Size(66, 17);
            this.lbl_fontstyle.TabIndex = 11;
            this.lbl_fontstyle.Text = "FontStyle";
            // 
            // lbl_alignment
            // 
            this.lbl_alignment.AutoSize = true;
            this.lbl_alignment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alignment.Location = new System.Drawing.Point(377, 30);
            this.lbl_alignment.Name = "lbl_alignment";
            this.lbl_alignment.Size = new System.Drawing.Size(73, 17);
            this.lbl_alignment.TabIndex = 10;
            this.lbl_alignment.Text = "Alignment";
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_C.Location = new System.Drawing.Point(398, 50);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(33, 25);
            this.btn_C.TabIndex = 9;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_R
            // 
            this.btn_R.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_R.Location = new System.Drawing.Point(437, 50);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(33, 25);
            this.btn_R.TabIndex = 8;
            this.btn_R.Text = "R";
            this.btn_R.UseVisualStyleBackColor = true;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            // 
            // btn_U
            // 
            this.btn_U.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_U.Location = new System.Drawing.Point(264, 49);
            this.btn_U.Name = "btn_U";
            this.btn_U.Size = new System.Drawing.Size(33, 25);
            this.btn_U.TabIndex = 7;
            this.btn_U.Text = "U\r\n";
            this.btn_U.UseVisualStyleBackColor = true;
            this.btn_U.Click += new System.EventHandler(this.btn_U_Click);
            // 
            // bnt_3
            // 
            this.bnt_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt_3.Location = new System.Drawing.Point(303, 49);
            this.bnt_3.Name = "bnt_3";
            this.bnt_3.Size = new System.Drawing.Size(33, 25);
            this.bnt_3.TabIndex = 6;
            this.bnt_3.Text = "/";
            this.bnt_3.UseVisualStyleBackColor = true;
            this.bnt_3.Click += new System.EventHandler(this.bnt_3_Click);
            // 
            // btn_L
            // 
            this.btn_L.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_L.Location = new System.Drawing.Point(359, 50);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(33, 25);
            this.btn_L.TabIndex = 5;
            this.btn_L.Text = "L";
            this.btn_L.UseVisualStyleBackColor = true;
            this.btn_L.Click += new System.EventHandler(this.btn_L_Click);
            // 
            // btn_B
            // 
            this.btn_B.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_B.Location = new System.Drawing.Point(225, 49);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(35, 25);
            this.btn_B.TabIndex = 4;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_size.Location = new System.Drawing.Point(158, 31);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(32, 17);
            this.lbl_size.TabIndex = 1;
            this.lbl_size.Text = "Size";
            // 
            // cmB_fontSize
            // 
            this.cmB_fontSize.FormattingEnabled = true;
            this.cmB_fontSize.Location = new System.Drawing.Point(139, 49);
            this.cmB_fontSize.Name = "cmB_fontSize";
            this.cmB_fontSize.Size = new System.Drawing.Size(66, 23);
            this.cmB_fontSize.TabIndex = 3;
            this.cmB_fontSize.SelectedIndexChanged += new System.EventHandler(this.cmB_fontSize_SelectedIndexChanged);
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_font.Location = new System.Drawing.Point(44, 31);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(36, 17);
            this.lbl_font.TabIndex = 2;
            this.lbl_font.Text = "Font";
            // 
            // cmB_font
            // 
            this.cmB_font.FormattingEnabled = true;
            this.cmB_font.Location = new System.Drawing.Point(12, 49);
            this.cmB_font.Name = "cmB_font";
            this.cmB_font.Size = new System.Drawing.Size(121, 23);
            this.cmB_font.TabIndex = 1;
            this.cmB_font.SelectedIndexChanged += new System.EventHandler(this.cmB_font_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(980, 357);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.grpB_WWK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpB_WWK.ResumeLayout(false);
            this.grpB_WWK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpB_WWK;
        private RichTextBox richTextBox1;
        private Button btn_U;
        private Button bnt_3;
        private Button btn_L;
        private Button btn_B;
        private Label lbl_size;
        private ComboBox cmB_fontSize;
        private Label lbl_font;
        private ComboBox cmB_font;
        private TextBox tb_save;
        private Label lbl_color;
        private ComboBox cmB_color;
        private Label lbl_fontstyle;
        private Label lbl_alignment;
        private Button btn_C;
        private Button btn_R;
        private TextBox tb_Load;
        private Button btn_save;
        private Button btn_load;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}