
namespace BDHome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSavedProcedure = new System.Windows.Forms.Button();
            this.buttonCodeProcedure = new System.Windows.Forms.Button();
            this.tableBD = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.buttonWrongSavedProcedure = new System.Windows.Forms.Button();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.buttonWrongCodeProcedure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSavedProcedure
            // 
            this.buttonSavedProcedure.Location = new System.Drawing.Point(388, 647);
            this.buttonSavedProcedure.Name = "buttonSavedProcedure";
            this.buttonSavedProcedure.Size = new System.Drawing.Size(211, 56);
            this.buttonSavedProcedure.TabIndex = 0;
            this.buttonSavedProcedure.Text = "Сохраненная процедура";
            this.buttonSavedProcedure.UseVisualStyleBackColor = true;
            this.buttonSavedProcedure.Click += new System.EventHandler(this.buttonSavedProcedure_Click);
            // 
            // buttonCodeProcedure
            // 
            this.buttonCodeProcedure.Location = new System.Drawing.Point(51, 647);
            this.buttonCodeProcedure.Name = "buttonCodeProcedure";
            this.buttonCodeProcedure.Size = new System.Drawing.Size(211, 56);
            this.buttonCodeProcedure.TabIndex = 1;
            this.buttonCodeProcedure.Text = "Процедура заданная в коде";
            this.buttonCodeProcedure.UseVisualStyleBackColor = true;
            this.buttonCodeProcedure.Click += new System.EventHandler(this.buttonCodeProcedure_Click);
            // 
            // tableBD
            // 
            this.tableBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBD.Location = new System.Drawing.Point(11, 36);
            this.tableBD.Name = "tableBD";
            this.tableBD.ReadOnly = true;
            this.tableBD.RowHeadersWidth = 51;
            this.tableBD.RowTemplate.Height = 29;
            this.tableBD.Size = new System.Drawing.Size(955, 393);
            this.tableBD.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 508);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 556);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(705, 27);
            this.textBox2.TabIndex = 4;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Location = new System.Drawing.Point(729, 647);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(211, 56);
            this.buttonLoadTable.TabIndex = 5;
            this.buttonLoadTable.Text = "Загрузить таблицу";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.buttonLoadTable_Click);
            // 
            // buttonWrongSavedProcedure
            // 
            this.buttonWrongSavedProcedure.Location = new System.Drawing.Point(388, 728);
            this.buttonWrongSavedProcedure.Name = "buttonWrongSavedProcedure";
            this.buttonWrongSavedProcedure.Size = new System.Drawing.Size(211, 56);
            this.buttonWrongSavedProcedure.TabIndex = 7;
            this.buttonWrongSavedProcedure.Text = "Заведомо неверная сохраненная процедура";
            this.buttonWrongSavedProcedure.UseVisualStyleBackColor = true;
            this.buttonWrongSavedProcedure.Click += new System.EventHandler(this.buttonWrongSavedProcedure_Click);
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(11, 435);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxError.Size = new System.Drawing.Size(955, 51);
            this.textBoxError.TabIndex = 8;
            // 
            // buttonWrongCodeProcedure
            // 
            this.buttonWrongCodeProcedure.Location = new System.Drawing.Point(51, 728);
            this.buttonWrongCodeProcedure.Name = "buttonWrongCodeProcedure";
            this.buttonWrongCodeProcedure.Size = new System.Drawing.Size(211, 56);
            this.buttonWrongCodeProcedure.TabIndex = 9;
            this.buttonWrongCodeProcedure.Text = "Заведомо неверная процедура заданная в коде";
            this.buttonWrongCodeProcedure.UseVisualStyleBackColor = true;
            this.buttonWrongCodeProcedure.Click += new System.EventHandler(this.buttonWrongCodeProcedure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя автора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия автора:";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(215, 600);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(705, 27);
            this.textBoxQuery.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Запрос:";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(729, 728);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(211, 56);
            this.buttonQuery.TabIndex = 14;
            this.buttonQuery.Text = "Выполнить запрос";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 805);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWrongCodeProcedure);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.buttonWrongSavedProcedure);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableBD);
            this.Controls.Add(this.buttonCodeProcedure);
            this.Controls.Add(this.buttonSavedProcedure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.tableBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSavedProcedure;
        private System.Windows.Forms.Button buttonCodeProcedure;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.DataGridView tableBD;
        private System.Windows.Forms.Button buttonWrongCodeProcedure;
        private System.Windows.Forms.Button buttonWrongSavedProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuery;
    }
}

