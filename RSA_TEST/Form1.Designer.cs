
namespace RSA_TEST
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
            this.label6 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fromFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finalMessageText = new System.Windows.Forms.Label();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.decryptionTextBox = new System.Windows.Forms.TextBox();
            this.encryptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Result:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(106, 188);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(134, 22);
            this.resultTextBox.TabIndex = 29;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(470, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "From file";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fromFileButton
            // 
            this.fromFileButton.Location = new System.Drawing.Point(626, 99);
            this.fromFileButton.Name = "fromFileButton";
            this.fromFileButton.Size = new System.Drawing.Size(73, 32);
            this.fromFileButton.TabIndex = 27;
            this.fromFileButton.Text = "From file";
            this.fromFileButton.UseVisualStyleBackColor = true;
            this.fromFileButton.Click += new System.EventHandler(this.fromFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Decryption text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Encryption text:";
            // 
            // finalMessageText
            // 
            this.finalMessageText.AutoSize = true;
            this.finalMessageText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalMessageText.Location = new System.Drawing.Point(248, 346);
            this.finalMessageText.Name = "finalMessageText";
            this.finalMessageText.Size = new System.Drawing.Size(0, 26);
            this.finalMessageText.TabIndex = 22;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(339, 161);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(38, 22);
            this.qTextBox.TabIndex = 21;
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(339, 104);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(38, 22);
            this.pTextBox.TabIndex = 20;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(470, 261);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(135, 47);
            this.decryptionButton.TabIndex = 19;
            this.decryptionButton.Text = "Decryption";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(106, 261);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(142, 47);
            this.encryptionButton.TabIndex = 18;
            this.encryptionButton.Text = "Encryption";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // decryptionTextBox
            // 
            this.decryptionTextBox.Location = new System.Drawing.Point(470, 104);
            this.decryptionTextBox.Name = "decryptionTextBox";
            this.decryptionTextBox.Size = new System.Drawing.Size(135, 22);
            this.decryptionTextBox.TabIndex = 17;
            // 
            // encryptionTextBox
            // 
            this.encryptionTextBox.Location = new System.Drawing.Point(106, 104);
            this.encryptionTextBox.Name = "encryptionTextBox";
            this.encryptionTextBox.Size = new System.Drawing.Size(129, 22);
            this.encryptionTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.fromFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalMessageText);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.decryptionTextBox);
            this.Controls.Add(this.encryptionTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button fromFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finalMessageText;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.TextBox decryptionTextBox;
        private System.Windows.Forms.TextBox encryptionTextBox;
    }
}

