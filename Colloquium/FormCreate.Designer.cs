namespace Colloquium
{
    partial class FormCreate
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(154, 221);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(101, 27);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "сщздать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(111, 87);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(46, 20);
            this.textBoxWidth.TabIndex = 1;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxObject_TextChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(53, 48);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(364, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Напишите через пробел длину, ширину, высоту и координаты объекта";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(111, 128);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(46, 20);
            this.textBoxLenght.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(111, 162);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(46, 20);
            this.textBoxHeight.TabIndex = 4;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(233, 87);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(41, 20);
            this.textBoxX.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(233, 128);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(41, 20);
            this.textBoxY.TabIndex = 6;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(233, 162);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(41, 20);
            this.textBoxZ.TabIndex = 7;
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 296);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxLenght);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
    }
}