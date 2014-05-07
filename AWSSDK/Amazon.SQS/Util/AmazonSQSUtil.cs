/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-09-15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Amazon.SQS.Model;
using Attribute = Amazon.SQS.Model.Attribute;
using System.Globalization;
using System.Text;
using System.IO;

namespace Amazon.SQS.Util
{
    internal static class AmazonSQSUtil
    {
        public static Attribute FindAttribute(IList<Attribute> attributes, string name)
        {
            foreach (Attribute attr in attributes)
            {
                if (string.Equals(name, attr.Name))
                {
                    return attr;
                }
            }

            return null;
        }

        [ThreadStatic]
        private static MD5 _md5 = null;
        private static MD5 MD5Hash
        {
            get
            {
                if (_md5 == null)
                    _md5 = MD5.Create();
                return _md5;
            }
        }

        private static Encoding utf8 = Encoding.UTF8;
        private const byte STRING_TYPE = 1;
        private const byte BINARY_TYPE = 2;
        private const byte STRING_LIST_TYPE = 3;
        private const byte BINARY_LIST_TYPE = 4;

        private class SQSWriter : IDisposable
        {
            private BinaryWriter writer;
            private Encoding utf8 = Encoding.UTF8;
            private bool shouldReverseInts;

            public SQSWriter(Stream stream)
            {
                writer = new BinaryWriter(stream);
                shouldReverseInts = BitConverter.IsLittleEndian;
            }

            public void Write(string value)
            {
                if (value == null) throw new ArgumentNullException("value");

                var valueUtf8 = utf8.GetBytes(value);
                Write(valueUtf8.Length);
                Write(valueUtf8);
            }
            public void Write(MemoryStream ms)
            {
                if (ms == null) throw new ArgumentNullException("ms");

                Write((int)ms.Length);
                var bytes = ms.ToArray();
                Write(bytes);
            }
            public void Write(int value)
            {
                var bytes = BitConverter.GetBytes(value);
                if (shouldReverseInts)
                    bytes = bytes.Reverse().ToArray();
                Write(bytes);
            }
            public void Write(byte value)
            {
                writer.Write(value);
            }
            public void Write(byte[] bytes)
            {
                writer.Write(bytes);
            }

            public void Dispose()
            {
                writer.Close();
            }
        }

