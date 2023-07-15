using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPOSSQLServerEFCore
{
    internal class center
    {

        public static bool isExecuted = false;

        public static string saleReceiptId;
        public static int saleReferenceNo;
        public static int empID;
        public static int cusID;

        // Helper method
        public static void focusTexBox(TextBox txt)
        {
            try
            {
                if(txt.CanFocus)
                {
                    txt.Focus();
                    txt.Select();
                    txt.SelectAll();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Focus Textbox : Dutcheang.", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }


    }
}
