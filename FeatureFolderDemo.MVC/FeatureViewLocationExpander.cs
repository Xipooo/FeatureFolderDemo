using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;

namespace FeatureFolderDemo.MVC
{
    public class FeatureViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            return new List<string> {
                "/Features/{1}/Views/{0}.cshtml",
                "/Features/Shared/Views/{0}.cshtml"
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {

        }
    }
}
