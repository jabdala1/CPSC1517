using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class ContestEntry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddressOne { get; set; }
        public string StreetAddressTwo
        {
            get
            {
                return StreetAddressTwo;
            }
            set
            {

            }
        }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }

        //Default constructor
        public ContestEntry()
        {

        }
        //greedy constructor
        public ContestEntry(string firstname, string lastname, string streetaddressone, string streetaddresstwo, string city, string province, string postalcode, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            StreetAddressOne = streetaddressone;
            StreetAddressTwo = streetaddresstwo;
            City = city;
            Province = province;
            PostalCode = postalcode;
            Email = email;
        }
    }
}