using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using WinAppDirect.Library;
using System.Net;




namespace WinAppDirect
{
    public partial class WinAppDirect : Form
    {

        SqlConnection connection;
        string ConnectionString;

        public WinAppDirect()
        {
            InitializeComponent();

            ConnectionString = ConfigurationManager.ConnectionStrings["WinAppDirect.Properties.Settings.WinAppDirectConnectionString"].ConnectionString;

        }

        private void WinAppDirect_Load(object sender, EventArgs e)
        {
            PopulateRate();



            //отображение иконки в трее Windows
            //notifyIcon1.Icon = SystemIcons.Shield;
            notifyIcon1.Text = "Программа WinAppDirect";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;



            WorkDB myvar = new WorkDB();
            MyVAR.Text = myvar.IndexTime.ToString();
        }



        private void PopulateRate()
        {
            using (connection = new SqlConnection(ConnectionString))
                using (SqlDataAdapter adapter=new SqlDataAdapter("SELECT * FROM NameT", connection))
            {
                DataTable MainTtable = new DataTable();
                adapter.Fill(MainTtable);

                ListMainT.DisplayMember = "Name";
                ListMainT.ValueMember = "Id";

                ListMainT.DataSource = MainTtable;
            }

        }

        private void ListMainT_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTable.Text=ListMainT.SelectedValue.ToString();

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
