using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teamRandomizer
{
    public partial class MessageForm : Form
    {
        private int warning = 0;
        private int error = 1;

        private bool choice;

        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(int messageType, string message, string title, bool showCancel)
        {
            InitializeComponent();

            if (messageType == 0)
            {
                imgDisplay.Image = global::teamRandomizer.Properties.Resources.warning;
            }
            else if (messageType == 1)
            {
                imgDisplay.Image = global::teamRandomizer.Properties.Resources.error;
            }

            txtErrorMessage.Text = message;
            Text = title;

            btnCancel.Visible = showCancel;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            choice = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            choice = false;
            Close();
        }

        public bool isOkay()
        {
            return choice;
        }

        private void txtErrorMessage_Enter(object sender, EventArgs e)
        {
            btnOk.Focus();
        }
    }
}
