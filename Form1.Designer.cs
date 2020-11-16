namespace WindowsFormsApp4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.BackColor = System.Drawing.Color.Sienna;
            this.btnRefill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefill.ForeColor = System.Drawing.Color.White;
            this.btnRefill.Location = new System.Drawing.Point(180, 25);
            this.btnRefill.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(157, 31);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = false;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtInfo.Location = new System.Drawing.Point(91, 76);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(374, 96);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.White;
            this.txtOut.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtOut.Location = new System.Drawing.Point(91, 178);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(268, 158);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            this.txtOut.TextChanged += new System.EventHandler(this.txtOut_TextChanged);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.Sienna;
            this.btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGet.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(362, 178);
            this.btnGet.Margin = new System.Windows.Forms.Padding(0);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(103, 158);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.Color.White;
            this.txtList.Location = new System.Drawing.Point(504, 76);
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(177, 260);
            this.txtList.TabIndex = 4;
            this.txtList.Text = "";
            this.txtList.TextChanged += new System.EventHandler(this.txtList_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRefill);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмулятор кино-автомата";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtList;
    }
}

