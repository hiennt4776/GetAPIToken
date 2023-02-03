using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Token
    {
        public string access_token { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }

        public int expires_in { get; set; }

        public override string ToString()
        {
            return $"[{access_token}, {scope}, {token_type}, {expires_in}]";
        }

    }
}
