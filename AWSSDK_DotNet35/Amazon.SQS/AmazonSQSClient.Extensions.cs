using Amazon.Runtime;
using Amazon.SQS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS.Model;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SQS
{
    public partial class AmazonSQSClient : AmazonWebServiceClient, IAmazonSQS
    {
        protected override void ProcessRequestHandlers(IRequest request)
        {
            if (request.Parameters.ContainsKey("QueueUrl"))
            {
                string queueUrl = request.Parameters["QueueUrl"];
                Uri uri = new Uri(queueUrl);
                request.Parameters.Remove("QueueUrl");
                request.ResourcePath = uri.AbsolutePath;
            }

            base.ProcessRequestHandlers(request);
        }

        protected override void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
        {
            base.ProcessResponseHandlers(response, request, webResponseData);

            ReceiveMessageResponse receiveMessageResponse = response as ReceiveMessageResponse;
            if (receiveMessageResponse != null)
            {
                ValidateReceiveMessage(receiveMessageResponse);
            }

            SendMessageResponse sendMessageResponse = response as SendMessageResponse;
            SendMessageRequest sendMessageRequest = request.OriginalRequest as SendMessageRequest;
            if (sendMessageRequest != null && sendMessageResponse != null)
            {
                ValidateSendMessage(sendMessageRequest, sendMessageResponse);
            }

            SendMessageBatchRequest sendMessageBatchRequest = request.OriginalRequest as SendMessageBatchRequest;
            SendMessageBatchResponse sendMessageBatchResponse = response as SendMessageBatchResponse;
            if (sendMessageBatchRequest != null && sendMessageBatchResponse != null)
            {
                ValidateSendMessageBatch(sendMessageBatchRequest, sendMessageBatchResponse);
            }
        }

        private static string CalculateMD5(string message)
        {
            var messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            var md5Hash = Amazon.Util.CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(messageBytes);
            var calculatedMd5 = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLower(CultureInfo.InvariantCulture);
            return calculatedMd5;
        }
        private static bool CompareMD5(string message, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(message);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        private static void ValidateMD5(string message, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException("MD5 hash mismatch");
        }
        private static void ValidateMD5(string message, string messageId, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException(string.Format(CultureInfo.InvariantCulture, "MD5 hash mismatch for message id {0}", messageId));
        }
        private static void ValidateMD5(Message message)
        {
            ValidateMD5(message.Body, message.MessageId, message.MD5OfBody);
        }

        private static void ValidateReceiveMessage(ReceiveMessageResponse response)
        {
            if (response != null && response.Messages != null && response.Messages.Count > 0)
            {
                foreach (Message message in response.Messages)
                {
                    ValidateMD5(message);
                }
            }
        }
        private static void ValidateSendMessage(SendMessageRequest request, SendMessageResponse response)
        {
            if (request != null && response != null && request.MessageBody != null &&
                !string.IsNullOrEmpty(request.MessageBody) &&
                !string.IsNullOrEmpty(response.MD5OfMessageBody))
            {
                ValidateMD5(request.MessageBody, response.MD5OfMessageBody);
            }
        }
        private static void ValidateSendMessageBatch(SendMessageBatchRequest request, SendMessageBatchResponse response)
        {
            if (response != null && response.Successful != null && response.Successful.Count > 0)
            {
                Dictionary<string, string> requestMessages = request.Entries.ToDictionary(entry => entry.Id, entry => entry.MessageBody, StringComparer.Ordinal);

                List<SendMessageBatchResultEntry> resultEntries = response.Successful;
                foreach (SendMessageBatchResultEntry entry in resultEntries)
                {
                    string body = requestMessages[entry.Id];
                    string md5 = entry.MD5OfMessageBody;
                    string id = entry.MessageId;

                    ValidateMD5(body, id, md5);
                }
            }
        }
    }
}
