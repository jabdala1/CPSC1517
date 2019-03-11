using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        public static List<ContestEntry> EntryCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EntryCollection = new List<ContestEntry>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //This test will fire the validation controls on the server side

                //if additional validation is required, do that first
                if (Terms.Checked)
                {
                    //User has agreed to the contest terms
                    //Collect the data
                    //Create/load a contest entry to the collection
                    //display the collection
                }
                else
                {
                    Message.Text = "You did not agree to the contest terms, Your entry has been denied!";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.ClearSelection();
            PostalCode.Text = "";
            EmailAddress.Text = "";

            Terms.Checked = false;
            CheckAnswer.Text = "";
        }
    }
}