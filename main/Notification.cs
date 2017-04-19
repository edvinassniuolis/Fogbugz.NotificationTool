using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutePY
{
    public partial class Notification : Form
    {
        private string caseText;
        private string priorityText;
        private string titleText;

        private Color color;

        public Notification(string caseText, string priorityText, string titleText, Color color)
        {
            InitializeComponent();

            this.caseText = caseText;
            this.titleText = titleText;
            this.priorityText = priorityText;
            this.color = color;

            SetAttr();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                          workingArea.Bottom - Size.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAttr()
        {
            caseLabel.Text = caseText;
            priorityLabel.Text = priorityText;
            titleLabel.Text = titleText;
            colorPanel.BackColor = color;

        }
    }
}
