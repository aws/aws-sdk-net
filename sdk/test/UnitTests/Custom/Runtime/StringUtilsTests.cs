﻿/*
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
using System.Threading;
using System.Net;
using System.Globalization;
using Amazon.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class StringUtilsTests
    {
        const string EXPECTED_FROM_DATE_STRING = "2018-07-18T00:00:00.000Z";
        static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

#pragma warning disable CS0618 // Type or member is obsolete
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeUtc()
        {
            string convertedDateTime = StringUtils.FromDateTime(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc));

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeUnspecified()
        {
            string convertedDateTime = StringUtils.FromDateTime(new DateTime(2018, 7, 18, 0, 0, 0));

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeLocal()
        {
            string convertedDateTime = StringUtils.FromDateTime(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Local));

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }
#pragma warning restore CS0618 // Type or member is obsolete

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeUtcUtc()
        {
            string convertedDateTime = StringUtils.FromDateTimeToISO8601(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc));

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeUtcUnspecified()
        {
            string convertedDateTime = StringUtils.FromDateTimeToISO8601(new DateTime(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime().Ticks));

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeUtcLocal()
        {
            string convertedDateTime = StringUtils.FromDateTimeToISO8601(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime());

            Assert.AreEqual(EXPECTED_FROM_DATE_STRING, convertedDateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeEpochCompatibilityUtc()
        {
            DateTime time = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc);
            TestStringUtilsFromDateUtcTimeEpochCompatibility(time);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeEpochCompatibilityUnknown()
        {
            DateTime time = new DateTime(new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime().Ticks);
            TestStringUtilsFromDateUtcTimeEpochCompatibility(time);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStringUtilsFromDateTimeEpochCompatibilityLocal()
        {
            DateTime time = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            TestStringUtilsFromDateUtcTimeEpochCompatibility(time);
        }

        private void TestStringUtilsFromDateUtcTimeEpochCompatibility(DateTime time)
        {
            string convertedDateTime = StringUtils.FromDateTimeToISO8601(time);
            DateTime restoredDateTime = DateTime.Parse(convertedDateTime).ToUniversalTime();

            //We want the marshalling performed by StringUtils.FromDateTimeUtc to be coherent with AWSSDKUtils.ConvertToUnixEpochSecondsDouble
            double secondsFromEpoch = AWSSDKUtils.ConvertToUnixEpochSecondsDouble(time);
            DateTime epochDateTime = EPOCH.AddSeconds(secondsFromEpoch);

            Assert.AreEqual(restoredDateTime, epochDateTime);
        }
    }
}
