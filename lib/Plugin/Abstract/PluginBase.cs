using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Базовая реализация интерфейса IPlugin
    /// </summary>
    internal abstract class PluginBase : IPlugin
    {
        public abstract string PluginName { get; }

        public abstract string Version { get; }

        public abstract Image Image { get; }

        public abstract string Description { get; }

        public abstract int Run(int value1, int value2);

    }
}
