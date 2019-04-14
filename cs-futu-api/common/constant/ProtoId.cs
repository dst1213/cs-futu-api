using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.common.constant
{
    public class ProtoId
    {
        public const int InitConnect = 1001;  //初始化连接
        public const int GetGlobalState = 1002;  //获取全局状态
        public const int Notify = 1003;  //通知推送
        public const int KeepAlive = 1004;  //通知推送
        public const int GetUserInfo = 1005;  //获取用户信息
        public const int Verification = 1006;  //请求或输入验证码
        public const int GetDelayStatistics = 1007;  //获取延迟统计


        public const int Trd_GetAccList = 2001;  //获取业务账户列表
        public const int Trd_UnlockTrade = 2005;  //解锁或锁定交易
        public const int Trd_SubAccPush = 2008;  //订阅业务账户的交易推送数据


        public const int Trd_GetFunds = 2101;  //获取账户资金
        public const int Trd_GetPositionList = 2102;  //获取账户持仓


        public const int Trd_GetOrderList = 2201;  //获取订单列表
        public const int Trd_PlaceOrder = 2202;  //下单
        public const int Trd_ModifyOrder = 2205;  //修改订单
        public const int Trd_UpdateOrder = 2208;  //订单状态变动通知(推送)


        public const int Trd_GetOrderFillList = 2211;  //获取成交列表
        public const int Trd_UpdateOrderFill = 2218;  //成交通知(推送)


        public const int Trd_GetHistoryOrderList = 2221;  //获取历史订单列表
        public const int Trd_GetHistoryOrderFillList = 2222;  //获取历史成交列表
        public const int Trd_GetAccTradingInfo = 2111;  //查询最大买卖数量


        //订阅数据
        public const int Qot_Sub = 3001;  //订阅或者反订阅
        public const int Qot_RegQotPush = 3002;  //注册推送
        public const int Qot_GetSubInfo = 3003;  //获取订阅信息
        public const int Qot_GetBasicQot = 3004;  //获取股票基本行情
        public const int Qot_UpdateBasicQot = 3005;  //推送股票基本行情
        public const int Qot_GetKL = 3006;  //获取K线
        public const int Qot_UpdateKL = 3007;  //推送K线
        public const int Qot_GetRT = 3008;  //获取分时
        public const int Qot_UpdateRT = 3009;  //推送分时
        public const int Qot_GetTicker = 3010;  //获取逐笔
        public const int Qot_UpdateTicker = 3011;  //推送逐笔
        public const int Qot_GetOrderBook = 3012;  //获取买卖盘
        public const int Qot_UpdateOrderBook = 3013;  //推送买卖盘
        public const int Qot_GetBroker = 3014;  //获取经纪队列
        public const int Qot_UpdateBroker = 3015;  //推送经纪队列

        //历史数据
        public const int Qot_GetHistoryKL = 3100;  //获取历史K线
        public const int Qot_GetHistoryKLPoints = 3101;  //获取多只股票历史单点K线
        public const int Qot_GetRehab = 3102;  //获取复权信息
        public const int Qot_RequestHistoryKL = 3103; //拉取历史K线
        public const int Qot_RequestHistoryKLQuota = 3104;  //拉取历史K线已经用掉的额度
        public const int Qot_RequestRehab = 3105;  //获取除权信息

        //其他行情数据
        public const int Qot_GetTradeDate = 3200;  //获取市场交易日
        public const int Qot_GetSuspend = 3201;  //获取股票停牌信息
        public const int Qot_GetStaticInfo = 3202;  //获取股票列表
        public const int Qot_GetSecuritySnapshot = 3203;  //获取股票快照
        public const int Qot_GetPlateSet = 3204;  //获取板块集合下的板块
        public const int Qot_GetPlateSecurity = 3205;  //获取板块下的股票
        public const int Qot_GetReference = 3206;  //获取正股相关股票，暂时只有窝轮
        public const int Qot_GetOwnerPlate = 3207;  //获取股票所属板块
        public const int Qot_GetHoldingChangeList = 3208;  //获取高管持股变动
        public const int Qot_GetOptionChain = 3209;  //获取期权链

        public const int Qot_GetOrderDetail = 3016;  //获取委托明细
        public const int Qot_UpdateOrderDetail = 3017;  //推送委托明细

        public const int Qot_GetWarrantData = 3210;  //拉取涡轮信息
    }
}
