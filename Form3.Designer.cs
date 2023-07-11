
namespace TugasAkhir_C4
{
    partial class Form3
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
            this.dataGridViewEmploy = new System.Windows.Forms.DataGridView();
            this.labelPro = new System.Windows.Forms.Label();
            this.labelCust = new System.Windows.Forms.Label();
            this.labelEmploy = new System.Windows.Forms.Label();
            this.titleEmploy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxIdEmploy = new System.Windows.Forms.TextBox();
            this.textboxPosition = new System.Windows.Forms.TextBox();
            this.btnClearEmp = new System.Windows.Forms.Button();
            this.textboxNameEmploy = new System.Windows.Forms.TextBox();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.textboxAddressEmploy = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.labelSupp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDepart = new System.Windows.Forms.Label();
            this.labelNameEmp = new System.Windows.Forms.Label();
            this.labelIdEmp = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelAddressEmp = new System.Windows.Forms.Label();
            this.labelTelpEmp = new System.Windows.Forms.Label();
            this.textboxTelpEmploy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploy)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmploy
            // 
            this.dataGridViewEmploy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmploy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmploy.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmploy.Name = "dataGridViewEmploy";
            this.dataGridViewEmploy.RowHeadersWidth = 51;
            this.dataGridViewEmploy.RowTemplate.Height = 24;
            this.dataGridViewEmploy.Size = new System.Drawing.Size(337, 281);
            this.dataGridViewEmploy.TabIndex = 0;
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPro.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPro.ForeColor = System.Drawing.Color.Yellow;
            this.labelPro.Location = new System.Drawing.Point(34, 327);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(66, 24);
            this.labelPro.TabIndex = 30;
            this.labelPro.Text = "Product";
            // 
            // labelCust
            // 
            this.labelCust.AutoSize = true;
            this.labelCust.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelCust.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCust.ForeColor = System.Drawing.Color.Yellow;
            this.labelCust.Location = new System.Drawing.Point(28, 263);
            this.labelCust.Name = "labelCust";
            this.labelCust.Size = new System.Drawing.Size(79, 24);
            this.labelCust.TabIndex = 29;
            this.labelCust.Text = "Customer";
            // 
            // labelEmploy
            // 
            this.labelEmploy.AutoSize = true;
            this.labelEmploy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelEmploy.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmploy.ForeColor = System.Drawing.Color.Yellow;
            this.labelEmploy.Location = new System.Drawing.Point(27, 202);
            this.labelEmploy.Name = "labelEmploy";
            this.labelEmploy.Size = new System.Drawing.Size(81, 24);
            this.labelEmploy.TabIndex = 28;
            this.labelEmploy.Text = "Employee";
            // 
            // titleEmploy
            // 
            this.titleEmploy.AutoSize = true;
            this.titleEmploy.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleEmploy.ForeColor = System.Drawing.Color.Yellow;
            this.titleEmploy.Location = new System.Drawing.Point(207, 23);
            this.titleEmploy.Name = "titleEmploy";
            this.titleEmploy.Size = new System.Drawing.Size(216, 39);
            this.titleEmploy.TabIndex = 16;
            this.titleEmploy.Text = "Manage Employee";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewEmploy);
            this.panel2.Location = new System.Drawing.Point(296, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 281);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.textboxTelpEmploy);
            this.panel1.Controls.Add(this.labelTelpEmp);
            this.panel1.Controls.Add(this.labelAddressEmp);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelIdEmp);
            this.panel1.Controls.Add(this.labelNameEmp);
            this.panel1.Controls.Add(this.titleEmploy);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textboxIdEmploy);
            this.panel1.Controls.Add(this.textboxPosition);
            this.panel1.Controls.Add(this.btnClearEmp);
            this.panel1.Controls.Add(this.textboxNameEmploy);
            this.panel1.Controls.Add(this.btnSaveEmp);
            this.panel1.Controls.Add(this.textboxAddressEmploy);
            this.panel1.Controls.Add(this.btnAddEmp);
            this.panel1.Location = new System.Drawing.Point(137, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 393);
            this.panel1.TabIndex = 27;
            // 
            // textboxIdEmploy
            // 
            this.textboxIdEmploy.Location = new System.Drawing.Point(120, 132);
            this.textboxIdEmploy.Name = "textboxIdEmploy";
            this.textboxIdEmploy.Size = new System.Drawing.Size(145, 22);
            this.textboxIdEmploy.TabIndex = 11;
            // 
            // textboxPosition
            // 
            this.textboxPosition.Location = new System.Drawing.Point(120, 166);
            this.textboxPosition.Name = "textboxPosition";
            this.textboxPosition.Size = new System.Drawing.Size(145, 22);
            this.textboxPosition.TabIndex = 10;
            // 
            // btnClearEmp
            // 
            this.btnClearEmp.FlatAppearance.BorderSize = 0;
            this.btnClearEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmp.ForeColor = System.Drawing.Color.Yellow;
            this.btnClearEmp.Location = new System.Drawing.Point(198, 299);
            this.btnClearEmp.Name = "btnClearEmp";
            this.btnClearEmp.Size = new System.Drawing.Size(67, 37);
            this.btnClearEmp.TabIndex = 7;
            this.btnClearEmp.Text = "Delete";
            this.btnClearEmp.UseVisualStyleBackColor = true;
            // 
            // textboxNameEmploy
            // 
            this.textboxNameEmploy.Location = new System.Drawing.Point(120, 97);
            this.textboxNameEmploy.Name = "textboxNameEmploy";
            this.textboxNameEmploy.Size = new System.Drawing.Size(145, 22);
            this.textboxNameEmploy.TabIndex = 8;
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.FlatAppearance.BorderSize = 0;
            this.btnSaveEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmp.ForeColor = System.Drawing.Color.Yellow;
            this.btnSaveEmp.Location = new System.Drawing.Point(101, 299);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(75, 37);
            this.btnSaveEmp.TabIndex = 6;
            this.btnSaveEmp.Text = "Update";
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            // 
            // textboxAddressEmploy
            // 
            this.textboxAddressEmploy.Location = new System.Drawing.Point(120, 200);
            this.textboxAddressEmploy.Name = "textboxAddressEmploy";
            this.textboxAddressEmploy.Size = new System.Drawing.Size(145, 22);
            this.textboxAddressEmploy.TabIndex = 9;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddEmp.Location = new System.Drawing.Point(23, 299);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(51, 37);
            this.btnAddEmp.TabIndex = 5;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            // 
            // labelSupp
            // 
            this.labelSupp.AutoSize = true;
            this.labelSupp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelSupp.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupp.ForeColor = System.Drawing.Color.Yellow;
            this.labelSupp.Location = new System.Drawing.Point(32, 390);
            this.labelSupp.Name = "labelSupp";
            this.labelSupp.Size = new System.Drawing.Size(71, 24);
            this.labelSupp.TabIndex = 31;
            this.labelSupp.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(157, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(157, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(157, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(157, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelDepart.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepart.ForeColor = System.Drawing.Color.Yellow;
            this.labelDepart.Location = new System.Drawing.Point(15, 145);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(105, 24);
            this.labelDepart.TabIndex = 21;
            this.labelDepart.Text = "Departement";
            // 
            // labelNameEmp
            // 
            this.labelNameEmp.AutoSize = true;
            this.labelNameEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNameEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameEmp.ForeColor = System.Drawing.Color.Yellow;
            this.labelNameEmp.Location = new System.Drawing.Point(20, 103);
            this.labelNameEmp.Name = "labelNameEmp";
            this.labelNameEmp.Size = new System.Drawing.Size(46, 16);
            this.labelNameEmp.TabIndex = 32;
            this.labelNameEmp.Text = "Name";
            // 
            // labelIdEmp
            // 
            this.labelIdEmp.AutoSize = true;
            this.labelIdEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelIdEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdEmp.ForeColor = System.Drawing.Color.Yellow;
            this.labelIdEmp.Location = new System.Drawing.Point(20, 137);
            this.labelIdEmp.Name = "labelIdEmp";
            this.labelIdEmp.Size = new System.Drawing.Size(26, 16);
            this.labelIdEmp.TabIndex = 33;
            this.labelIdEmp.Text = "ID";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPosition.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.Color.Yellow;
            this.labelPosition.Location = new System.Drawing.Point(20, 171);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(60, 16);
            this.labelPosition.TabIndex = 34;
            this.labelPosition.Text = "Position";
            // 
            // labelAddressEmp
            // 
            this.labelAddressEmp.AutoSize = true;
            this.labelAddressEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelAddressEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressEmp.ForeColor = System.Drawing.Color.Yellow;
            this.labelAddressEmp.Location = new System.Drawing.Point(20, 205);
            this.labelAddressEmp.Name = "labelAddressEmp";
            this.labelAddressEmp.Size = new System.Drawing.Size(60, 16);
            this.labelAddressEmp.TabIndex = 35;
            this.labelAddressEmp.Text = "Address";
            // 
            // labelTelpEmp
            // 
            this.labelTelpEmp.AutoSize = true;
            this.labelTelpEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelTelpEmp.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelpEmp.ForeColor = System.Drawing.Color.Yellow;
            this.labelTelpEmp.Location = new System.Drawing.Point(20, 246);
            this.labelTelpEmp.Name = "labelTelpEmp";
            this.labelTelpEmp.Size = new System.Drawing.Size(93, 16);
            this.labelTelpEmp.TabIndex = 36;
            this.labelTelpEmp.Text = "Phone Numb";
            // 
            // textboxTelpEmploy
            // 
            this.textboxTelpEmploy.Location = new System.Drawing.Point(120, 240);
            this.textboxTelpEmploy.Name = "textboxTelpEmploy";
            this.textboxTelpEmploy.Size = new System.Drawing.Size(145, 22);
            this.textboxTelpEmploy.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TugasAkhir_C4.Properties.Resources.clearbtn;
            this.pictureBox1.Location = new System.Drawing.Point(744, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TugasAkhir_C4.Properties.Resources._1642256;
            this.pictureBox3.Location = new System.Drawing.Point(28, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPro);
            this.Controls.Add(this.labelCust);
            this.Controls.Add(this.labelEmploy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSupp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDepart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pegawai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmploy;
        private System.Windows.Forms.Label labelPro;
        private System.Windows.Forms.Label labelCust;
        private System.Windows.Forms.Label labelEmploy;
        private System.Windows.Forms.Label titleEmploy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxIdEmploy;
        private System.Windows.Forms.TextBox textboxPosition;
        private System.Windows.Forms.Button btnClearEmp;
        private System.Windows.Forms.TextBox textboxNameEmploy;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.TextBox textboxAddressEmploy;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label labelSupp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Label labelNameEmp;
        private System.Windows.Forms.Label labelIdEmp;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textboxTelpEmploy;
        private System.Windows.Forms.Label labelTelpEmp;
        private System.Windows.Forms.Label labelAddressEmp;
    }
}