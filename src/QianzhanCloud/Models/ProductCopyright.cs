using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 作品著作权
    /// </summary>
    public class ProductCopyright
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
        /// 登记日期
        /// </summary>
        public string regDate { get; set; }
        /// <summary>
        /// 作品名称
        /// </summary>
        public string productName { get; set; }
        /// <summary>
        /// 作品类别
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 著作权人
        /// </summary>
        public string productAuthor { get; set; }
        /// <summary>
        /// 创作完成日期
        /// </summary>
        public string completionDate { get; set; }
        /// <summary>
        /// 首次发表日期
        /// </summary>
        public string firstPublicationDate { get; set; }
        /// <summary>
        /// 单个著作人名
        /// </summary>
        public string companyName { get; set; }
    }

}
