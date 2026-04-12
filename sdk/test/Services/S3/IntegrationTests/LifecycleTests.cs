using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class LifecycleTests : IClassFixture<S3PublicAclBucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public LifecycleTests(S3PublicAclBucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

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

        [Fact]
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

            await _client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = _bucketName,
                Configuration = s3Configuration
            });

            var configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                return res.Configuration?.Rules?.Any(r => r.Id == "Empty-filter-test") == true ? res.Configuration : null;
            });

            Assert.Equal(configuration.Rules.First().Id, "Empty-filter-test");
            Assert.Equal(configuration.Rules.First().Expiration.Days, 30);
        }

        // even if a user explicitly sets status to null we should set it to disabled so the 
        // request succeeds
        [Fact]
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

            await _client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = _bucketName,
                Configuration = s3Configuration
            });

            var configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                return res.Configuration?.Rules?.Any(r => r.Id == "null-status-test") == true ? res.Configuration : null;
            });

            Assert.Equal(configuration.Rules.First().Id, "null-status-test");
            Assert.Equal(configuration.Rules.First().Expiration.Days, 30);
        }

        [Fact]
        public async Task LifecycleTest()
        {
            // Delete any lifecycle config left by a previous test and wait for deletion to propagate.
            await _client.DeleteLifecycleConfigurationAsync(_bucketName);

            var s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                var rules = res.Configuration?.Rules;
                return (rules == null || rules.Count == 0) ? res.Configuration : null;
            });
            Assert.NotNull(s3Configuration);

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

            await _client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = _bucketName,
                Configuration = configuration
            });

            s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                return res.Configuration?.Rules?.Count == configuration.Rules.Count ? res.Configuration : null;
            });

            string abortRuleId = null;
            Assert.NotNull(s3Configuration);
            Assert.NotNull(s3Configuration.Rules);
            Assert.Equal(configuration.Rules.Count, s3Configuration.Rules.Count);
            for (int i = 0; i < configuration.Rules.Count; i++)
            {
                var s3Rule = s3Configuration.Rules[i];
                var rule = configuration.Rules[i];
                Assert.NotNull(rule);
                Assert.NotNull(s3Rule);
                if (rule.AbortIncompleteMultipartUpload != null)
                {
                    abortRuleId = s3Rule.Id;
                }

                AssertRulesAreEqual(rule, s3Rule);
            }

            var expectedMinAbortDate = DateTime.UtcNow.Date.AddDays(7);
            var initResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = "rule1-123",
                CannedACL = S3CannedACL.PublicRead
            });

            var listResponse = await _client.ListPartsAsync(_bucketName, initResponse.Key, initResponse.UploadId);
            Assert.Equal(abortRuleId, initResponse.AbortRuleId);
            Assert.Equal(abortRuleId, listResponse.AbortRuleId);
            Assert.Equal(initResponse.AbortDate, listResponse.AbortDate);
            Assert.True(expectedMinAbortDate < initResponse.AbortDate);
        }

        [Fact]
        public async Task LifecycleV2Test()
        {
            // Delete any lifecycle config left by a previous test and wait for deletion to propagate.
            await _client.DeleteLifecycleConfigurationAsync(_bucketName);

            var s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                var rules = res.Configuration?.Rules;
                return (rules == null || rules.Count == 0) ? res.Configuration : null;
            });
            Assert.NotNull(s3Configuration);

            var ruleId = Guid.NewGuid().ToString("N");
            var configuration = new LifecycleConfiguration
            {
                Rules = new List<LifecycleRule>
                {
                    new LifecycleRule
                    {
                        Id = ruleId,
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

            await _client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = _bucketName,
                Configuration = configuration
            });

            s3Configuration = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetLifecycleConfigurationAsync(_bucketName);
                return res.Configuration?.Rules?.Any(r => r.Id == ruleId) == true ? res.Configuration : null;
            });

            Assert.NotNull(s3Configuration);
            Assert.NotNull(s3Configuration.Rules);
            var s3Rule = s3Configuration.Rules.Single(r => r.Id == ruleId);
            AssertRulesAreEqual(configuration.Rules[0], s3Rule);
        }

        [Fact]
        public async Task TestLifecycleFilterPrefix()
        {
            await TestLifecycleFilterPredicate(BasicPrefixPredicate1);
        }

        [Fact]
        public async Task TestLifecycleFilterTag()
        {
            await TestLifecycleFilterPredicate(BasicTagPredicate1);
        }

        [Fact]
        public async Task TestLifecycleFilterAndPrefixTag()
        {
            await TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicTagPredicate1));
        }

        [Fact]
        public async Task TestLifecycleFilterAndTwoTags()
        {
            await TestLifecycleFilterPredicate(BuildAndOperator(BasicTagPredicate1, BasicTagPredicate2));
        }

        [Fact]
        public async Task TestLifecycleFilterAndTwoPrefixes()
        {
            // make a client that fails faster since that's what we're expecting
            var oneRetryClient = new AmazonS3Client(new AmazonS3Config
            {
                MaxErrorRetry = 1
            });

            var actualException = await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                TestLifecycleFilterPredicate(BuildAndOperator(BasicPrefixPredicate1, BasicPrefixPredicate2), oneRetryClient)
            );
            Assert.Equal("An And operator may only contain one 'Prefix'.", actualException.Message);
        }

        private static LifecycleAndOperator BuildAndOperator(params LifecycleFilterPredicate[] operands)
        {
            return new LifecycleAndOperator()
            {
                Operands = new List<LifecycleFilterPredicate>(operands)
            };
        }

        private async Task TestLifecycleFilterPredicate(LifecycleFilterPredicate predicate, AmazonS3Client client = null)
        {
            var filter = new LifecycleFilter
            {
                LifecycleFilterPredicate = predicate
            };

            var ruleId = Guid.NewGuid().ToString("N");
            var rule = new LifecycleRule
            {
                Id = ruleId,
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
                client = _client;
            }

            await client.PutLifecycleConfigurationAsync(new PutLifecycleConfigurationRequest
            {
                BucketName = _bucketName,
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
                var res = await client.GetLifecycleConfigurationAsync(_bucketName);
                return res.Configuration?.Rules?.Any(r => r.Id == ruleId) == true ? res.Configuration : null;
            });

            Assert.NotNull(actualConfig);
            Assert.NotNull(actualConfig.Rules);
            Assert.Equal(1, actualConfig.Rules.Count);
            AssertRulesAreEqual(rule, actualConfig.Rules[0]);
        }

        private static void AssertRulesAreEqual(LifecycleRule expected, LifecycleRule actual)
        {
            Assert.False(string.IsNullOrEmpty(actual.Id));
            AssertFiltersAreEqual(expected.Filter, actual.Filter);
            Assert.Equal(expected.Transitions.Count, actual.Transitions.Count);

            if (expected.NoncurrentVersionTransitions == null)
            {
                Assert.Null(actual.NoncurrentVersionTransitions);
            }
            else
            {
                Assert.Equal(expected.NoncurrentVersionTransitions.Count, actual.NoncurrentVersionTransitions.Count);
            }

            if (expected.AbortIncompleteMultipartUpload == null)
            {
                Assert.Null(actual.AbortIncompleteMultipartUpload);
            }
            else
            {
                Assert.Equal(expected.AbortIncompleteMultipartUpload.DaysAfterInitiation, actual.AbortIncompleteMultipartUpload.DaysAfterInitiation);
            }
            Assert.Equal(expected.Status, actual.Status);
            if (expected.Expiration == null)
            {
                Assert.Null(actual.Expiration);
            }
            else
            {
                Assert.Equal(expected.Expiration.Days, actual.Expiration.Days);
                Assert.Equal(expected.Expiration.ExpiredObjectDeleteMarker, actual.Expiration.ExpiredObjectDeleteMarker);
            }

            if (expected.NoncurrentVersionExpiration == null)
            {
                Assert.Null(actual.NoncurrentVersionExpiration);
            }
            else
            {
                Assert.Equal(expected.NoncurrentVersionExpiration.NoncurrentDays,
                    actual.NoncurrentVersionExpiration.NoncurrentDays);

                Assert.Equal(expected.NoncurrentVersionExpiration.NewerNoncurrentVersions,
                    actual.NoncurrentVersionExpiration.NewerNoncurrentVersions);
            }

            Assert.Equal(expected.Transitions[0].Days, actual.Transitions[0].Days);
            if (expected.NoncurrentVersionTransitions == null)
            {
                Assert.Null(actual.NoncurrentVersionTransitions);
            }
            else
            {
                Assert.Equal(expected.NoncurrentVersionTransitions[0].NoncurrentDays,
                    actual.NoncurrentVersionTransitions[0].NoncurrentDays);

                Assert.Equal(expected.NoncurrentVersionTransitions[0].NewerNoncurrentVersions,
                    actual.NoncurrentVersionTransitions[0].NewerNoncurrentVersions);
            }
        }

        private static void AssertFiltersAreEqual(LifecycleFilter expected, LifecycleFilter actual)
        {
            if (expected == null)
            {
                Assert.Null(actual);
            }
            else
            {
                AssertPredicatesAreEqual(expected.LifecycleFilterPredicate, actual.LifecycleFilterPredicate);
            }
        }

        private static void AssertPredicatesAreEqual(LifecycleFilterPredicate expected, LifecycleFilterPredicate actual)
        {
            Assert.NotNull(expected);
            Assert.NotNull(actual);
            Assert.Equal(expected.GetType(), actual.GetType());

            if (expected is LifecyclePrefixPredicate)
            {
                var expectedPrefixPredicate = expected as LifecyclePrefixPredicate;
                var actualPrefixPredicate = actual as LifecyclePrefixPredicate;

                Assert.Equal(expectedPrefixPredicate.Prefix, actualPrefixPredicate.Prefix);
            }
            else if (expected is LifecycleTagPredicate)
            {
                var expectedTagPredicate = expected as LifecycleTagPredicate;
                var actualTagPredicate = actual as LifecycleTagPredicate;

                Assert.Equal(expectedTagPredicate.Tag.Key, actualTagPredicate.Tag.Key);
                Assert.Equal(expectedTagPredicate.Tag.Value, actualTagPredicate.Tag.Value);
            }
            else if (expected is LifecycleObjectSizeLessThanPredicate)
            {
                var expectedTagPredicate = expected as LifecycleObjectSizeLessThanPredicate;
                var actualTagPredicate = actual as LifecycleObjectSizeLessThanPredicate;

                Assert.Equal(expectedTagPredicate.ObjectSizeLessThan, actualTagPredicate.ObjectSizeLessThan);
            }
            else if (expected is LifecycleObjectSizeGreaterThanPredicate)
            {
                var expectedTagPredicate = expected as LifecycleObjectSizeGreaterThanPredicate;
                var actualTagPredicate = actual as LifecycleObjectSizeGreaterThanPredicate;

                Assert.Equal(expectedTagPredicate.ObjectSizeGreaterThan, actualTagPredicate.ObjectSizeGreaterThan);
            }
            else if (expected is LifecycleAndOperator)
            {
                var expectedAndOperator = expected as LifecycleAndOperator;
                var actualAndOperator = actual as LifecycleAndOperator;

                var expectedOperands = expectedAndOperator.Operands.ToArray();
                var actualOperands = actualAndOperator.Operands.ToArray();

                Assert.Equal(expectedOperands.Length, actualOperands.Length);

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
