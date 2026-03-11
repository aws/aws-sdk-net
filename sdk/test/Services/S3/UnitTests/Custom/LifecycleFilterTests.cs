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
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LifecycleFilterTests
    {
        private readonly string ExpectedRequestFormat = "<LifecycleConfiguration xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\"><Rule>{0}<Status>Disabled</Status><Transition><Days>1</Days><StorageClass>GLACIER" +
            "</StorageClass></Transition></Rule></LifecycleConfiguration>";


        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullPredicate()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter />"), MarshallRequest(new LifecycleFilter()));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullPrefix()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><Prefix /></Filter>"),
                MarshallPredicate(new LifecyclePrefixPredicate() { }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestEmptyPrefix()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><Prefix /></Filter>"),
                MarshallPredicate(new LifecyclePrefixPredicate()
                {
                    Prefix = ""
                }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullTag()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><Tag /></Filter>"),
                MarshallPredicate(new LifecycleTagPredicate() { }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullTagKeyAndValue()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><Tag><Key /><Value /></Tag></Filter>"),
                MarshallPredicate(new LifecycleTagPredicate()
                {
                    Tag = new Tag() { }
                }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestEmptyTagKeyAndValue()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><Tag><Key /><Value /></Tag></Filter>"),
                MarshallPredicate(new LifecycleTagPredicate()
                {
                    Tag = new Tag() {
                        Key = "",
                        Value = ""
                    }
                }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullAndOperands()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><And /></Filter>"),
                MarshallPredicate(new LifecycleAndOperator() { }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestEmptyAndOperands()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><And /></Filter>"),
                MarshallPredicate(new LifecycleAndOperator() {
                    Operands = new List<LifecycleFilterPredicate>()
                }));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MarshallRequestNullAndOperand()
        {
            Assert.AreEqual(GetExpectedRequest("<Filter><And /></Filter>"),
                MarshallPredicate(new LifecycleAndOperator()
                {
                    Operands = new List<LifecycleFilterPredicate>()
                    {
                        null
                    }
                }));
        }

        private string GetExpectedRequest(string expectedFilter)
        {
            return string.Format(ExpectedRequestFormat, expectedFilter);
        }

        private string MarshallPredicate(LifecycleFilterPredicate predicate)
        {
            return MarshallRequest(new LifecycleFilter() { LifecycleFilterPredicate = predicate });
        }

        private string MarshallRequest(LifecycleFilter filter)
        {
            var request = new PutLifecycleConfigurationRequest()
            {
                BucketName = "bucket",
                Configuration = new LifecycleConfiguration()
                {
                    Rules = new List<LifecycleRule>()
                    {
                        new LifecycleRule()
                        {
                            Filter = filter,
                            Transitions = new List<LifecycleTransition>()
                            {
                                new LifecycleTransition()
                                {
                                    Days = 1,
                                    StorageClass = S3StorageClass.Glacier
                                }
                            }
                        }
                    }
                }
            };

            return Encoding.UTF8.GetString(new PutLifecycleConfigurationRequestMarshaller().Marshall(request).Content);
        }
    }
}