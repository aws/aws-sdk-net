using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Runtime;
using Amazon;
using Amazon.S3;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon.Runtime.CredentialManagement;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CredentialsTests
    {
        [TestMethod]
        [TestCategory("General")]
        [TestCategory("RequiresIAMUser")]
        public void TestSessionCredentials()
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;

                using (var ec2 = new Amazon.EC2.AmazonEC2Client(credentials))
                {
                    var regions = ec2.DescribeRegions().Regions;
                    Console.WriteLine(regions.Count);
                }

                using (var s3 = new Amazon.S3.AmazonS3Client(credentials))
                {
                    var buckets = s3.ListBuckets().Buckets;
                    Console.WriteLine(buckets.Count);
                }

                using (var swf = new Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient(credentials))
                {
                    var domains = swf.ListDomains(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).DomainInfos;
                    Console.WriteLine(domains.Infos.Count);
                }
            }
        }

        [TestMethod]
        [TestCategory("General")]
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
            
            Assert.AreEqual(ic.SecretKey, rc.SecretKey);
            Assert.AreEqual(ic.AccessKey, rc.AccessKey);
            Assert.AreEqual(ic.UseToken, rc.UseToken);
            Assert.AreEqual(ic.Token, rc.Token);

            for (int i = 0; i < 4; i++)
            {
                var shouldHaveToken = (i % 2 == 1);
                sharedCredentialsFile.TryGetProfile(profileName + i, out credentialProfile);
                Assert.IsNotNull(credentialProfile);


                rc = credentialProfile.GetAWSCredentials(sharedCredentialsFile).GetCredentials();
                Assert.IsNotNull(rc.AccessKey);
                Assert.IsNotNull(rc.SecretKey);
                Assert.AreEqual(shouldHaveToken, rc.UseToken);

                if (rc.UseToken)
                {
                    Assert.AreEqual(sessionCreds.AccessKey, rc.AccessKey);
                    Assert.AreEqual(sessionCreds.SecretKey, rc.SecretKey);
                    Assert.AreEqual(sessionCreds.Token, rc.Token);
                }
                else
                {
                    Assert.AreEqual(basicCreds.AccessKey, rc.AccessKey);
                    Assert.AreEqual(basicCreds.SecretKey, rc.SecretKey);
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
