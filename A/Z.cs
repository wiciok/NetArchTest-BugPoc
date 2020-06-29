using B;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class Z : Y
    {
        public Task<List<X>> Test()
        {
            //var d = new X(); //uncomment to pass the test
            throw new NotImplementedException();
        }
    }
}
