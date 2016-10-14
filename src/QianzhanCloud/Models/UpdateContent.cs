using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 企业变更事项
    /// </summary>
    public class CompanyUpdate
    {
        /// <summary>
        /// 变更日期
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 变更内容
        /// </summary>
        public CompanyUpdateContent[] content { get; set; }
    }

    /// <summary>
    /// 变更内容
    /// </summary>
    public class CompanyUpdateContent
    {
        /// <summary>
        /// 变更事项
        /// </summary>
        public string bgsx { get; set; }
        /// <summary>
        /// 变更前
        /// </summary>
        public string bgq { get; set; }
        /// <summary>
        /// 变更后
        /// </summary>
        public string bgh { get; set; }
    }
}
