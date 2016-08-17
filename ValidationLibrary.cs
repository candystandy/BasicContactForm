using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoForm
{
    class ValidationLibrary
    {
        /*
         * Validation Library (incl. functions for validating entries and valid email addresses) 
         */

        public static bool isCorrectLength(string temp, int tempLength)
        {
            bool result = false;

            if (temp.Length == tempLength)
            {
                result = true;
            }

            return result;
        }

        // Check to see if the specific field is required
        public static bool isRequired(string temp, bool tempCheck)
        {
            bool result = false;

            if (tempCheck == true && temp == "")
            {
                result = false;
            }

            return result;
        }

        public static bool IsFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0) 
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidEmail(string temp)
        {
            bool result = true;
            
            // finding positon of '@' symbol
            int atLocation = temp.IndexOf("@");
            int atNextLocation = temp.IndexOf("@", atLocation + 1);

            // finding position of '.' period
            int periodLocation = temp.LastIndexOf(".");

            // perform the check
            if (temp.Length < 8)
            {
                result = false;
            } 
            else if (atLocation < 2) 
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;
        }
    }
}