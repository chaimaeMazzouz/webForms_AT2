using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AT2_web
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                calDate.Visible = false;
                team1.Visible = false;
                team2.Visible = false;
            }
           
        }

        protected void listMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            calDate.Visible = true;
            team1.Visible = true;
            team2.Visible = true;
            switch (listMatch.SelectedIndex)
            {
                case 0:
                    calDate.Visible = false;
                    team1.Visible = false;
                    team2.Visible = false;
                    lblMatchs.Text = "";
                    break;
                case 1:
                    calDate.SelectedDate = new DateTime(2021, 03, 16);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    team1.ImageUrl = "~/Images/kacm.png";
                    team2.ImageUrl = "~/Images/utc.png";
                    break;
                case 2:
                    calDate.SelectedDate = new DateTime(2021, 03, 20);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    team1.ImageUrl = "~/Images/tas.png";
                    team2.ImageUrl = "~/Images/Kac.png";
                    break;
                case 3:
                    calDate.SelectedDate = new DateTime(2021, 02, 17);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    team1.ImageUrl = "~/Images/Waf.png";
                    team2.ImageUrl = "~/Images/cak.png";
                    break;
                default:
                    calDate.Visible = false;
                    lblMatchs.Text = "";
                    break;
            }
        }
    }  }