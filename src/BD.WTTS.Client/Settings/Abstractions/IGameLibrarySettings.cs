#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
// <console-tools-generated/>
#pragma warning restore SA1634 // File header should show copyright
#pragma warning restore IDE0079 // 请删除不必要的忽略
// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings.Abstractions;

public interface IGameLibrarySettings
{
    static IGameLibrarySettings? Instance
        => Ioc.Get_Nullable<IOptionsMonitor<IGameLibrarySettings>>()?.CurrentValue;

    /// <summary>
    /// 已安装游戏筛选
    /// </summary>
    bool? GameInstalledFilter { get; set; }

    /// <summary>
    /// 已安装游戏筛选的默认值
    /// </summary>
    const bool DefaultGameInstalledFilter = false;

    /// <summary>
    /// 支持云存档游戏筛选状态
    /// </summary>
    bool? GameCloudArchiveFilter { get; set; }

    /// <summary>
    /// 支持云存档游戏筛选状态的默认值
    /// </summary>
    const bool DefaultGameCloudArchiveFilter = false;

    /// <summary>
    /// 游戏类型筛选状态列表
    /// </summary>
    List<SteamAppType>? GameTypeFiltres { get; set; }

    /// <summary>
    /// 游戏类型筛选状态列表的默认值
    /// </summary>
    static readonly List<SteamAppType> DefaultGameTypeFiltres = new List<SteamAppType> { SteamAppType.Game, SteamAppType.Application, SteamAppType.Demo, SteamAppType.Beta };

    /// <summary>
    /// 隐藏的游戏列表
    /// </summary>
    Dictionary<uint, string?>? HideGameList { get; set; }

    /// <summary>
    /// 隐藏的游戏列表的默认值
    /// </summary>
    const Dictionary<uint, string?> DefaultHideGameList = null;

    /// <summary>
    /// 挂时长游戏列表
    /// </summary>
    Dictionary<uint, string?>? AFKAppList { get; set; }

    /// <summary>
    /// 挂时长游戏列表的默认值
    /// </summary>
    const Dictionary<uint, string?> DefaultAFKAppList = null;

    /// <summary>
    /// 启用自动挂机
    /// </summary>
    bool? IsAutoAFKApps { get; set; }

    /// <summary>
    /// 启用自动挂机的默认值
    /// </summary>
    const bool DefaultIsAutoAFKApps = true;

}
