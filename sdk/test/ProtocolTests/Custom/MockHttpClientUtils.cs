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
using Amazon.Runtime.EventStreams;
using AWSSDK.UnitTests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.ProtocolTests.Utils
{
#if NETFRAMEWORK
    using PlatformMockHttpRequestFactory = MockHttpRequestFactory<System.IO.Stream>;
#else
    using PlatformMockHttpRequestFactory = MockHttpRequestFactory<System.Net.Http.HttpContent>;
#endif

    /// <summary>
    /// Helpers for running protocol tests end-to-end through a real service client with a mocked HTTP layer.
    /// </summary>
    internal static class MockHttpClientUtils
    {
        public const string TestServiceUrl = "https://test.com/";

        /// <summary>
        /// Credentials to construct a client under test with. Signing runs as normal against these.
        /// </summary>
        public static AWSCredentials TestCredentials => new BasicAWSCredentials("AKID", "SECRET");

        /// <summary>
        /// Replaces the HttpHandler of the client's pipeline with one backed by a <see cref="MockHttpRequestFactory{T}"/>
        /// that always returns the given response.
        /// </summary>
        public static PlatformMockHttpRequestFactory InjectMockHttp(AmazonServiceClient client, MockHttpResponse response)
        {
            var factory = new PlatformMockHttpRequestFactory(response);
            CustomResponses.ReplaceHttpRequestHandler(client, factory);
            return factory;
        }

        /// <summary>
        /// Encodes event stream messages into an HTTP response body.
        /// </summary>
        public static byte[] EncodeEvents(params EventStreamMessage[] messages)
        {
            using (var body = new MemoryStream())
            {
                foreach (var message in messages)
                {
                    var bytes = message.ToByteArray();
                    body.Write(bytes, 0, bytes.Length);
                }
                return body.ToArray();
            }
        }

        /// <summary>
        /// Creates an event message the way a service would send it for the given event type.
        /// </summary>
        public static EventStreamMessage CreateEvent(string eventType, string contentType, byte[] payload, IDictionary<string, string> eventHeaders = null)
        {
            var headers = new List<IEventStreamHeader>
            {
                CreateStringHeader(":message-type", "event"),
                CreateStringHeader(":event-type", eventType),
            };
            if (contentType != null)
                headers.Add(CreateStringHeader(":content-type", contentType));
            if (eventHeaders != null)
                headers.AddRange(eventHeaders.Select(h => CreateStringHeader(h.Key, h.Value)));

            return new EventStreamMessage(headers, payload ?? Array.Empty<byte>());
        }

        public static EventStreamMessage CreateEvent(string eventType, string contentType, string payload, IDictionary<string, string> eventHeaders = null)
        {
            return CreateEvent(eventType, contentType, Encoding.UTF8.GetBytes(payload), eventHeaders);
        }

        /// <summary>
        /// The SDK signs each input event by wrapping it in an outer message with :date and :chunk-signature
        /// headers. This returns the inner event messages, skipping the empty end-of-stream frame.
        /// </summary>
        public static List<EventStreamMessage> DecodeSignedInputFrames(IEnumerable<byte[]> frames)
        {
            return frames
                .Select(frame => EventStreamMessage.FromBuffer(frame, 0, frame.Length))
                .Where(outer => outer.Payload != null && outer.Payload.Length > 0)
                .Select(outer => EventStreamMessage.FromBuffer(outer.Payload, 0, outer.Payload.Length))
                .ToList();
        }

        public static string GetStringHeader(EventStreamMessage message, string name)
        {
            return message.Headers.TryGetValue(name, out var header) ? header.AsString() : null;
        }

        private static IEventStreamHeader CreateStringHeader(string name, string value)
        {
            var header = new EventStreamHeader(name);
            header.SetString(value);
            return header;
        }
    }
}
