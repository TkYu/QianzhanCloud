using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 软件著作权
    /// </summary>
    public class SoftwareCopyright
    {
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 登记号
        /// </summary>
        public string regId { get; set; }
        /// <summary>
        /// 分类号
        /// </summary>
        public string typeNum { get; set; }
        /// <summary>
        /// 软件全名
        /// </summary>
        public string softName { get; set; }
        /// <summary>
        /// 软件简称
        /// </summary>
        public string shortName { get; set; }
        /// <summary>
        /// 软件版本号
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// 著作权人
        /// </summary>
        public string softAuthor { get; set; }
        /// <summary>
        /// 国籍
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 著作权登记批准日期
        /// </summary>
        public string successDate { get; set; }
        /// <summary>
        /// 首次发表日期
        /// </summary>
        public string firstDate { get; set; }
        /// <summary>
        /// 单个公司名
        /// </summary>
        public string companyName { get; set; }
    }

}
