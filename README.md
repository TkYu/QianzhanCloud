QianzhanCloud - 更专业的企业大数据平台
========================================

这是什么
-------------

这是一个[前瞻云数据](http://open.qianzhan.com/)的C# SDK


功能
--------
本SDK提供 前瞻云数据的[数据接口](http://open.qianzhan.com/interface)中的所有方法。
使用前请先前往[http://open.qianzhan.com/](http://open.qianzhan.com/)申请一个APP Key，会得到一个appKey及一个appSec。


在项目中初始化SDK实例：
------------------------------------------------------------

Note: 建议把SDK实例设置为一个全局变量.

```csharp
QianzhanCloud sdk = new QianzhanCloud("你的appKey", "你的appSec", true);
```


调用函数：
-------------------------------------------------------

在[http://open.qianzhan.com/interface](http://open.qianzhan.com/interface)挑选自己需要的功能，点击以查看详情，在详情页的“接口信息”处可以找到“接口地址”(例如“CombineIndexSearch”)，然后我们只需要使用SDK调用相应名字的函数即可。

```csharp
var result = sdk.CombineIndexSearch("深圳前瞻资讯");
```
这个函数可以通过多个条件来搜索相应的公司，具体参数有详细的中文注释，可以自行查看。

