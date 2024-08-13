using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Amazon.EC2.Model;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon;
using Amazon.Runtime;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests.Custom.Custom.Runtime
{
    [TestClass]
    public class ServiceSpecificEndpointTests
    {
        //These are here and not in SharedCredentialsFileTest.cs because we are testing
        //the endpoint_url that is hit (via the Client Config's ServiceUrl) when Environment
        //variables are set and set in config files.

        private static readonly string TestingProfile = new StringBuilder()
            .AppendLine("[profile default]")
            .AppendLine("aws_access_key_id=123")
            .AppendLine("aws_secret_access_key=456")
            .AppendLine("[profile service_global_only]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .AppendLine("endpoint_url=https://global.endpoint.aws")
            .AppendLine("[profile service_specific_s3]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .AppendLine("services=service_specific_s3")
            .AppendLine("[profile global_and_service_specific_s3]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .AppendLine("endpoint_url=https://global.endpoint.aws")
            .AppendLine("services=service_specific_s3")
            .AppendLine("[services service_specific_s3]")
            .AppendLine("s3=")
            .AppendLine("\tendpoint_url     =     https://s3.endpoint.aws")
            .AppendLine("[services service_specific_dynamo_db]")
            .AppendLine("dynamo_db=")
            .AppendLine("\tendpoint_url=https://s3.endpoint.aws")
            .ToString();
        private static readonly string ClientConfigProvidedEndpointUrl = "https://client-config.endpoint.aws/";

        private static readonly string GLOBAL_ENVIRONMENT_VARIABLE = "AWS_ENDPOINT_URL";

        private static readonly string SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE = "AWS_ENDPOINT_URL_S3";

        private static readonly string GlobalEnvironmentVariableEndpointUrl = "https://global-from-envvar.endpoint.aws/";
        private static readonly string ServiceSpecificS3EnvironmentVariableEndpointUrl = "https://s3-from-envvar.endpoint.aws/";


        CredentialProfile profile = null;

        [TestMethod]
        public void ReadGlobalEndpointUrl()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = "https://global.endpoint.aws/"; //We add a slash to the end of all urls, so the expected endpoint should have a /
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;

                    try
                    {
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        AWSConfigs.AWSProfileName = profile.Name;
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }

        [TestMethod]
        public void ReadServiceSpecificEndpoint()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = "https://s3.endpoint.aws/";
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    try
                    {
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        AWSConfigs.AWSProfileName = profile.Name;
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointTakesPrecedenceOverGlobalInConfigFile()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = "https://s3.endpoint.aws/";
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    try
                    {
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        AWSConfigs.AWSProfileName = profile.Name;
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                    }
                }
            }
        }
        [TestMethod]
        public void GlobalEndpointEnvVariableTakesPrecedenceOverDefaultValue()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = GlobalEnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("default", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {

                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);

                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName= savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation= savedProfileLocation;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE,savedGlobalEnvVariable);
                    }

   
                }
            }
        }
        [TestMethod]
        public void GlobalEndpointEnvVariableTakesPrecedenceOverGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = GlobalEnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        using(var client = new AmazonS3Client())
                        {

                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }

        [TestMethod]
        public void GlobalEndpointEnvVariableTakesPrecedenceOverGlobalAndServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = GlobalEnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {

                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {                       
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverDefault()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("default", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;

                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using(var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;

                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;

                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverServicesSectionAndGlobalEndpointUrlInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;

                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverGlobalEndpointEnvVariable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;

                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverGlobalEndpointEnvVariableAndGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverGlobalEndpointEnvVariableAndServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))

            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ServiceSpecificEndpointEnvVariableTakesPrecedenceOverGlobalEndpointEnvVariableAndServiceSpecificAndGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ServiceSpecificS3EnvironmentVariableEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    var savedProfileEnv = AWSConfigs.AWSProfileName;
                    var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                    var savedServiceSpecificS3EnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                    var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                        using (var client = new AmazonS3Client())
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificS3EnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverDefaultValue()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("default", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        AWSConfigs.AWSProfileName = profile.Name;
                        AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using(var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverGlobalEndpointInServicesSection()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointUrlInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointInConfigAndGlobalEndpointinConfigFile()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverGlobalEndpointEnvVariable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("default", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverGlobalEndpointEnvVariableAndGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverGlobalEndpointEnvVaraibleAndServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverGlobalEndpointEnvVariableAndGlobalAndServiceSpecificEndpointsInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("default", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableAndGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableAndServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableServicesSpecificEndpointInConfigAndGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                    }
                }

            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableAndGlobalEndpointEnvVariable()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                var savedServiceSpecificEnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                if (configFile.TryGetProfile("default", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                    Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificEnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableGlobalEndpointEnvVariableandGlobalEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                var savedServiceSpecificEnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                if (configFile.TryGetProfile("service_global_only", out profile))
                {
                    
                    //AWSConfigs.AWSProfileName = profile.Name;
                    //AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                    Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                    try
                    {
                        var config = new AmazonS3Config();
                        //Testing with new Profile property added to ClientConfig
                        config.Profile = new Profile("service_global_only", sharedCredentialsFile.ConfigFilePath);
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificEnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverServiceSpecificEndpointEnvVariableGlobalEndpointEnvVariableAndServiceSpecificEndpointInConfig()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;

                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                var savedServiceSpecificEnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                if (configFile.TryGetProfile("service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                    Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificEnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
        [TestMethod]
        public void ClientConfigTakesPrecedenceOverAllOtherEndpointUrlsSet()
        {
            using (var sharedCredentialsFile = new SharedCredentialsFileTestFixture(credentialsFileContents: null, configFileContents: TestingProfile))
            {
                string expectedEndpoint = ClientConfigProvidedEndpointUrl;
                var configFile = sharedCredentialsFile.CredentialsFile;
                var savedProfileEnv = AWSConfigs.AWSProfileName;
                var savedProfileLocation = AWSConfigs.AWSProfilesLocation;
                var savedServiceSpecificEnvVariable = Environment.GetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE);
                var savedGlobalEnvVariable = Environment.GetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE);
                if (configFile.TryGetProfile("global_and_service_specific_s3", out profile))
                {
                    AWSConfigs.AWSProfileName = profile.Name;
                    AWSConfigs.AWSProfilesLocation = sharedCredentialsFile.ConfigFilePath;
                    Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, ServiceSpecificS3EnvironmentVariableEndpointUrl);
                    Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, GlobalEnvironmentVariableEndpointUrl);
                    try
                    {
                        var config = new AmazonS3Config();
                        config.ServiceURL = ClientConfigProvidedEndpointUrl;

                        using (var client = new AmazonS3Client(config))
                        {
                            Assert.AreEqual<string>(expectedEndpoint, client.Config.ServiceURL);
                        }
                    }
                    finally
                    {
                        AWSConfigs.AWSProfileName = savedProfileEnv;
                        AWSConfigs.AWSProfilesLocation = savedProfileLocation;
                        Environment.SetEnvironmentVariable(SERVICE_SPECIFIC_S3_ENVIRONMENT_VARIABLE, savedServiceSpecificEnvVariable);
                        Environment.SetEnvironmentVariable(GLOBAL_ENVIRONMENT_VARIABLE, savedGlobalEnvVariable);
                    }
                }
            }
        }
    }
}
