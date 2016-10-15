namespace Qianzhan.Models
{
    /// <summary>
    ///     企业证书
    /// </summary>
    public class CertificationInfo
    {
        /// <summary>
        ///     公司主键
        /// </summary>
        public string companyKey { get; set; }

        /// <summary>
        ///     证书编号
        /// </summary>
        public string certNo { get; set; }

        /// <summary>
        ///     证书状态
        /// </summary>
        public string certStatus { get; set; }

        /// <summary>
        ///     发证机构名称
        /// </summary>
        public string issuedCompanyName { get; set; }

        /// <summary>
        ///     证书到期时间
        /// </summary>
        public string expiredDate { get; set; }

        /// <summary>
        ///     认证项目
        /// </summary>
        public string certificationProgram { get; set; }

        /// <summary>
        ///     获证组织名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     证书详情
        /// </summary>
        public string detailInfo { get; set; }

        /// <summary>
        ///     证书详情链接地址
        /// </summary>
        public string detailInfoUrl { get; set; }
    }
}