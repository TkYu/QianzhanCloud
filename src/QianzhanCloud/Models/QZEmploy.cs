using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 企业招聘岗位
    /// </summary>
    public class QZEmploy
    {
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string jobTitle { get; set; }
        /// <summary>
        /// 职能类别
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 职能关键字
        /// </summary>
        public string keys { get; set; }
        /// <summary>
        /// 薪资范围
        /// </summary>
        public string salaryRange { get; set; }
        /// <summary>
        /// 工作性质
        /// </summary>
        public string workingProperty { get; set; }
        /// <summary>
        /// 福利
        /// </summary>
        public string welfare { get; set; }
        /// <summary>
        /// 年限要求
        /// </summary>
        public string yearsReq { get; set; }
        /// <summary>
        /// 学历要求
        /// </summary>
        public string eduReq { get; set; }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public string count { get; set; }
        /// <summary>
        /// 岗位职责
        /// </summary>
        public string duty { get; set; }
        /// <summary>
        /// 职位描述
        /// </summary>
        public string des { get; set; }
        /// <summary>
        /// 工作城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 工作地区
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 工作详细地址
        /// </summary>
        public string addr { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 搜索地区
        /// </summary>
        public string searchCity { get; set; }
        /// <summary>
        /// 搜索类目
        /// </summary>
        public string searchClass { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public string publicDate { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public string updateTime { get; set; }
    }

}
