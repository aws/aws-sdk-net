using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System.IO;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [Trait("Category", "General")]
    public class CredentialsTests
    {
        [Fact]
        public void TestCredentialsFile()
        {
            var ic = new ImmutableCredentials("access-key", "secret-key", null);
            TestCredentialsFile(ic);
            ic = new ImmutableCredentials("access-key", "secret-key", "token");
            TestCredentialsFile(ic);
        }

        private static void TestCredentialsFile(ImmutableCredentials ic)
        {
            var profileName = "testProfile";
            var profilesLocation = WriteCreds(profileName, ic);

            var sharedCredentialsFile = new SharedCredentialsFile(profilesLocation);
            CredentialProfile credentialProfile;
            sharedCredentialsFile.TryGetProfile(profileName, out credentialProfile);
            var awsCredentials = credentialProfile.GetAWSCredentials(sharedCredentialsFile);
            var rc = awsCredentials.GetCredentials();

            Assert.Equal(ic.SecretKey, rc.SecretKey);
            Assert.Equal(ic.AccessKey, rc.AccessKey);
            Assert.Equal(ic.UseToken, rc.UseToken);
            Assert.Equal(ic.Token, rc.Token);

            for (int i = 0; i < 4; i++)
            {
                var shouldHaveToken = (i % 2 == 1);
                sharedCredentialsFile.TryGetProfile(profileName + i, out credentialProfile);
                Assert.NotNull(credentialProfile);

                rc = credentialProfile.GetAWSCredentials(sharedCredentialsFile).GetCredentials();
                Assert.NotNull(rc.AccessKey);
                Assert.NotNull(rc.SecretKey);
                Assert.Equal(shouldHaveToken, rc.UseToken);

                if (rc.UseToken)
                {
                    Assert.Equal(sessionCreds.AccessKey, rc.AccessKey);
                    Assert.Equal(sessionCreds.SecretKey, rc.SecretKey);
                    Assert.Equal(sessionCreds.Token, rc.Token);
                }
                else
                {
                    Assert.Equal(basicCreds.AccessKey, rc.AccessKey);
                    Assert.Equal(basicCreds.SecretKey, rc.SecretKey);
                }
            }
        }

        private static ImmutableCredentials basicCreds = new ImmutableCredentials("=ac0", "sc=1", null);
        private static ImmutableCredentials sessionCreds = new ImmutableCredentials("ac2", "sc3=", "token==");

        private static string WriteCreds(string profileName, ImmutableCredentials ic)
        {
            string configPath = Path.GetFullPath("credentials");
            using (var stream = File.Open(configPath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (var writer = new StreamWriter(stream))
            {
                AppendCredentialsSet(writer, profileName + "0", basicCreds);
                AppendCredentialsSet(writer, profileName + "1", sessionCreds);
                AppendCredentialsSet(writer, profileName, ic);
                AppendCredentialsSet(writer, profileName + "2", basicCreds);
                AppendCredentialsSet(writer, profileName + "3", sessionCreds);
            }

            return configPath;
        }

        private static void AppendCredentialsSet(StreamWriter writer, string profileName, ImmutableCredentials ic)
        {
            writer.WriteLine();
            writer.WriteLine("; profile {0} and its credentials", profileName);
            writer.WriteLine("# alternative comment marker");
            writer.WriteLine("[{0}]", profileName);
            writer.WriteLine("aws_access_key_id = {0}", ic.AccessKey);
            writer.WriteLine("aws_secret_access_key={0}", ic.SecretKey);
            if (ic.UseToken)
                writer.WriteLine("aws_session_token= {0}", ic.Token);
            writer.WriteLine();
        }
    }
}
