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
using System;
using System.Collections.Generic;
using System.Globalization;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal;
using Amazon.SimpleNotificationService;
using Amazon.SQS;
using Amazon.SQS.Model;

#if NET8_0_OR_GREATER
using System.Text.Json.Serialization;
#endif

namespace Amazon.Glacier.Transfer.Internal
{
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("ArchiveTransferManager has not been updated to support Native AOT compilations.")]
#endif
    internal partial class DownloadFileCommand : IDisposable
    {
        internal const int MAX_OPERATION_RETRY = 5;
        const string SQS_POLICY = 
            "{" +
            "    \"Version\" : \"2008-10-17\"," +
            "    \"Statement\" : [" +
            "        {" +
            "            \"Sid\" : \"sns-rule\"," +
            "            \"Effect\" : \"Allow\"," +
            "            \"Principal\" : {" +
            "                \"AWS\" : \"*\"" +
            "            }," +
            "            \"Action\"    : \"sqs:SendMessage\"," +
            "            \"Resource\"  : \"{QuereArn}\"," +
            "            \"Condition\" : {" +
            "                \"ArnLike\" : {" +
            "                    \"aws:SourceArn\" : \"{TopicArn}\"" +
            "                }" +
            "            }" +
            "        }" +
            "    ]" +
            "}";

        ArchiveTransferManager manager;
        string vaultName;
        string archiveId;
        string filePath;
        DownloadOptions options;

        IAmazonSimpleNotificationService snsClient;
        IAmazonSQS sqsClient;

        string topicArn;
        string queueUrl;
        string queueArn;

        bool disposed = false;

        internal DownloadFileCommand(ArchiveTransferManager manager, string vaultName, string archiveId, string filePath, DownloadOptions options)
        {
            this.manager = manager;
            this.vaultName = vaultName;
            this.archiveId = archiveId;
            this.filePath = filePath;
            this.options = options;

            var glacierClient = this.manager.GlacierClient as AmazonGlacierClient;
            if (glacierClient == null)
                throw new InvalidOperationException("This can only be called using an AmazonGlacierClient");

            this.snsClient = ServiceClientHelpers.CreateServiceFromAnother<AmazonSimpleNotificationServiceClient, AmazonSimpleNotificationServiceConfig>(glacierClient);
            this.sqsClient = ServiceClientHelpers.CreateServiceFromAnother<AmazonSQSClient, AmazonSQSConfig>(glacierClient);

            if (this.options == null)
                this.options = new DownloadOptions();
        }  

        /// <summary>
        /// Parse the sqs message to make sure it contains the right job id and that the job was successful
        /// </summary>
        /// <param name="message"></param>
        string getJobIdFromMessage(Message message)
        {
            string json;

            // Some older AWS accounts send messages base 64 encoded.  Do a check to 
            // see if this is the start of a json document.  If not then base 64 decode the message.
            if (message.Body.Trim().StartsWith("{", StringComparison.OrdinalIgnoreCase))
                json = message.Body;
            else
                json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(message.Body));

            Dictionary<string, string> outerLayer = JsonSerializerHelper.Deserialize<Dictionary<string, string>>(json, GlacierDictionarySerializerContexts.Default);
            Dictionary<string, object> fields = JsonSerializerHelper.Deserialize<Dictionary<string, object>>(outerLayer["Message"], GlacierDictionarySerializerContexts.Default);

            string jobId = fields["JobId"] as string;

            string statusCode = fields["StatusCode"] as string;
            if (!string.Equals(statusCode, GlacierUtils.JOB_STATUS_SUCCEEDED, StringComparison.OrdinalIgnoreCase))
            {
                object statusMessage = "";
                fields.TryGetValue("StatusMessage", out statusMessage);
                throw new AmazonGlacierException(
                    string.Format(CultureInfo.InvariantCulture, "Failed to download {0}: {1}",
                        this.filePath, Convert.ToString(statusMessage, CultureInfo.InvariantCulture)));
            }

            return jobId;
        }

#region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (snsClient != null)
                    {
                        snsClient.Dispose();
                        snsClient = null;
                    }
                    if (sqsClient != null)
                    {
                        sqsClient.Dispose();
                        sqsClient = null;
                    }
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

#endregion
    }

    [JsonSerializable(typeof(Dictionary<string, string>))]
    [JsonSerializable(typeof(Dictionary<string, object>))]
    internal partial class GlacierDictionarySerializerContexts : JsonSerializerContext
    {
    }
}
