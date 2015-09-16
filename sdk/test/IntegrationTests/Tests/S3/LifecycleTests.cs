using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests;
using AWSSDK_DotNet.IntegrationTests.Tests.S3;
using Amazon.S3.Util;

namespace S3UnitTest
{
    [TestClass]
    public class LifecycleTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucket(Client);
        }

        [TestCleanup]
        public void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        public void LifecycleTest1()
        {
            var s3Configuration = Client.GetLifecycleConfiguration(bucketName).Configuration;
            Assert.IsNotNull(s3Configuration);
            Assert.IsNotNull(s3Configuration.Rules);
            Assert.AreEqual(0, s3Configuration.Rules.Count);

            var configuration = new LifecycleConfiguration
            {
                Rules =new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Prefix = "rule1-",
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 2                            
                        },
#pragma warning disable 618
                        Transition = new LifecycleTransition
                        {
                            Days = 1,
                            StorageClass = S3StorageClass.Glacier
                        },
                        NoncurrentVersionTransition = new LifecycleRuleNoncurrentVersionTransition
                        {
                            NoncurrentDays = 14,
                            StorageClass = S3StorageClass.Glacier
                        }
#pragma warning restore 618
                    },
                    new LifecycleRule
                    {
                        Prefix = "rule2-",
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 120
                        },
                        Transitions = new List<LifecycleTransition>
                        {
                            new LifecycleTransition
                            {
                                Days = 30,
                                StorageClass = S3StorageClass.StandardInfrequentAccess
                            },
                            new LifecycleTransition
                            {
                                Days = 90,
                                StorageClass = S3StorageClass.Glacier
                            }
                        },
                        NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>
                        {
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 30,
                                StorageClass = S3StorageClass.StandardInfrequentAccess
                            },
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 90,
                                StorageClass = S3StorageClass.Glacier
                            }
                        }
                    },
                }
            };

            Client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = configuration
            });
            s3Configuration = Client.GetLifecycleConfiguration(bucketName).Configuration;

            Assert.IsNotNull(s3Configuration);
            Assert.IsNotNull(s3Configuration.Rules);
            Assert.AreEqual(configuration.Rules.Count, s3Configuration.Rules.Count);
            for(int i=0;i<configuration.Rules.Count;i++)
            {
                var rule = configuration.Rules[i];
                Assert.IsNotNull(rule);
                var s3Rule = s3Configuration.Rules[i];
                Assert.IsNotNull(s3Rule);

                Assert.AreEqual(rule.Transitions.Count, s3Rule.Transitions.Count);
                Assert.AreEqual(rule.NoncurrentVersionTransitions.Count, s3Rule.NoncurrentVersionTransitions.Count);
#pragma warning disable 618
                Assert.AreEqual(rule.Transition.Days, s3Rule.Transition.Days);
                Assert.AreEqual(rule.NoncurrentVersionTransition.NoncurrentDays, s3Rule.NoncurrentVersionTransition.NoncurrentDays);
#pragma warning restore 618
            }
        }
    }
}
