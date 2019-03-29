using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.PracticeForms
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Instructions.Text = "Please fill in the form below and submit. After submitting the form," +
                " you will recieve an email with a link to confim your registration" +
                " by clicking on that link, you will complete the registration process.";
            MessageLabel.Text = "";
        }

        protected void SubmitForm_Click(object sender, EventArgs e)
        {
            //Check if the data is valid
            if (Page.IsValid)
            {
                //First Name, Last Name Required
                if (string.IsNullOrEmpty(FirstName.Text))
                {

                }
            }
            else
            {
                
            }
        }
    }
}