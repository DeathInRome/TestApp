

namespace ds.test.impl
{
    /// <summary>
    /// Контейнер с плагинами
    /// </summary>
    public  class Plugins : IPluginFactory
    {
        //Коллекия плагинов
        private static readonly List<IPlugin> _plugins = new();

        /// <summary>
        /// Вернуть число записей
        /// </summary>
        public int? PluginsCount => _plugins?.Count;

        /// <summary>
        /// Получить список имен плагинов
        /// </summary>
        public string[] GetPluginNames => _plugins
            .Select(name => name.PluginName)
            .ToArray();

        /// <summary>
        /// Вернуть плагин по имени
        /// </summary>
        public IPlugin GetPlugin(string namePlugin)
        {
            if(_plugins.Count<1)
                throw new ArgumentNullException($"Коллекция с плагинами пуста.");

            IPlugin? plugin = _plugins
                .SingleOrDefault(plugin => plugin.PluginName == namePlugin);

            return plugin ?? throw new InvalidOperationException($"Отсутствует плагин {namePlugin}");
        }

        /// <summary>
        /// Метод для добавления новых плагинов
        /// </summary>
        public void RegisterPlugin(IPlugin plugin)
        {
            if (plugin == null)
                throw new ArgumentNullException(nameof(plugin));

            _plugins.Add(plugin);
        }
    }
}
