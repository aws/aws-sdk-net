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
using System.Threading;
using System.Net;
using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;

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
            PutScheduledUpdateGroupActionRequest request = new PutScheduledUpdateGroupActionRequest();

            DateTime timeUtc = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc);

            //This is a valid use of .ToLocalTime to construct a local time for testing.
            DateTime timeLocal = new DateTime(2018, 7, 18, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            DateTime timeUnspecified = new DateTime(timeLocal.Ticks);

            request.StartTime = timeUtc;
            request.EndTime = timeLocal;
            request.Time = timeUnspecified;
            Assert.AreEqual(request.StartTime, timeUtc);
            Assert.AreEqual(request.EndTime, timeLocal);
            Assert.AreEqual(request.Time, timeUnspecified);

            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var marshalledRequest = marshaller.Marshall(request);

            Assert.AreEqual(marshalledRequest.Parameters["StartTime"], EXPECTED_MARSHALLED_STRING);
            Assert.AreEqual(marshalledRequest.Parameters["EndTime"], EXPECTED_MARSHALLED_STRING);
            Assert.AreEqual(marshalledRequest.Parameters["Time"], EXPECTED_MARSHALLED_STRING);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestUtcFieldsWithMS()
        {
            PutScheduledUpdateGroupActionRequest request = new PutScheduledUpdateGroupActionRequest();

            DateTime timeUtc = new DateTime(2018, 7, 18, 0, 0, 0, 123, DateTimeKind.Utc);

            //This is a valid use of .ToLocalTime to construct a local time for testing.
            DateTime timeLocal = new DateTime(2018, 7, 18, 0, 0, 0, 123, DateTimeKind.Utc).ToLocalTime();
            DateTime timeUnspecified = new DateTime(timeLocal.Ticks);

            request.StartTime = timeUtc;
            request.EndTime = timeLocal;
            request.Time = timeUnspecified;
            Assert.AreEqual(request.StartTime, timeUtc);
            Assert.AreEqual(request.EndTime, timeLocal);
            Assert.AreEqual(request.Time, timeUnspecified);

            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var marshalledRequest = marshaller.Marshall(request);

            Assert.AreEqual(marshalledRequest.Parameters["StartTime"], EXPECTED_MARSHALLED_STRING_WITH_MS);
            Assert.AreEqual(marshalledRequest.Parameters["EndTime"], EXPECTED_MARSHALLED_STRING_WITH_MS);
            Assert.AreEqual(marshalledRequest.Parameters["Time"], EXPECTED_MARSHALLED_STRING_WITH_MS);
        }
    }
}
