using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Patient
    {
        partial void Name_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }

        partial void PatientID_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.Id+"/2016";
        }
    }
}