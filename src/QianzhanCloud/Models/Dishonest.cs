namespace Qianzhan.Models
{
    /// <summary>
    ///     失信
    /// </summary>
    public class Dishonest
    {
        /// <summary>
        ///     失信 Id
        /// </summary>
        public string dishonestId { get; set; }

        /// <summary>
        ///     被执行人
        /// </summary>
        public string dishonestName { get; set; }

        /// <summary>
        ///     案号
        /// </summary>
        public string caseCode { get; set; }

        /// <summary>
        ///     身份证号码/组织机构代码
        /// </summary>
        public string cardNum { get; set; }

        /// <summary>
        ///     负责人姓名
        /// </summary>
        public string businessEntity { get; set; }

        /// <summary>
        ///     执行法院
        /// </summary>
        public string courtName { get; set; }

        /// <summary>
        ///     省份
        /// </summary>
        public string areaName { get; set; }

        /// <summary>
        ///     执行依据文号
        /// </summary>
        public string gistId { get; set; }

        /// <summary>
        ///     执行单位
        /// </summary>
        public string gistUnit { get; set; }

        /// <summary>
        ///     法律职责
        /// </summary>
        public string legalDuty { get; set; }

        /// <summary>
        ///     立案时间
        /// </summary>
        public string regDate { get; set; }

        /// <summary>
        ///     被执行人的履行情况
        /// </summary>
        public string performance { get; set; }

        /// <summary>
        ///     被执行人行为具体情形
        /// </summary>
        public string disruptTypeName { get; set; }

        /// <summary>
        ///     发布时间
        /// </summary>
        public string publishDate { get; set; }
    }
}