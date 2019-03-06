using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //Create a static List<T> that will hang around between posting of the web page.
        //This could also have been done using a ViewState variable
        //Using a ViewState variable would required the user to retrived the data on each posting
        public static List<DDLClass> DataCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Page_Load executes EACH and EVERY time their is a posting to this page
            //Page_Load is executed BEFORE any submit events

            //This method is an exellent place to do form initialization
            //You can test your postings using Page.IsPostBack
            //IsPostBack is the same item as IsPost in our razor forms
            if (!Page.IsPostBack)
            {
                //This code will be executed only on the first pass to this page
                //Create an instance for the static data collection
                DataCollection = new List<DDLClass>();

                //Add instance to this collection using the DDLClass greedy constructor
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT2018"));
                DataCollection.Add(new DDLClass(4, "DMIT1508"));

                //Sorting a List<T>
                //Use the .Sort() Method
                //(x,y) this represents any two items in your list
                //Compare x.Field to y.Field; ascending
                //Compare y.Field to x.Field; descending
                DataCollection.Sort((x, y) => x.DisplayField.CompareTo(y.DisplayField));

                //Put the data collection into the dropdownlist
                //a) assign the collection to the controls DataSource
                CollectionList.DataSource = DataCollection;

                //b) assign the field names to the properties of the dropdownlist for data association
                //DataValueField represents the value of the line item
                //DataTextField represents the display of the line item
                CollectionList.DataValueField = "ValueField";
                CollectionList.DataTextField = nameof(DDLClass.DisplayField);

                //c) bind the data to the web control
                //NOTE: this statement is not required in a Windows Form Application
                CollectionList.DataBind();

                //Can one put a prompt on their dropdownlist control 
                //YES
                CollectionList.Items.Insert(0, "Select ...");
            }
        }

        protected void SubmitButtonChoice_Click(object sender, EventArgs e)
        {
            //To grab the contents of a control will depend on the access technique of the control
            //For a TextBox, Label, Literal use .Text
            //For Lists(RadioButtonList, DropDownList) you may use:
            //  a) .SelectedValue -> associated data value field
            //  b) .SelectedInder -> the physical index position in the list
            //  c) .SelectedItem -> associated display field
            //For a checkbox use .Checked (true or false)

            //For the most part, all data from a control returns as a string except for boolean type controls

            string submitchoice = TextBoxNumberChoice.Text;
            int anum = 0;
            if (string.IsNullOrEmpty(submitchoice))
            {
                MessageLabel.Text = "Enter a number from 1 to 4.";
            }
            else if(!int.TryParse(submitchoice, out anum))
            {
                MessageLabel.Text = "Entered value must be a number.";
            }
            else if(anum > 4 || anum < 1)
            {
                MessageLabel.Text = "Enter a number from 1 to 4.";
            }
            else
            {
                //When positioning in a list it is BEST to position using the SelectedValue unless you wish to postion in a specific physical location
                //  such as your prompt line, then use SelectedIndex
                
                //SelectedValue expects a string value
                //SelectedIndex expects a numeric value
                RadioButtonListChoice.SelectedValue = submitchoice;

                //Boolean controls are set using true or false
                if (submitchoice.Equals("2") || submitchoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                CollectionList.SelectedValue = submitchoice;

                //Display label will show the varios values obtained from a list using SelectedVlaue, SelectedIndex and SelectItem
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text + " at index " + CollectionList.SelectedIndex + " has a value of " + CollectionList.SelectedValue;
            }
        }
    }
}