/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Tests;
using AWSSDK_DotNet.IntegrationTests.Tests.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace S3UnitTest
{
    [TestClass]
    public class LifecycleTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        private readonly LifecyclePrefixPredicate BasicPrefixPredicate1 = new LifecyclePrefixPredicate()
        {
            Prefix = "thePrefix1"
        };

        private readonly LifecyclePrefixPredicate BasicPrefixPredicate2 = new LifecyclePrefixPredicate()
        {
            Prefix = "thePrefix2"
        };

        private readonly LifecycleTagPredicate BasicTagPredicate1 = new LifecycleTagPredicate()
        {
            Tag = new Tag()
            {
                Key = "theKey1",
                Value = "theValue1"
            }
        };

        private readonly LifecycleTagPredicate BasicTagPredicate2 = new LifecycleTagPredicate()
        {
            Tag = new Tag()
            {
                Key = "theKey2",
                Value = "theValue2"
            }
        };

        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (!string.IsNullOrEmpty(bucketName))
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void LifecycleEmptyFilterTest()
        {
            var s3Configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                    {
                        new LifecycleRule
                        {
                            Id = "Empty-filter-test",
                            Filter = new LifecycleFilter{},
                            Expiration = new LifecycleRuleExpiration
                            {
                                Days = 30
                            }
                        },
                    }
            };
            Client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = s3Configuration
            });

            var configuration = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetLifecycleConfiguration(bucketName);
                return res.Configuration?.Rules?.Count == s3Configuration.Rules.Count ? res.Configuration : null;
            });

            Assert.AreEqual<string>(configuration.Rules.First().Id, "Empty-filter-test");
            Assert.AreEqual<int?>(configuration.Rules.First().Expiration.Days, 30);
        }



        [TestMethod]
        [TestCategory("S3")]
        public void LifecycleTest()
        {
            var s3Configuration = Client.GetLifecycleConfiguration(bucketName).Configuration;
            Assert.IsNotNull(s3Configuration);

            if (AWSConfigs.InitializeCollections)
                Assert.AreEqual(0, s3Configuration.Rules.Count);
            else
                Assert.IsNull(s3Configuration.Rules);

            var configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate()
                            {
                                Prefix = "rule1-"
                            }
                        },
                        Status = LifecycleRuleStatus.Enabled,
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 2,
                        },
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration()
                        {
                            NoncurrentDays = 15, // 'NoncurrentDays' in the NoncurrentVersionExpiration action must be greater than 'NoncurrentDays' in the NoncurrentVersionTransition action.
                            NewerNoncurrentVersions = 10,
                        },
#pragma warning disable 618
                        Transitions = new List<LifecycleTransition>
                        {
                            new LifecycleTransition
                            {
                                Days = 1,
                                StorageClass = S3StorageClass.Glacier
                            }
                        },
                        NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>()
                        {
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 14,
                                NewerNoncurrentVersions = 10,
                                StorageClass = S3StorageClass.Glacier
                            }
                        },
