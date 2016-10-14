using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 商标详情
    /// </summary>
    public class OrgCompanyBrand
    {
        /// <summary>
        /// 注册号
        /// </summary>
        public string regNo { get; set; }
        /// <summary>
        /// 类别号
        /// </summary>
        public string typeNo { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string applicationDate { get; set; }
        /// <summary>
        /// 申请名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 申请人中文名
        /// </summary>
        public string proposer { get; set; }
        /// <summary>
        /// 申请人中文地址
        /// </summary>
        public string proposerAddr { get; set; }
        /// <summary>
        /// 商标图片路径
        /// </summary>
        public string imgUrl { get; set; }
        /// <summary>
        /// 商标代理人名称
        /// </summary>
        public string brandAgent { get; set; }
        /// <summary>
        /// 商标类型
        /// </summary>
        public string branType { get; set; }
        /// <summary>
        /// 商品/服务列表
        /// </summary>
        public string serviceList { get; set; }
        /// <summary>
        /// 商标流程
        /// </summary>
        public string brandProcess { get; set; }
        /// <summary>
        /// 来源地址
        /// </summary>
        public string sourceUrl { get; set; }
    }

}
