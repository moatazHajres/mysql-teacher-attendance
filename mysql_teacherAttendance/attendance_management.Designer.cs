
namespace mysql_teacherAttendance
{
    partial class attendance_management
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
            this.components = new System.ComponentModel.Container();
            this.Leave = new System.Windows.Forms.DateTimePicker();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.ShowCourse = new System.Windows.Forms.Button();
            this.ShowRoom = new System.Windows.Forms.Button();
            this.ShowTeacher = new System.Windows.Forms.Button();
            this.Courses = new System.Windows.Forms.ComboBox();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.Teachers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Leave
            // 
            this.Leave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Leave.Location = new System.Drawing.Point(890, 31);
            this.Leave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(229, 31);
            this.Leave.TabIndex = 43;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start.Location = new System.Drawing.Point(522, 29);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(229, 31);
            this.Start.TabIndex = 42;
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(174, 31);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(229, 31);
            this.Date.TabIndex = 41;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(942, 216);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 45);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(86, 305);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.Size = new System.Drawing.Size(1029, 335);
            this.dgv1.TabIndex = 39;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            //this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(820, 216);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(112, 45);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(699, 216);
            this.Insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(112, 45);
            this.Insert.TabIndex = 37;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // ShowCourse
            // 
            this.ShowCourse.Location = new System.Drawing.Point(411, 216);
            this.ShowCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowCourse.Name = "ShowCourse";
            this.ShowCourse.Size = new System.Drawing.Size(64, 34);
            this.ShowCourse.TabIndex = 36;
            this.ShowCourse.Text = "Edit";
            this.ShowCourse.UseVisualStyleBackColor = true;
            this.ShowCourse.Click += new System.EventHandler(this.ShowCourse_Click);
            // 
            // ShowRoom
            // 
            this.ShowRoom.Location = new System.Drawing.Point(411, 162);
            this.ShowRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowRoom.Name = "ShowRoom";
            this.ShowRoom.Size = new System.Drawing.Size(64, 34);
            this.ShowRoom.TabIndex = 35;
            this.ShowRoom.Text = "Edit";
            this.ShowRoom.UseVisualStyleBackColor = true;
            this.ShowRoom.Click += new System.EventHandler(this.ShowRoom_Click);
            // 
            // ShowTeacher
            // 
            this.ShowTeacher.Location = new System.Drawing.Point(411, 95);
            this.ShowTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowTeacher.Name = "ShowTeacher";
            this.ShowTeacher.Size = new System.Drawing.Size(64, 34);
            this.ShowTeacher.TabIndex = 34;
            this.ShowTeacher.Text = "Edit";
            this.ShowTeacher.UseVisualStyleBackColor = true;
            this.ShowTeacher.Click += new System.EventHandler(this.ShowTeacher_Click);
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(171, 216);
            this.Courses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(229, 27);
            this.Courses.TabIndex = 33;
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(171, 162);
            this.Rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(229, 27);
            this.Rooms.TabIndex = 32;
            // 
            // Teachers
            // 
            this.Teachers.FormattingEnabled = true;
            this.Teachers.Location = new System.Drawing.Point(171, 96);
            this.Teachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(229, 27);
            this.Teachers.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Course ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Teacher Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(770, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Leave Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(621, 95);
            this.Comment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(498, 99);
            this.Comment.TabIndex = 44;
            this.Comment.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // attendance_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.ShowCourse);
            this.Controls.Add(this.ShowRoom);
            this.Controls.Add(this.ShowTeacher);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "attendance_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.attendance_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Leave;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button ShowCourse;
        private System.Windows.Forms.Button ShowRoom;
        private System.Windows.Forms.Button ShowTeacher;
        private System.Windows.Forms.ComboBox Courses;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.ComboBox Teachers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

