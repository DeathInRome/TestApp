﻿namespace ds.test.impl
{
    /// <summary>
    /// Контейнер с плагинами
    /// </summary>
    internal class Plugins : IPluginFactory
    {
        //Список плагинов
        private static readonly List<PluginBase> _plugins = new();

        /// <summary>
        /// Вернуть число записей
        /// </summary>
        public int PluginsCount => _plugins.Count;

        /// <summary>
        /// Получить список имен плагинов
        /// </summary>
        public string[]? GetPluginNames
        {
            get
            {
                if (_plugins.Count < 1)
                    throw new ArgumentNullException("Отсутствуют плагины");

                string[]? pluginNames = _plugins?
                    .Select(name => name.PluginName)
                    .ToArray();

                return pluginNames;
            }
        }

        /// <summary>
        /// Вернуть плагин по имени
        /// </summary>
        public IPlugin GetPlugin(string namePlugin)
        {
            if (_plugins.Count < 1)
                throw new ArgumentNullException($"Отсутствуют плагин {namePlugin}");

            PluginBase? plugin = _plugins
                .SingleOrDefault(plugin => plugin.PluginName == namePlugin);

            return plugin ?? throw new InvalidOperationException($"Отсутствует плагин {namePlugin}");
        }

        /// <summary>
        /// Метод для добавления новых плагинов
        /// </summary>
        public void RegisterPlugin(PluginBase plugin)
        {
            if (plugin == null)
                throw new ArgumentNullException($"Пустой аргумент {plugin}");

            _plugins.Add(plugin);
        }
    }
}
