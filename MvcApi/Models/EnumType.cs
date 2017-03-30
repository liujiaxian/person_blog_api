using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApi.Models
{

    public enum Enum_Return
    {
        成功 = 0,
        失败,
        登录失效,
        账号未激活
    }

    public enum Enum_Sex
    {
        男 = 1,
        女
    }

    public enum Enum_User
    {
        管理员 = 1,
        普通会员
    }
    /// <summary>
    /// 计划状态
    /// </summary>
    public enum Enum_PlanStatus
    {
        未开启 = 0,
        开始,
        结束
    }

    public enum Enum_TradeType
    {
        无偿交易 = 1,
        有偿交易
    }

    public enum Enum_TradeStatus
    {
        进行中 = 1,
        交易中,
        已提交,
        已完成,
        已关闭
    }

    public enum Enum_CollectionType
    {
        博客 = 1,
        计划,
        图书,
        轮播,
        音乐,
        导航,
        案例,
        公告
    }

    public enum Enum_PhotoType
    {
        博客类型 = 1,
        头像,
        富文本
    }

    public enum Enum_Blog_Source
    {
        原创 = 1,
        转载,
        翻译
    }

    public enum Enum_Email_Type
    {
        绑定邮箱 = 1,
        忘记密码
    }

    public enum Enum_Education_Type
    {
        大专 = 1,
        本科,
        硕士,
        博士,
        其它
    }

    public enum Enum_WorkTime_Type
    {
        一年 = 1,
        二年,
        三年,
        四年,
        五年,
        六年,
        七年,
        八年,
        九年,
        十年,
        十年以上
    }

    public enum Enum_Member_Status
    {
        正常 = 0,
        限制,
        黑名单,
        删除
    }
}
