using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 机构对象
    /// </summary>
    public class OrgCompanyList
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        public string companyCode { get; set; }
        /// <summary>
        /// 机构主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 登记证号
        /// </summary>
        public string regNumber { get; set; }
        /// <summary>
        /// 区域代码
        /// </summary>
        public string areaCode { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string areaName { get; set; }
        /// <summary>
        /// 登记机关
        /// </summary>
        public string regOrgName { get; set; }
        /// <summary>
        /// 信用代码
        /// </summary>
        public string creditCode { get; set; }
        /// <summary>
        /// 证书生效日期
        /// </summary>
        public string issueTime { get; set; }
        /// <summary>
        /// 证书失效日期
        /// </summary>
        public string invalidTime { get; set; }
        /// <summary>
        /// 机构类型
        /// </summary>
        public string companyType { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 详情链接
        /// </summary>
        public string urlLink { get; set; }
    }
}
