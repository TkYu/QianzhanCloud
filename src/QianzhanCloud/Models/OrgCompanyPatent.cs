using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 专利信息
    /// </summary>
    public class OrgCompanyPatent
    {
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 专利申请号
        /// </summary>
        public string patentNo { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string patentDate { get; set; }
        /// <summary>
        /// 专利公开号
        /// </summary>
        public string patentOpen { get; set; }
        /// <summary>
        /// 公开日
        /// </summary>
        public string patentOpenDate { get; set; }
        /// <summary>
        /// 发明专利名称
        /// </summary>
        public string patentName { get; set; }
        /// <summary>
        /// 发明(设计)人
        /// </summary>
        public string patentInventor { get; set; }
        /// <summary>
        /// 专利类型
        /// </summary>
        public string patentType { get; set; }
        /// <summary>
        /// 优先权
        /// </summary>
        public string patentPriority { get; set; }
        /// <summary>
        /// 优先权日
        /// </summary>
        public string patentPriorityDate { get; set; }
        /// <summary>
        /// 代理人
        /// </summary>
        public string patentAgent { get; set; }
        /// <summary>
        /// 代理机构
        /// </summary>
        public string patentAgency { get; set; }
        /// <summary>
        /// 法律状态
        /// </summary>
        public string patentLegalStatus { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string patentApplicant { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string patentAddr { get; set; }
        /// <summary>
        /// 国（省）
        /// </summary>
        public string patentCity { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string patentPostCode { get; set; }
        /// <summary>
        /// 主分类号
        /// </summary>
        public string patentMainClass { get; set; }
        /// <summary>
        /// 分类号
        /// </summary>
        public string patentClass { get; set; }
        /// <summary>
        /// 颁证日
        /// </summary>
        public string patentIssueDate { get; set; }
        /// <summary>
        /// 国际申请
        /// </summary>
        public string patentInternationalApplication { get; set; }
        /// <summary>
        /// 国际公布
        /// </summary>
        public string patentInternationalPublication { get; set; }
        /// <summary>
        /// 进入国家日期
        /// </summary>
        public string patentDateOfEntry { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string patentAbstract { get; set; }
        /// <summary>
        /// 主权项
        /// </summary>
        public string patentPrincipalClaim { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string patentImgURL { get; set; }
    }

}
