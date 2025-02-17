using Castle.Core.Internal;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AWSSDK_NetStandard.UnitTests
{
    public class Utils
    {   
        public static Stream GetAssemblyResourceStream(string resourceName)
        {
            Assembly assembly = typeof(Utils).GetTypeInfo().Assembly;
            var names = assembly.GetManifestResourceNames();
            var fullResourceName = names.First((name) => name.EndsWith(resourceName));
            return assembly.GetManifestResourceStream(fullResourceName);
        }
    }
}