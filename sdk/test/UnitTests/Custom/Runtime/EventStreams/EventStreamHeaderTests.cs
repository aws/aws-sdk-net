#if NET8_0_OR_GREATER
using Amazon.Runtime;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EventStreamHeaderTests
    {
        #region Helper Test Models

        private class TestEventModel
        {
            public string StringHeader { get; set; }
            public bool? BoolHeader { get; set; }
            public int? IntHeader { get; set; }
            public long? LongHeader { get; set; }
            public double? DoubleHeader { get; set; }
            public MemoryStream BytesHeader { get; set; }
            public DateTime? TimestampHeader { get; set; }

            public bool IsSetStringHeader() => StringHeader != null;
            public bool IsSetBoolHeader() => BoolHeader.HasValue;
            public bool IsSetIntHeader() => IntHeader.HasValue;
            public bool IsSetLongHeader() => LongHeader.HasValue;
            public bool IsSetDoubleHeader() => DoubleHeader.HasValue;
            public bool IsSetBytesHeader() => BytesHeader != null;
            public bool IsSetTimestampHeader() => TimestampHeader.HasValue;
        }

        private class TestEventModelMarshaller : IRequestMarshaller<TestEventModel, JsonMarshallerContext>
        {
            public void Marshall(TestEventModel requestObject, JsonMarshallerContext context)
            {
                if (requestObject == null)
                    return;

                if (requestObject.IsSetStringHeader())
                {
                    var header = new EventStreamHeader("StringHeader");
                    header.SetString(requestObject.StringHeader);
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetBoolHeader())
                {
                    var header = new EventStreamHeader("BoolHeader");
                    header.SetBool(requestObject.BoolHeader.Value);
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetIntHeader())
                {
                    var header = new EventStreamHeader("IntHeader");
                    header.SetInt32(requestObject.IntHeader.Value);
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetLongHeader())
                {
                    var header = new EventStreamHeader("LongHeader");
                    header.SetInt64(requestObject.LongHeader.Value);
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetDoubleHeader())
                {
                    var header = new EventStreamHeader("DoubleHeader");
                    header.SetDouble(requestObject.DoubleHeader.Value);
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetBytesHeader())
                {
                    var header = new EventStreamHeader("BytesHeader");
                    header.SetByteBuf(requestObject.BytesHeader.ToArray());
                    context.Request.EventHeaders.Add(header);
                }

                if (requestObject.IsSetTimestampHeader())
                {
                    var header = new EventStreamHeader("TimestampHeader");
                    header.SetTimestamp(requestObject.TimestampHeader.Value);
                    context.Request.EventHeaders.Add(header);
                }
            }
        }

        private class TestAmazonWebServiceRequest : AmazonWebServiceRequest
        {
        }

        private class TestEventModelUnmarshaller
        {
            public TestEventModel Unmarshall(JsonUnmarshallerContext context)
            {
                var unmarshalledObject = new TestEventModel();

                if (context.ResponseData.IsEventHeaderPresent("StringHeader"))
                    unmarshalledObject.StringHeader = context.ResponseData.GetEventStreamHeader("StringHeader").AsString();

                if (context.ResponseData.IsEventHeaderPresent("BoolHeader"))
                    unmarshalledObject.BoolHeader = context.ResponseData.GetEventStreamHeader("BoolHeader").AsBool();

                if (context.ResponseData.IsEventHeaderPresent("IntHeader"))
                    unmarshalledObject.IntHeader = context.ResponseData.GetEventStreamHeader("IntHeader").AsInt32();

                if (context.ResponseData.IsEventHeaderPresent("LongHeader"))
                    unmarshalledObject.LongHeader = context.ResponseData.GetEventStreamHeader("LongHeader").AsInt64();

                if (context.ResponseData.IsEventHeaderPresent("DoubleHeader"))
                    unmarshalledObject.DoubleHeader = context.ResponseData.GetEventStreamHeader("DoubleHeader").AsDouble();

                if (context.ResponseData.IsEventHeaderPresent("BytesHeader"))
                {
                    var byteBuf = context.ResponseData.GetEventStreamHeader("BytesHeader").AsByteBuf();
                    unmarshalledObject.BytesHeader = new MemoryStream(byteBuf, 0, byteBuf.Length, writable: false);
                }

                if (context.ResponseData.IsEventHeaderPresent("TimestampHeader"))
                    unmarshalledObject.TimestampHeader = context.ResponseData.GetEventStreamHeader("TimestampHeader").AsTimestamp();

                return unmarshalledObject;
            }
        }

        #endregion

        #region Request-Side Marshalling Tests

        [TestMethod]
        public void RequestMarshalling_StringEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { StringHeader = "TestStringValue" };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("StringHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.String, request.EventHeaders[0].HeaderType);
            Assert.AreEqual("TestStringValue", request.EventHeaders[0].AsString());
        }

        [TestMethod]
        public void RequestMarshalling_BoolEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { BoolHeader = true };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("BoolHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.BoolTrue, request.EventHeaders[0].HeaderType);
            Assert.IsTrue(request.EventHeaders[0].AsBool());
        }

        [TestMethod]
        public void RequestMarshalling_IntEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { IntHeader = 42 };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("IntHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.Int32, request.EventHeaders[0].HeaderType);
            Assert.AreEqual(42, request.EventHeaders[0].AsInt32());
        }

        [TestMethod]
        public void RequestMarshalling_LongEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { LongHeader = long.MaxValue };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("LongHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.Int64, request.EventHeaders[0].HeaderType);
            Assert.AreEqual(long.MaxValue, request.EventHeaders[0].AsInt64());
        }

        [TestMethod]
        public void RequestMarshalling_DoubleEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { DoubleHeader = 3.14159 };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("DoubleHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.Double, request.EventHeaders[0].HeaderType);
            Assert.AreEqual(3.14159, request.EventHeaders[0].AsDouble());
        }

        [TestMethod]
        public void RequestMarshalling_ByteBufferEventHeader_MarshalledCorrectly()
        {
            var testBytes = new byte[] { 0x01, 0x02, 0x03, 0xFF, 0xAA };
            var testModel = new TestEventModel { BytesHeader = new MemoryStream(testBytes) };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("BytesHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.ByteBuf, request.EventHeaders[0].HeaderType);
            CollectionAssert.AreEqual(testBytes, request.EventHeaders[0].AsByteBuf());
        }

        [TestMethod]
        public void RequestMarshalling_TimestampEventHeader_MarshalledCorrectly()
        {
            var testTimestamp = new DateTime(2026, 3, 9, 10, 30, 45, DateTimeKind.Utc);
            var testModel = new TestEventModel { TimestampHeader = testTimestamp };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("TimestampHeader", request.EventHeaders[0].Name);
            Assert.AreEqual(EventStreamHeaderType.Timestamp, request.EventHeaders[0].HeaderType);
            Assert.AreEqual(testTimestamp, request.EventHeaders[0].AsTimestamp());
        }

        [TestMethod]
        public void RequestMarshalling_MultipleEventHeaders_AllMarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                StringHeader = "MultiTest",
                BoolHeader = false,
                IntHeader = 100,
                LongHeader = 200L
            };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(4, request.EventHeaders.Count);
            Assert.AreEqual("MultiTest", request.EventHeaders[0].AsString());
            Assert.IsFalse(request.EventHeaders[1].AsBool());
            Assert.AreEqual(100, request.EventHeaders[2].AsInt32());
            Assert.AreEqual(200L, request.EventHeaders[3].AsInt64());
        }

        #endregion

        #region Response-Side Unmarshalling Tests

        [TestMethod]
        public void ResponseUnmarshalling_StringEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var stringHeader = new EventStreamHeader("StringHeader");
            stringHeader.SetString("ResponseValue");
            eventHeaders["StringHeader"] = stringHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var context = new JsonUnmarshallerContext(new MemoryStream(), false, responseData);
            var result = new TestEventModelUnmarshaller().Unmarshall(context);

            Assert.IsNotNull(result);
            Assert.AreEqual("ResponseValue", result.StringHeader);
        }

        [TestMethod]
        public void ResponseUnmarshalling_BoolEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var boolHeader = new EventStreamHeader("BoolHeader");
            boolHeader.SetBool(true);
            eventHeaders["BoolHeader"] = boolHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var context = new JsonUnmarshallerContext(new MemoryStream(), false, responseData);
            var result = new TestEventModelUnmarshaller().Unmarshall(context);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.BoolHeader.Value);
        }

        [TestMethod]
        public void ResponseUnmarshalling_IntEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var intHeader = new EventStreamHeader("IntHeader");
            intHeader.SetInt32(12345);
            eventHeaders["IntHeader"] = intHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var context = new JsonUnmarshallerContext(new MemoryStream(), false, responseData);
            var result = new TestEventModelUnmarshaller().Unmarshall(context);

            Assert.IsNotNull(result);
            Assert.AreEqual(12345, result.IntHeader);
        }

        [TestMethod]
        public void ResponseUnmarshalling_MissingEventHeader_PropertyNotSet()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var responseData = new HttpClientResponseData(eventHeaders);
            var context = new JsonUnmarshallerContext(new MemoryStream(), false, responseData);
            var result = new TestEventModelUnmarshaller().Unmarshall(context);

            Assert.IsNotNull(result);
            Assert.IsNull(result.StringHeader);
            Assert.IsNull(result.BoolHeader);
            Assert.IsNull(result.IntHeader);
            Assert.IsNull(result.LongHeader);
            Assert.IsNull(result.DoubleHeader);
            Assert.IsNull(result.BytesHeader);
            Assert.IsNull(result.TimestampHeader);
        }

        #endregion

        #region Round-Trip Tests

        [TestMethod]
        public void RoundTrip_AllHeaderTypes_PreserveValues()
        {
            var testTimestamp = new DateTime(2026, 6, 15, 12, 30, 0, DateTimeKind.Utc);
            var testBytes = new byte[] { 0xCA, 0xFE, 0xBA, 0xBE };

            var originalModel = new TestEventModel
            {
                StringHeader = "RoundTripTest",
                BoolHeader = true,
                IntHeader = 777,
                LongHeader = 8888888888L,
                DoubleHeader = 123.456789,
                BytesHeader = new MemoryStream(testBytes),
                TimestampHeader = testTimestamp
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var marshalContext = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(originalModel, marshalContext);

            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            foreach (var header in request.EventHeaders)
                eventHeaders[header.Name] = header;

            var responseData = new HttpClientResponseData(eventHeaders);
            var unmarshalContext = new JsonUnmarshallerContext(new MemoryStream(), false, responseData);
            var resultModel = new TestEventModelUnmarshaller().Unmarshall(unmarshalContext);

            Assert.AreEqual(originalModel.StringHeader, resultModel.StringHeader);
            Assert.AreEqual(originalModel.BoolHeader, resultModel.BoolHeader);
            Assert.AreEqual(originalModel.IntHeader, resultModel.IntHeader);
            Assert.AreEqual(originalModel.LongHeader, resultModel.LongHeader);
            Assert.AreEqual(originalModel.DoubleHeader, resultModel.DoubleHeader);
            CollectionAssert.AreEqual(testBytes, resultModel.BytesHeader.ToArray());
            Assert.AreEqual(originalModel.TimestampHeader, resultModel.TimestampHeader);
        }

        #endregion

        #region Edge Case Tests

        [TestMethod]
        public void EdgeCase_EmptyString_MarshalledAndUnmarshalledCorrectly()
        {
            var testModel = new TestEventModel { StringHeader = "" };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual("", request.EventHeaders[0].AsString());
        }

        [TestMethod]
        public void EdgeCase_UnicodeString_MarshalledCorrectly()
        {
            var unicodeValue = "Hello 世界 🌍 Привет مرحبا";
            var testModel = new TestEventModel { StringHeader = unicodeValue };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual(unicodeValue, request.EventHeaders[0].AsString());
        }

        [TestMethod]
        public void EdgeCase_ZeroValues_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { IntHeader = 0, LongHeader = 0L, DoubleHeader = 0.0 };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(3, request.EventHeaders.Count);
            Assert.AreEqual(0, request.EventHeaders[0].AsInt32());
            Assert.AreEqual(0L, request.EventHeaders[1].AsInt64());
            Assert.AreEqual(0.0, request.EventHeaders[2].AsDouble());
        }

        [TestMethod]
        public void EdgeCase_NegativeNumbers_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { IntHeader = -12345, LongHeader = long.MinValue, DoubleHeader = -987.654321 };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(3, request.EventHeaders.Count);
            Assert.AreEqual(-12345, request.EventHeaders[0].AsInt32());
            Assert.AreEqual(long.MinValue, request.EventHeaders[1].AsInt64());
            Assert.AreEqual(-987.654321, request.EventHeaders[2].AsDouble());
        }

        [TestMethod]
        public void EdgeCase_NullModel_NoHeadersAdded()
        {
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(null, context);

            Assert.AreEqual(0, request.EventHeaders.Count);
        }

        [TestMethod]
        public void EdgeCase_EmptyByteBuffer_MarshalledCorrectly()
        {
            var testModel = new TestEventModel { BytesHeader = new MemoryStream(new byte[0]) };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            new TestEventModelMarshaller().Marshall(testModel, context);

            Assert.AreEqual(1, request.EventHeaders.Count);
            Assert.AreEqual(0, request.EventHeaders[0].AsByteBuf().Length);
        }

        [TestMethod]
        public void EdgeCase_SpecialDoubleValues_MarshalledCorrectly()
        {
            var marshaller = new TestEventModelMarshaller();

            var nanModel = new TestEventModel { DoubleHeader = double.NaN };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var ms = new MemoryStream();
            using var writer = new Utf8JsonWriter(ms);
            marshaller.Marshall(nanModel, new JsonMarshallerContext(request, writer));
            Assert.IsTrue(double.IsNaN(request.EventHeaders[0].AsDouble()));

            var posInfModel = new TestEventModel { DoubleHeader = double.PositiveInfinity };
            var request2 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var ms2 = new MemoryStream();
            using var writer2 = new Utf8JsonWriter(ms2);
            marshaller.Marshall(posInfModel, new JsonMarshallerContext(request2, writer2));
            Assert.AreEqual(double.PositiveInfinity, request2.EventHeaders[0].AsDouble());

            var negInfModel = new TestEventModel { DoubleHeader = double.NegativeInfinity };
            var request3 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var ms3 = new MemoryStream();
            using var writer3 = new Utf8JsonWriter(ms3);
            marshaller.Marshall(negInfModel, new JsonMarshallerContext(request3, writer3));
            Assert.AreEqual(double.NegativeInfinity, request3.EventHeaders[0].AsDouble());
        }

        #endregion
    }
}
#endif
