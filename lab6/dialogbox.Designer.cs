
namespace lab6
{
    partial class dialogbox
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.font3 = new System.Windows.Forms.RadioButton();
            this.font2 = new System.Windows.Forms.RadioButton();
            this.font1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.size3 = new System.Windows.Forms.RadioButton();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.size1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.newtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.font3);
            this.tabPage1.Controls.Add(this.font2);
            this.tabPage1.Controls.Add(this.font1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Font";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // font3
            // 
            this.font3.AutoSize = true;
            this.font3.Location = new System.Drawing.Point(66, 124);
            this.font3.Name = "font3";
            this.font3.Size = new System.Drawing.Size(58, 17);
            this.font3.TabIndex = 2;
            this.font3.TabStop = true;
            this.font3.Text = "Courier";
            this.font3.UseVisualStyleBackColor = true;
            // 
            // font2
            // 
            this.font2.AutoSize = true;
            this.font2.Location = new System.Drawing.Point(66, 88);
            this.font2.Name = "font2";
            this.font2.Size = new System.Drawing.Size(45, 17);
            this.font2.TabIndex = 1;
            this.font2.TabStop = true;
            this.font2.Text = "Arial";
            this.font2.UseVisualStyleBackColor = true;
            // 
            // font1
            // 
            this.font1.AutoSize = true;
            this.font1.Location = new System.Drawing.Point(66, 49);
            this.font1.Name = "font1";
            this.font1.Size = new System.Drawing.Size(109, 17);
            this.font1.TabIndex = 0;
            this.font1.Text = "TimesNewRoman";
            this.font1.UseVisualStyleBackColor = true;
            this.font1.CheckedChanged += new System.EventHandler(this.font1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.size3);
            this.tabPage2.Controls.Add(this.size2);
            this.tabPage2.Controls.Add(this.size1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Size";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // size3
            // 
            this.size3.AutoSize = true;
            this.size3.Location = new System.Drawing.Point(66, 142);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(37, 17);
            this.size3.TabIndex = 2;
            this.size3.TabStop = true;
            this.size3.Text = "24";
            this.size3.UseVisualStyleBackColor = true;
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(66, 102);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(37, 17);
            this.size2.TabIndex = 1;
            this.size2.TabStop = true;
            this.size2.Text = "20";
            this.size2.UseVisualStyleBackColor = true;
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Location = new System.Drawing.Point(66, 63);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(37, 17);
            this.size1.TabIndex = 0;
            this.size1.Text = "16";
            this.size1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(455, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 110);
            this.button3.TabIndex = 0;
            this.button3.Text = "Change color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.newtext);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(455, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Text";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Text";
            // 
            // newtext
            // 
            this.newtext.Location = new System.Drawing.Point(174, 72);
            this.newtext.Name = "newtext";
            this.newtext.Size = new System.Drawing.Size(129, 20);
            this.newtext.TabIndex = 2;
            this.newtext.TextChanged += new System.EventHandler(this.newtext_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dialogbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "dialogbox";
            this.Text = "dialogbox";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton font3;
        private System.Windows.Forms.RadioButton font2;
        private System.Windows.Forms.RadioButton font1;
        private System.Windows.Forms.RadioButton size3;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtext;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}