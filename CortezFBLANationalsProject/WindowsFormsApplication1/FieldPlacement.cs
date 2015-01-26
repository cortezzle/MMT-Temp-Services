using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CortezFBLA
{
   public class FieldPlacement
    {
        //This class makes an object from field placement data to represent a field placement.
        public string employerName, employeeName;
        public FieldPlacement(string emplrName, string empName)
        {
            employerName = emplrName;
            employeeName = empName;
        }
       
    }
}
