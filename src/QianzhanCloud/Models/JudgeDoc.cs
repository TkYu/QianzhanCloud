using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 法院文书
    /// </summary>
    public class JudgeDoc
    {
        /// <summary>
        /// 文书 Id
        /// </summary>
        public string judgeId { get; set; }
        /// <summary>
        /// 原告机构代码
        /// </summary>
        public string companyCodePlaintiff { get; set; }
        /// <summary>
        /// 被告机构代码
        /// </summary>
        public string companyCodeDefendant { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 审判机构
        /// </summary>
        public string ch { get; set; }
        /// <summary>
        /// 案号
        /// </summary>
        public string num { get; set; }
        /// <summary>
        /// 审判日期
        /// </summary>
        public string date { get; set; }
    }

}
