﻿
namespace mysql_teacherAttendance
{
    partial class Teachers
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Teacher_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(13, 107);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(240, 150);
            this.dgv1.TabIndex = 42;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Teacher Name";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(269, 180);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 30);
            this.Delete.TabIndex = 39;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(269, 144);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 30);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(269, 108);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 30);
            this.Insert.TabIndex = 37;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Teacher_name
            // 
            this.Teacher_name.Location = new System.Drawing.Point(110, 78);
            this.Teacher_name.Name = "Teacher_name";
            this.Teacher_name.Size = new System.Drawing.Size(141, 20);
            this.Teacher_name.TabIndex = 36;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 285);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Teacher_name);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox Teacher_name;
    }
}