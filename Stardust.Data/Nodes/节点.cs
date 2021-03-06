using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Stardust.Data.Nodes
{
    /// <summary>节点</summary>
    [Serializable]
    [DataObject]
    [Description("节点")]
    [BindIndex("IU_Node_Code", true, "Code")]
    [BindIndex("IX_Node_Uuid_MachineGuid_MACs", false, "Uuid,MachineGuid,MACs")]
    [BindIndex("IX_Node_UpdateTime", false, "UpdateTime")]
    [BindTable("Node", Description = "节点", ConnName = "Node", DbType = DatabaseType.None)]
    public partial class Node : INode
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "", Master = true)]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private String _Code;
        /// <summary>编码。NodeKey</summary>
        [DisplayName("编码")]
        [Description("编码。NodeKey")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Code", "编码。NodeKey", "")]
        public String Code { get => _Code; set { if (OnPropertyChanging("Code", value)) { _Code = value; OnPropertyChanged("Code"); } } }

        private String _Secret;
        /// <summary>密钥。NodeSecret</summary>
        [DisplayName("密钥")]
        [Description("密钥。NodeSecret")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Secret", "密钥。NodeSecret", "")]
        public String Secret { get => _Secret; set { if (OnPropertyChanging("Secret", value)) { _Secret = value; OnPropertyChanged("Secret"); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get => _Enable; set { if (OnPropertyChanging("Enable", value)) { _Enable = value; OnPropertyChanged("Enable"); } } }

        private String _Version;
        /// <summary>版本</summary>
        [DisplayName("版本")]
        [Description("版本")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Version", "版本", "")]
        public String Version { get => _Version; set { if (OnPropertyChanging("Version", value)) { _Version = value; OnPropertyChanged("Version"); } } }

        private DateTime _CompileTime;
        /// <summary>编译时间</summary>
        [DisplayName("编译时间")]
        [Description("编译时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CompileTime", "编译时间", "")]
        public DateTime CompileTime { get => _CompileTime; set { if (OnPropertyChanging("CompileTime", value)) { _CompileTime = value; OnPropertyChanged("CompileTime"); } } }

        private String _OS;
        /// <summary>操作系统</summary>
        [DisplayName("操作系统")]
        [Description("操作系统")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OS", "操作系统", "")]
        public String OS { get => _OS; set { if (OnPropertyChanging("OS", value)) { _OS = value; OnPropertyChanged("OS"); } } }

        private String _OSVersion;
        /// <summary>系统版本</summary>
        [DisplayName("系统版本")]
        [Description("系统版本")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OSVersion", "系统版本", "")]
        public String OSVersion { get => _OSVersion; set { if (OnPropertyChanging("OSVersion", value)) { _OSVersion = value; OnPropertyChanged("OSVersion"); } } }

        private String _MachineName;
        /// <summary>机器名称</summary>
        [DisplayName("机器名称")]
        [Description("机器名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MachineName", "机器名称", "")]
        public String MachineName { get => _MachineName; set { if (OnPropertyChanging("MachineName", value)) { _MachineName = value; OnPropertyChanged("MachineName"); } } }

        private String _UserName;
        /// <summary>用户名称</summary>
        [DisplayName("用户名称")]
        [Description("用户名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UserName", "用户名称", "")]
        public String UserName { get => _UserName; set { if (OnPropertyChanging("UserName", value)) { _UserName = value; OnPropertyChanged("UserName"); } } }

        private Int32 _Cpu;
        /// <summary>CPU</summary>
        [DisplayName("CPU")]
        [Description("CPU")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Cpu", "CPU", "")]
        public Int32 Cpu { get => _Cpu; set { if (OnPropertyChanging("Cpu", value)) { _Cpu = value; OnPropertyChanged("Cpu"); } } }

        private Int32 _Memory;
        /// <summary>内存。单位M</summary>
        [DisplayName("内存")]
        [Description("内存。单位M")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Memory", "内存。单位M", "")]
        public Int32 Memory { get => _Memory; set { if (OnPropertyChanging("Memory", value)) { _Memory = value; OnPropertyChanged("Memory"); } } }

        private Int32 _TotalSize;
        /// <summary>磁盘。应用所在盘，单位M</summary>
        [DisplayName("磁盘")]
        [Description("磁盘。应用所在盘，单位M")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("TotalSize", "磁盘。应用所在盘，单位M", "")]
        public Int32 TotalSize { get => _TotalSize; set { if (OnPropertyChanging("TotalSize", value)) { _TotalSize = value; OnPropertyChanged("TotalSize"); } } }

        private String _Dpi;
        /// <summary>像素点。默认96*96</summary>
        [DisplayName("像素点")]
        [Description("像素点。默认96*96")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Dpi", "像素点。默认96*96", "")]
        public String Dpi { get => _Dpi; set { if (OnPropertyChanging("Dpi", value)) { _Dpi = value; OnPropertyChanged("Dpi"); } } }

        private String _Resolution;
        /// <summary>分辨率。例如1024*768</summary>
        [DisplayName("分辨率")]
        [Description("分辨率。例如1024*768")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Resolution", "分辨率。例如1024*768", "")]
        public String Resolution { get => _Resolution; set { if (OnPropertyChanging("Resolution", value)) { _Resolution = value; OnPropertyChanged("Resolution"); } } }

        private String _Processor;
        /// <summary>处理器</summary>
        [DisplayName("处理器")]
        [Description("处理器")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Processor", "处理器", "")]
        public String Processor { get => _Processor; set { if (OnPropertyChanging("Processor", value)) { _Processor = value; OnPropertyChanged("Processor"); } } }

        private String _CpuID;
        /// <summary>CPU标识</summary>
        [DisplayName("CPU标识")]
        [Description("CPU标识")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("CpuID", "CPU标识", "")]
        public String CpuID { get => _CpuID; set { if (OnPropertyChanging("CpuID", value)) { _CpuID = value; OnPropertyChanged("CpuID"); } } }

        private String _Uuid;
        /// <summary>唯一标识</summary>
        [DisplayName("唯一标识")]
        [Description("唯一标识")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Uuid", "唯一标识", "")]
        public String Uuid { get => _Uuid; set { if (OnPropertyChanging("Uuid", value)) { _Uuid = value; OnPropertyChanged("Uuid"); } } }

        private String _MachineGuid;
        /// <summary>机器标识</summary>
        [DisplayName("机器标识")]
        [Description("机器标识")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("MachineGuid", "机器标识", "")]
        public String MachineGuid { get => _MachineGuid; set { if (OnPropertyChanging("MachineGuid", value)) { _MachineGuid = value; OnPropertyChanged("MachineGuid"); } } }

        private String _DiskID;
        /// <summary>磁盘序列号</summary>
        [DisplayName("磁盘序列号")]
        [Description("磁盘序列号")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("DiskID", "磁盘序列号", "")]
        public String DiskID { get => _DiskID; set { if (OnPropertyChanging("DiskID", value)) { _DiskID = value; OnPropertyChanged("DiskID"); } } }

        private String _MACs;
        /// <summary>网卡</summary>
        [DisplayName("网卡")]
        [Description("网卡")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("MACs", "网卡", "")]
        public String MACs { get => _MACs; set { if (OnPropertyChanging("MACs", value)) { _MACs = value; OnPropertyChanged("MACs"); } } }

        private String _InstallPath;
        /// <summary>安装路径</summary>
        [DisplayName("安装路径")]
        [Description("安装路径")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("InstallPath", "安装路径", "")]
        public String InstallPath { get => _InstallPath; set { if (OnPropertyChanging("InstallPath", value)) { _InstallPath = value; OnPropertyChanged("InstallPath"); } } }

        private String _Runtime;
        /// <summary>运行时。.Net版本</summary>
        [DisplayName("运行时")]
        [Description("运行时。.Net版本")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Runtime", "运行时。.Net版本", "")]
        public String Runtime { get => _Runtime; set { if (OnPropertyChanging("Runtime", value)) { _Runtime = value; OnPropertyChanged("Runtime"); } } }

        private Int32 _ProvinceID;
        /// <summary>省份</summary>
        [DisplayName("省份")]
        [Description("省份")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ProvinceID", "省份", "")]
        public Int32 ProvinceID { get => _ProvinceID; set { if (OnPropertyChanging("ProvinceID", value)) { _ProvinceID = value; OnPropertyChanged("ProvinceID"); } } }

        private Int32 _CityID;
        /// <summary>城市</summary>
        [DisplayName("城市")]
        [Description("城市")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CityID", "城市", "")]
        public Int32 CityID { get => _CityID; set { if (OnPropertyChanging("CityID", value)) { _CityID = value; OnPropertyChanged("CityID"); } } }

        private String _Address;
        /// <summary>地址</summary>
        [DisplayName("地址")]
        [Description("地址")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Address", "地址", "")]
        public String Address { get => _Address; set { if (OnPropertyChanging("Address", value)) { _Address = value; OnPropertyChanged("Address"); } } }

        private Int32 _Logins;
        /// <summary>登录次数</summary>
        [DisplayName("登录次数")]
        [Description("登录次数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Logins", "登录次数", "")]
        public Int32 Logins { get => _Logins; set { if (OnPropertyChanging("Logins", value)) { _Logins = value; OnPropertyChanged("Logins"); } } }

        private DateTime _LastLogin;
        /// <summary>最后登录</summary>
        [DisplayName("最后登录")]
        [Description("最后登录")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastLogin", "最后登录", "")]
        public DateTime LastLogin { get => _LastLogin; set { if (OnPropertyChanging("LastLogin", value)) { _LastLogin = value; OnPropertyChanged("LastLogin"); } } }

        private String _LastLoginIP;
        /// <summary>最后IP。最后的公网IP地址</summary>
        [DisplayName("最后IP")]
        [Description("最后IP。最后的公网IP地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LastLoginIP", "最后IP。最后的公网IP地址", "")]
        public String LastLoginIP { get => _LastLoginIP; set { if (OnPropertyChanging("LastLoginIP", value)) { _LastLoginIP = value; OnPropertyChanged("LastLoginIP"); } } }

        private Int32 _OnlineTime;
        /// <summary>在线时长。单位，秒</summary>
        [DisplayName("在线时长")]
        [Description("在线时长。单位，秒")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("OnlineTime", "在线时长。单位，秒", "")]
        public Int32 OnlineTime { get => _OnlineTime; set { if (OnPropertyChanging("OnlineTime", value)) { _OnlineTime = value; OnPropertyChanged("OnlineTime"); } } }

        private Int32 _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "")]
        public Int32 CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "")]
        public Int32 UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get => _UpdateIP; set { if (OnPropertyChanging("UpdateIP", value)) { _UpdateIP = value; OnPropertyChanged("UpdateIP"); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Remark", "备注", "")]
        public String Remark { get => _Remark; set { if (OnPropertyChanging("Remark", value)) { _Remark = value; OnPropertyChanged("Remark"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID": return _ID;
                    case "Name": return _Name;
                    case "Code": return _Code;
                    case "Secret": return _Secret;
                    case "Enable": return _Enable;
                    case "Version": return _Version;
                    case "CompileTime": return _CompileTime;
                    case "OS": return _OS;
                    case "OSVersion": return _OSVersion;
                    case "MachineName": return _MachineName;
                    case "UserName": return _UserName;
                    case "Cpu": return _Cpu;
                    case "Memory": return _Memory;
                    case "TotalSize": return _TotalSize;
                    case "Dpi": return _Dpi;
                    case "Resolution": return _Resolution;
                    case "Processor": return _Processor;
                    case "CpuID": return _CpuID;
                    case "Uuid": return _Uuid;
                    case "MachineGuid": return _MachineGuid;
                    case "DiskID": return _DiskID;
                    case "MACs": return _MACs;
                    case "InstallPath": return _InstallPath;
                    case "Runtime": return _Runtime;
                    case "ProvinceID": return _ProvinceID;
                    case "CityID": return _CityID;
                    case "Address": return _Address;
                    case "Logins": return _Logins;
                    case "LastLogin": return _LastLogin;
                    case "LastLoginIP": return _LastLoginIP;
                    case "OnlineTime": return _OnlineTime;
                    case "CreateUserID": return _CreateUserID;
                    case "CreateTime": return _CreateTime;
                    case "CreateIP": return _CreateIP;
                    case "UpdateUserID": return _UpdateUserID;
                    case "UpdateTime": return _UpdateTime;
                    case "UpdateIP": return _UpdateIP;
                    case "Remark": return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "Code": _Code = Convert.ToString(value); break;
                    case "Secret": _Secret = Convert.ToString(value); break;
                    case "Enable": _Enable = value.ToBoolean(); break;
                    case "Version": _Version = Convert.ToString(value); break;
                    case "CompileTime": _CompileTime = value.ToDateTime(); break;
                    case "OS": _OS = Convert.ToString(value); break;
                    case "OSVersion": _OSVersion = Convert.ToString(value); break;
                    case "MachineName": _MachineName = Convert.ToString(value); break;
                    case "UserName": _UserName = Convert.ToString(value); break;
                    case "Cpu": _Cpu = value.ToInt(); break;
                    case "Memory": _Memory = value.ToInt(); break;
                    case "TotalSize": _TotalSize = value.ToInt(); break;
                    case "Dpi": _Dpi = Convert.ToString(value); break;
                    case "Resolution": _Resolution = Convert.ToString(value); break;
                    case "Processor": _Processor = Convert.ToString(value); break;
                    case "CpuID": _CpuID = Convert.ToString(value); break;
                    case "Uuid": _Uuid = Convert.ToString(value); break;
                    case "MachineGuid": _MachineGuid = Convert.ToString(value); break;
                    case "DiskID": _DiskID = Convert.ToString(value); break;
                    case "MACs": _MACs = Convert.ToString(value); break;
                    case "InstallPath": _InstallPath = Convert.ToString(value); break;
                    case "Runtime": _Runtime = Convert.ToString(value); break;
                    case "ProvinceID": _ProvinceID = value.ToInt(); break;
                    case "CityID": _CityID = value.ToInt(); break;
                    case "Address": _Address = Convert.ToString(value); break;
                    case "Logins": _Logins = value.ToInt(); break;
                    case "LastLogin": _LastLogin = value.ToDateTime(); break;
                    case "LastLoginIP": _LastLoginIP = Convert.ToString(value); break;
                    case "OnlineTime": _OnlineTime = value.ToInt(); break;
                    case "CreateUserID": _CreateUserID = value.ToInt(); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = value.ToInt(); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "UpdateIP": _UpdateIP = Convert.ToString(value); break;
                    case "Remark": _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得节点字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>编码。NodeKey</summary>
            public static readonly Field Code = FindByName("Code");

            /// <summary>密钥。NodeSecret</summary>
            public static readonly Field Secret = FindByName("Secret");

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName("Enable");

            /// <summary>版本</summary>
            public static readonly Field Version = FindByName("Version");

            /// <summary>编译时间</summary>
            public static readonly Field CompileTime = FindByName("CompileTime");

            /// <summary>操作系统</summary>
            public static readonly Field OS = FindByName("OS");

            /// <summary>系统版本</summary>
            public static readonly Field OSVersion = FindByName("OSVersion");

            /// <summary>机器名称</summary>
            public static readonly Field MachineName = FindByName("MachineName");

            /// <summary>用户名称</summary>
            public static readonly Field UserName = FindByName("UserName");

            /// <summary>CPU</summary>
            public static readonly Field Cpu = FindByName("Cpu");

            /// <summary>内存。单位M</summary>
            public static readonly Field Memory = FindByName("Memory");

            /// <summary>磁盘。应用所在盘，单位M</summary>
            public static readonly Field TotalSize = FindByName("TotalSize");

            /// <summary>像素点。默认96*96</summary>
            public static readonly Field Dpi = FindByName("Dpi");

            /// <summary>分辨率。例如1024*768</summary>
            public static readonly Field Resolution = FindByName("Resolution");

            /// <summary>处理器</summary>
            public static readonly Field Processor = FindByName("Processor");

            /// <summary>CPU标识</summary>
            public static readonly Field CpuID = FindByName("CpuID");

            /// <summary>唯一标识</summary>
            public static readonly Field Uuid = FindByName("Uuid");

            /// <summary>机器标识</summary>
            public static readonly Field MachineGuid = FindByName("MachineGuid");

            /// <summary>磁盘序列号</summary>
            public static readonly Field DiskID = FindByName("DiskID");

            /// <summary>网卡</summary>
            public static readonly Field MACs = FindByName("MACs");

            /// <summary>安装路径</summary>
            public static readonly Field InstallPath = FindByName("InstallPath");

            /// <summary>运行时。.Net版本</summary>
            public static readonly Field Runtime = FindByName("Runtime");

            /// <summary>省份</summary>
            public static readonly Field ProvinceID = FindByName("ProvinceID");

            /// <summary>城市</summary>
            public static readonly Field CityID = FindByName("CityID");

            /// <summary>地址</summary>
            public static readonly Field Address = FindByName("Address");

            /// <summary>登录次数</summary>
            public static readonly Field Logins = FindByName("Logins");

            /// <summary>最后登录</summary>
            public static readonly Field LastLogin = FindByName("LastLogin");

            /// <summary>最后IP。最后的公网IP地址</summary>
            public static readonly Field LastLoginIP = FindByName("LastLoginIP");

            /// <summary>在线时长。单位，秒</summary>
            public static readonly Field OnlineTime = FindByName("OnlineTime");

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName("UpdateIP");

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得节点字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>编码。NodeKey</summary>
            public const String Code = "Code";

            /// <summary>密钥。NodeSecret</summary>
            public const String Secret = "Secret";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>版本</summary>
            public const String Version = "Version";

            /// <summary>编译时间</summary>
            public const String CompileTime = "CompileTime";

            /// <summary>操作系统</summary>
            public const String OS = "OS";

            /// <summary>系统版本</summary>
            public const String OSVersion = "OSVersion";

            /// <summary>机器名称</summary>
            public const String MachineName = "MachineName";

            /// <summary>用户名称</summary>
            public const String UserName = "UserName";

            /// <summary>CPU</summary>
            public const String Cpu = "Cpu";

            /// <summary>内存。单位M</summary>
            public const String Memory = "Memory";

            /// <summary>磁盘。应用所在盘，单位M</summary>
            public const String TotalSize = "TotalSize";

            /// <summary>像素点。默认96*96</summary>
            public const String Dpi = "Dpi";

            /// <summary>分辨率。例如1024*768</summary>
            public const String Resolution = "Resolution";

            /// <summary>处理器</summary>
            public const String Processor = "Processor";

            /// <summary>CPU标识</summary>
            public const String CpuID = "CpuID";

            /// <summary>唯一标识</summary>
            public const String Uuid = "Uuid";

            /// <summary>机器标识</summary>
            public const String MachineGuid = "MachineGuid";

            /// <summary>磁盘序列号</summary>
            public const String DiskID = "DiskID";

            /// <summary>网卡</summary>
            public const String MACs = "MACs";

            /// <summary>安装路径</summary>
            public const String InstallPath = "InstallPath";

            /// <summary>运行时。.Net版本</summary>
            public const String Runtime = "Runtime";

            /// <summary>省份</summary>
            public const String ProvinceID = "ProvinceID";

            /// <summary>城市</summary>
            public const String CityID = "CityID";

            /// <summary>地址</summary>
            public const String Address = "Address";

            /// <summary>登录次数</summary>
            public const String Logins = "Logins";

            /// <summary>最后登录</summary>
            public const String LastLogin = "LastLogin";

            /// <summary>最后IP。最后的公网IP地址</summary>
            public const String LastLoginIP = "LastLoginIP";

            /// <summary>在线时长。单位，秒</summary>
            public const String OnlineTime = "OnlineTime";

            /// <summary>创建者</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }

    /// <summary>节点接口</summary>
    public partial interface INode
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>编码。NodeKey</summary>
        String Code { get; set; }

        /// <summary>密钥。NodeSecret</summary>
        String Secret { get; set; }

        /// <summary>启用</summary>
        Boolean Enable { get; set; }

        /// <summary>版本</summary>
        String Version { get; set; }

        /// <summary>编译时间</summary>
        DateTime CompileTime { get; set; }

        /// <summary>操作系统</summary>
        String OS { get; set; }

        /// <summary>系统版本</summary>
        String OSVersion { get; set; }

        /// <summary>机器名称</summary>
        String MachineName { get; set; }

        /// <summary>用户名称</summary>
        String UserName { get; set; }

        /// <summary>CPU</summary>
        Int32 Cpu { get; set; }

        /// <summary>内存。单位M</summary>
        Int32 Memory { get; set; }

        /// <summary>磁盘。应用所在盘，单位M</summary>
        Int32 TotalSize { get; set; }

        /// <summary>像素点。默认96*96</summary>
        String Dpi { get; set; }

        /// <summary>分辨率。例如1024*768</summary>
        String Resolution { get; set; }

        /// <summary>处理器</summary>
        String Processor { get; set; }

        /// <summary>CPU标识</summary>
        String CpuID { get; set; }

        /// <summary>唯一标识</summary>
        String Uuid { get; set; }

        /// <summary>机器标识</summary>
        String MachineGuid { get; set; }

        /// <summary>磁盘序列号</summary>
        String DiskID { get; set; }

        /// <summary>网卡</summary>
        String MACs { get; set; }

        /// <summary>安装路径</summary>
        String InstallPath { get; set; }

        /// <summary>运行时。.Net版本</summary>
        String Runtime { get; set; }

        /// <summary>省份</summary>
        Int32 ProvinceID { get; set; }

        /// <summary>城市</summary>
        Int32 CityID { get; set; }

        /// <summary>地址</summary>
        String Address { get; set; }

        /// <summary>登录次数</summary>
        Int32 Logins { get; set; }

        /// <summary>最后登录</summary>
        DateTime LastLogin { get; set; }

        /// <summary>最后IP。最后的公网IP地址</summary>
        String LastLoginIP { get; set; }

        /// <summary>在线时长。单位，秒</summary>
        Int32 OnlineTime { get; set; }

        /// <summary>创建者</summary>
        Int32 CreateUserID { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>更新者</summary>
        Int32 UpdateUserID { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}