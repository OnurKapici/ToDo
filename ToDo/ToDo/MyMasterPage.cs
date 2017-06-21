using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MasterPages;
using Xamarin.Forms;

namespace ToDo
{
    public class MyMasterPage:MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MyMaster();
            Detail = new MyDetails();
            

        }
    }
}
