namespace WindowsFormsApp1
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
            this.btn_what_is_button = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.picture_cat = new System.Windows.Forms.PictureBox();
            this.picture_dog = new System.Windows.Forms.PictureBox();
            this.picture_parrot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_parrot)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_what_is_button
            // 
            this.btn_what_is_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_what_is_button.Location = new System.Drawing.Point(517, 519);
            this.btn_what_is_button.Name = "btn_what_is_button";
            this.btn_what_is_button.Size = new System.Drawing.Size(515, 92);
            this.btn_what_is_button.TabIndex = 0;
            this.btn_what_is_button.Text = "What is it?";
            this.btn_what_is_button.UseVisualStyleBackColor = true;
            this.btn_what_is_button.Click += new System.EventHandler(this.Btn_cat_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1360, 568);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(161, 43);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // picture_cat
            // 
            this.picture_cat.BackColor = System.Drawing.SystemColors.Control;
            this.picture_cat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_cat.BackgroundImage")));
            this.picture_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_cat.Location = new System.Drawing.Point(12, 12);
            this.picture_cat.Name = "picture_cat";
            this.picture_cat.Size = new System.Drawing.Size(499, 462);
            this.picture_cat.TabIndex = 4;
            this.picture_cat.TabStop = false;
            this.picture_cat.Click += new System.EventHandler(this.picture_cat_Click);
            // 
            // picture_dog
            // 
            this.picture_dog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_dog.BackgroundImage")));
            this.picture_dog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_dog.Location = new System.Drawing.Point(517, 12);
            this.picture_dog.Name = "picture_dog";
            this.picture_dog.Size = new System.Drawing.Size(515, 462);
            this.picture_dog.TabIndex = 5;
            this.picture_dog.TabStop = false;
            this.picture_dog.Click += new System.EventHandler(this.picture_dog_Click);
            // 
            // picture_parrot
            // 
            this.picture_parrot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_parrot.BackgroundImage")));
            this.picture_parrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_parrot.Location = new System.Drawing.Point(1038, 12);
            this.picture_parrot.Name = "picture_parrot";
            this.picture_parrot.Size = new System.Drawing.Size(513, 462);
            this.picture_parrot.TabIndex = 6;
            this.picture_parrot.TabStop = false;
            this.picture_parrot.Click += new System.EventHandler(this.picture_parrot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 650);
            this.Controls.Add(this.picture_parrot);
            this.Controls.Add(this.picture_dog);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_what_is_button);
            this.Controls.Add(this.picture_cat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_parrot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_what_is_button;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox picture_cat;
        private System.Windows.Forms.PictureBox picture_dog;
        private System.Windows.Forms.PictureBox picture_parrot;
    }
}

