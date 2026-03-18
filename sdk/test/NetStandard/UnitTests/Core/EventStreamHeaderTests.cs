#if NET8_0_OR_GREATER
using Amazon.Runtime;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Xunit;

namespace UnitTests.NetStandard.Core
{
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
                {
                    unmarshalledObject.StringHeader = context.ResponseData.GetEventStreamHeader("StringHeader").AsString();
                }

                if (context.ResponseData.IsEventHeaderPresent("BoolHeader"))
                {
                    unmarshalledObject.BoolHeader = context.ResponseData.GetEventStreamHeader("BoolHeader").AsBool();
                }

                if (context.ResponseData.IsEventHeaderPresent("IntHeader"))
                {
                    unmarshalledObject.IntHeader = context.ResponseData.GetEventStreamHeader("IntHeader").AsInt32();
                }

                if (context.ResponseData.IsEventHeaderPresent("LongHeader"))
                {
                    unmarshalledObject.LongHeader = context.ResponseData.GetEventStreamHeader("LongHeader").AsInt64();
                }

                if (context.ResponseData.IsEventHeaderPresent("DoubleHeader"))
                {
                    unmarshalledObject.DoubleHeader = context.ResponseData.GetEventStreamHeader("DoubleHeader").AsDouble();
                }

                if (context.ResponseData.IsEventHeaderPresent("BytesHeader"))
                {
                    var s = context.ResponseData.GetEventStreamHeader("BytesHeader");
                    var byteBuf = s.AsByteBuf();
                    unmarshalledObject.BytesHeader = new MemoryStream(byteBuf, 0, byteBuf.Length, writable: false);
                }

                if (context.ResponseData.IsEventHeaderPresent("TimestampHeader"))
                {
                    unmarshalledObject.TimestampHeader = context.ResponseData.GetEventStreamHeader("TimestampHeader").AsTimestamp();
                }

