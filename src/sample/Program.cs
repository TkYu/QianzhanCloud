using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qianzhan;

namespace sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var qz = new QianzhanCloud("你的appKey", "你的appSec", true);
            //debug here
            var search = qz.OrgCompany(4403,"深圳市腾讯计算机系统");
            var tencent = qz.GetDtlInfoByCompanyKey("477fb95a0a640a034c7b35dd2a3d83de");
            Console.WriteLine();
        }
    }
}
