using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akozak_asql_a3
{
    public partial class mainForm : Form
    {
        OleDbConnection dest = null, source = null;
        string getAllTablesCommand = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            OleDbConnection dConn, sConn;
            lbSource.Items.Clear();
            lbDest.Items.Clear();

            try
            {
                sConn = new OleDbConnection(tbSourceConn.Text);
                OleDbCommand sCmd = new OleDbCommand();
                sCmd.Connection = sConn;
                sConn.Open();

                if (sConn.State == ConnectionState.Open)
                {
                    // get all tables\
                    sCmd.CommandText = getAllTablesCommand;
                    OleDbDataReader reader = sCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbSource.Items.Add(reader[0]);
                    }
                    reader.Close();

                    lblSourceName.Text = sConn.Database;

                    sConn.Close();
                    source = sConn;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Invalid Source Connection String");
            }

            try
            {
                dConn = new OleDbConnection(tbDestinationConn.Text);
                OleDbCommand dCmd = new OleDbCommand();
                dCmd.Connection = dConn;
                dConn.Open();

                if (dConn.State == ConnectionState.Open)
                {
                    // get all tables
                    dCmd.CommandText = getAllTablesCommand;
                    OleDbDataReader reader = dCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbDest.Items.Add(reader[0]);
                    }
                    reader.Close();

                    lblDestName.Text = dConn.Database;

                    dConn.Close();
                    dest = dConn;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid Destination Connection String");
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            if (source != null && dest != null)
            {
                source.Open();
                dest.Open();

                // copy all records

                source.Close();
                dest.Close();
            }
            else
            {
                MessageBox.Show(this, "Please specify source and destination connection strings before attempting to copy data.");
            }
        }

        private void btnCopySelected_Click(object sender, EventArgs e)
        {
            if (source != null && dest != null && lbSource.SelectedIndex >= 0)
            {
                string copyTable = lbSource.Items[lbSource.SelectedIndex].ToString();
                source.Open();
                dest.Open();

                if (MessageBox.Show(string.Format("Copy {0} to {1}?", copyTable, dest.Database), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Copying...");
                }

                // copy all records

                source.Close();
                dest.Close();
            }
        }
    }
}
