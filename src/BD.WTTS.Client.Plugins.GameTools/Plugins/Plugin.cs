using BD.WTTS.Properties;

namespace BD.WTTS.Plugins;

#if (WINDOWS || MACCATALYST || MACOS || LINUX) && !(IOS || ANDROID)
[CompositionExport(typeof(IPlugin))]
#endif
public sealed class Plugin : PluginBase<Plugin>, IPlugin
{
    const string moduleName = AssemblyInfo.GameTools;

    public override Guid Id => Guid.Parse(AssemblyInfo.GameToolsId);

    public override string Name => Strings.GameRelated;

    public sealed override string UniqueEnglishName => moduleName;

    public sealed override string Description => "游戏工具";

    protected sealed override string? AuthorOriginalString => null;

    public sealed override object? Icon => new MemoryStream(Resources.toolbox); //"avares://BD.WTTS.Client.Plugins.GameTools/UI/Assets/toolbox.ico";

    public override IEnumerable<TabItemViewModel>? GetMenuTabItems()
    {
        yield return new MenuTabItemViewModel()
        {
            ResourceKeyOrName = nameof(Strings.GameRelated),
            PageType = null,
            IsResourceGet = true,
            IconKey = Icon,
        };
    }

    public override void ConfigureDemandServices(IServiceCollection services, Startup startup)
    {
    }

    public override void ConfigureRequiredServices(IServiceCollection services, Startup startup)
    {
    }

    public override void OnAddAutoMapper(IMapperConfigurationExpression cfg)
    {

    }
}
