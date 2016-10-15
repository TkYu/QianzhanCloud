namespace Qianzhan.Models
{
    /// <summary>
    ///     国家标准行业和产品分析
    /// </summary>
    public class ProductAnalysis
    {
        /// <summary>
        ///     行业代码
        /// </summary>
        public AnalysedTrade tradeList { get; set; }

        /// <summary>
        ///     产品代码
        /// </summary>
        public AnalysedProduct productList { get; set; }
    }

    /// <summary>
    ///     行业分析结果
    /// </summary>
    public class AnalysedTrade
    {
        /// <summary>
        ///     行业代码
        /// </summary>
        public string tradeCode { get; set; }

        /// <summary>
        ///     行业名称
        /// </summary>
        public string tradeName { get; set; }

        /// <summary>
        ///     权重
        /// </summary>
        public string tradeWeight { get; set; }
    }

    /// <summary>
    ///     产品分析结果
    /// </summary>
    public class AnalysedProduct
    {
        /// <summary>
        ///     产品代码
        /// </summary>
        public string productCode { get; set; }

        /// <summary>
        ///     产品名称
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        ///     权重
        /// </summary>
        public string productWeight { get; set; }
    }
}