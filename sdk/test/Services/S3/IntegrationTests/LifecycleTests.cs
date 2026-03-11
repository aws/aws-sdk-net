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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
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
        public async Task Init()
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, true);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            if (!string.IsNullOrEmpty(bucketName))
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            }
        }

        [TestMethod]
        public async Task LifecycleEmptyFilterTest()
        {
            var s3Configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Id = "Empty-filter-test",
                        Filter = new LifecycleFilter(),
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 30
                        }
                    },
                }
            };

            await Client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = s3Configuration
            });

            var configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetLifecycleConfigurationAsync(bucketName);
                return res.Configuration?.Rules?.Count == s3Configuration.Rules.Count ? res.Configuration : null;
            });

            Assert.AreEqual(configuration.Rules.First().Id, "Empty-filter-test");
            Assert.AreEqual(configuration.Rules.First().Expiration.Days, 30);
        }

        // even if a user explicitly sets status to null we should set it to disabled so the 
        // request succeeds
        [TestMethod]
        public async Task LifecycleNullStatusTest()
        {
            var s3Configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Id = "null-status-test",
                        Filter = new LifecycleFilter(),
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 30
                        },
                        Status = null
                    }
                }
            };

            await Client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = s3Configuration
            });

            var configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetLifecycleConfigurationAsync(bucketName);
                return res.Configuration?.Rules?.Count == s3Configuration.Rules.Count ? res.Configuration : null;
            });

            Assert.AreEqual(configuration.Rules.First().Id, "null-status-test");
            Assert.AreEqual(configuration.Rules.First().Expiration.Days, 30);
        }

        [TestMethod]
        public async Task LifecycleTest()
        {
            var s3Configuration = (await Client.GetLifecycleConfigurationAsync(bucketName)).Configuration;
            Assert.IsNotNull(s3Configuration);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.AreEqual(0, s3Configuration.Rules.Count);
            }
            else
            {
                Assert.IsNull(s3Configuration.Rules);
            }

            var configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate
                            {
                                Prefix = "rule1-"
                            }
                        },
                        Status = LifecycleRuleStatus.Enabled,
                        Expiration = new LifecycleRuleExpiration
                        {
                            Days = 2,
                        },
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration
                        {
                            NoncurrentDays = 15, // 'NoncurrentDays' in the NoncurrentVersionExpiration action must be greater than 'NoncurrentDays' in the NoncurrentVersionTransition action.
                            NewerNoncurrentVersions = 10,
                        },
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
                        AbortIncompleteMultipartUpload = new LifecycleRuleAbortIncompleteMultipartUpload
                        {
                            DaysAfterInitiation = 7
                        }
                    },
                    new LifecycleRule
                    {
                        Filter = new LifecycleFilter
                        {
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate
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
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration
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
                            LifecycleFilterPredicate = new LifecyclePrefixPredicate
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
                        NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration
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

            await Client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = configuration
            });

            s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetLifecycleConfigurationAsync(bucketName);
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
                {
                    abortRuleId = s3Rule.Id;
                }

                AssertRulesAreEqual(rule, s3Rule);
            }

            await Task.Delay(10000);

            var expectedMinAbortDate = DateTime.UtcNow.Date.AddDays(7);
            var initResponse = await Client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "rule1-123",
                CannedACL = S3CannedACL.PublicRead
            });

            var listResponse = await Client.ListPartsAsync(bucketName, initResponse.Key, initResponse.UploadId);
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
        public async Task LifecycleV2Test()
        {
            var s3Configuration = (await Client.GetLifecycleConfigurationAsync(bucketName)).Configuration;
            Assert.IsNotNull(s3Configuration);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.AreEqual(0, s3Configuration.Rules.Count);
            }
            else
            {
                Assert.IsNull(s3Configuration.Rules);
            }

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

            await Client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = bucketName,
                Configuration = configuration
            });

            s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetLifecycleConfigurationAsync(bucketName);
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
                {
                    abortRuleId = s3Rule.Id;
                }

                AssertRulesAreEqual(rule, s3Rule);
            }
        }

        [TestMethod]
        public async Task TestLifecycleFilterPrefix()
        {
            await TestLifecycleFilterPredicate(BasicPrefixPredicate1);
        }

        [TestMethod]
        public async Task TestLifecycleFilterTag()
        {
            await TestLifecycleFilterPredicate(BasicTagPredicate1);
        }

        [TestMethod]
        public async Task TestLifecycleFilterAndPrefixTag()
        {
            await TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicTagPredicate1));
        }

        [TestMethod]
        public async Task TestLifecycleFilterAndTwoTags()
        {
            await TestLifecycleFilterPredicate(BuildAndOperator(BasicTagPredicate1, BasicTagPredicate2));
        }

        [TestMethod]
        public async Task TestLifecycleFilterAndTwoPrefixes()
        {
            // make a client that fails faster since that's what we're expecting
            var oneRetryClient = new AmazonS3Client(new AmazonS3Config
            {
                MaxErrorRetry = 1
            });

            var actualException = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicPrefixPredicate2), oneRetryClient)
            );
            Assert.AreEqual("An And operator may only contain one 'Prefix'.", actualException.Message);
        }

        private static LifecycleAndOperator BuildAndOperator(params LifecycleFilterPredicate[] operands)
        {
            return new LifecycleAndOperator()
            {
                Operands = new List<LifecycleFilterPredicate>(operands)
            };
        }

        private static async Task TestLifecycleFilterPredicate(LifecycleFilterPredicate predicate, AmazonS3Client client = null)
        {
            var filter = new LifecycleFilter
            {
                LifecycleFilterPredicate = predicate
            };

            var rule = new LifecycleRule
            {
                Filter = filter,
                Status = LifecycleRuleStatus.Enabled,
                Transitions = new List<LifecycleTransition>
                {
                    new LifecycleTransition
                    {
                        Days = 1,
                        StorageClass = S3StorageClass.Glacier
                    }
                }
            };

            if (client == null)
            {
                client = Client;
            }

            await client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
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

            var actualConfig = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await client.GetLifecycleConfigurationAsync(bucketName);
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
