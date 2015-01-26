using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CortezFBLA
{
   public class Employer
    {
        //This class makes an object from employer data to represent an employer.
       public string emplrID, compName, email, compPhone, address, address2, theCity, theState, zip, companyRep;
        public Employer(string employerIdentifier, string companyName, string emailAddress, string companyPhone,
            string streetAddress, string streetAddress2, string city, string state, string zipCode, string compRep)
        {
            emplrID = employerIdentifier;
            compName = companyName;
            email = emailAddress;
            compPhone = companyPhone;
            address = streetAddress;
            address2 = streetAddress2;
            theCity = city;
            theState = state;
            zip = zipCode;
            companyRep = compRep;
        }
    }
}
