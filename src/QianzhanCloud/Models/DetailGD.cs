namespace Qianzhan.Models
{
    /// <summary>
    ///     股东信息查询结果
    /// </summary>
    public class DetailGD
    {
        /// <summary>
        ///     所属公司机构代码
        /// </summary>
        public string companyCode { get; set; }

        /// <summary>
        ///     公司主键
        /// </summary>
        public string companyKey { get; set; }

        /// <summary>
        ///     股东
        /// </summary>
        public string gdName { get; set; }

        /// <summary>
        ///     出资金额
        /// </summary>
        public string money { get; set; }

        /// <summary>
        ///     股东属性
        /// </summary>
        public string property { get; set; }

        /// <summary>
        ///     出资比例(%)
        /// </summary>
        public string proportion { get; set; }

        /// <summary>
        ///     出资金额单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        ///     详情链接
        /// </summary>
        public string urlLink { get; set; }
    }
}