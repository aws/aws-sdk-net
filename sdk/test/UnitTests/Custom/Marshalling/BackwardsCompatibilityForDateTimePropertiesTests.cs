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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using Amazon.Runtime.Internal.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class BackwardsCompatibilityForDateTimePropertiesTests
    {
        const string EXPECTED_MARSHALLED_STRING = "2018-07-18T00:00:00Z";
        const string EXPECTED_MARSHALLED_STRING_WITH_MS = "2018-07-18T00:00:00.123Z";

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestUtcFields()
        {
            DateTime timeUtc = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc);
            DateTime timeLocal = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            DateTime timeUnspecified = new DateTime(timeLocal.Ticks);

            Assert.AreEqual(EXPECTED_MARSHALLED_STRING, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeUtc));
            Assert.AreEqual(EXPECTED_MARSHALLED_STRING, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeLocal));
            Assert.AreEqual(EXPECTED_MARSHALLED_STRING, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeUnspecified));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestUtcFieldsWithMS()
        {
            DateTime timeUtc = new DateTime(2018, 7, 18, 0, 0, 0, 123, DateTimeKind.Utc);
            DateTime timeLocal = new DateTime(2018, 7, 18, 0, 0, 0, 123, DateTimeKind.Utc).ToLocalTime();
            DateTime timeUnspecified = new DateTime(timeLocal.Ticks);

            Assert.AreEqual(EXPECTED_MARSHALLED_STRING_WITH_MS, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeUtc));
            Assert.AreEqual(EXPECTED_MARSHALLED_STRING_WITH_MS, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeLocal));
            Assert.AreEqual(EXPECTED_MARSHALLED_STRING_WITH_MS, StringUtils.FromDateTimeToISO8601WithOptionalMs(timeUnspecified));
        }
    }
}
