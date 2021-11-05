using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
    public partial class Recu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int total;
            int a = 4;
            if (a % 2 != 0)
            {
                total = odd(a);
                Response.Write(total);
            }
            else
            {
                total = even(a);
                Response.Write(total);
            }
        }

        int odd(int b)
        {
            if (b == 1)
                return 11;
            else if (b == 2)
                return 11 + 4;
            else
                return odd(b - 2) + odd(b - 1);
        }
        int even(int c)
        {
            if (c == 1)
                return 11;
            else if (c == 2)
                return 18;
            else
                return even(c - 2) + even(c - 1);
        }
    }
}