        private static string CalculateMD5(List<MessageAttribute> attributes)
        {
            var sorted = attributes.OrderBy(m => m.Name, StringComparer.OrdinalIgnoreCase);

            var ms = new MemoryStream();
            using (var writer = new SQSWriter(ms))
            {
                foreach (var m in sorted)
                {
                    var name = m.Name;
                    var value = m.Value;
                    writer.Write(name);
                    writer.Write(value.DataType);

                    if (value.StringValue != null)
                    {
                        writer.Write(STRING_TYPE);
                        writer.Write(value.StringValue);
                    }
                    else if (value.BinaryValue != null)
                    {
                        writer.Write(BINARY_TYPE);
                        writer.Write(value.BinaryValue);
                    }
                    else if (value.StringListValue != null)
                    {
                        writer.Write(STRING_LIST_TYPE);
                        foreach (var item in value.StringListValue)
                        {
                            writer.Write(item);
                        }
                    }
                    else if (value.BinaryListValue != null)
                    {
                        writer.Write(BINARY_LIST_TYPE);
                        foreach (var item in value.BinaryListValue)
                        {
                            writer.Write(item);
                        }
                    }
                }
            }

            var bytes = ms.ToArray();
            Console.WriteLine(BitConverter.ToString(bytes));
            return CalculateMD5(bytes);
        }
        private static string CalculateMD5(string message)
        {
            var messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            return CalculateMD5(messageBytes);
        }
        private static string CalculateMD5(byte[] bytes)
        {
            var md5Hash = MD5Hash.ComputeHash(bytes);
            var calculatedMd5 = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLower(CultureInfo.InvariantCulture);
            return calculatedMd5;
        }
        private static bool CompareMD5(string message, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(message);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        private static bool CompareMD5(List<MessageAttribute> attributes, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(attributes);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        private static void ValidateMD5(string message, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException("MD5 hash mismatch");
        }
        private static void ValidateMD5(List<MessageAttribute> attributes, string md5FromService)
        {
            if (!CompareMD5(attributes, md5FromService))
                throw new AmazonSQSException("Attribute MD5 hash mismatch");
        }
        private static void ValidateMD5(string message, string messageId, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException(string.Format(CultureInfo.InvariantCulture, "MD5 hash mismatch for message id {0}", messageId));
        }
        private static void ValidateMD5(List<MessageAttribute> attributes, string messageId, string md5FromService)
        {
            if (!CompareMD5(attributes, md5FromService))
                throw new AmazonSQSException(string.Format(CultureInfo.InvariantCulture, "Attribute MD5 hash mismatch for message id {0}", messageId));
        }
        private static void ValidateMD5(Message message)
        {
            ValidateMD5(message.Body, message.MessageId, message.MD5OfBody);
            if (message.MessageAttribute != null && message.MessageAttribute.Count > 0 && !string.IsNullOrEmpty(message.MD5OfMessageAttributes))
                ValidateMD5(message.MessageAttribute, message.MessageId, message.MD5OfMessageAttributes);
        }


        public static void ValidateReceiveMessage(ReceiveMessageResponse response)
        {
            if (response != null && response.ReceiveMessageResult != null &&
                response.ReceiveMessageResult.Message != null && response.ReceiveMessageResult.Message.Count > 0)
            {
                foreach (Message message in response.ReceiveMessageResult.Message)
                {
                    ValidateMD5(message);
                }
            }
        }
        public static void ValidateSendMessage(SendMessageRequest request, SendMessageResponse response)
        {
            if (request != null && response != null &&
                request.MessageBody != null && response.SendMessageResult != null &&
                !string.IsNullOrEmpty(request.MessageBody) &&
                !string.IsNullOrEmpty(response.SendMessageResult.MD5OfMessageBody))
            {
                ValidateMD5(request.MessageBody, response.SendMessageResult.MD5OfMessageBody);
            }

            if (request != null && response != null && response.SendMessageResult != null &&
                request.MessageAttribute != null && request.MessageAttribute.Count > 0 &&
                !string.IsNullOrEmpty(response.SendMessageResult.MD5OfMessageAttributes))
            {
                ValidateMD5(request.MessageAttribute, response.SendMessageResult.MD5OfMessageAttributes);
            }
        }
        public static void ValidateSendMessageBatch(SendMessageBatchRequest request, SendMessageBatchResponse response)
        {
            if (response != null && response.SendMessageBatchResult != null &&
                response.SendMessageBatchResult.SendMessageBatchResultEntry != null && response.SendMessageBatchResult.SendMessageBatchResultEntry.Count > 0)
            {
                Dictionary<string, SendMessageBatchRequestEntry> requestMessages = request.Entries.ToDictionary(entry => entry.Id, StringComparer.Ordinal);

                List<SendMessageBatchResultEntry> resultEntries = response.SendMessageBatchResult.SendMessageBatchResultEntry;
                foreach (SendMessageBatchResultEntry entry in resultEntries)
                {
                    var message = requestMessages[entry.Id];
                    string body = message.MessageBody;
                    string md5 = entry.MD5OfMessageBody;
                    string id = entry.MessageId;

                    ValidateMD5(body, id, md5);

                    var attributes = message.MessageAttribute;
                    var attributesMd5 = entry.MD5OfMessageAttributes;
                    if (attributes != null && attributes.Count > 0 && !string.IsNullOrEmpty(attributesMd5))
                        ValidateMD5(attributes, id, attributesMd5);
                }
            }
        }

    }
}
