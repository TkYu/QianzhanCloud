using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Qianzhan.Models;

namespace Qianzhan
{
    /// <summary>
    /// 前瞻云SDK
    /// </summary>
    public partial class QianzhanCloud
    {
        #region 企业基础信息
        /// <summary>
        /// 多条件联合搜索
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页返回数据条数</param>
        /// <param name="companyName">企业名称</param>
        /// <param name="areaCode">区域代码</param>
        /// <param name="faRen">法人代表</param>
        /// <param name="bussinessDes">经营范围</param>
        /// <param name="address">企业地址</param>
        /// <param name="gd">股东</param>
        public OrgCompany[] CombineIndexSearch(string companyName = "", int page = 1, int pagesize = 10, string areaCode = "", string faRen = "", string bussinessDes = "", string address = "", string gd = "")
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("page", page.ToString()),
                new KeyValuePair<string, string>("pagesize", pagesize.ToString()),
                new KeyValuePair<string, string>("companyName", companyName),
                new KeyValuePair<string, string>("areaCode", areaCode),
                new KeyValuePair<string, string>("faRen", faRen),
                new KeyValuePair<string, string>("bussinessDes", bussinessDes),
                new KeyValuePair<string, string>("address", address),
                new KeyValuePair<string, string>("gd", gd)
            };
            return Post<OrgCompany[]>("CombineIndexSearch", param);
        }

        /// <summary>
        /// 根据公司主键获取机构信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public OrgCompanyDetail OrgCompanyListByCompanyKey(string companyKey)
        {
            return Get<OrgCompanyDetail>("OrgCompanyListByCompanyKey", $"companyKey={companyKey}");
        }

        /// <summary>
        /// 根据公司主键获取机构信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public OrgCompanyDetail GetDtlInfoByCompanyKey(string companyKey)
        {
            return Get<OrgCompanyDetail>("GetDtlInfoByCompanyKey", $"companyKey={companyKey}");
        }

        /// <summary>
        /// 成员信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public DetailManager[] GetDtlMgrInfo(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return Get<DetailManager[]>("GetDtlMgrInfo", param);
        }

        /// <summary>
        /// 股东信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public DetailGD[] CompanyGDDetail(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return Get<DetailGD[]>("CompanyGDDetail", param);
        }

        /// <summary>
        /// 根据公司名或地区搜索
        /// </summary>
        /// <param name="areaCode">区域代码</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        /// <param name="companyName">企业名称关键字</param>
        public OrgCompany[] OrgCompany(string companyName, string areaCode = "", int page = 1, int pagesize = 10)
        {
            var param = $"areaCode={areaCode}&page={page}&pagesize={pagesize}&companyName={companyName}";
            return Get<OrgCompany[]>("OrgCompany", param);
        }

        /// <summary>
        /// 根据企业全名获取机构信息
        /// </summary>
        /// <param name="companyName">企业全名</param>
        public OrgCompanyList OrgCompanyListByCompanyName(string companyName)
        {
            var param = $"companyName={companyName}";
            return Get<OrgCompanyList>("OrgCompanyListByCompanyName", param);
        }

        /// <summary>
        /// 根据机构代码获取机构信息
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        public OrgCompanyList OrgCompanyListByCompanyCode(string companyCode)
        {
            var param = $"companyCode={companyCode}";
            return Get<OrgCompanyList>("OrgCompanyListByCompanyCode", param);
        }

        /// <summary>
        /// 根据机构代码获取主体信息
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        public OrgCompanyDetail GetDtlInfo(string companyCode)
        {
            var param = $"companyCode={companyCode}";
            return Get<OrgCompanyDetail>("GetDtlInfo", param);
        }

        /// <summary>
        /// 根据登记证号获取机构信息
        /// </summary>
        /// <param name="regNumber">登记证号</param>
        public OrgCompanyList OrgCompanyListByNumber(string regNumber)
        {
            var param = $"regNumber={regNumber}";
            return Get<OrgCompanyList>("OrgCompanyListByNumber", param);
        }
        #endregion

        #region 企业附加信息
        /// <summary>
        /// 企业变更信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public CompanyUpdate[] CompanyUpdateSelectPage(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<CompanyUpdate[]>("CompanyUpdateSelectPage", param);
        }

        /// <summary>
        /// 域名备案查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public CompanyRegister[] CompanyRegisterSelectPage(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<CompanyRegister[]>("CompanyRegisterSelectPage", param);
        }

        /// <summary>
        /// 企业年报列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="year">年份</param>
        public CompanyNB[] CompanyNBList(string companyKey, int year)
        {
            var param = $"companyKey={companyKey}&year={year}";
            return Get<CompanyNB[]>("CompanyNBList", param);
        }

        /// <summary>
        /// 企业年报详情
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="year">年份， (默认查询所有年份)</param>
        public CompanyNBDetail[] CompanyNBDetail(string companyKey, int year)
        {
            var param = $"companyKey={companyKey}&year={year}";
            return Get<CompanyNBDetail[]>("CompanyNBDetail", param);
        }
        #endregion

        #region 企业关系
        /// <summary>
        /// 分支机构查询
        /// </summary>
        /// <param name="companyName">公司名称</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public CompanyBranch[] CompanyBranchSelectPage(string companyName, int page = 1, int pagesize = 10)
        {
            var param = $"companyName={companyName}&page={page}&pagesize={pagesize}";
            return Get<CompanyBranch[]>("CompanyBranchSelectPage", param);
        }

        /// <summary>
        /// 对外投资查询
        /// </summary>
        /// <param name="companyName">企业名称</param>
        public InvestedCompany[] InvestedCompany(string companyName)
        {
            var param = $"companyName={companyName}";
            return Get<InvestedCompany[]>("InvestedCompany", param);
        }
        #endregion

        #region 知识产权
        /// <summary>
        /// 专利信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public OrgCompanyPatent[] OrgCompanyPatentList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<OrgCompanyPatent[]>("OrgCompanyPatentList", param);
        }

        /// <summary>
        /// 企业证书列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public CertificationInfo[] CertificationInfoList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<CertificationInfo[]>("CertificationInfoList", param);
        }

        /// <summary>
        /// 软件著作权
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public SoftwareCopyright[] SoftwareCopyrightList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<SoftwareCopyright[]>("SoftwareCopyrightList", param);
        }

        /// <summary>
        /// 作品著作权
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public ProductCopyright[] ProductCopyrightList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<ProductCopyright[]>("ProductCopyrightList", param);
        }

        /// <summary>
        /// 商标详情
        /// </summary>
        /// <param name="regNo">商标注册号</param>
        public OrgCompanyBrand OrgCompanyBrandDetail(string regNo)
        {
            var param = $"regNo={regNo}";
            return Get<OrgCompanyBrand>("OrgCompanyBrandDetail", param);
        }

        /// <summary>
        /// 商标列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public OrgCompanyBrand[] OrgCompanyBrandList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<OrgCompanyBrand[]>("OrgCompanyBrandList", param);
        }
        #endregion

        #region 经营信息
        /// <summary>
        /// 企业招聘岗位列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public QZEmploy[] QZEmployList(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return Get<QZEmploy[]>("QZEmployList", param);
        }

        /// <summary>
        /// 招聘企业详情
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public QZEmployDetail QZEmployQZEmployCompanyDetail(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return Get<QZEmployDetail>("QZEmployQZEmployCompanyDetail", param);
        }
        #endregion

        #region 风险信息
        /// <summary>
        /// 法院文书列表
        /// </summary>
        /// <param name="input">查询字符串</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public JudgeDoc[] JudgeList(string input, int page = 1, int pagesize = 10)
        {
            var param = $"input={input}&page={page}&pagesize={pagesize}";
            return Get<JudgeDoc[]>("JudgeList", param);
        }

        /// <summary>
        /// 机构代码查询法院文书
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public JudgeDoc[] JudgeListByCompanyCode(string companyCode, int page = 1, int pagesize = 10)
        {
            var param = $"companyCode={companyCode}&page={page}&pagesize={pagesize}";
            return Get<JudgeDoc[]>("JudgeListByCompanyCode", param);
        }

        /// <summary>
        /// 法院文书详情
        /// </summary>
        /// <param name="judgeId">文书 Id</param>
        public JudgeDoc JudgeDtlByjudgeId(string judgeId)
        {
            var param = $"judgeId={judgeId}";
            return Get<JudgeDoc>("JudgeDtlByjudgeId", param);
        }

        /// <summary>
        /// 失信列表
        /// </summary>
        /// <param name="input">查询字符串</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public Dishonest[] DishonestList(string input, int page = 1, int pagesize = 10)
        {
            var param = $"input={input}&page={page}&pagesize={pagesize}";
            return Get<Dishonest[]>("DishonestList", param);
        }

        /// <summary>
        /// 失信详情
        /// </summary>
        /// <param name="dishonestId">失信 Id</param>
        public Dishonest DishonestDtlBydishonestId(string dishonestId)
        {
            var param = $"dishonestId={dishonestId}";
            return Get<Dishonest>("DishonestDtlBydishonestId", param);
        }
        #endregion

        #region 其它常用接口
        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        public string GetToken()
        {
            if (_saveTokenToFile)
                LoadKeyFromFile();
            if (_token == null || DateTime.UtcNow > _expTime)
                RefreshToken();
            return _token;
        }

        /// <summary>
        /// 获取所有省份区域代码
        /// </summary>
        public AreaCode[] GetAllProvince()
        {
            return Get<AreaCode[]>("GetAllProvince");
        }

        /// <summary>
        /// 根据省份代码获取下级区域代码
        /// </summary>
        /// <param name="areaCode">区域代码</param>
        public AreaCode[] GetCityByProvince(string areaCode)
        {
            var param = $"areaCode={areaCode}";
            return Get<AreaCode[]>("GetCityByProvince", param);
        }

        /// <summary>
        /// 文档内公司信息快速抽取
        /// </summary>
        /// <param name="input">需要解析的字符串</param>
        public ExtractedCompany[] CompanyExtract(string input)
        {
            var param = $"input={input}";
            return Get<ExtractedCompany[]>("CompanyExtract", param);
        }

        /// <summary>
        /// 公司名关键词快速自动提示
        /// </summary>
        /// <param name="input">企业名称前缀</param>
        public ExtractedCompany[] CompanyInputTips(string input)
        {
            var param = $"input={input}";
            return Get<ExtractedCompany[]>("CompanyInputTips", param);
        }

        /// <summary>
        /// 国家标准行业和产品分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public AnalysedProduct[] AnalysisProductAndTrade(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return Post<AnalysedProduct[]>("AnalysisProductAndTrade", param);
        }

        /// <summary>
        /// 展会行业分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public ExhibitionAnalysis[] AnalysisExhibitionTrade(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return Post<ExhibitionAnalysis[]>("AnalysisExhibitionTrade", param);
        }

        /// <summary>
        /// 前瞻行业分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public ExhibitionAnalysisForward[] AnalysisForwardTrade(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return Post<ExhibitionAnalysisForward[]>("AnalysisForwardTrade", param);
        }

        /// <summary>
        /// 分析所有行业
        /// </summary>
        /// <param name="input">分析字符串</param>
        public AllTradeAnalysis[] AnalysisAllTrade(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return Post<AllTradeAnalysis[]>("AnalysisAllTrade", param);
        }

        /// <summary>
        /// 企业说列表
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public CompanyShow[] CompanyShowList(int page = 1, int pagesize = 2)
        {
            var param = $"page={page}&pagesize={pagesize}";
            return Get<CompanyShow[]>("CompanyShowList", param);
        }

        /// <summary>
        /// 企业说详情
        /// </summary>
        /// <param name="newsId">文章 Id</param>
        public CompanyShowDetail CompanyShowDetail(string newsId)
        {
            var param = $"newsId={newsId}";
            return Get<CompanyShowDetail>("CompanyShowDetail", param);
        }
        #endregion
    }
}