                return unmarshalledObject;
            }
        }

        #endregion

        #region Request-Side Marshalling Tests

        [Fact]
        public void RequestMarshalling_StringEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                StringHeader = "TestStringValue"
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("StringHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.String, request.EventHeaders[0].HeaderType);
            Assert.Equal("TestStringValue", request.EventHeaders[0].AsString());
        }

        [Fact]
        public void RequestMarshalling_BoolEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                BoolHeader = true
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("BoolHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.BoolTrue, request.EventHeaders[0].HeaderType);
            Assert.True(request.EventHeaders[0].AsBool());
        }

        [Fact]
        public void RequestMarshalling_IntEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                IntHeader = 42
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("IntHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.Int32, request.EventHeaders[0].HeaderType);
            Assert.Equal(42, request.EventHeaders[0].AsInt32());
        }

        [Fact]
        public void RequestMarshalling_LongEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                LongHeader = 9223372036854775807L
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("LongHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.Int64, request.EventHeaders[0].HeaderType);
            Assert.Equal(9223372036854775807L, request.EventHeaders[0].AsInt64());
        }

        [Fact]
        public void RequestMarshalling_DoubleEventHeader_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                DoubleHeader = 3.14159
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("DoubleHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.Double, request.EventHeaders[0].HeaderType);
            Assert.Equal(3.14159, request.EventHeaders[0].AsDouble());
        }

        [Fact]
        public void RequestMarshalling_ByteBufferEventHeader_MarshalledCorrectly()
        {
            var testBytes = new byte[] { 0x01, 0x02, 0x03, 0xFF, 0xAA };
            var testModel = new TestEventModel
            {
                BytesHeader = new MemoryStream(testBytes)
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("BytesHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.ByteBuf, request.EventHeaders[0].HeaderType);
            Assert.Equal(testBytes, request.EventHeaders[0].AsByteBuf());
        }

        [Fact]
        public void RequestMarshalling_TimestampEventHeader_MarshalledCorrectly()
        {
            var testTimestamp = new DateTime(2026, 3, 9, 10, 30, 45, DateTimeKind.Utc);
            var testModel = new TestEventModel
            {
                TimestampHeader = testTimestamp
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("TimestampHeader", request.EventHeaders[0].Name);
            Assert.Equal(EventStreamHeaderType.Timestamp, request.EventHeaders[0].HeaderType);
            Assert.Equal(testTimestamp, request.EventHeaders[0].AsTimestamp());
        }

        [Fact]
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

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Equal(4, request.EventHeaders.Count);
            
            var stringHeader = request.EventHeaders[0];
            Assert.Equal("StringHeader", stringHeader.Name);
            Assert.Equal("MultiTest", stringHeader.AsString());
            
            var boolHeader = request.EventHeaders[1];
            Assert.Equal("BoolHeader", boolHeader.Name);
            Assert.False(boolHeader.AsBool());
            
            var intHeader = request.EventHeaders[2];
            Assert.Equal("IntHeader", intHeader.Name);
            Assert.Equal(100, intHeader.AsInt32());
            
            var longHeader = request.EventHeaders[3];
            Assert.Equal("LongHeader", longHeader.Name);
            Assert.Equal(200L, longHeader.AsInt64());
        }

        #endregion

        #region Response-Side Unmarshalling Tests

        [Fact]
        public void ResponseUnmarshalling_StringEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var stringHeader = new EventStreamHeader("StringHeader");
            stringHeader.SetString("ResponseValue");
            eventHeaders["StringHeader"] = stringHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal("ResponseValue", result.StringHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_BoolEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var boolHeader = new EventStreamHeader("BoolHeader");
            boolHeader.SetBool(true);
            eventHeaders["BoolHeader"] = boolHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.True(result.BoolHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_IntEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var intHeader = new EventStreamHeader("IntHeader");
            intHeader.SetInt32(12345);
            eventHeaders["IntHeader"] = intHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal(12345, result.IntHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_LongEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var longHeader = new EventStreamHeader("LongHeader");
            longHeader.SetInt64(9223372036854775806L);
            eventHeaders["LongHeader"] = longHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal(9223372036854775806L, result.LongHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_DoubleEventHeader_UnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var doubleHeader = new EventStreamHeader("DoubleHeader");
            doubleHeader.SetDouble(2.718281828);
            eventHeaders["DoubleHeader"] = doubleHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal(2.718281828, result.DoubleHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_ByteBufferEventHeader_UnmarshalledCorrectly()
        {
            var testBytes = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF };
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var byteBufHeader = new EventStreamHeader("BytesHeader");
            byteBufHeader.SetByteBuf(testBytes);
            eventHeaders["BytesHeader"] = byteBufHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.NotNull(result.BytesHeader);
            Assert.Equal(testBytes, result.BytesHeader.ToArray());
        }

        [Fact]
        public void ResponseUnmarshalling_TimestampEventHeader_UnmarshalledCorrectly()
        {
            var testTimestamp = new DateTime(2026, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var timestampHeader = new EventStreamHeader("TimestampHeader");
            timestampHeader.SetTimestamp(testTimestamp);
            eventHeaders["TimestampHeader"] = timestampHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal(testTimestamp, result.TimestampHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_MultipleEventHeaders_AllUnmarshalledCorrectly()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            
            var stringHeader = new EventStreamHeader("StringHeader");
            stringHeader.SetString("UTF8");
            eventHeaders["StringHeader"] = stringHeader;

            var boolHeader = new EventStreamHeader("BoolHeader");
            boolHeader.SetBool(false);
            eventHeaders["BoolHeader"] = boolHeader;

            var intHeader = new EventStreamHeader("IntHeader");
            intHeader.SetInt32(500);
            eventHeaders["IntHeader"] = intHeader;

            var longHeader = new EventStreamHeader("LongHeader");
            longHeader.SetInt64(1000000L);
            eventHeaders["LongHeader"] = longHeader;

            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Equal("UTF8", result.StringHeader);
            Assert.False(result.BoolHeader);
            Assert.Equal(500, result.IntHeader);
            Assert.Equal(1000000L, result.LongHeader);
        }

        [Fact]
        public void ResponseUnmarshalling_MissingEventHeader_PropertyNotSet()
        {
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            var responseData = new HttpClientResponseData(eventHeaders);
            var stream = new MemoryStream();
            var context = new JsonUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new TestEventModelUnmarshaller();
            var result = unmarshaller.Unmarshall(context);

            Assert.NotNull(result);
            Assert.Null(result.StringHeader);
            Assert.Null(result.BoolHeader);
            Assert.Null(result.IntHeader);
            Assert.Null(result.LongHeader);
            Assert.Null(result.DoubleHeader);
            Assert.Null(result.BytesHeader);
            Assert.Null(result.TimestampHeader);
        }

        #endregion

        #region Round-Trip Tests (Marshall then Unmarshall)

        [Fact]
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

            // Marshall
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var marshalContext = new JsonMarshallerContext(request, writer);
            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(originalModel, marshalContext);

            // Transfer headers from request to response (simulating the service echoing them back)
            var eventHeaders = new Dictionary<string, IEventStreamHeader>();
            foreach (var header in request.EventHeaders)
            {
                eventHeaders[header.Name] = header;
            }

            // Unmarshall
            var responseData = new HttpClientResponseData(eventHeaders);
            var responseStream = new MemoryStream();
            var unmarshalContext = new JsonUnmarshallerContext(responseStream, false, responseData);
            var unmarshaller = new TestEventModelUnmarshaller();
            var resultModel = unmarshaller.Unmarshall(unmarshalContext);

            // Verify all values preserved
            Assert.Equal(originalModel.StringHeader, resultModel.StringHeader);
            Assert.Equal(originalModel.BoolHeader, resultModel.BoolHeader);
            Assert.Equal(originalModel.IntHeader, resultModel.IntHeader);
            Assert.Equal(originalModel.LongHeader, resultModel.LongHeader);
            Assert.Equal(originalModel.DoubleHeader, resultModel.DoubleHeader);
            Assert.Equal(testBytes, resultModel.BytesHeader.ToArray());
            Assert.Equal(originalModel.TimestampHeader, resultModel.TimestampHeader);
        }

        #endregion

        #region Edge Case Tests

        [Fact]
        public void EdgeCase_EmptyString_MarshalledAndUnmarshalledCorrectly()
        {
            var testModel = new TestEventModel { StringHeader = "" };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal("", request.EventHeaders[0].AsString());
        }

        [Fact]
        public void EdgeCase_UnicodeString_MarshalledCorrectly()
        {
            var unicodeValue = "Hello 世界 🌍 Привет مرحبا";
            var testModel = new TestEventModel { StringHeader = unicodeValue };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal(unicodeValue, request.EventHeaders[0].AsString());
        }

        [Fact]
        public void EdgeCase_ZeroValues_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                IntHeader = 0,
                LongHeader = 0L,
                DoubleHeader = 0.0
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Equal(3, request.EventHeaders.Count);
            Assert.Equal(0, request.EventHeaders[0].AsInt32());
            Assert.Equal(0L, request.EventHeaders[1].AsInt64());
            Assert.Equal(0.0, request.EventHeaders[2].AsDouble());
        }

        [Fact]
        public void EdgeCase_NegativeNumbers_MarshalledCorrectly()
        {
            var testModel = new TestEventModel
            {
                IntHeader = -12345,
                LongHeader = -9223372036854775808L,
                DoubleHeader = -987.654321
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Equal(3, request.EventHeaders.Count);
            Assert.Equal(-12345, request.EventHeaders[0].AsInt32());
            Assert.Equal(-9223372036854775808L, request.EventHeaders[1].AsInt64());
            Assert.Equal(-987.654321, request.EventHeaders[2].AsDouble());
        }

        [Fact]
        public void EdgeCase_LargeByteBuffer_MarshalledCorrectly()
        {
            var largeBuffer = new byte[10000];
            for (int i = 0; i < largeBuffer.Length; i++)
            {
                largeBuffer[i] = (byte)(i % 256);
            }

            var testModel = new TestEventModel
            {
                BytesHeader = new MemoryStream(largeBuffer)
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Equal(largeBuffer, request.EventHeaders[0].AsByteBuf());
        }

        [Fact]
        public void EdgeCase_MinMaxInt32_RoundTrip()
        {
            // Test Min Value
            var minModel = new TestEventModel { IntHeader = int.MinValue };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(minModel, context);
            Assert.Equal(int.MinValue, request.EventHeaders[0].AsInt32());

            // Test Max Value
            var maxModel = new TestEventModel { IntHeader = int.MaxValue };
            var request2 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream2 = new MemoryStream();
            using var writer2 = new Utf8JsonWriter(memoryStream2);
            var context2 = new JsonMarshallerContext(request2, writer2);
            marshaller.Marshall(maxModel, context2);
            Assert.Equal(int.MaxValue, request2.EventHeaders[0].AsInt32());
        }

        [Fact]
        public void EdgeCase_MinMaxInt64_RoundTrip()
        {
            // Test Min Value
            var minModel = new TestEventModel { LongHeader = long.MinValue };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(minModel, context);
            Assert.Equal(long.MinValue, request.EventHeaders[0].AsInt64());

            // Test Max Value
            var maxModel = new TestEventModel { LongHeader = long.MaxValue };
            var request2 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream2 = new MemoryStream();
            using var writer2 = new Utf8JsonWriter(memoryStream2);
            var context2 = new JsonMarshallerContext(request2, writer2);
            marshaller.Marshall(maxModel, context2);
            Assert.Equal(long.MaxValue, request2.EventHeaders[0].AsInt64());
        }

        [Fact]
        public void EdgeCase_NullModel_NoHeadersAdded()
        {
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(null, context);

            Assert.Empty(request.EventHeaders);
        }

        [Fact]
        public void EdgeCase_EmptyByteBuffer_MarshalledCorrectly()
        {
            var emptyBytes = new byte[0];
            var testModel = new TestEventModel
            {
                BytesHeader = new MemoryStream(emptyBytes)
            };

            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);

            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(testModel, context);

            Assert.Single(request.EventHeaders);
            Assert.Empty(request.EventHeaders[0].AsByteBuf());
        }

        [Fact]
        public void EdgeCase_MinMaxDouble_RoundTrip()
        {
            // Test Min Value
            var minModel = new TestEventModel { DoubleHeader = double.MinValue };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(minModel, context);
            Assert.Equal(double.MinValue, request.EventHeaders[0].AsDouble());

            // Test Max Value
            var maxModel = new TestEventModel { DoubleHeader = double.MaxValue };
            var request2 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream2 = new MemoryStream();
            using var writer2 = new Utf8JsonWriter(memoryStream2);
            var context2 = new JsonMarshallerContext(request2, writer2);
            marshaller.Marshall(maxModel, context2);
            Assert.Equal(double.MaxValue, request2.EventHeaders[0].AsDouble());
        }

        [Fact]
        public void EdgeCase_SpecialDoubleValues_MarshalledCorrectly()
        {
            // Test NaN
            var nanModel = new TestEventModel { DoubleHeader = double.NaN };
            var request = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
            var context = new JsonMarshallerContext(request, writer);
            var marshaller = new TestEventModelMarshaller();
            marshaller.Marshall(nanModel, context);
            Assert.True(double.IsNaN(request.EventHeaders[0].AsDouble()));

            // Test Positive Infinity
            var posInfModel = new TestEventModel { DoubleHeader = double.PositiveInfinity };
            var request2 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream2 = new MemoryStream();
            using var writer2 = new Utf8JsonWriter(memoryStream2);
            var context2 = new JsonMarshallerContext(request2, writer2);
            marshaller.Marshall(posInfModel, context2);
            Assert.Equal(double.PositiveInfinity, request2.EventHeaders[0].AsDouble());

            // Test Negative Infinity
            var negInfModel = new TestEventModel { DoubleHeader = double.NegativeInfinity };
            var request3 = new DefaultRequest(new TestAmazonWebServiceRequest(), "TestService");
            var memoryStream3 = new MemoryStream();
            using var writer3 = new Utf8JsonWriter(memoryStream3);
            var context3 = new JsonMarshallerContext(request3, writer3);
            marshaller.Marshall(negInfModel, context3);
            Assert.Equal(double.NegativeInfinity, request3.EventHeaders[0].AsDouble());
        }

        #endregion
    }
}
#endif
