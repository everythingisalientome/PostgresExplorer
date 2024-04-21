using DatabaseAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomPostgresExplorer.Properties;

namespace CustomPostgresExplorer
{
    public partial class PostgresExplorer : Form
    {
        private DatabaseConnection dc = null;
        private bool currentlyDisplayingPassword = false;
        private readonly string DEFAULT_SELECTION = "--";
        public PostgresExplorer()
        {
            InitializeComponent();
            PrepareApplication();
        }

        /**** Hard Codings ***/
        #region Hard Codings

        private void PrepareApplication()
        {
            txtHostName.Text = "localhost";
            txtHostName.Enabled = false;
            txtPassword.Text = "";
        }

        #endregion
        /**** Hard Codings ***/

        public void Alert(string message, AlertForm.emType type)
        {
            AlertForm frm = new AlertForm();
            frm.ShowAlert(message, type);
        }

        private void lblStatusStrip_Click(object sender, EventArgs e)
        {
            var statusStripvalue = lblStatusStrip.Text.ToString();
            Clipboard.SetText(statusStripvalue);
            Alert("Copied to Clipboard", AlertForm.emType.Info);
        }

        #region Show-Hide Password Control
        private void picBxPassControl_Click(object sender, EventArgs e)
        {
            //If displaying password currently, hide it on click
            if (currentlyDisplayingPassword)
            {
                //password is being displayed, hide the password
                txtPassword.PasswordChar = '*';

                //change icon to show password
                picBxPassControl.Image = Resources.eye_show;
                currentlyDisplayingPassword = false;
            }
            else
            {
                //password is not displayed, show the password
                txtPassword.PasswordChar = '\0';
                //change icon to hide  password
                picBxPassControl.Image = Resources.eye_hide;
                currentlyDisplayingPassword = true;
            }
        }
        #endregion

        #region Connect to Posgtres and Get DB List
        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {
            var host = txtHostName.Text;
            var user = txtUserName.Text;
            var password = txtPassword.Text;

            if(!string.IsNullOrEmpty(host)&& !string.IsNullOrWhiteSpace(host) &&
                !string.IsNullOrEmpty(user) && !string.IsNullOrWhiteSpace(user) &&
                    !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                if(host == "localhost")
                {
                    try
                    {
                        dc = new DatabaseConnection(user, password);
                        List<string> dbList = new List<string>();
                        dbList = dc.ConnectToPostgres();
                        if(dbList.Count > 0)
                        {
                            cmbDatabase.Items.Clear();
                            cmbDatabase.Items.Add(DEFAULT_SELECTION);
                            foreach(string itms in dbList)
                            {
                                cmbDatabase.Items.Add(itms);
                            }
                            cmbDatabase.SelectedIndex = 0;
                            Alert("Database Connection Successful", AlertForm.emType.Success);
                        }
                        else
                        {
                            Alert("No Database Found", AlertForm.emType.Warning);
                        }
                    }
                    catch(Exception ex) 
                    {
                        Alert("Connection Failed", AlertForm.emType.Error);
                        MessageBox.Show("Connection Failed: "+ex.Message);
                    }
                }
                else
                {
                    Alert("Host must be set to localhost", AlertForm.emType.Error);
                }
            }
            else
            {
                Alert("Fill Mandatory Fields", AlertForm.emType.Error);
            }

            
        }
        #endregion

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            var host = txtHostName.Text;
            var user = txtUserName.Text;
            var password = txtPassword.Text;
            var database = cmbDatabase.Text;
            var query = txtQueryEditor.Text;
            
            if (dgViewResults.DataSource != null)
            {
                dgViewResults.DataSource = null;
            }
            else
            {
                dgViewResults.Rows.Clear();
            }

            if (!string.IsNullOrEmpty(host) && !string.IsNullOrWhiteSpace(host) &&
                !string.IsNullOrEmpty(user) && !string.IsNullOrWhiteSpace(user) &&
                    !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                if (!string.IsNullOrEmpty(database) 
                    && !string.IsNullOrWhiteSpace(database) 
                        && database != DEFAULT_SELECTION) 
                {

                    if (!string.IsNullOrEmpty(query)
                        && !string.IsNullOrWhiteSpace(query)) 
                    {
                        if (!query.ToLower().Contains("LIMIT".ToLower()))
                        {
                            Alert($"Please limit the number of rows", AlertForm.emType.Warning);                            
                        }
                        else
                        {
                            try
                            {
                                dc = new DatabaseConnection(user, password);
                                DataTable dt = new DataTable();
                                dt = dc.ExecuteQuery(database, query);
                                if (dt != null)
                                {
                                    if (dt.Rows.Count > 0)
                                    {
                                        dgViewResults.DataSource = dt;
                                        Alert("Execution Successful", AlertForm.emType.Success);
                                    }
                                    else
                                    {
                                        Alert("no results found", AlertForm.emType.Error);
                                    }
                                }
                                else
                                {
                                    Alert("Please validate query again", AlertForm.emType.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                Alert($"Failed to Connect {database}", AlertForm.emType.Error);
                                MessageBox.Show($"Failed to Connect {database}: " + ex.Message);
                            }
                        }                        
                    }
                    else
                    {
                        Alert("Please provide a query to execute", AlertForm.emType.Error);
                    }                    
                }
                else
                {
                    Alert("Database Needs to be selected", AlertForm.emType.Error);
                }
            }
            else
            {
                Alert("Fill Mandatory Fields", AlertForm.emType.Error);
            }
        }

        private void PostgresExplorer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnExecuteQuery_Click(null, null);
            }
        }
    }
}
