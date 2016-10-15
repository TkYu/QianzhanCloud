namespace Qianzhan.Models
{
    /// <summary>
    ///     根据公司主键获取主体信息结果
    /// </summary>
    public class OrgCompanyDetail
    {
        /// <summary>
        ///     机构代码
        /// </summary>
        public string companyCode { get; set; }

        /// <summary>
        ///     公司主键
        /// </summary>
        public string companyKey { get; set; }

        /// <summary>
        ///     公司名称
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        ///     登记证号
        /// </summary>
        public string regNumber { get; set; }

        /// <summary>
        ///     公司地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     企业法人
        /// </summary>
        public string faRen { get; set; }

        /// <summary>
        ///     经营范围
        /// </summary>
        public string bussinessDes { get; set; }

        /// <summary>
        ///     注册资本
        /// </summary>
        public string regMoney { get; set; }

        /// <summary>
        ///     实出资本
        /// </summary>
        public string factMoney { get; set; }

        /// <summary>
        ///     主体类型
        /// </summary>
        public string regType { get; set; }

        /// <summary>
        ///     注册日期
        /// </summary>
        public string regDate { get; set; }

        /// <summary>
        ///     经营期限
        /// </summary>
        public string bussiness { get; set; }

        /// <summary>
        ///     核准日期
        /// </summary>
        public string chkDate { get; set; }

        /// <summary>
        ///     年检日期
        /// </summary>
        public string yearChk { get; set; }

        /// <summary>
        ///     最近更新
        /// </summary>
        public string recentUpdate { get; set; }

        /// <summary>
        ///     经营状态
        /// </summary>
        public string businessStatus { get; set; }

        /// <summary>
        ///     详情链接
        /// </summary>
        public string urlLink { get; set; }
    }
}