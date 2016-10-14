using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 分析所有行业
    /// </summary>
    public class AllTradeAnalysis
    {
        /// <summary>
        /// 行业代码
        /// </summary>
        public AnalysedTrade tradeList { get; set; }
        /// <summary>
        /// 产品代码
        /// </summary>
        public AnalysedProduct productList { get; set; }
        /// <summary>
        /// 展会代码
        /// </summary>
        public ExhibitionAnalysis exhibitonTagList { get; set; }
        /// <summary>
        /// 前瞻代码
        /// </summary>
        public ExhibitionAnalysisForward forwardTradeList { get; set; }
    }


    /// <summary>
    /// 展会行业分析
    /// </summary>
    public class ExhibitionAnalysis
    {
        /// <summary>
        /// 行业名称
        /// </summary>
        public string exhibitionTradeName { get; set; }
        /// <summary>
        /// 权重
        /// </summary>
        public string exhibitionTradeWeight { get; set; }
    }

    /// <summary>
    /// 前瞻行业分析
    /// </summary>
    public class ExhibitionAnalysisForward
    {
        /// <summary>
        /// 行业名称
        /// </summary>
        public string forwardTradeName { get; set; }
        /// <summary>
        /// 权重
        /// </summary>
        public string forwardTradeWeight { get; set; }
    }


}
