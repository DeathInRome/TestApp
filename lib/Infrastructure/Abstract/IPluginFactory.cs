namespace ds.test.impl
{
    public interface IPluginFactory
    {
         int PluginsCount { get; }
         string[]? GetPluginNames { get; }
         IPlugin GetPlugin(string namePlugin);
    }
}
