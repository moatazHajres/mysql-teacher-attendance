﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql_teacherAttendance
{
    public partial class Courses : Form

    {
        public string id = "";
        public Courses()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            Course_name.Text = "";
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            dbOperations.query = "SELECT * FROM teacher_attendance.courses";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd);
            Reset();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            dbOperations.query = "INSERT INTO teacher_attendance.courses (`name`) VALUES (@name);";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("name", Course_name.Text.Trim());
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT * FROM teacher_attendance.courses", dbOperations.con));
            Reset();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dbOperations.query = "UPDATE teacher_attendance.courses SET `name` = @name WHERE `courses`.`id` = @id; ";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("id", this.id);
            dbOperations.cmd.Parameters.AddWithValue("name", Course_name.Text.Trim());
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT * FROM teacher_attendance.courses", dbOperations.con));
            Reset();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dbOperations.query = "DELETE FROM teacher_attendance.courses WHERE `courses`.`id` = @id ";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("id", this.id);
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT * FROM teacher_attendance.courses", dbOperations.con));
            Reset();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgv1.CurrentRow.Cells[0].Value.ToString();
            Course_name.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
