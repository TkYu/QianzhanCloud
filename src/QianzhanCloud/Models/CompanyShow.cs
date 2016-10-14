using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 企业说
    /// </summary>
    public class CompanyShow
    {
        /// <summary>
        /// 文章 Id
        /// </summary>
        public string newsId { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string picUrl { get; set; }
        /// <summary>
        /// 文章详情链接
        /// </summary>
        public string contentLink { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 核心内容
        /// </summary>
        public string summary { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public string right { get; set; }
        /// <summary>
        /// 友好时间
        /// </summary>
        public string lastTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string createTime { get; set; }
    }

}
