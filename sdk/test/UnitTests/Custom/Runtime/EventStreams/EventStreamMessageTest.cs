/*******************************************************************************
 *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using AWSSDK_DotNet35.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdParty.Json.LitJson;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EventStreamMessageTest
    {
        private static readonly string TestFileEncodedPositivePrefix = "eventstream_encoded_positive";
        private static readonly string TestFileDecodedPositivePrefix = "eventstream_decoded_positive";
        private static readonly string TestFileEncodedNegativePrefix = "eventstream_encoded_negative";

        private const string HeaderField = "header";
        private const string HeaderNameField = "name";
        private const string HeaderTypeField = "type";
        private const string HeaderValueField = "value";
        private const string PayloadField = "payload";

        private readonly IDictionary<string, byte[]> _positiveEncodedTestCases = new Dictionary<string, byte[]>();
        private readonly IDictionary<string, byte[]> _positiveDecodedTestCases = new Dictionary<string, byte[]>();
        private readonly IDictionary<string, byte[]> _negativeEncodedTestCases = new Dictionary<string, byte[]>();
        private readonly IList<EventStreamMessage> _decoderMessages = new List<EventStreamMessage>();

        [TestInitialize]
        public void InitTestCase()
        {
            var allResources = typeof(EventStreamMessageTest).Assembly.GetManifestResourceNames();

            var positiveEncodedCases = allResources.Where(name => name.Contains(TestFileEncodedPositivePrefix)).ToList();
            foreach (var testcase in positiveEncodedCases)
            {
                AddTestCaseResource(testcase, _positiveEncodedTestCases);
            }

            var positiveDecodedCases = allResources.Where(name => name.Contains(TestFileDecodedPositivePrefix)).ToList();
            foreach (var testcase in positiveDecodedCases)
            {
                AddTestCaseResource(testcase, _positiveDecodedTestCases);
            }

            var negativeDecodedCases = allResources.Where(name => name.Contains(TestFileEncodedNegativePrefix)).ToList();
            foreach (var testcase in negativeDecodedCases)
            {
                AddTestCaseResource(testcase, _negativeEncodedTestCases);
            }
        }

        private static void AddTestCaseResource(string resourceName, IDictionary<string, byte[]> collection)
        {
            using (var stream = Utils.GetResourceStream(resourceName))
            {
                var fileBuf = new byte[stream.Length];

                var offset = 0;
                var read = 0;
                while ((read = stream.Read(fileBuf, offset, fileBuf.Length - offset)) != 0)
                {
                    offset += read;
                }

                var key = resourceName.Substring(resourceName.LastIndexOf('.') + 1).Replace("eventstream_decoded_", "").Replace("eventstream_encoded_", "");
                collection.Add(key, fileBuf);
            }
        }

        [TestMethod]
        public void TestPositiveDecode()
        {
            foreach (var entry in _positiveEncodedTestCases)
            {
                //verify decode doesn't throw any errors.
                var message = EventStreamMessage.FromBuffer(entry.Value, 0, entry.Value.Length);
                //reencode and make sure the buffers are identical
                var serializedMessage = message.ToByteArray();
                CollectionAssert.AreEqual(entry.Value, serializedMessage);

                //now loop over the decoded document and make sure the fields are match.
                var decodedDoc = _positiveDecodedTestCases[entry.Key];
                var jsonStr = Encoding.UTF8.GetString(decodedDoc);
                var data = JsonMapper.ToObject(jsonStr);

                if (data[PayloadField] != null)
                {
                    var base64Payload = (String)data[PayloadField];
                    var payload = Convert.FromBase64String(base64Payload);
                    CollectionAssert.AreEqual(payload, message.Payload);
                }

                if (data[HeaderField] != null)
                {
                    var headersCollection = data[HeaderField];

                    Assert.AreEqual(headersCollection.Count, message.Headers.Count);

                    foreach (var header in headersCollection.OfType<JsonData>())
                    {
                        string headerName = (string)header[HeaderNameField];
                        var headerValue = message.Headers[headerName];
                        Assert.IsNotNull(headerValue);

                        var type = (EventStreamHeaderType)(int)header[HeaderTypeField];
                        Assert.AreEqual(type, headerValue.HeaderType);

                        switch (type)
                        {
                            case EventStreamHeaderType.String:
                                var strVal = Encoding.UTF8.GetString(Convert.FromBase64String((string)header[HeaderValueField]));
                                Assert.AreEqual(strVal, headerValue.AsString());
                                break;
                            case EventStreamHeaderType.UUID:
                                var uuidVal = Convert.FromBase64String((string)header[HeaderValueField]);
                                CollectionAssert.AreEqual(uuidVal, headerValue.AsUUID().ToByteArray());
                                break;
                            case EventStreamHeaderType.ByteBuf:
                                var byteBuf = Convert.FromBase64String((string)header[HeaderValueField]);
                                CollectionAssert.AreEqual(byteBuf, headerValue.AsByteBuf());
                                break;
                            case EventStreamHeaderType.BoolFalse:
                            case EventStreamHeaderType.BoolTrue:
                                var boolVal = (bool)header[HeaderValueField];
                                Assert.AreEqual(boolVal, headerValue.AsBool());
                                break;
                            case EventStreamHeaderType.Byte:
                                var byteVal = (byte)(int)header[HeaderValueField];
                                Assert.AreEqual(byteVal, headerValue.AsByte());
                                break;
                            case EventStreamHeaderType.Int16:
                                var int16Val = (short)header[HeaderValueField];
                                Assert.AreEqual(int16Val, headerValue.AsInt16());
                                break;
                            case EventStreamHeaderType.Int32:
                                var int32Val = (int)header[HeaderValueField];
                                Assert.AreEqual(int32Val, headerValue.AsInt32());
                                break;
                            case EventStreamHeaderType.Int64:
                                var intVal = (long)header[HeaderValueField];
                                Assert.AreEqual(intVal, headerValue.AsInt64());
                                break;
                            case EventStreamHeaderType.Timestamp:
                                var dateVal = (long)header[HeaderValueField];
                                /* we only do this in this spot because we're setting it from the unix epoch directly.
                                   normal API usage, you can use DateTime as a first class citizen. */
                                Assert.AreEqual(dateVal, headerValue.AsTimestamp().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void TestPositiveEncode()
        {
            foreach (var entry in _positiveDecodedTestCases)
            {
                byte[] payload = null;
                var headersList = new List<IEventStreamHeader>();

                //read the data to encode, then add it to payload and headers list.
                var decodedDoc = entry.Value;
                var jsonStr = Encoding.UTF8.GetString(decodedDoc);
                var data = JsonMapper.ToObject(jsonStr);

                if (data[PayloadField] != null)
                {
                    var base64Payload = (String)data[PayloadField];
                    payload = Convert.FromBase64String(base64Payload);
                }

                if (data[HeaderField] != null)
                {
                    var headersCollection = data[HeaderField];

                    foreach (var header in headersCollection.OfType<JsonData>())
                    {
                        var headerName = (string)header[HeaderNameField];
                        var headerValue = new EventStreamHeader(headerName);

                        var type = (EventStreamHeaderType)(int)header[HeaderTypeField];

                        switch (type)
                        {
                            case EventStreamHeaderType.String:
                                var strVal = Encoding.UTF8.GetString(Convert.FromBase64String((string)header[HeaderValueField]));
                                headerValue.SetString(strVal);
                                break;
                            case EventStreamHeaderType.UUID:
                                var uuidVal = Convert.FromBase64String((string)header[HeaderValueField]);
                                headerValue.SetUUID(new Guid(uuidVal));
                                break;
                            case EventStreamHeaderType.ByteBuf:
                                var byteBuf = Convert.FromBase64String((string)header[HeaderValueField]);
                                headerValue.SetByteBuf(byteBuf);
                                break;
                            case EventStreamHeaderType.BoolFalse:
                            case EventStreamHeaderType.BoolTrue:
                                var boolVal = (bool)header[HeaderValueField];
                                headerValue.SetBool(boolVal);
                                break;
                            case EventStreamHeaderType.Byte:
                                var byteVal = (byte)(int)header[HeaderValueField];
                                headerValue.SetByte(byteVal);
                                break;
                            case EventStreamHeaderType.Int16:
                                var int16Val = (short)header[HeaderValueField];
                                headerValue.SetInt16(int16Val);
                                break;
                            case EventStreamHeaderType.Int32:
                                var int32Val = (int)header[HeaderValueField];
                                headerValue.SetInt32(int32Val);
                                break;
                            case EventStreamHeaderType.Int64:
                                var intVal = (long)header[HeaderValueField];
                                headerValue.SetInt64(intVal);
                                break;
                            case EventStreamHeaderType.Timestamp:
                                var dateVal = (long)header[HeaderValueField];
                                /* we only do this in this spot because we're setting it from the unix epoch directly.
                                   normal API usage, you can use DateTime as a first class citizen. */
                                headerValue.SetTimestamp(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(dateVal));
                                break;
                            default:
                                break;
                        }

                        headersList.Add(headerValue);
                    }
                }

                //create the message, and serialize it, it should equal the original encoded data.
                var message = new EventStreamMessage(headersList, payload);
                CollectionAssert.Equals(_positiveEncodedTestCases[entry.Key], message.ToByteArray());
            }
        }

        [TestMethod]
        public void TestNegativeDecode()
        {
            foreach (var entry in _negativeEncodedTestCases)
            {
                try
                {
                    var message = EventStreamMessage.FromBuffer(entry.Value, 0, entry.Value.Length);
                    Assert.Fail("Invalid message should have failed");
                }
                catch (Exception)
                {
                }
            }
        }

        [TestMethod]
        public void TestStreamingDecoder()
        {
            foreach(var bufferSize in new[] { 20, 128 })
            {
                _decoderMessages.Clear();
                using (var memoryStream = new MemoryStream())
                {
                    foreach (var entry in _positiveEncodedTestCases)
                    {
                        memoryStream.Write(entry.Value, 0, entry.Value.Length);
                    }

                    memoryStream.Position = 0;

                    var decoder = new EventStreamDecoder();
                    decoder.MessageReceived += Decoder_MessageReceived;

                    var buffer = new byte[bufferSize];
                    var read = 0;
                    while ((read = memoryStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        decoder.ProcessData(buffer, 0, read);
                    }
                }

                Assert.AreEqual(_positiveEncodedTestCases.Count, _decoderMessages.Count);
                var index = 0;

                foreach (var messageBuffer in _positiveEncodedTestCases.Values)
                {
                    CollectionAssert.AreEqual(messageBuffer, _decoderMessages[index++].ToByteArray());
                }

            }
        }

        private void Decoder_MessageReceived(object sender, EventStreamMessageReceivedEventArgs args)
        {
            _decoderMessages.Add(args.Message);
        }

        [TestMethod]
        public void TestStreamingDecoderFailures()
        {
            foreach (var entry in _negativeEncodedTestCases)
            {
                var decoder = new EventStreamDecoder();
                decoder.MessageReceived += DecoderDidNotFail;

                try
                {
                    decoder.ProcessData(entry.Value, 0, entry.Value.Length);
                    Assert.Fail("The decoder should have failed on write of invalid data.");
                }
                catch (Exception)
                {
                    try
                    {
                        decoder.ProcessData(entry.Value, 0, entry.Value.Length);
                        Assert.Fail("Calling decode on a decoder that has failed, should throw and exception");
                    }
                    catch (EventStreamDecoderIllegalStateException ex)
                    {
                    }
                }
            }
        }

        private void DecoderDidNotFail(object sender, EventStreamMessageReceivedEventArgs args)
        {
            Assert.Fail("Invalid message should have caused a failure instead of an event");
        }
    }
}
