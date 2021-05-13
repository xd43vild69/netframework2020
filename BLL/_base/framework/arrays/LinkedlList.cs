using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Arrays
{    
    public class LinkedlList
    {
        private readonly string[] words = {"aaa", "bbb", "ccc", "ddd", "eee"};
        private readonly LinkedlList<string> ll;

        public LinkedlList()
        {
            ll = new LinkedlList<string>(words);
            ll.removeFirst();        
        }


    }
}
