using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Brgy.App
{
    public partial class PublicDashboard : MaterialSkin.Controls.MaterialForm
    {
        // 1. Create a variable to hold the status
        bool _isOfficial = false;

        // 2. Update this part to accept the 'userIsOfficial' value
        public PublicDashboard(bool userIsOfficial)
        {
            InitializeComponent();
            _isOfficial = userIsOfficial; // Store the answer
        }

        // 3. This is the Load Event
        private void PublicDashboard_Load(object sender, EventArgs e)
        {
            if (_isOfficial)
            {
                // If they are an official, show the edit buttons
              
            }
            else
            {
                // If they are just public, hide them
               
            }
        }
    }
}