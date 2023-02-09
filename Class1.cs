using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
     class Class1
    {
        string build;
         string body;
        string color;
        int years;



        public Class1(string build, string body,string color,int years)
        {
            this.build = build;
            this.body = body;
            this.color = color;
            this.years = years;
        }
        public string Build
        {
            get
            {
                return  build;
            }
            set
            {
                build = value;
            }

        }
        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }

    }
}
