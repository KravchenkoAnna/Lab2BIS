namespace WindowsFormsApp1
{
    partial class Cipher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Encoding = new System.Windows.Forms.TabPage();
            this.textBoxEncodeResult = new System.Windows.Forms.RichTextBox();
            this.keywordEtext = new System.Windows.Forms.RichTextBox();
            this.textBoxEncode = new System.Windows.Forms.RichTextBox();
            this.lableForg1 = new System.Windows.Forms.Label();
            this.exportEncode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gasloEncodeRButton = new System.Windows.Forms.RadioButton();
            this.nonLinearEncode = new System.Windows.Forms.RadioButton();
            this.linearEncode = new System.Windows.Forms.RadioButton();
            this.browseEncode = new System.Windows.Forms.Button();
            this.labelEncodePage = new System.Windows.Forms.Label();
            this.goEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Decoding = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.RichTextBox();
            this.keywordD = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.RichTextBox();
            this.lableForg2 = new System.Windows.Forms.Label();
            this.gasloDecode = new System.Windows.Forms.RadioButton();
            this.nonlinearDe = new System.Windows.Forms.RadioButton();
            this.linearDecode = new System.Windows.Forms.RadioButton();
            this.browseDecode = new System.Windows.Forms.Button();
            this.exportDecode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.Encoding.SuspendLayout();
            this.Decoding.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Encoding);
            this.tabControl1.Controls.Add(this.Decoding);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 653);
            this.tabControl1.TabIndex = 3;
            // 
            // Encoding
            // 
            this.Encoding.Controls.Add(this.textBoxEncodeResult);
            this.Encoding.Controls.Add(this.keywordEtext);
            this.Encoding.Controls.Add(this.textBoxEncode);
            this.Encoding.Controls.Add(this.lableForg1);
            this.Encoding.Controls.Add(this.exportEncode);
            this.Encoding.Controls.Add(this.label3);
            this.Encoding.Controls.Add(this.gasloEncodeRButton);
            this.Encoding.Controls.Add(this.nonLinearEncode);
            this.Encoding.Controls.Add(this.linearEncode);
            this.Encoding.Controls.Add(this.browseEncode);
            this.Encoding.Controls.Add(this.labelEncodePage);
            this.Encoding.Controls.Add(this.goEncode);
            this.Encoding.Controls.Add(this.label1);
            this.Encoding.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encoding.Location = new System.Drawing.Point(4, 25);
            this.Encoding.Name = "Encoding";
            this.Encoding.Padding = new System.Windows.Forms.Padding(3);
            this.Encoding.Size = new System.Drawing.Size(874, 624);
            this.Encoding.TabIndex = 0;
            this.Encoding.Text = "Encoding";
            this.Encoding.UseVisualStyleBackColor = true;
            // 
            // textBoxEncodeResult
            // 
            this.textBoxEncodeResult.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEncodeResult.Location = new System.Drawing.Point(34, 434);
            this.textBoxEncodeResult.Name = "textBoxEncodeResult";
            this.textBoxEncodeResult.Size = new System.Drawing.Size(645, 69);
            this.textBoxEncodeResult.TabIndex = 20;
            this.textBoxEncodeResult.Text = "";
            // 
            // keywordEtext
            // 
            this.keywordEtext.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordEtext.Location = new System.Drawing.Point(34, 284);
            this.keywordEtext.Name = "keywordEtext";
            this.keywordEtext.Size = new System.Drawing.Size(402, 57);
            this.keywordEtext.TabIndex = 19;
            this.keywordEtext.Text = "";
            this.keywordEtext.Visible = false;
            // 
            // textBoxEncode
            // 
            this.textBoxEncode.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEncode.Location = new System.Drawing.Point(39, 82);
            this.textBoxEncode.Name = "textBoxEncode";
            this.textBoxEncode.Size = new System.Drawing.Size(640, 69);
            this.textBoxEncode.TabIndex = 18;
            this.textBoxEncode.Text = "";
            // 
            // lableForg1
            // 
            this.lableForg1.AutoSize = true;
            this.lableForg1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableForg1.Location = new System.Drawing.Point(30, 244);
            this.lableForg1.Name = "lableForg1";
            this.lableForg1.Size = new System.Drawing.Size(160, 24);
            this.lableForg1.TabIndex = 16;
            this.lableForg1.Text = "Input key word:";
            this.lableForg1.Visible = false;
            // 
            // exportEncode
            // 
            this.exportEncode.BackColor = System.Drawing.Color.Black;
            this.exportEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportEncode.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportEncode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportEncode.Location = new System.Drawing.Point(709, 434);
            this.exportEncode.Name = "exportEncode";
            this.exportEncode.Size = new System.Drawing.Size(130, 69);
            this.exportEncode.TabIndex = 15;
            this.exportEncode.Text = "Export";
            this.exportEncode.UseVisualStyleBackColor = false;
            this.exportEncode.Click += new System.EventHandler(this.exportEncode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result of encoding:";
            // 
            // gasloEncodeRButton
            // 
            this.gasloEncodeRButton.AutoSize = true;
            this.gasloEncodeRButton.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasloEncodeRButton.Location = new System.Drawing.Point(594, 174);
            this.gasloEncodeRButton.Name = "gasloEncodeRButton";
            this.gasloEncodeRButton.Size = new System.Drawing.Size(221, 35);
            this.gasloEncodeRButton.TabIndex = 12;
            this.gasloEncodeRButton.TabStop = true;
            this.gasloEncodeRButton.Text = "String key use";
            this.gasloEncodeRButton.UseVisualStyleBackColor = true;
            this.gasloEncodeRButton.CheckedChanged += new System.EventHandler(this.gasloEncodeRButton_CheckedChanged);
            // 
            // nonLinearEncode
            // 
            this.nonLinearEncode.AutoSize = true;
            this.nonLinearEncode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonLinearEncode.Location = new System.Drawing.Point(284, 174);
            this.nonLinearEncode.Name = "nonLinearEncode";
            this.nonLinearEncode.Size = new System.Drawing.Size(281, 35);
            this.nonLinearEncode.TabIndex = 11;
            this.nonLinearEncode.TabStop = true;
            this.nonLinearEncode.Text = "Non-linear key use";
            this.nonLinearEncode.UseVisualStyleBackColor = true;
            this.nonLinearEncode.CheckedChanged += new System.EventHandler(this.nonLinearEncode_CheckedChanged);
            // 
            // linearEncode
            // 
            this.linearEncode.AutoSize = true;
            this.linearEncode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearEncode.Location = new System.Drawing.Point(34, 174);
            this.linearEncode.Name = "linearEncode";
            this.linearEncode.Size = new System.Drawing.Size(225, 35);
            this.linearEncode.TabIndex = 10;
            this.linearEncode.TabStop = true;
            this.linearEncode.Text = "Linear key use";
            this.linearEncode.UseVisualStyleBackColor = true;
            this.linearEncode.CheckedChanged += new System.EventHandler(this.linearEncode_CheckedChanged);
            // 
            // browseEncode
            // 
            this.browseEncode.BackColor = System.Drawing.Color.Black;
            this.browseEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseEncode.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseEncode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.browseEncode.Location = new System.Drawing.Point(709, 82);
            this.browseEncode.Name = "browseEncode";
            this.browseEncode.Size = new System.Drawing.Size(130, 69);
            this.browseEncode.TabIndex = 8;
            this.browseEncode.Text = "Browse";
            this.browseEncode.UseVisualStyleBackColor = false;
            this.browseEncode.Click += new System.EventHandler(this.browseEncode_Click);
            // 
            // labelEncodePage
            // 
            this.labelEncodePage.AutoSize = true;
            this.labelEncodePage.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncodePage.Location = new System.Drawing.Point(34, 28);
            this.labelEncodePage.Name = "labelEncodePage";
            this.labelEncodePage.Size = new System.Drawing.Size(336, 30);
            this.labelEncodePage.TabIndex = 4;
            this.labelEncodePage.Text = "Input the message to encode:";
            // 
            // goEncode
            // 
            this.goEncode.BackColor = System.Drawing.Color.Black;
            this.goEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goEncode.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goEncode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goEncode.Location = new System.Drawing.Point(34, 527);
            this.goEncode.Name = "goEncode";
            this.goEncode.Size = new System.Drawing.Size(166, 74);
            this.goEncode.TabIndex = 3;
            this.goEncode.Text = "GO";
            this.goEncode.UseVisualStyleBackColor = false;
            this.goEncode.Click += new System.EventHandler(this.goEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 2;
            // 
            // Decoding
            // 
            this.Decoding.BackColor = System.Drawing.Color.White;
            this.Decoding.Controls.Add(this.textBox4);
            this.Decoding.Controls.Add(this.keywordD);
            this.Decoding.Controls.Add(this.textBox3);
            this.Decoding.Controls.Add(this.lableForg2);
            this.Decoding.Controls.Add(this.gasloDecode);
            this.Decoding.Controls.Add(this.nonlinearDe);
            this.Decoding.Controls.Add(this.linearDecode);
            this.Decoding.Controls.Add(this.browseDecode);
            this.Decoding.Controls.Add(this.exportDecode);
            this.Decoding.Controls.Add(this.label5);
            this.Decoding.Controls.Add(this.DecodeButton);
            this.Decoding.Controls.Add(this.label4);
            this.Decoding.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decoding.Location = new System.Drawing.Point(4, 25);
            this.Decoding.Name = "Decoding";
            this.Decoding.Padding = new System.Windows.Forms.Padding(3);
            this.Decoding.Size = new System.Drawing.Size(874, 624);
            this.Decoding.TabIndex = 1;
            this.Decoding.Text = "Decoding";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(37, 444);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(636, 67);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "";
            // 
            // keywordD
            // 
            this.keywordD.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordD.Location = new System.Drawing.Point(33, 282);
            this.keywordD.Name = "keywordD";
            this.keywordD.Size = new System.Drawing.Size(399, 60);
            this.keywordD.TabIndex = 27;
            this.keywordD.Text = "";
            this.keywordD.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(33, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(640, 69);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "";
            // 
            // lableForg2
            // 
            this.lableForg2.AutoSize = true;
            this.lableForg2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableForg2.Location = new System.Drawing.Point(38, 245);
            this.lableForg2.Name = "lableForg2";
            this.lableForg2.Size = new System.Drawing.Size(160, 24);
            this.lableForg2.TabIndex = 24;
            this.lableForg2.Text = "Input key word:";
            this.lableForg2.Visible = false;
            // 
            // gasloDecode
            // 
            this.gasloDecode.AutoSize = true;
            this.gasloDecode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasloDecode.Location = new System.Drawing.Point(615, 186);
            this.gasloDecode.Name = "gasloDecode";
            this.gasloDecode.Size = new System.Drawing.Size(221, 35);
            this.gasloDecode.TabIndex = 23;
            this.gasloDecode.TabStop = true;
            this.gasloDecode.Text = "String key use";
            this.gasloDecode.UseVisualStyleBackColor = true;
            this.gasloDecode.CheckedChanged += new System.EventHandler(this.gasloDecode_CheckedChanged);
            // 
            // nonlinearDe
            // 
            this.nonlinearDe.AutoSize = true;
            this.nonlinearDe.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonlinearDe.Location = new System.Drawing.Point(301, 186);
            this.nonlinearDe.Name = "nonlinearDe";
            this.nonlinearDe.Size = new System.Drawing.Size(281, 35);
            this.nonlinearDe.TabIndex = 22;
            this.nonlinearDe.TabStop = true;
            this.nonlinearDe.Text = "Non-linear key use";
            this.nonlinearDe.UseVisualStyleBackColor = true;
            this.nonlinearDe.CheckedChanged += new System.EventHandler(this.nonlinearDe_CheckedChanged);
            // 
            // linearDecode
            // 
            this.linearDecode.AutoSize = true;
            this.linearDecode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearDecode.Location = new System.Drawing.Point(33, 186);
            this.linearDecode.Name = "linearDecode";
            this.linearDecode.Size = new System.Drawing.Size(225, 35);
            this.linearDecode.TabIndex = 21;
            this.linearDecode.TabStop = true;
            this.linearDecode.Text = "Linear key use";
            this.linearDecode.UseVisualStyleBackColor = true;
            this.linearDecode.CheckedChanged += new System.EventHandler(this.linearDecode_CheckedChanged);
            // 
            // browseDecode
            // 
            this.browseDecode.BackColor = System.Drawing.Color.Black;
            this.browseDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseDecode.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseDecode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.browseDecode.Location = new System.Drawing.Point(712, 92);
            this.browseDecode.Name = "browseDecode";
            this.browseDecode.Size = new System.Drawing.Size(130, 69);
            this.browseDecode.TabIndex = 20;
            this.browseDecode.Text = "Browse";
            this.browseDecode.UseVisualStyleBackColor = false;
            this.browseDecode.Click += new System.EventHandler(this.browseDecode_Click);
            // 
            // exportDecode
            // 
            this.exportDecode.BackColor = System.Drawing.Color.Black;
            this.exportDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportDecode.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDecode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportDecode.Location = new System.Drawing.Point(712, 442);
            this.exportDecode.Name = "exportDecode";
            this.exportDecode.Size = new System.Drawing.Size(130, 69);
            this.exportDecode.TabIndex = 19;
            this.exportDecode.Text = "Export";
            this.exportDecode.UseVisualStyleBackColor = false;
            this.exportDecode.Click += new System.EventHandler(this.exportDecode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Result of decoding:";
            // 
            // DecodeButton
            // 
            this.DecodeButton.BackColor = System.Drawing.Color.Black;
            this.DecodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecodeButton.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecodeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DecodeButton.Location = new System.Drawing.Point(37, 535);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(166, 74);
            this.DecodeButton.TabIndex = 16;
            this.DecodeButton.Text = "GO";
            this.DecodeButton.UseVisualStyleBackColor = false;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input the message to decode:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 624);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Authors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 45);
            this.label7.TabIndex = 1;
            this.label7.Text = "Group TP-13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(568, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Developer is Anna Kravchenko";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cipher";
            this.Text = "Cipher";
            this.tabControl1.ResumeLayout(false);
            this.Encoding.ResumeLayout(false);
            this.Encoding.PerformLayout();
            this.Decoding.ResumeLayout(false);
            this.Decoding.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Encoding;
        private System.Windows.Forms.TabPage Decoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseEncode;
        private System.Windows.Forms.Label labelEncodePage;
        private System.Windows.Forms.Button goEncode;
        private System.Windows.Forms.RadioButton gasloEncodeRButton;
        private System.Windows.Forms.RadioButton nonLinearEncode;
        private System.Windows.Forms.RadioButton linearEncode;
        private System.Windows.Forms.Button exportEncode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseDecode;
        private System.Windows.Forms.Button exportDecode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton gasloDecode;
        private System.Windows.Forms.RadioButton nonlinearDe;
        private System.Windows.Forms.RadioButton linearDecode;
        private System.Windows.Forms.Label lableForg1;
        private System.Windows.Forms.Label lableForg2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox textBox3;
        private System.Windows.Forms.RichTextBox textBox4;
        private System.Windows.Forms.RichTextBox keywordD;
        private System.Windows.Forms.RichTextBox textBoxEncodeResult;
        private System.Windows.Forms.RichTextBox keywordEtext;
        private System.Windows.Forms.RichTextBox textBoxEncode;
    }
}

