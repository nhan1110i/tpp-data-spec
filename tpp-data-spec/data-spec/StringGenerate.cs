using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_spec
{
    public class StringGenerate
    {
        public string GenerateLength(int length)
        {
            string result = "";
            for (int i = 1; i < length + 1; i++)
            {
                result += (i % 10).ToString();
            }
            return result;
        }
    }
}
