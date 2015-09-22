using System.Collections.Generic;

namespace RestaurantManager.UniversalWindows
{
    class DataManagerResourceLoader : Windows.UI.Xaml.Resources.CustomXamlResourceLoader
    {
        protected override object GetResource(string resourceId, string objectType, string propertyName, string propertyType)
        {
            return _resources[resourceId];
        }

        private System.Collections.Generic.Dictionary<string, object> _resources
            = new Dictionary<string, object>()
            {
                { "DataManager", new RestaurantManager.Models.DataManager() }
            };
    }
}