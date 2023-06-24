using System;
using System.IO;
using System.Linq;

namespace ServiceClientGeneratorTests
{
    public class EmbeddedResourceHelper
    {
        public string LoadContent(string resourceNamespace)
        {
            var allResources = GetType().Assembly.GetManifestResourceNames();

            if (!allResources.Contains(resourceNamespace))
                throw new ArgumentException(
                    $"Could not find Resource [{resourceNamespace}]. " +
                    $"Have {string.Join(",", allResources)}");

            var contents = GetType().Assembly.GetManifestResourceStream(resourceNamespace) ?? new MemoryStream();
            
            using (var sr = new StreamReader(contents))
                return sr.ReadToEnd();
        }
    }
}
