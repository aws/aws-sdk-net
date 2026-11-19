using ServiceClientGenerator.Generators.NuGet;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class CoreNuspecTests
    {
        private static readonly string[] CoreTargetFrameworks = { "net472", "netstandard2.0", "net8.0", "net10.0", "net11.0" };

        [Fact]
        public void EveryTargetFrameworkDependsOnNumerics()
        {
            var nuspec = new CoreNuspec
            {
                Session = new Dictionary<string, object>
                {
                    { "FileVersion", "4.1.0.0" },
                    { "NuGetPreviewFlag", "" },
                    { "NumericsVersionRange", "[4.0.0.2, 5.0)" }
                }
            };

            var document = XDocument.Parse(nuspec.TransformText().Trim());
            var groups = document.Descendants("group").ToList();

            Assert.Equal(CoreTargetFrameworks, groups.Select(g => (string)g.Attribute("targetFramework")));
            foreach (var group in groups)
            {
                var numerics = group.Elements("dependency").Single(d => (string)d.Attribute("id") == "AWSSDK.Extensions.Numerics");
                Assert.Equal("[4.0.0.2, 5.0)", (string)numerics.Attribute("version"));
            }
        }
    }
}
