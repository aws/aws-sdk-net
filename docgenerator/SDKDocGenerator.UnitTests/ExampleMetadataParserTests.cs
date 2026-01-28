using System;
using System.IO;
using System.Linq;
using Xunit;

namespace SDKDocGenerator.UnitTests
{
    public class ExampleMetadataParserTests
    {
        private readonly string _testMetaJsonPath;

        public ExampleMetadataParserTests()
        {
            _testMetaJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "SDKDocGenerator", "example_meta.json");
        }

        [Fact]
        public void GenerateExampleFragments_WithValidFile_ShouldSetFragmentsPath()
        {
            ExampleMetadataParser.GenerateExampleFragments(_testMetaJsonPath);

            try
            {
                Assert.False(string.IsNullOrEmpty(ExampleMetadataParser.ExampleFragmentsFullPath));
                Assert.True(Directory.Exists(ExampleMetadataParser.ExampleFragmentsFullPath));
            }
            finally
            {
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }

        [Fact]
        public void GenerateExampleFragments_WithValidFile_ShouldCreateControlTowerFragment()
        {
            ExampleMetadataParser.GenerateExampleFragments(_testMetaJsonPath);
            try
            {
                var fragmentPath = Path.Combine(ExampleMetadataParser.ExampleFragmentsFullPath, "ControlTower.fragment.html");
                Assert.True(File.Exists(fragmentPath));

                var content = File.ReadAllText(fragmentPath);
                Assert.Contains("<a href=\"https://docs.aws.amazon.com/code-library/latest/ug/dotnet_4_controltower_code_examples.html\" target=\"_blank\">AWS SDK Code Examples Code Library</a>", content);
                Assert.Contains("<h3 class=\"\">Api</h3>", content);
                Assert.Contains("Use DisableBaseline", content);
                Assert.Contains("Use DisableControl", content);
                Assert.Contains("Use EnableBaseline", content);
                Assert.Contains("Use EnableControl", content);
                Assert.Contains("Use GetBaselineOperation", content);
                Assert.Contains("Use GetControlOperation", content);
                Assert.Contains("Use ListBaselines", content);
                Assert.Contains("Use ListEnabledBaselines", content);
                Assert.Contains("Use ListEnabledControls", content);
                Assert.Contains("Use ListLandingZones", content);
                Assert.Contains("Use ResetEnabledBaseline", content);                
            }
            finally
            {
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }

        [Fact]
        public void GenerateExampleFragments_WithNonExistentFile_ShouldNotThrow()
        {
            var nonExistentPath = Path.Combine(Path.GetTempPath(), "nonexistent.json");
            try
            {
                var exception = Record.Exception(() => ExampleMetadataParser.GenerateExampleFragments(nonExistentPath));
                Assert.Null(exception);
            }
            finally
            {
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }

        [Fact]
        public void CleanupExampleFragments_ShouldRemoveDirectory()
        {
            ExampleMetadataParser.GenerateExampleFragments(_testMetaJsonPath);
            var fragmentsPath = ExampleMetadataParser.ExampleFragmentsFullPath;
            try
            {
                Assert.True(Directory.Exists(fragmentsPath));
            }
            finally
            {
                ExampleMetadataParser.CleanupExampleFragments();
            }
            
            Assert.False(Directory.Exists(fragmentsPath));
        }

        [Fact]
        public void CleanupExampleFragments_WithNullPath_ShouldNotThrow()
        {
            var exception = Record.Exception(() => ExampleMetadataParser.CleanupExampleFragments());
            Assert.Null(exception);
        }

        [Fact]
        public void SanitizeStringForClassName_ShouldRemoveAWSAndAmazon()
        {
            var result = ExampleMetadataParser.SanitizeStringForClassName("AWS Control Tower");
            Assert.Equal("ControlTower", result);
            
            result = ExampleMetadataParser.SanitizeStringForClassName("Amazon S3");
            Assert.Equal("S3", result);
        }

        [Fact]
        public void ToUpperFirstCharacter_ShouldCapitalizeFirstLetter()
        {
            var result = ExampleMetadataParser.ToUpperFirstCharacter("controlTower");
            Assert.Equal("ControlTower", result);
            
            result = ExampleMetadataParser.ToUpperFirstCharacter("s");
            Assert.Equal("S", result);
        }

        [Fact]
        public void GenerateExampleFragments_WithInvalidJson_ShouldCreateFailureFile()
        {
            var tempJsonFile = Path.GetTempFileName();
            var failureFile = Path.GetTempFileName();
            
            try
            {
                File.WriteAllText(tempJsonFile, "{ \"bad file\": \"test\"}");
                
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                
                ExampleMetadataParser.GenerateExampleFragments(tempJsonFile, failureFile);
                
                Assert.True(File.Exists(failureFile));
                var content = File.ReadAllText(failureFile);
                Assert.Contains("Failed to generate example fragments: System.Exception: Examples could not be found.", content);
            }
            finally
            {
                if (File.Exists(tempJsonFile))
                    File.Delete(tempJsonFile);
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }

        [Fact]
        public void GenerateExampleFragments_WithNullPath_ShouldCreateFailureFile()
        {
            var failureFile = Path.GetTempFileName();
            
            try
            {
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                
                ExampleMetadataParser.GenerateExampleFragments(null, failureFile);
                
                Assert.True(File.Exists(failureFile));
                var content = File.ReadAllText(failureFile);
                Assert.Contains("Example metadata file has not been specified.", content);
            }
            finally
            {
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }

        [Fact]
        public void GenerateExampleFragments_WithEmptyPath_ShouldCreateFailureFile()
        {
            var failureFile = Path.GetTempFileName();
            
            try
            {
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                
                ExampleMetadataParser.GenerateExampleFragments("", failureFile);
                
                Assert.True(File.Exists(failureFile));
                var content = File.ReadAllText(failureFile);
                Assert.Contains("Example metadata file has not been specified.", content);
            }
            finally
            {
                if (File.Exists(failureFile))
                    File.Delete(failureFile);
                ExampleMetadataParser.CleanupExampleFragments();
            }
        }
    }
}