#pragma warning restore 618
                        AbortIncompleteMultipartUpload = new LifecycleRuleAbortIncompleteMultipartUpload
                        {
                            DaysAfterInitiation = 7
                        }
                    },
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate()
                            {
                                Prefix = "rule2-"
                            }
                        },
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
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration()
                        {
                            NoncurrentDays = 91, // 'NoncurrentDays' in the NoncurrentVersionExpiration action must be greater than 'NoncurrentDays' in the NoncurrentVersionTransition action.
                            NewerNoncurrentVersions = 10,
                        },
                        NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>
                        {
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 30,
                                NewerNoncurrentVersions = 20,
                                StorageClass = S3StorageClass.StandardInfrequentAccess
                            },
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 90,
                                NewerNoncurrentVersions = 50,
                                StorageClass = S3StorageClass.Glacier
                            }
                        }
                    },
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate()
                            {
                                Prefix = "rule3-"
                            }
                        },
                        Expiration = new LifecycleRuleExpiration
                        {
                            ExpiredObjectDeleteMarker = true
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
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration()
                        {
                            NoncurrentDays = 92, // 'NoncurrentDays' in the NoncurrentVersionExpiration action must be greater than 'NoncurrentDays' in the NoncurrentVersionTransition action.
                            NewerNoncurrentVersions = 60
                        },
                        NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>
                        {
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 30,
                                NewerNoncurrentVersions = 60,
                                StorageClass = S3StorageClass.StandardInfrequentAccess
                            },
                            new LifecycleRuleNoncurrentVersionTransition
                            {
                                NoncurrentDays = 90,
                                NewerNoncurrentVersions = 70,
                                StorageClass = S3StorageClass.Glacier
                            }
                        }
                    }
                }
            };

            Client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = configuration
            });

            s3Configuration = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetLifecycleConfiguration(bucketName);
                return res.Configuration?.Rules?.Count == configuration.Rules.Count ? res.Configuration : null;
            });

            string abortRuleId = null;
            Assert.IsNotNull(s3Configuration);
            Assert.IsNotNull(s3Configuration.Rules);
            Assert.AreEqual(configuration.Rules.Count, s3Configuration.Rules.Count);
            for (int i = 0; i < configuration.Rules.Count; i++)
            {
                var s3Rule = s3Configuration.Rules[i];
                var rule = configuration.Rules[i];
                Assert.IsNotNull(rule);
                Assert.IsNotNull(s3Rule);
                if (rule.AbortIncompleteMultipartUpload != null)
                    abortRuleId = s3Rule.Id;

                AssertRulesAreEqual(rule, s3Rule);
            }

            Thread.Sleep(10000);

            var expectedMinAbortDate = DateTime.UtcNow.Date.AddDays(7);
            var initResponse = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "rule1-123",
                CannedACL = S3CannedACL.PublicRead
            });
            var listResponse = Client.ListParts(bucketName, initResponse.Key, initResponse.UploadId);

            Assert.AreEqual(abortRuleId, initResponse.AbortRuleId);
            Assert.AreEqual(abortRuleId, listResponse.AbortRuleId);
            Assert.AreEqual(initResponse.AbortDate, listResponse.AbortDate);
            Assert.IsTrue(expectedMinAbortDate < initResponse.AbortDate);
        }

        /// <summary>
        /// Tests V2 rules that can not be combined with the request made in
        /// <see cref="LifecycleTest"/>
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void LifecycleV2Test()
        {
            var s3Configuration = Client.GetLifecycleConfiguration(bucketName).Configuration;
            Assert.IsNotNull(s3Configuration);

            if (AWSConfigs.InitializeCollections)
                Assert.AreEqual(0, s3Configuration.Rules.Count);
            else
                Assert.IsNull(s3Configuration.Rules);

            var configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecycleAndOperator
                            {
                                Operands = new List<LifecycleFilterPredicate>
                                {
                                    new LifecycleObjectSizeGreaterThanPredicate
                                    {
                                        ObjectSizeGreaterThan = 132000
                                    },
                                    new LifecycleObjectSizeLessThanPredicate
                                    {
                                        ObjectSizeLessThan = 422000
                                    }
                                }
                            }
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
                        }
                    }
                }
            };

            Client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = configuration
            });

            s3Configuration = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetLifecycleConfiguration(bucketName);
                return res.Configuration?.Rules?.Count == configuration.Rules.Count ? res.Configuration : null;
            });

            string abortRuleId = null;
            Assert.IsNotNull(s3Configuration);
            Assert.IsNotNull(s3Configuration.Rules);
            Assert.AreEqual(configuration.Rules.Count, s3Configuration.Rules.Count);
            for (int i = 0; i < configuration.Rules.Count; i++)
            {
                var s3Rule = s3Configuration.Rules[i];
                var rule = configuration.Rules[i];
                Assert.IsNotNull(rule);
                Assert.IsNotNull(s3Rule);
                if (rule.AbortIncompleteMultipartUpload != null)
                    abortRuleId = s3Rule.Id;

                AssertRulesAreEqual(rule, s3Rule);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestLifecycleFilterPrefix()
        {
            TestLifecycleFilterPredicate(BasicPrefixPredicate1);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestLifecycleFilterTag()
        {
            TestLifecycleFilterPredicate(BasicTagPredicate1);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestLifecycleFilterAndPrefixTag()
        {
            TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicTagPredicate1));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestLifecycleFilterAndTwoTags()
        {
            TestLifecycleFilterPredicate(BuildAndOperator(BasicTagPredicate1, BasicTagPredicate2));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestLifecycleFilterAndTwoPrefixes()
        {
            // make a client that fails faster since that's what we're expecting
            var oneRetryClient = new AmazonS3Client(new AmazonS3Config()
            {
                MaxErrorRetry = 1
            });

            AssertExtensions.ExpectException(() =>
            {
                TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicPrefixPredicate2), oneRetryClient);
            }, typeof(AmazonS3Exception), "An And operator may only contain one 'Prefix'.");
        }

        private static LifecycleAndOperator BuildAndOperator(params LifecycleFilterPredicate[] operands)
        {
            return new LifecycleAndOperator()
            {
                Operands = new List<LifecycleFilterPredicate>(operands)
            };
        }

        private static void TestLifecycleFilterPredicate(LifecycleFilterPredicate predicate, AmazonS3Client client = null)
        {
            var filter = new LifecycleFilter()
            {
                LifecycleFilterPredicate = predicate
            };

            var rule = new LifecycleRule
            {
                Filter = filter,
                Status = LifecycleRuleStatus.Enabled,
                Transitions = new List<LifecycleTransition>()
                {
                    new LifecycleTransition
                    {
                        Days = 1,
                        StorageClass = S3StorageClass.Glacier
                    }
                }
            };

            if (client == null)
                client = Client;

            client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = new LifecycleConfiguration
                {
                    Rules = new List<LifecycleRule>
                    {
                        rule
                    }
                }
            });

            var actualConfig = S3TestUtils.WaitForConsistency(() =>
            {
                var res = client.GetLifecycleConfiguration(bucketName);
                return res.Configuration?.Rules?.Count == 1 ? res.Configuration : null;
            });
            Assert.IsNotNull(actualConfig);
            Assert.IsNotNull(actualConfig.Rules);
            Assert.AreEqual(1, actualConfig.Rules.Count);
            AssertRulesAreEqual(rule, actualConfig.Rules[0]);
        }

        private static void AssertRulesAreEqual(LifecycleRule expected, LifecycleRule actual)
        {
            Assert.IsFalse(string.IsNullOrEmpty(actual.Id));

            AssertFiltersAreEqual(expected.Filter, actual.Filter);

            Assert.AreEqual(expected.Transitions.Count, actual.Transitions.Count);

            if (expected.NoncurrentVersionTransitions == null)
            {
                Assert.IsNull(actual.NoncurrentVersionTransitions);
            }
            else
            {
                Assert.AreEqual(expected.NoncurrentVersionTransitions.Count, actual.NoncurrentVersionTransitions.Count);
            }

            if (expected.AbortIncompleteMultipartUpload == null)
            {
                Assert.IsNull(actual.AbortIncompleteMultipartUpload);
            }
            else
            {
                Assert.AreEqual(expected.AbortIncompleteMultipartUpload.DaysAfterInitiation, actual.AbortIncompleteMultipartUpload.DaysAfterInitiation);
            }
            Assert.AreEqual(expected.Status, actual.Status);
            if (expected.Expiration == null)
            {
                Assert.IsNull(actual.Expiration);
            }
            else
            {
                Assert.AreEqual(expected.Expiration.Days, actual.Expiration.Days);
                Assert.AreEqual(expected.Expiration.ExpiredObjectDeleteMarker, actual.Expiration.ExpiredObjectDeleteMarker);
            }

            if (expected.NoncurrentVersionExpiration == null)
            {
                Assert.IsNull(actual.NoncurrentVersionExpiration);
            }
            else
            {
                Assert.AreEqual(expected.NoncurrentVersionExpiration.NoncurrentDays,
                    actual.NoncurrentVersionExpiration.NoncurrentDays);

                Assert.AreEqual(expected.NoncurrentVersionExpiration.NewerNoncurrentVersions,
                    actual.NoncurrentVersionExpiration.NewerNoncurrentVersions);
            }

#pragma warning disable 618
            Assert.AreEqual(expected.Transitions[0].Days, actual.Transitions[0].Days);
            if (expected.NoncurrentVersionTransitions == null)
            {
                Assert.IsNull(actual.NoncurrentVersionTransitions);
            }
            else
            {
                Assert.AreEqual(expected.NoncurrentVersionTransitions[0].NoncurrentDays,
                    actual.NoncurrentVersionTransitions[0].NoncurrentDays);

                Assert.AreEqual(expected.NoncurrentVersionTransitions[0].NewerNoncurrentVersions,
                    actual.NoncurrentVersionTransitions[0].NewerNoncurrentVersions);
            }
#pragma warning restore 618
        }

        private static void AssertFiltersAreEqual(LifecycleFilter expected, LifecycleFilter actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
            }
            else
            {
                AssertPredicatesAreEqual(expected.LifecycleFilterPredicate, actual.LifecycleFilterPredicate);
            }
        }

        private static void AssertPredicatesAreEqual(LifecycleFilterPredicate expected, LifecycleFilterPredicate actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());

            if (expected is LifecyclePrefixPredicate)
            {
                var expectedPrefixPredicate = expected as LifecyclePrefixPredicate;
                var actualPrefixPredicate = actual as LifecyclePrefixPredicate;

                Assert.AreEqual(expectedPrefixPredicate.Prefix, actualPrefixPredicate.Prefix);
            }
            else if (expected is LifecycleTagPredicate)
            {
                var expectedTagPredicate = expected as LifecycleTagPredicate;
                var actualTagPredicate = actual as LifecycleTagPredicate;

                Assert.AreEqual(expectedTagPredicate.Tag.Key, actualTagPredicate.Tag.Key);
                Assert.AreEqual(expectedTagPredicate.Tag.Value, actualTagPredicate.Tag.Value);
            }
            else if (expected is LifecycleObjectSizeLessThanPredicate)
            {
                var expectedTagPredicate = expected as LifecycleObjectSizeLessThanPredicate;
                var actualTagPredicate = actual as LifecycleObjectSizeLessThanPredicate;

                Assert.AreEqual(expectedTagPredicate.ObjectSizeLessThan, actualTagPredicate.ObjectSizeLessThan);
            }
            else if (expected is LifecycleObjectSizeGreaterThanPredicate)
            {
                var expectedTagPredicate = expected as LifecycleObjectSizeGreaterThanPredicate;
                var actualTagPredicate = actual as LifecycleObjectSizeGreaterThanPredicate;

                Assert.AreEqual(expectedTagPredicate.ObjectSizeGreaterThan, actualTagPredicate.ObjectSizeGreaterThan);
            }
            else if (expected is LifecycleAndOperator)
            {
                var expectedAndOperator = expected as LifecycleAndOperator;
                var actualAndOperator = actual as LifecycleAndOperator;

                var expectedOperands = expectedAndOperator.Operands.ToArray();
                var actualOperands = actualAndOperator.Operands.ToArray();

                Assert.AreEqual(expectedOperands.Length, actualOperands.Length);

                for (int i = 0; i < expectedOperands.Length; i++)
                {
                    AssertPredicatesAreEqual(expectedOperands[i], actualOperands[i]);
                }
            }
            else
            {
                throw new Exception("Unknown predicate type " + expected.GetType().FullName);
            }
        }
    }
}
