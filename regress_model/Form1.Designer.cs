namespace regress_model
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
            this.button_open_xlsx = new System.Windows.Forms.Button();
            this.button_tab1_to_tab2 = new System.Windows.Forms.Button();
            this.listBox_all_parameters = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox_managed = new System.Windows.Forms.ListBox();
            this.listBox_managers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_tab2_to_tab3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_from_all_to_managers = new System.Windows.Forms.Button();
            this.button_from_managers_to_all = new System.Windows.Forms.Button();
            this.button_from_all_to_managed = new System.Windows.Forms.Button();
            this.button_from_managed_to_all = new System.Windows.Forms.Button();
            this.pictureBox_load = new System.Windows.Forms.PictureBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_load)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open_xlsx
            // 
            this.button_open_xlsx.Location = new System.Drawing.Point(3, 3);
            this.button_open_xlsx.Name = "button_open_xlsx";
            this.button_open_xlsx.Size = new System.Drawing.Size(84, 43);
            this.button_open_xlsx.TabIndex = 0;
            this.button_open_xlsx.Text = "выбрать xlsx-файл";
            this.button_open_xlsx.UseVisualStyleBackColor = true;
            this.button_open_xlsx.Click += new System.EventHandler(this.button_open_xlsx_Click);
            // 
            // button_tab1_to_tab2
            // 
            this.button_tab1_to_tab2.Location = new System.Drawing.Point(593, 337);
            this.button_tab1_to_tab2.Name = "button_tab1_to_tab2";
            this.button_tab1_to_tab2.Size = new System.Drawing.Size(80, 30);
            this.button_tab1_to_tab2.TabIndex = 1;
            this.button_tab1_to_tab2.Text = "Далее";
            this.button_tab1_to_tab2.UseVisualStyleBackColor = true;
            this.button_tab1_to_tab2.Click += new System.EventHandler(this.button_start_Click);
            // 
            // listBox_all_parameters
            // 
            this.listBox_all_parameters.FormattingEnabled = true;
            this.listBox_all_parameters.Location = new System.Drawing.Point(6, 78);
            this.listBox_all_parameters.Name = "listBox_all_parameters";
            this.listBox_all_parameters.Size = new System.Drawing.Size(250, 212);
            this.listBox_all_parameters.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 399);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_solve);
            this.tabPage1.Controls.Add(this.pictureBox_load);
            this.tabPage1.Controls.Add(this.button_from_managed_to_all);
            this.tabPage1.Controls.Add(this.button_from_all_to_managed);
            this.tabPage1.Controls.Add(this.button_from_managers_to_all);
            this.tabPage1.Controls.Add(this.button_from_all_to_managers);
            this.tabPage1.Controls.Add(this.listBox_managed);
            this.tabPage1.Controls.Add(this.listBox_managers);
            this.tabPage1.Controls.Add(this.listBox_all_parameters);
            this.tabPage1.Controls.Add(this.button_open_xlsx);
            this.tabPage1.Controls.Add(this.button_tab1_to_tab2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox_managed
            // 
            this.listBox_managed.FormattingEnabled = true;
            this.listBox_managed.Location = new System.Drawing.Point(423, 195);
            this.listBox_managed.Name = "listBox_managed";
            this.listBox_managed.Size = new System.Drawing.Size(250, 95);
            this.listBox_managed.TabIndex = 4;
            // 
            // listBox_managers
            // 
            this.listBox_managers.FormattingEnabled = true;
            this.listBox_managers.Location = new System.Drawing.Point(423, 78);
            this.listBox_managers.Name = "listBox_managers";
            this.listBox_managers.Size = new System.Drawing.Size(250, 95);
            this.listBox_managers.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_tab2_to_tab3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_tab2_to_tab3
            // 
            this.button_tab2_to_tab3.Location = new System.Drawing.Point(593, 337);
            this.button_tab2_to_tab3.Name = "button_tab2_to_tab3";
            this.button_tab2_to_tab3.Size = new System.Drawing.Size(80, 30);
            this.button_tab2_to_tab3.TabIndex = 0;
            this.button_tab2_to_tab3.Text = "Далее";
            this.button_tab2_to_tab3.UseVisualStyleBackColor = true;
            this.button_tab2_to_tab3.Click += new System.EventHandler(this.button_tab2_to_tab3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(679, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_from_all_to_managers
            // 
            this.button_from_all_to_managers.Location = new System.Drawing.Point(303, 101);
            this.button_from_all_to_managers.Name = "button_from_all_to_managers";
            this.button_from_all_to_managers.Size = new System.Drawing.Size(75, 23);
            this.button_from_all_to_managers.TabIndex = 5;
            this.button_from_all_to_managers.Text = ">>";
            this.button_from_all_to_managers.UseVisualStyleBackColor = true;
            // 
            // button_from_managers_to_all
            // 
            this.button_from_managers_to_all.Location = new System.Drawing.Point(303, 131);
            this.button_from_managers_to_all.Name = "button_from_managers_to_all";
            this.button_from_managers_to_all.Size = new System.Drawing.Size(75, 23);
            this.button_from_managers_to_all.TabIndex = 6;
            this.button_from_managers_to_all.Text = "<<";
            this.button_from_managers_to_all.UseVisualStyleBackColor = true;
            // 
            // button_from_all_to_managed
            // 
            this.button_from_all_to_managed.Location = new System.Drawing.Point(303, 215);
            this.button_from_all_to_managed.Name = "button_from_all_to_managed";
            this.button_from_all_to_managed.Size = new System.Drawing.Size(75, 23);
            this.button_from_all_to_managed.TabIndex = 7;
            this.button_from_all_to_managed.Text = ">>";
            this.button_from_all_to_managed.UseVisualStyleBackColor = true;
            // 
            // button_from_managed_to_all
            // 
            this.button_from_managed_to_all.Location = new System.Drawing.Point(303, 245);
            this.button_from_managed_to_all.Name = "button_from_managed_to_all";
            this.button_from_managed_to_all.Size = new System.Drawing.Size(75, 23);
            this.button_from_managed_to_all.TabIndex = 8;
            this.button_from_managed_to_all.Text = "<<";
            this.button_from_managed_to_all.UseVisualStyleBackColor = true;
            // 
            // pictureBox_load
            // 
            this.pictureBox_load.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_load.Image")));
            this.pictureBox_load.Location = new System.Drawing.Point(325, 14);
            this.pictureBox_load.Name = "pictureBox_load";
            this.pictureBox_load.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_load.TabIndex = 9;
            this.pictureBox_load.TabStop = false;
            this.pictureBox_load.Visible = false;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(71, 323);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(106, 29);
            this.button_solve.TabIndex = 10;
            this.button_solve.Text = "Получить модели";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_open_xlsx;
        private System.Windows.Forms.Button button_tab1_to_tab2;
        private System.Windows.Forms.ListBox listBox_all_parameters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_managed;
        private System.Windows.Forms.ListBox listBox_managers;
        private System.Windows.Forms.Button button_tab2_to_tab3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_from_managed_to_all;
        private System.Windows.Forms.Button button_from_all_to_managed;
        private System.Windows.Forms.Button button_from_managers_to_all;
        private System.Windows.Forms.Button button_from_all_to_managers;
        private System.Windows.Forms.PictureBox pictureBox_load;
        private System.Windows.Forms.Button button_solve;
    }
}

