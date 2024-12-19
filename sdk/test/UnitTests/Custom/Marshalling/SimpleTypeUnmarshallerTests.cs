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
using System.Text.Json;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Amazon.KeyManagementService.Model;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SimpleTypeUnmarshallerTests
    {
        private static readonly string JsonWithValues = "{'Priority': 1, 'ReservoirQuotaTTL': 1533081600, 'StartTimeISO8601': '2018-08-01T00:00:00.0000000Z', 'StartTimeEpoch': 1533081600, 'StartTimeRFC822': 'Wed, 01 Aug 2018 00:00:00 GMT', 'Stream':'SEVMTE8='}".Replace("'", "\"");
        private static readonly string JsonWithNullValues = "{'Priority': null, 'ReservoirQuotaTTL': null, 'StartTimeISO8601': null, 'StartTimeEpoch': null, 'StartTimeRFC822': null, 'Stream': null}".Replace("'", "\"");

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestJsonUnmarshalling()
        {
            var model = UnmarshallModel(JsonWithValues);
            var nullModel = UnmarshallModel(JsonWithNullValues);

            Assert.AreEqual(1, model.Priority);
            Assert.AreEqual(null, nullModel.Priority);

            var expected = new DateTime(2018, 8, 1, 0, 0, 0, DateTimeKind.Utc);
            Assert.AreEqual(expected, model.ReservoirQuotaTTL.Value.ToUniversalTime());
            Assert.AreEqual(DateTimeKind.Utc, model.ReservoirQuotaTTL.Value.Kind);
            Assert.AreEqual(null, nullModel.ReservoirQuotaTTL);

            Assert.AreEqual(expected, model.StartTimeISO8601.ToUniversalTime());
            Assert.AreEqual(DateTimeKind.Local, model.StartTimeISO8601.Kind);
            Assert.AreEqual(DateTime.MinValue, nullModel.StartTimeISO8601);
            Assert.AreEqual(DateTimeKind.Unspecified, nullModel.StartTimeISO8601.Kind);
            
            Assert.AreEqual(expected, model.StartTimeEpoch.ToUniversalTime());
            Assert.AreEqual(DateTimeKind.Utc, model.StartTimeEpoch.Kind);
            Assert.AreEqual(DateTime.MinValue, nullModel.StartTimeEpoch);
            Assert.AreEqual(DateTimeKind.Unspecified, nullModel.StartTimeEpoch.Kind);

            Assert.AreEqual(expected, model.StartTimeRFC822.ToUniversalTime());
            Assert.AreEqual(DateTimeKind.Local, model.StartTimeRFC822.Kind);
            Assert.AreEqual(DateTime.MinValue, nullModel.StartTimeRFC822);
            Assert.AreEqual(DateTimeKind.Unspecified, nullModel.StartTimeRFC822.Kind);
        }

        private Model UnmarshallModel(string json)
        {
            var stream = Utils.CreateStreamFromString(json);
            JsonUnmarshallerContext context = new JsonUnmarshallerContext(stream, false, null);
            var reader = new StreamingUtf8JsonReader(stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            var model = new Model();
            bool isSetPriority = false, isSetReservoirQuotaTTL = false, isSetStartTimeISO8601 = false, 
                isSetStartTimeEpoch = false, isSetStartTimeRFC822 = false, isSetStream = false;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    model.Priority = unmarshaller.Unmarshall(context, ref reader);
                    isSetPriority = true;
                }
                if (context.TestExpression("ReservoirQuotaTTL", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    model.ReservoirQuotaTTL = unmarshaller.Unmarshall(context, ref reader);
                    isSetReservoirQuotaTTL = true;
                }
                if (context.TestExpression("StartTimeISO8601", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    model.StartTimeISO8601 = unmarshaller.Unmarshall(context, ref reader);
                    isSetStartTimeISO8601 = true;
                }
                if (context.TestExpression("StartTimeEpoch", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    model.StartTimeEpoch = unmarshaller.Unmarshall(context, ref reader);
                    isSetStartTimeEpoch = true;
                }
                if (context.TestExpression("StartTimeRFC822", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    model.StartTimeRFC822 = unmarshaller.Unmarshall(context, ref reader);
                    isSetStartTimeRFC822 = true;
                }
                if (context.TestExpression("Stream", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    model.Stream = unmarshaller.Unmarshall(context, ref reader);

                    if (model.Stream != null)
                    {
                        // V4 added support for getting access to the buffer to allow customers to avoid copying data.
                        Assert.IsTrue(model.Stream.GetBuffer().Length > 0);
                    }

                    isSetStream = true;
                }
            }
            if (!(isSetPriority && isSetReservoirQuotaTTL && isSetStartTimeISO8601 && isSetStartTimeEpoch && isSetStartTimeRFC822 && isSetStream))
            {
                throw new Exception($"Could not parse all properties in JSON '{json}'");
            }
            return model;
        }

        class Model
        {
            public int? Priority { get; set; }
            public DateTime? ReservoirQuotaTTL { get; set; }
            public DateTime StartTimeISO8601 { get; set; }
            public DateTime StartTimeEpoch { get; set; }
            public DateTime StartTimeRFC822 { get; set; }
            public MemoryStream Stream { get; set; }
        }
    }
}
