namespace Colloquium
{
    partial class FormMain
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
            this.buttonCreateSea = new System.Windows.Forms.Button();
            this.listBoxObject = new System.Windows.Forms.ListBox();
            this.buttonCreateIsland = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateSea
            // 
            this.buttonCreateSea.Location = new System.Drawing.Point(465, 45);
            this.buttonCreateSea.Name = "buttonCreateSea";
            this.buttonCreateSea.Size = new System.Drawing.Size(99, 34);
            this.buttonCreateSea.TabIndex = 0;
            this.buttonCreateSea.Text = "создать море";
            this.buttonCreateSea.UseVisualStyleBackColor = true;
            this.buttonCreateSea.Click += new System.EventHandler(this.buttonCreateSea_Click);
            // 
            // listBoxObject
            // 
            this.listBoxObject.FormattingEnabled = true;
            this.listBoxObject.Location = new System.Drawing.Point(27, 12);
            this.listBoxObject.Name = "listBoxObject";
            this.listBoxObject.Size = new System.Drawing.Size(412, 420);
            this.listBoxObject.TabIndex = 1;
            // 
            // buttonCreateIsland
            // 
            this.buttonCreateIsland.Location = new System.Drawing.Point(465, 110);
            this.buttonCreateIsland.Name = "buttonCreateIsland";
            this.buttonCreateIsland.Size = new System.Drawing.Size(99, 35);
            this.buttonCreateIsland.TabIndex = 2;
            this.buttonCreateIsland.Text = "создать остров";
            this.buttonCreateIsland.UseVisualStyleBackColor = true;
            this.buttonCreateIsland.Click += new System.EventHandler(this.buttonCreateIsland_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.buttonCreateIsland);
            this.Controls.Add(this.listBoxObject);
            this.Controls.Add(this.buttonCreateSea);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSea;
        private System.Windows.Forms.ListBox listBoxObject;
        private System.Windows.Forms.Button buttonCreateIsland;
    }
}

