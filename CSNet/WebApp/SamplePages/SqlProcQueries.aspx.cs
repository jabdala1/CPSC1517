using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;  //points to the controller class
using NorthwindSystem.Data; //points to the record descriptions
#endregion

namespace WebApp.SamplePages
{
    public partial class SqlProcQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Clear old messages
            MessageLabel.Text = "";

            if (!Page.IsPostBack)
            {
                //All calls should be done in user friendly error handling
                try
                {
                    //When the page is first loaded, obtain the complete list of categories from the database
                    CategoryController sysmgr = new CategoryController();
                    List<Category> datainfo = sysmgr.Category_List();
                    //Sorth this list alphabetically
                    datainfo.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                    //Assign the data to the dropdownlist control
                    CategoryList.DataSource = datainfo;
                    //Indicate the DataTextField and DataValueField
                    CategoryList.DataTextField = nameof(Category.CategoryName);
                    CategoryList.DataTextField = nameof(Category.CategoryID);
                    //Bind the datasoruce
                    CategoryList.DataBind();
                    //add a prompt
                    CategoryList.Items.Insert(0, "Select...");
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //Ensure a selection was made
            if (CategoryList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Make a selection...";
            }
            else
            {
                //within user friendly error handling
                try
                {
                    //Connect to the appropraite conroller
                    ProductController sysmgr = new ProductController();
                    //issue a request to the controller's appropriate method
                    List<Product> datainfo = sysmgr.Product_GetByCategory(int.Parse(CategoryList.SelectedValue));
                    //check results
                    if (datainfo.Count() == 0)
                    {
                        // none (.Count() == 0): message to user
                        MessageLabel.Text = "No data found for selected category...";
                        //Optionally clear out display
                        CategoryProductList.DataSource = null;
                        CategoryProductList.DataBind();
                    }
                    else
                    {
                        // found: load a gridview
                        //Optional sort on ProductName
                        datainfo.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                        CategoryProductList.DataSource = datainfo;
                        CategoryProductList.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
                
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            CategoryList.ClearSelection();
            CategoryProductList.DataSource = null;
            CategoryProductList.DataBind();
        }
    }
}