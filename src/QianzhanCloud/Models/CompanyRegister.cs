using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 域名备案查询结果
    /// </summary>
    public class CompanyRegister
    {
        /// <summary>
        /// 备案通过时间
        /// </summary>
        public string checkTime { get; set; }
        /// <summary>
        /// 备案域名
        /// </summary>
        public string domain { get; set; }
        /// <summary>
        /// 备案单位/个人
        /// </summary>
        public string host { get; set; }
        /// <summary>
        /// 主体类型
        /// </summary>
        public string hostType { get; set; }
        /// <summary>
        /// 备案号
        /// </summary>
        public string recordNumber { get; set; }
        /// <summary>
        /// 网站首页地址
        /// </summary>
        public string siteHomePage { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
        public string siteName { get; set; }
        /// <summary>
        /// 经营状态
        /// </summary>
        public string operatingStatus { get; set; }
        /// <summary>
        /// 详情链接
        /// </summary>
        public string urlLink { get; set; }
    }

}
