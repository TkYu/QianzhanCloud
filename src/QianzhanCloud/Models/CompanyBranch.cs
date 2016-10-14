using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 分支机构
    /// </summary>
    public class CompanyBranch
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        public string companyCode { get; set; }
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 详情链接
        /// </summary>
        public string urlLink { get; set; }
    }

}
