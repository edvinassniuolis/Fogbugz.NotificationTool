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
    public partial class MainSettingView : Form
    {
        private MainView mainBox;

        private string querry;

        public MainSettingView(MainView mainBox)
        {
            this.mainBox = mainBox;
            InitializeComponent();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SetDropDown();

            Querry querryColumn = new Querry(querry);
            mainBox.Querry = querryColumn;

            this.Hide();
        }

        private void exitImg_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string GetQuerry()
        {
            return querry;
        }

        private void SetDropDown()
        {
                switch(dropdown.selectedValue)
                {
                    case "AssignedTo":
                        {
                            querry = "AssignedTo";
                            break;
                        }
                    case "OpenedBy":
                        {
                            querry = "OpenedBy";
                            break;
                        }
                    case "AlsoEditedBy":
                        {
                            querry = "AlsoEditedBy";
                            break;
                        }
                    case "ClosedBy":
                        {
                            querry = "ClosedBy";
                            break;
                        }
                    case "CreatedBy":
                        {
                            querry = "CreatedBy";
                            break;
                        }
                    case "EditedBy":
                        {
                            querry = "EditedBy";
                            break;
                        }
                    case "LastEditedBy":
                        {
                            querry = "LastEditedBy";
                            break;
                        }
                default:
                    {
                        querry = "OpenedBy";
                        break;
                    }
                }
        }
    }
}
