﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NewLife.Data;
using XCode;
using XCode.Membership;

namespace Stardust.Data.Nodes
{
    /// <summary>节点升级通道</summary>
    public enum NodeChannels
    {
        /// <summary>发布</summary>
        Release = 1,

        /// <summary>测试</summary>
        Beta = 2,

        /// <summary>开发</summary>
        Develop = 3,
    }

    /// <summary>节点版本。发布更新</summary>
    public partial class NodeVersion : EntityBase<NodeVersion>
    {
        #region 对象操作
        static NodeVersion()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.ProductID);

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<UserModule>();
            Meta.Modules.Add<TimeModule>();
            Meta.Modules.Add<IPModule>();
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 重新聚合规则
            if (!Dirtys[__.Strategy] && Rules != null)
            {
                var sb = new StringBuilder();
                foreach (var item in Rules)
                {
                    if (sb.Length > 0) sb.Append(";");
                    sb.AppendFormat("{0}={1}", item.Key, item.Value.Join(","));
                }
                Strategy = sb.ToString();
            }

            // 默认通道
            if (Channel < NodeChannels.Release || Channel > NodeChannels.Develop) Channel = NodeChannels.Release;
        }

        /// <summary>加载后，释放规则</summary>
        protected override void OnLoad()
        {
            base.OnLoad();

            var dic = Strategy.SplitAsDictionary("=", ";");
            Rules = dic.ToDictionary(e => e.Key, e => e.Value.Split(","));
        }
        #endregion

        #region 扩展属性
        /// <summary>规则集合</summary>
        [XmlIgnore]
        public IDictionary<String, String[]> Rules { get; set; }
        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static NodeVersion FindByID(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.ID == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.ID == id);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        /// <summary>获取有效</summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static IList<NodeVersion> GetValids(NodeChannels channel)
        {
            var list = Meta.Cache.FindAll(e => e.Enable);
            if (list.Count == 0) return list;

            if (channel >= NodeChannels.Release) list = list.Where(e => e.Channel == channel).ToList();

            // 按照编号降序，最大100个
            list = list.OrderByDescending(e => e.ID).Take(100).ToList();

            return list;
        }

        /// <summary>应用策略是否匹配指定节点</summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Boolean Match(Node node)
        {
            // 没有使用该规则，直接过
            if (Rules.TryGetValue("version", out var vs))
            {
                var ver = node.Version;
                if (ver.IsNullOrEmpty() || !vs.Contains(ver)) return false;
            }

            if (Rules.TryGetValue("node", out vs))
            {
                var code = node.Code;
                if (code.IsNullOrEmpty() || !vs.Contains(code)) return false;
            }

            return true;
        }
        #endregion
    }
}