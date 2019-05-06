namespace MyRestaurant
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.排骨飯 = new System.Windows.Forms.Button();
            this.餐廳1 = new System.Windows.Forms.Label();
            this.餐廳1菜單 = new System.Windows.Forms.Label();
            this.排骨飯價錢 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 排骨飯
            // 
            this.排骨飯.Location = new System.Drawing.Point(13, 25);
            this.排骨飯.Name = "排骨飯";
            this.排骨飯.Size = new System.Drawing.Size(75, 23);
            this.排骨飯.TabIndex = 0;
            this.排骨飯.Text = "排骨飯";
            this.排骨飯.UseVisualStyleBackColor = true;
            this.排骨飯.Click += new System.EventHandler(this.排骨飯_Click);
            // 
            // 餐廳1
            // 
            this.餐廳1.AutoSize = true;
            this.餐廳1.Location = new System.Drawing.Point(169, 25);
            this.餐廳1.Name = "餐廳1";
            this.餐廳1.Size = new System.Drawing.Size(71, 12);
            this.餐廳1.TabIndex = 1;
            this.餐廳1.Text = "餐廳1菜單：";
            // 
            // 餐廳1菜單
            // 
            this.餐廳1菜單.AutoSize = true;
            this.餐廳1菜單.Location = new System.Drawing.Point(180, 37);
            this.餐廳1菜單.Name = "餐廳1菜單";
            this.餐廳1菜單.Size = new System.Drawing.Size(0, 12);
            this.餐廳1菜單.TabIndex = 2;
            // 
            // 排骨飯價錢
            // 
            this.排骨飯價錢.Location = new System.Drawing.Point(95, 26);
            this.排骨飯價錢.Name = "排骨飯價錢";
            this.排骨飯價錢.Size = new System.Drawing.Size(36, 22);
            this.排骨飯價錢.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.排骨飯價錢);
            this.Controls.Add(this.餐廳1菜單);
            this.Controls.Add(this.餐廳1);
            this.Controls.Add(this.排骨飯);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 排骨飯;
        private System.Windows.Forms.Label 餐廳1;
        private System.Windows.Forms.Label 餐廳1菜單;
        private System.Windows.Forms.TextBox 排骨飯價錢;
        private System.Windows.Forms.Label label1;

    }
}

