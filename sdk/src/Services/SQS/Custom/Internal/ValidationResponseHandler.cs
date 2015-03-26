using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.SQS.Model;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Internal
{
    public class ValidationResponseHandler : PipelineHandler
    {
        /// <summary>
        /// Calls the post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            base.InvokeSync(executionContext);
            PostInvoke(executionContext);
        }
#if AWS_ASYNC_API

        /// <summary>
        /// Calls the and post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            PostInvoke(executionContext);
            return response;
        }

#elif AWS_APM_API

        /// <summary>
        /// Calls the PostInvoke methods after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            PostInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            base.InvokeAsyncCallback(executionContext);
        }
#endif
        protected void PostInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var response = executionContext.ResponseContext.Response;
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
#if WIN_RT
                writer.Dispose();
#else
                writer.Close();
#endif
            }
        }

        public static string CalculateMD5(Dictionary<string, MessageAttributeValue> attributes)
        {
            var sorted = attributes.OrderBy(kvp => kvp.Key, StringComparer.Ordinal);

            var ms = new MemoryStream();
            using (var writer = new SQSWriter(ms))
            {
                foreach (var kvp in sorted)
                {
                    var name = kvp.Key;
                    var value = kvp.Value;
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
                    else if (value.StringListValues != null)
                    {
                        writer.Write(STRING_LIST_TYPE);
                        foreach (var item in value.StringListValues)
                        {
                            writer.Write(item);
                        }
                    }
                    else if (value.BinaryListValues != null)
                    {
                        writer.Write(BINARY_LIST_TYPE);
                        foreach (var item in value.BinaryListValues)
                        {
                            writer.Write(item);
                        }
                    }
                }
            }

            var bytes = ms.ToArray();
            return CalculateMD5(bytes);
        }
        public static string CalculateMD5(string message)
        {
            var messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            return CalculateMD5(messageBytes);
        }
        public static string CalculateMD5(byte[] bytes)
        {
            var md5Hash = Amazon.Util.CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(bytes);
            var calculatedMd5 = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLowerInvariant();
            return calculatedMd5;
        }
        public static bool CompareMD5(string message, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(message);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        public static bool CompareMD5(Dictionary<string, MessageAttributeValue> attributes, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(attributes);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
        public static void ValidateMD5(string message, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException("MD5 hash mismatch");
        }
        public static void ValidateMD5(Dictionary<string, MessageAttributeValue> attributes, string md5FromService)
        {
            if (!CompareMD5(attributes, md5FromService))
                throw new AmazonSQSException("Attribute MD5 hash mismatch");
        }
        public static void ValidateMD5(string message, string messageId, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new AmazonSQSException(string.Format(CultureInfo.InvariantCulture, "MD5 hash mismatch for message id {0}", messageId));
        }
        public static void ValidateMD5(Dictionary<string, MessageAttributeValue> attributes, string messageId, string md5FromService)
        {
            if (!CompareMD5(attributes, md5FromService))
                throw new AmazonSQSException(string.Format(CultureInfo.InvariantCulture, "Attribute MD5 hash mismatch for message id {0}", messageId));
        }
        public static void ValidateMD5(Message message)
        {
            ValidateMD5(message.Body, message.MessageId, message.MD5OfBody);
            if (message.MessageAttributes != null && message.MessageAttributes.Count > 0 && !string.IsNullOrEmpty(message.MD5OfMessageAttributes))
                ValidateMD5(message.MessageAttributes, message.MessageId, message.MD5OfMessageAttributes);
        }

        public static void ValidateReceiveMessage(ReceiveMessageResponse response)
        {
            if (response != null && response.Messages != null && response.Messages.Count > 0)
            {
                foreach (Message message in response.Messages)
                {
                    ValidateMD5(message);
                }
            }
        }
        public static void ValidateSendMessage(SendMessageRequest request, SendMessageResponse response)
        {
            if (request != null && response != null && request.MessageBody != null &&
                !string.IsNullOrEmpty(request.MessageBody) &&
                !string.IsNullOrEmpty(response.MD5OfMessageBody))
            {
                ValidateMD5(request.MessageBody, response.MD5OfMessageBody);
            }

            if (request != null && response != null &&
                request.MessageAttributes != null && request.MessageAttributes.Count > 0 &&
                !string.IsNullOrEmpty(response.MD5OfMessageAttributes))
            {
                ValidateMD5(request.MessageAttributes, response.MD5OfMessageAttributes);
            }

        }
        public static void ValidateSendMessageBatch(SendMessageBatchRequest request, SendMessageBatchResponse response)
        {
            if (response != null && response.Successful != null && response.Successful.Count > 0)
            {
                Dictionary<string, SendMessageBatchRequestEntry> requestMessages = request.Entries.ToDictionary(entry => entry.Id, StringComparer.Ordinal);

                List<SendMessageBatchResultEntry> resultEntries = response.Successful;
                foreach (SendMessageBatchResultEntry entry in resultEntries)
                {
                    var message = requestMessages[entry.Id];
                    string id = entry.MessageId;

                    var body = message.MessageBody;
                    var bodyMd5 = entry.MD5OfMessageBody;
                    ValidateMD5(body, id, bodyMd5);

                    var attributes = message.MessageAttributes;
                    var attributesMd5 = entry.MD5OfMessageAttributes;
                    if (attributes != null && attributes.Count > 0 && !string.IsNullOrEmpty(attributesMd5))
                        ValidateMD5(attributes, id, attributesMd5);
                }
            }
        }
    }
}
