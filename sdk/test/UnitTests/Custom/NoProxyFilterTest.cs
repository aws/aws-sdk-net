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
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class NoProxyFilterTest
    {
        [TestMethod]
        [DataRow("dynamodb.*.amazonaws.com", "dynamodb.us-west-2.amazonaws.com", true)]
        [DataRow("dynamodb.*.amazonaws.com", "ec2.us-west-2.amazonaws.com", false)]
        [DataRow("169.254.169.254", "169.254.169.254", true)]
        [DataRow("169.254.169.*", "169.254.169.254", true)]
        [DataRow("www.foo.com", "www.foo.com", true)]
        [DataRow(" www.foo.com ", "www.foo.com", true)]
        [DataRow("*.foo.com", "www.foo.com", true)]
        [DataRow("*foo.com", "foo.com", true)]
        [DataRow("www.foo.com", "www.bar.com", false)]
        [DataRow("*foo.com", "www.bar.com", false)]
        [DataRow("*foo.com", "bar.com", false)]
        [DataRow("", "bar.com", false)]
        [DataRow(null, "bar.com", false)]
        [DataRow("127.0.0.1,localhost,ssm.us-west-2.amazonaws.com", "ssm.us-west-2.amazonaws.com", true)]
        [DataRow("127.0.0.1,localhost,ssm.us-west-2.amazonaws.com", "autoscaling.us-west-2.amazonaws.com", false)]
        [DataRow("us-west-2.amazonaws.com","bucket-name.s3.us-west-2.amazonaws.com", true)]
        [DataRow("*.s3.us-west-2.amazonaws.com", "bucket-name.s3.us-west-2.amazonaws.com", true)]

        public void Match(string noProxyValue, string testUri, bool skip)
        {
            var filter = new NoProxyFilter(new EnvironmentVariableStub(noProxyValue));
            Assert.AreEqual(skip, filter.Match(new Uri("https://" + testUri + "/")));
        }

        class EnvironmentVariableStub : IEnvironmentVariableRetriever
        {
            private readonly string _noProxyValue;
            public EnvironmentVariableStub(string noProxyValue)
            {
                _noProxyValue = noProxyValue;
            }

            public string GetEnvironmentVariable(string key)
            {
                if (!string.Equals(key, NoProxyFilter.NO_PROXY_ENV_NAME, StringComparison.OrdinalIgnoreCase))
                    return null;

                return _noProxyValue;
            }
        }
    }
}
