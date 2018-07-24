using System;
using Amazon.Extensions.Configuration.AWSSystemsManager;
using Amazon.Extensions.NETCore.Setup;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Configuration.AWSSystemsManagerTests
{
    public class AWSSystemsManagerExtensionsTests
    {
        [Theory, MemberData(nameof(SourceExtensionData))]
        public void AddAWSSystemsManagerExtensionWithSourceTest(AWSOptions awsOptions, string path, bool optional, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            IConfigurationBuilder ExecuteBuilder() =>
                builder.AddAWSSystemsManager(source =>
                {
                    source.AwsOptions = awsOptions;
                    source.Path = path;
                    source.Optional = optional;
                    source.ReloadAfter = reloadAfter;
                    source.OnLoadException = onLoadException;
                });

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>((Func<IConfigurationBuilder>)ExecuteBuilder);
            }
            else
            {
                var result = ExecuteBuilder();
                Assert.Equal(builder, result);
            }
        }

        [Theory, MemberData(nameof(WithAWSOptionsExtentionData))]
        public void AddAWSSystemsManagerWithAWSOptionsTest(AWSOptions awsOptions, string path, bool optional, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            IConfigurationBuilder ExecuteBuilder() => builder.AddAWSSystemsManager(awsOptions, path, optional, reloadAfter, onLoadException);

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>((Func<IConfigurationBuilder>)ExecuteBuilder);
            }
            else
            {
                var result = ExecuteBuilder();
                Assert.Equal(builder, result);
            }
        }

        [Theory, MemberData(nameof(NoAWSOptionsExtensionData))]
        public void AddAWSSystemsManagerWithNoAWSOptionsTest(string path, bool optional, TimeSpan? reloadAfter, Action<AWSSystemsManagerExceptionContext> onLoadException, bool throwsArgumentNullException)
        {
            var builder = new ConfigurationBuilder();

            IConfigurationBuilder ExecuteBuilder() => builder.AddAWSSystemsManager(path, optional, reloadAfter, onLoadException);

            if (throwsArgumentNullException)
            {
                Assert.Throws<ArgumentNullException>((Func<IConfigurationBuilder>) ExecuteBuilder);
            }
            else
            {
                var result = ExecuteBuilder();
                Assert.Equal(builder, result);
            }
        }

        public static TheoryData<AWSOptions, string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> SourceExtensionData =>
            new TheoryData<AWSOptions, string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, null, false, null, null, true},
                {null, null, true, null, null, true},
                {null, "/path", false, null, null, false}
            };

        public static TheoryData<AWSOptions, string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> WithAWSOptionsExtentionData =>
            new TheoryData<AWSOptions, string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, null, false, null, null, true},
                {null, "/path", false, null, null, true},
                {new AWSOptions(), null, false, null, null, true},
                {new AWSOptions(), "/path", false, null, null, false}
            };

        public static TheoryData<string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool> NoAWSOptionsExtensionData =>
            new TheoryData<string, bool, TimeSpan?, Action<AWSSystemsManagerExceptionContext>, bool>
            {
                {null, false, null, null, true},
                {"/path", false, null, null, false}
            };
    }
}
