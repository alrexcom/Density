namespace Density
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDensity = new System.Windows.Forms.Label();
            this.txtLabourTemperature = new System.Windows.Forms.TextBox();
            this.lblLabTemp = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabDensity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Плотность";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDensity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLabTemp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLabDensity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.26087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 152);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDensity.Location = new System.Drawing.Point(206, 0);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(198, 26);
            this.lblDensity.TabIndex = 2;
            this.lblDensity.Text = "0";
            this.lblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLabourTemperature
            // 
            this.txtLabourTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLabourTemperature.Location = new System.Drawing.Point(102, 35);
            this.txtLabourTemperature.Name = "txtLabourTemperature";
            this.txtLabourTemperature.Size = new System.Drawing.Size(93, 20);
            this.txtLabourTemperature.TabIndex = 4;
            this.txtLabourTemperature.Text = "20";
            this.txtLabourTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLabTemp
            // 
            this.lblLabTemp.AutoSize = true;
            this.lblLabTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabTemp.Location = new System.Drawing.Point(3, 92);
            this.lblLabTemp.Name = "lblLabTemp";
            this.lblLabTemp.Size = new System.Drawing.Size(197, 27);
            this.lblLabTemp.TabIndex = 6;
            this.lblLabTemp.Text = "Лабораторная плотность";
            this.lblLabTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTemp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTemperature, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLabourTemperature, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(206, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 60);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTemperature.Location = new System.Drawing.Point(3, 35);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(93, 20);
            this.txtTemperature.TabIndex = 5;
            this.txtTemperature.Text = "94,60";
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemp.Location = new System.Drawing.Point(3, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(93, 30);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "Температура";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(102, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Лабораторная температура";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLabDensity
            // 
            this.txtLabDensity.Location = new System.Drawing.Point(206, 95);
            this.txtLabDensity.Name = "txtLabDensity";
            this.txtLabDensity.Size = new System.Drawing.Size(100, 20);
            this.txtLabDensity.TabIndex = 8;
            this.txtLabDensity.Text = "768";
            this.txtLabDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(206, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "sql расчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(407, 190);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.TextBox txtLabourTemperature;
        private System.Windows.Forms.Label lblLabTemp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabDensity;
        private System.Windows.Forms.Button button2;
    }
}

