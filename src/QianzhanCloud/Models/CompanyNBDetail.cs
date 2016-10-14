using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qianzhan.Models
{
    /// <summary>
    /// 企业年报详情
    /// </summary>
    public class CompanyNBDetail
    {
        /// <summary>
        /// 年报信息
        /// </summary>
        public NBInfo nbInfo { get; set; }

        /// <summary>
        /// 对外担保信息
        /// </summary>
        public DwtgbzdbInfo dwtgbzdbInfoList { get; set; }

        /// <summary>
        /// 对外投资集合
        /// </summary>
        public DwtzInfo[] dwtzInfoList { get; set; }

        /// <summary>
        /// 股东出资
        /// </summary>
        public GdCzInfo gdCzInfoList { get; set; }

        /// <summary>
        /// 股权变更
        /// </summary>
        public GqbgInfo gqbgInfoList { get; set; }

        /// <summary>
        /// 网站集合
        /// </summary>
        public WwInfo[] wwInfoList { get; set; }

        /// <summary>
        /// 修改记录集合
        /// </summary>
        public XgjlInfo[] xgjlInfoList { get; set; }
    }

    /// <summary>
    /// 年报详情
    /// </summary>
    public class NBInfo
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        public string companyCode { get; set; }
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyKey { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 注册号
        /// </summary>
        public string regNumber { get; set; }
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string postCode { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string mail { get; set; }
        /// <summary>
        /// 有限责任公司本年度是否发生股东股权转让 (0 否 1是)
        /// </summary>
        public string shareTransfer { get; set; }
        /// <summary>
        /// 企业经营状态
        /// </summary>
        public string runStatus { get; set; }
        /// <summary>
        /// 是否有网站或网点 (0 否 1是)
        /// </summary>
        public string webSite { get; set; }
        /// <summary>
        /// 是否有投资信息或购买其他公司股权 (0 否 1 是)
        /// </summary>
        public string otherShare { get; set; }
        /// <summary>
        /// 从业人数
        /// </summary>
        public string members { get; set; }
        /// <summary>
        /// 资产总额
        /// </summary>
        public string totalAssets { get; set; }
        /// <summary>
        /// 所有者权益合计
        /// </summary>
        public string totalEquity { get; set; }
        /// <summary>
        /// 营业总收入
        /// </summary>
        public string totalIncome { get; set; }
        /// <summary>
        /// 利润总额
        /// </summary>
        public string toalProfit { get; set; }
        /// <summary>
        /// 营业总收入中主营业务收入
        /// </summary>
        public string mainIncome { get; set; }
        /// <summary>
        /// 净利润
        /// </summary>
        public string netProfit { get; set; }
        /// <summary>
        /// 纳税总额
        /// </summary>
        public string totalTax { get; set; }
        /// <summary>
        /// 负债总额
        /// </summary>
        public string totalDebt { get; set; }
        /// <summary>
        /// 企业地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 详情链接
        /// </summary>
        public string urlLink { get; set; }
    }

    /// <summary>
    /// 对外担保信息
    /// </summary>
    public class DwtgbzdbInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 债权人
        /// </summary>
        public string zcr { get; set; }
        /// <summary>
        /// 债务人
        /// </summary>
        public string zwr { get; set; }
        /// <summary>
        /// 主债权种类
        /// </summary>
        public string zzczl { get; set; }
        /// <summary>
        /// 主债权数额
        /// </summary>
        public string zzcse { get; set; }
        /// <summary>
        /// 履行债务的期限
        /// </summary>
        public string lxzwqx { get; set; }
        /// <summary>
        /// 保证的期间
        /// </summary>
        public string bzqj { get; set; }
        /// <summary>
        /// 保证的方式
        /// </summary>
        public string bzfs { get; set; }
        /// <summary>
        /// 保证担保的范围
        /// </summary>
        public string bzdbfw { get; set; }
    }

    /// <summary>
    /// 对外投资
    /// </summary>
    public class DwtzInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 登记证号
        /// </summary>
        public string regNumber { get; set; }
    }

    /// <summary>
    /// 股东出资
    /// </summary>
    public class GdCzInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 股东
        /// </summary>
        public string gd { get; set; }
        /// <summary>
        /// 认缴出资额
        /// </summary>
        public string rjczeM { get; set; }
        /// <summary>
        /// 认缴出资额（带单位）
        /// </summary>
        public string rjcze { get; set; }
        /// <summary>
        /// 认缴出资时间
        /// </summary>
        public string rjczsj { get; set; }
        /// <summary>
        /// 认缴出资方式
        /// </summary>
        public string rjczfs { get; set; }
        /// <summary>
        /// 实缴出资额
        /// </summary>
        public string sjczeM { get; set; }
        /// <summary>
        /// 实缴出资额（带单位）
        /// </summary>
        public string sjcze { get; set; }
        /// <summary>
        /// 出资时间
        /// </summary>
        public string czsj { get; set; }
        /// <summary>
        /// 出资方式
        /// </summary>
        public string czfs { get; set; }
    }

    /// <summary>
    /// 股权变更
    /// </summary>
    public class GqbgInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 股东
        /// </summary>
        public string gd { get; set; }
        /// <summary>
        /// 变更前股权比例
        /// </summary>
        public string qgqbl { get; set; }
        /// <summary>
        /// 变更后股权比例
        /// </summary>
        public string hgqbl { get; set; }
        /// <summary>
        /// 股权变更日期
        /// </summary>
        public string bgsj { get; set; }
    }

    /// <summary>
    /// 网站
    /// </summary>
    public class WwInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 网址
        /// </summary>
        public string webSite { get; set; }
    }

    /// <summary>
    /// 企业年报详情结果
    /// </summary>
    public class XgjlInfo
    {
        /// <summary>
        /// 年份
        /// </summary>
        public string year { get; set; }
        /// <summary>
        /// 修改事项
        /// </summary>
        public string xgsx { get; set; }
        /// <summary>
        /// 修改前
        /// </summary>
        public string xgq { get; set; }
        /// <summary>
        /// 修改后
        /// </summary>
        public string xgh { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public string xgsj { get; set; }
    }
}
