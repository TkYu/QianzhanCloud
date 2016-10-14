using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 招聘企业详情
    /// </summary>
    public class QZEmployDetail
    {
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 公司性质
        /// </summary>
        public string companyNature { get; set; }
        /// <summary>
        /// 公司规模
        /// </summary>
        public string companySize { get; set; }
        /// <summary>
        /// 公司行业
        /// </summary>
        public string companyIndustry { get; set; }
        /// <summary>
        /// 工作详细地址
        /// </summary>
        public string addr { get; set; }
        /// <summary>
        /// 公司简介
        /// </summary>
        public string about { get; set; }
        /// <summary>
        /// 公司联系人
        /// </summary>
        public string cotacts { get; set; }
        /// <summary>
        /// 公司电话
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// 公司邮件
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 公司网站
        /// </summary>
        public string webSite { get; set; }
    }

}
