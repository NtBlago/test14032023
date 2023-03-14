namespace test14032023
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
            this.enter_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.bot_pannel = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.icon_picturebox = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.enter_button.Location = new System.Drawing.Point(146, 150);
            this.enter_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(152, 78);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.exit_button.Location = new System.Drawing.Point(146, 236);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(152, 78);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.top_panel.Controls.Add(this.icon_picturebox);
            this.top_panel.Controls.Add(this.label_name);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(373, 114);
            this.top_panel.TabIndex = 2;
            // 
            // bot_pannel
            // 
            this.bot_pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bot_pannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bot_pannel.Location = new System.Drawing.Point(0, 368);
            this.bot_pannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bot_pannel.Name = "bot_pannel";
            this.bot_pannel.Size = new System.Drawing.Size(373, 98);
            this.bot_pannel.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(173, 54);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(125, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "ООО «Украшение»";
            // 
            // icon_picturebox
            // 
            this.icon_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("icon_picturebox.Image")));
            this.icon_picturebox.Location = new System.Drawing.Point(0, 3);
            this.icon_picturebox.Name = "icon_picturebox";
            this.icon_picturebox.Size = new System.Drawing.Size(121, 111);
            this.icon_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_picturebox.TabIndex = 1;
            this.icon_picturebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 466);
            this.Controls.Add(this.bot_pannel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.enter_button);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Вход.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel bot_pannel;
        private System.Windows.Forms.PictureBox icon_picturebox;
        private System.Windows.Forms.Label label_name;
    }
}

