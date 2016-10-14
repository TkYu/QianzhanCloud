using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 企业说详情
    /// </summary>
    public class CompanyShowDetail
    {
        /// <summary>
        /// 文章 Id
        /// </summary>
        public string newsId { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string createTime { get; set; }
        /// <summary>
        /// 友好时间
        /// </summary>
        public string astTime { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public string right { get; set; }
        /// <summary>
        /// 点击量
        /// </summary>
        public string hits { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public string favors { get; set; }
        /// <summary>
        /// 内容详情
        /// </summary>
        public string content { get; set; }
    }

}
