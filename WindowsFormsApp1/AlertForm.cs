using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomPostgresExplorer.Properties;

namespace CustomPostgresExplorer
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        private int x, y;
        public enum emAction
        {
            wait,
            start,
            close
        }

        public enum emType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private AlertForm.emAction action;

        private void btnClose_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 1;
            action = emAction.close;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            switch(action)
            {
                case emAction.wait:
                    myTimer.Interval = 5000;
                    action = emAction.close;
                    break;
                case emAction.start:
                    myTimer.Interval = 1;
                    this.Opacity += 0.1;
                    if(x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = emAction.wait;
                        }
                    }
                    break;
                case emAction.close:
                    myTimer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void ShowAlert(string message, emType type)
        {
            Opacity = 0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertForm frm = (AlertForm)Application.OpenForms[fname];
                
                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - 40 - Height * i;
                    Location = new Point(x, y);
                    break;
                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


            switch (type)
            {
                case emType.Success:
                    picMsgIcon.Image = Resources.icons8_success_50;
                    BackColor = Color.SeaGreen;
                    break;
                case emType.Error:
                    picMsgIcon.Image = Resources.icons8_error_50;
                    BackColor = Color.DarkRed;
                    break;
                case emType.Info:
                    picMsgIcon.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case emType.Warning:
                    picMsgIcon.Image = Resources.icons8_medium_risk_50;
                    BackColor = Color.DarkOrange;
                    break;
            }

            lblMessage.Text = message;
            Show();
            action = emAction.start;
            myTimer.Interval = 1;
            myTimer.Start();
        }
    }
}
