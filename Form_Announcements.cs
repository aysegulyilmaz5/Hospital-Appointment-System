﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectHospital
{
    public partial class Form_Announcements : Form
    {
        public Form_Announcements()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Announcements",connection.connected());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
