using System;
using Amazon.Extensions.NETCore.Setup;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Configuration.AWSSystemsManagerTests
{
    public class AWSSystemsManagerExtensionsTests
    {
        [Theory, MemberData(nameof(SourceExtensionData))]
        public void AddAWSSystemsManagerExtensionWithSourceTest(AWSOptions awsOptions, string path, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            Func<IConfigurationBuilder> executeBuilder = () => builder.AddAWSSystemsManager(source =>
            {
                source.AwsOptions = awsOptions;
                source.Path = path;
                source.ReloadAfter = reloadAfter;
                source.OnLoadException = onLoadException;
            });

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>(executeBuilder);
            }
            else
            {
                var result = executeBuilder();
                Assert.Equal(builder, result);
            }
        }

        [Theory, MemberData(nameof(WithAWSOptionsExtentionData))]
        public void AddAWSSystemsManagerWithAWSOptionsTest(AWSOptions awsOptions, string path, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            Func<IConfigurationBuilder> executeBuilder = () => builder.AddAWSSystemsManager(awsOptions, path, reloadAfter, onLoadException);

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>(executeBuilder);
            }
            else
            {
                var result = executeBuilder();
                Assert.Equal(builder, result);
            }
        }

        [Theory, MemberData(nameof(NoAWSOptionsExtensionData))]
        public void AddAWSSystemsManagerWithNoAWSOptionsTest(string path, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            Func<IConfigurationBuilder> executeBuilder = () => builder.AddAWSSystemsManager(path, reloadAfter, onLoadException);

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>(executeBuilder);
            }
            else
            {
                var result = executeBuilder();
                Assert.Equal(builder, result);
            }
        }

        public static TheoryData<AWSOptions, string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> SourceExtensionData =>  
            new TheoryData<AWSOptions, string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, null, null, null, true},
                {null, "/path", null, null, false}
            };

        public static TheoryData<AWSOptions, string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> WithAWSOptionsExtentionData =>  
            new TheoryData<AWSOptions, string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, null, null, null, true},
                {null, "/path", null, null, true},
                {new AWSOptions(), null, null, null, true},
                {new AWSOptions(), "/path", null, null, false}
            };

        public static TheoryData<string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> NoAWSOptionsExtensionData =>  
            new TheoryData<string, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, null, null, true},
                {"/path", null, null, false}
            };
    }
}
