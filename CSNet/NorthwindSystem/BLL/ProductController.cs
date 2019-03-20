using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data; //Obtains the <T> definitions
using NorthwindSystem.DAL; //Obtains the context class
using System.Data.SqlClient;   //Required for Sql Proc Calls
#endregion

namespace NorthwindSystem.BLL
{
    //This class needs to be called from another class(es)
    //This class is part of the system interface to the web application (and/or any other client that needs to get to the Northwind Database)
    //This class is the entery point into the Northwind System
    //This class needs to be public 
    public class ProductController
    {
        //This method will receive a value that represents the ProductID
        //This method will forward the value to the DbSet<T> in the DbContext class for processing
        //This method will return an instance of Product
        //This method must be public
        public Product Product_Get(int productid)
        {
            //The instantiation of the DbContext will be done in a transaction using group
            using (var context = new NorthwindContext())
            {
                //Return the results of the method call
                //Context points to the DAL context class
                //Products is the DbSet<T>
                //.Find(pkey value) looks for a set record 
                //  whose primary key is equal to the supplied value
                return context.Products.Find(productid);
            }
        }
        //This method will return all records of a DbSet<T>
        //No parameter value is necessary
        public List<Product> Product_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        //This method will query the DbSet <T> using a sql procedure
        //The query will be against a non primary key field
        //The result return will still be the complete entity <T> record
        //We need to add a using clause to System.Data.Entity to our class
        //Input: category id
        //Output: List<Product> matching the category id
        public List<Product> Product_GetByCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                //Generally datasets from DbSet calls return as a datatype of IEnumerable<T>
                //This IEnumerable<T> dataset will be turned into a list by using .ToList()
                IEnumerable<Product> results = context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID", new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }
    }
}
