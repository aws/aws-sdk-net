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

        public static string CalculateMD5(string message)
        {
            var messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            var md5Hash = MD5Hash.ComputeHash(messageBytes);
            var calculatedMd5 = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLower();
            return calculatedMd5;
        }
        public static bool CompareMD5(string message, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(message);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        public static void ValidateMD5(string message, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException("MD5 hash mismatch");
        }
        public static void ValidateMD5(string message, string messageId, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException(string.Format("MD5 hash mismatch for message id {0}", messageId));
        }
        public static void ValidateMD5(Message message)
        {
            ValidateMD5(message.Body, message.MessageId, message.MD5OfBody);
        }

        public static void ValidateReceiveMessage(ReceiveMessageResponse response)
        {
            if (response != null && response.ReceiveMessageResult != null &&
                response.ReceiveMessageResult.Message != null && response.ReceiveMessageResult.Message.Count > 0)
            {
                foreach (Message message in response.ReceiveMessageResult.Message)
                {
                    AmazonSQSUtil.ValidateMD5(message);
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
                AmazonSQSUtil.ValidateMD5(request.MessageBody, response.SendMessageResult.MD5OfMessageBody);
            }
        }
        public static void ValidateSendMessageBatch(SendMessageBatchRequest request, SendMessageBatchResponse response)
        {
            if (response != null && response.SendMessageBatchResult != null &&
                response.SendMessageBatchResult.SendMessageBatchResultEntry != null && response.SendMessageBatchResult.SendMessageBatchResultEntry.Count > 0)
            {
                Dictionary<string, string> requestMessages = request.Entries.ToDictionary(entry => entry.Id, entry => entry.MessageBody, StringComparer.Ordinal);

                List<SendMessageBatchResultEntry> resultEntries = response.SendMessageBatchResult.SendMessageBatchResultEntry;
                foreach (SendMessageBatchResultEntry entry in resultEntries)
                {
                    string body = requestMessages[entry.Id];
                    string md5 = entry.MD5OfMessageBody;
                    string id = entry.MessageId;

                    AmazonSQSUtil.ValidateMD5(body, id, md5);
                }
            }
        }

    }
}
