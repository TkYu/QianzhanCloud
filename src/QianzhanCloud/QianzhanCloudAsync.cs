#if !NET40 && !NET20
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qianzhan.Models;
using Newtonsoft.Json;

namespace Qianzhan
{
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
        public async Task<OrgCompany[]> CombineIndexSearchAsync(string companyName = "", int page = 1, int pagesize = 10, string areaCode = "", string faRen = "", string bussinessDes = "", string address = "", string gd = "")
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
            return await PostAsync<OrgCompany[]>("CombineIndexSearch", param);
        }

        /// <summary>
        /// 根据公司主键获取机构信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public async Task<OrgCompanyDetail> OrgCompanyListByCompanyKeyAsync(string companyKey)
        {
            return await GetAsync<OrgCompanyDetail>("OrgCompanyListByCompanyKey", $"companyKey={companyKey}");
        }

        /// <summary>
        /// 根据公司主键获取机构信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public async Task<OrgCompanyDetail> GetDtlInfoByCompanyKeyAsync(string companyKey)
        {
            return await GetAsync<OrgCompanyDetail>("GetDtlInfoByCompanyKey", $"companyKey={companyKey}");
        }

        /// <summary>
        /// 成员信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public async Task<DetailManager[]> GetDtlMgrInfoAsync(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return await GetAsync<DetailManager[]>("GetDtlMgrInfo", param);
        }

        /// <summary>
        /// 股东信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public async Task<DetailGD[]> CompanyGDDetailAsync(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return await GetAsync<DetailGD[]>("CompanyGDDetail", param);
        }

        /// <summary>
        /// 根据公司名或地区搜索
        /// </summary>
        /// <param name="areaCode">区域代码</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        /// <param name="companyName">企业名称关键字</param>
        public async Task<OrgCompany[]> OrgCompanyAsync(int areaCode, string companyName = "", int page = 1, int pagesize = 10)
        {
            var param = $"areaCode={areaCode}&page={page}&pagesize={pagesize}&companyName={companyName}";
            return await GetAsync<OrgCompany[]>("OrgCompany", param);
        }

        /// <summary>
        /// 根据企业全名获取机构信息
        /// </summary>
        /// <param name="companyName">企业全名</param>
        public async Task<OrgCompanyList> OrgCompanyListByCompanyNameAsync(string companyName)
        {
            var param = $"companyName={companyName}";
            return await GetAsync<OrgCompanyList>("OrgCompanyListByCompanyName", param);
        }

        /// <summary>
        /// 根据机构代码获取机构信息
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        public async Task<OrgCompanyList> OrgCompanyListByCompanyCodeAsync(string companyCode)
        {
            var param = $"companyCode={companyCode}";
            return await GetAsync<OrgCompanyList>("OrgCompanyListByCompanyCode", param);
        }

        /// <summary>
        /// 根据机构代码获取主体信息
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        public async Task<OrgCompanyDetail> GetDtlInfoAsync(string companyCode)
        {
            var param = $"companyCode={companyCode}";
            return await GetAsync<OrgCompanyDetail>("GetDtlInfo", param);
        }

        /// <summary>
        /// 根据登记证号获取机构信息
        /// </summary>
        /// <param name="regNumber">登记证号</param>
        public async Task<OrgCompanyList> OrgCompanyListByNumberAsync(string regNumber)
        {
            var param = $"regNumber={regNumber}";
            return await GetAsync<OrgCompanyList>("OrgCompanyListByNumber", param);
        }
        #endregion

        #region 企业附加信息
        /// <summary>
        /// 企业变更信息查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<CompanyUpdate[]> CompanyUpdateSelectPageAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<CompanyUpdate[]>("CompanyUpdateSelectPage", param);
        }

        /// <summary>
        /// 域名备案查询
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<CompanyRegister[]> CompanyRegisterSelectPageAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<CompanyRegister[]>("CompanyRegisterSelectPage", param);
        }

        /// <summary>
        /// 企业年报列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="year">年份</param>
        public async Task<CompanyNB[]> CompanyNBListAsync(string companyKey, int year)
        {
            var param = $"companyKey={companyKey}&year={year}";
            return await GetAsync<CompanyNB[]>("CompanyNBList", param);
        }

        /// <summary>
        /// 企业年报详情
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="year">年份， (默认查询所有年份)</param>
        public async Task<CompanyNBDetail[]> CompanyNBDetailAsync(string companyKey, int year)
        {
            var param = $"companyKey={companyKey}&year={year}";
            return await GetAsync<CompanyNBDetail[]>("CompanyNBDetail", param);
        }
        #endregion

        #region 企业关系
        /// <summary>
        /// 分支机构查询
        /// </summary>
        /// <param name="companyName">公司名称</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<CompanyBranch[]> CompanyBranchSelectPageAsync(string companyName, int page = 1, int pagesize = 10)
        {
            var param = $"companyName={companyName}&page={page}&pagesize={pagesize}";
            return await GetAsync<CompanyBranch[]>("CompanyBranchSelectPage", param);
        }

        /// <summary>
        /// 对外投资查询
        /// </summary>
        /// <param name="companyName">企业名称</param>
        public async Task<InvestedCompany[]> InvestedCompanyAsync(string companyName)
        {
            var param = $"companyName={companyName}";
            return await GetAsync<InvestedCompany[]>("InvestedCompany", param);
        }
        #endregion

        #region 知识产权
        /// <summary>
        /// 专利信息
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<OrgCompanyPatent[]> OrgCompanyPatentListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<OrgCompanyPatent[]>("OrgCompanyPatentList", param);
        }

        /// <summary>
        /// 企业证书列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<CertificationInfo[]> CertificationInfoListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<CertificationInfo[]>("CertificationInfoList", param);
        }

        /// <summary>
        /// 软件著作权
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<SoftwareCopyright[]> SoftwareCopyrightListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<SoftwareCopyright[]>("SoftwareCopyrightList", param);
        }

        /// <summary>
        /// 作品著作权
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<ProductCopyright[]> ProductCopyrightListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<ProductCopyright[]>("ProductCopyrightList", param);
        }

        /// <summary>
        /// 商标详情
        /// </summary>
        /// <param name="regNo">商标注册号</param>
        public async Task<OrgCompanyBrand> OrgCompanyBrandDetailAsync(string regNo)
        {
            var param = $"regNo={regNo}";
            return await GetAsync<OrgCompanyBrand>("OrgCompanyBrandDetail", param);
        }

        /// <summary>
        /// 商标列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<OrgCompanyBrand[]> OrgCompanyBrandListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<OrgCompanyBrand[]>("OrgCompanyBrandList", param);
        }
        #endregion

        #region 经营信息
        /// <summary>
        /// 企业招聘岗位列表
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<QZEmploy[]> QZEmployListAsync(string companyKey, int page = 1, int pagesize = 10)
        {
            var param = $"companyKey={companyKey}&page={page}&pagesize={pagesize}";
            return await GetAsync<QZEmploy[]>("QZEmployList", param);
        }

        /// <summary>
        /// 招聘企业详情
        /// </summary>
        /// <param name="companyKey">公司主键</param>
        public async Task<QZEmployDetail> QZEmployQZEmployCompanyDetailAsync(string companyKey)
        {
            var param = $"companyKey={companyKey}";
            return await GetAsync<QZEmployDetail>("QZEmployQZEmployCompanyDetail", param);
        }
        #endregion

        #region 风险信息
        /// <summary>
        /// 法院文书列表
        /// </summary>
        /// <param name="input">查询字符串</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<JudgeDoc[]> JudgeListAsync(string input, int page = 1, int pagesize = 10)
        {
            var param = $"input={input}&page={page}&pagesize={pagesize}";
            return await GetAsync<JudgeDoc[]>("JudgeList", param);
        }

        /// <summary>
        /// 机构代码查询法院文书
        /// </summary>
        /// <param name="companyCode">机构代码</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<JudgeDoc[]> JudgeListByCompanyCodeAsync(string companyCode, int page = 1, int pagesize = 10)
        {
            var param = $"companyCode={companyCode}&page={page}&pagesize={pagesize}";
            return await GetAsync<JudgeDoc[]>("JudgeListByCompanyCode", param);
        }

        /// <summary>
        /// 法院文书详情
        /// </summary>
        /// <param name="judgeId">文书 Id</param>
        public async Task<JudgeDoc> JudgeDtlByjudgeIdAsync(string judgeId)
        {
            var param = $"judgeId={judgeId}";
            return await GetAsync<JudgeDoc>("JudgeDtlByjudgeId", param);
        }

        /// <summary>
        /// 失信列表
        /// </summary>
        /// <param name="input">查询字符串</param>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<Dishonest[]> DishonestListAsync(string input, int page = 1, int pagesize = 10)
        {
            var param = $"input={input}&page={page}&pagesize={pagesize}";
            return await GetAsync<Dishonest[]>("DishonestList", param);
        }

        /// <summary>
        /// 失信详情
        /// </summary>
        /// <param name="dishonestId">失信 Id</param>
        public async Task<Dishonest> DishonestDtlBydishonestIdAsync(string dishonestId)
        {
            var param = $"dishonestId={dishonestId}";
            return await GetAsync<Dishonest>("DishonestDtlBydishonestId", param);
        }
        #endregion

        #region 其它常用接口
        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetTokenAsync()
        {
            if (_saveTokenToFile && System.IO.File.Exists(_configPath))
            {
                try
                {
                    var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(System.IO.File.ReadAllText(_configPath));
                    _expTime = DateTime.ParseExact(values["expTime"], "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None);
                    _token = values["token"];
                }
                catch
                {
                    //TODO
                }
            }
            if (_token == null || DateTime.UtcNow > _expTime)
                await RefreshTokenAsync();
            return _token;
        }
        /// <summary>
        /// 获取所有省份区域代码
        /// </summary>
        public async Task<AreaCode[]> GetAllProvinceAsync()
        {
            return await GetAsync<AreaCode[]>("GetAllProvince");
        }

        /// <summary>
        /// 根据省份代码获取下级区域代码
        /// </summary>
        /// <param name="areaCode">区域代码</param>
        public async Task<AreaCode[]> GetCityByProvinceAsync(string areaCode)
        {
            var param = $"areaCode={areaCode}";
            return await GetAsync<AreaCode[]>("GetCityByProvince", param);
        }

        /// <summary>
        /// 文档内公司信息快速抽取
        /// </summary>
        /// <param name="input">需要解析的字符串</param>
        public async Task<ExtractedCompany[]> CompanyExtractAsync(string input)
        {
            var param = $"input={input}";
            return await GetAsync<ExtractedCompany[]>("CompanyExtract", param);
        }

        /// <summary>
        /// 公司名关键词快速自动提示
        /// </summary>
        /// <param name="input">企业名称前缀</param>
        public async Task<ExtractedCompany[]> CompanyInputTipsAsync(string input)
        {
            var param = $"input={input}";
            return await GetAsync<ExtractedCompany[]>("CompanyInputTips", param);
        }

        /// <summary>
        /// 国家标准行业和产品分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public async Task<AnalysedProduct[]> AnalysisProductAndTradeAsync(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return await PostAsync<AnalysedProduct[]>("AnalysisProductAndTrade", param);
        }

        /// <summary>
        /// 展会行业分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public async Task<ExhibitionAnalysis[]> AnalysisExhibitionTradeAsync(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return await PostAsync<ExhibitionAnalysis[]>("AnalysisExhibitionTrade", param);
        }

        /// <summary>
        /// 前瞻行业分析
        /// </summary>
        /// <param name="input">分析字符串</param>
        public async Task<ExhibitionAnalysisForward[]> AnalysisForwardTradeAsync(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return await PostAsync<ExhibitionAnalysisForward[]>("AnalysisForwardTrade", param);
        }

        /// <summary>
        /// 分析所有行业
        /// </summary>
        /// <param name="input">分析字符串</param>
        public async Task<AllTradeAnalysis[]> AnalysisAllTradeAsync(string input)
        {
            var param = new[]
            {
                new KeyValuePair<string, string>("input", input)
            };
            return await PostAsync<AllTradeAnalysis[]>("AnalysisAllTrade", param);
        }

        /// <summary>
        /// 企业说列表
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="pagesize">每页数据条数</param>
        public async Task<CompanyShow[]> CompanyShowListAsync(int page = 1, int pagesize = 2)
        {
            var param = $"page={page}&pagesize={pagesize}";
            return await GetAsync<CompanyShow[]>("CompanyShowList", param);
        }

        /// <summary>
        /// 企业说详情
        /// </summary>
        /// <param name="newsId">文章 Id</param>
        public async Task<CompanyShowDetail> CompanyShowDetailAsync(string newsId)
        {
            var param = $"newsId={newsId}";
            return await GetAsync<CompanyShowDetail>("CompanyShowDetail", param);
        }
        #endregion
    }
}
#endif