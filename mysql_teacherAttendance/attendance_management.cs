using System;
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
    public partial class attendance_management : Form
    {
        public string id = "";
        public attendance_management()
        {
            InitializeComponent();
        }

        private void attendance_management_Load(object sender, EventArgs e)
        {
            dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd);
            Fill_combo();
            Reset();
        }
        private void Reset()
        {
            Date.Text = "";
            Start.Text = "";
            Leave.Text = "";
            Teachers.SelectedIndex = -1;
            Courses.SelectedIndex = -1;
            Rooms.SelectedIndex = -1;
            Comment.Text = "";
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            dbOperations.query = "INSERT INTO teacher_attendance.attendance_management (`date`, `start_time`, `leave_time`, `teacher_id`, `room_id`, `course_id`, `comment`) VALUES (@date, @start_time, @leave_time, @teacher_id, @room_id, @course_id, @comment);";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("date", Date.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("start_time", Start.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("leave_time", Leave.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("teacher_id", Teachers.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("room_id", Rooms.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("course_id", Courses.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("comment", Comment.Text.Trim());
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgv1.CurrentRow.Cells[0].Value.ToString();
            Date.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            Start.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            Leave.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            Teachers.SelectedValue = Convert.ToInt32(dgv1.CurrentRow.Cells[4].Value);
            Rooms.SelectedValue = Convert.ToInt32(dgv1.CurrentRow.Cells[5].Value);
            Courses.SelectedValue = Convert.ToInt32(dgv1.CurrentRow.Cells[6].Value);
            Comment.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dbOperations.query = "UPDATE teacher_attendance.attendance_management SET `date` = @date, `start_time` = @start_time, `leave_time` = @leave_time, `teacher_id` = @teacher_id, `room_id` = @room_id, `course_id` = @course_id, `comment` = @comment WHERE `attendance_management`.`id` = @id; ";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("id", this.id);
            dbOperations.cmd.Parameters.AddWithValue("date", Date.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("start_time", Start.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("leave_time", Leave.Text.Trim());
            dbOperations.cmd.Parameters.AddWithValue("teacher_id", Teachers.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("room_id", Rooms.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("course_id", Courses.SelectedValue.ToString());
            dbOperations.cmd.Parameters.AddWithValue("comment", Comment.Text.Trim());
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dbOperations.query = "DELETE FROM teacher_attendance.attendance_management WHERE `attendance_management`.`id` = @id  ";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dbOperations.cmd.Parameters.Clear();
            dbOperations.cmd.Parameters.AddWithValue("id", this.id);
            dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));
        }
        private void Fill_combo()
        {
            dbOperations.query = "SELECT * FROM teacher_attendance.teachers";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            Teachers.ValueMember = "id";
            Teachers.DisplayMember = "name";
            DataTable dt_teacher = dbOperations.execute(dbOperations.cmd);
            Teachers.DataSource = dt_teacher;


            dbOperations.query = "SELECT * FROM teacher_attendance.courses";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            Courses.ValueMember = "id";
            Courses.DisplayMember = "name";
            DataTable dt_course = dbOperations.execute(dbOperations.cmd);
            Courses.DataSource = dt_course;


            dbOperations.query = "SELECT * FROM teacher_attendance.rooms";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            Rooms.ValueMember = "id";
            Rooms.DisplayMember = "name";
            DataTable dt_room = dbOperations.execute(dbOperations.cmd);
            Rooms.DataSource = dt_room;



        }

        private void ShowTeacher_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            teacher.ShowDialog();
            Fill_combo();
            dbOperations.query = "DELETE FROM teacher_attendance.attendance_management WHERE teacher_id NOT IN (SELECT teachers.id FROM teacher_attendance.teachers)";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));
            Reset();
        }

        private void ShowRoom_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.ShowDialog();
            Fill_combo();
            dbOperations.query = "DELETE FROM teacher_attendance.attendance_management WHERE room_id NOT IN (SELECT rooms.id FROM teacher_attendance.rooms)";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));
            Reset();
        }

        private void ShowCourse_Click(object sender, EventArgs e)
        {
            Courses course = new Courses();
            course.ShowDialog();
            Fill_combo();
            dbOperations.query = "DELETE FROM teacher_attendance.attendance_management WHERE course_id NOT IN (SELECT courses.id FROM teacher_attendance.courses)";
            dbOperations.cmd = new MySqlCommand(dbOperations.query, dbOperations.con);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd);
            dgv1.DataSource = dbOperations.execute(dbOperations.cmd = new MySqlCommand(dbOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `teacher_attendance`.`attendance_management`,`teacher_attendance`.`teachers`,`teacher_attendance`.`rooms`,`teacher_attendance`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", dbOperations.con));
            Reset();
        }
    }
}
