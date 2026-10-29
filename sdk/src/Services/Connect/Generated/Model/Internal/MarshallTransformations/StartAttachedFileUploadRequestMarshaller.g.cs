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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Connect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAttachedFileUpload Request Marshaller
    /// </summary>
    public partial class StartAttachedFileUploadRequestMarshaller : IMarshaller<IRequest, StartAttachedFileUploadRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAttachedFileUploadRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartAttachedFileUploadRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (string.IsNullOrEmpty(publicRequest.AssociatedResourceArn))
            {
                throw new AmazonConnectException("Request object does not have required field AssociatedResourceArn set");
            }

            if (publicRequest.IsSetAssociatedResourceArn())
            {
                request.Parameters.Add("associatedResourceArn", StringUtils.FromString(publicRequest.AssociatedResourceArn));
            }

            if (!publicRequest.IsSetInstanceId())
            {
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            }
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));

            request.ResourcePath = "/attached-files/{InstanceId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetCreatedBy())
            {
                context.Writer.WritePropertyName("CreatedBy");
                context.Writer.WriteStartObject();

                var marshaller = CreatedByInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.CreatedBy, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFileName())
            {
                context.Writer.WritePropertyName("FileName");
                context.Writer.WriteStringValue(publicRequest.FileName);
            }
            if (publicRequest.IsSetFileSizeInBytes())
            {
                context.Writer.WritePropertyName("FileSizeInBytes");
                context.Writer.WriteNumberValue(publicRequest.FileSizeInBytes.Value);
            }
            if (publicRequest.IsSetFileUseCaseType())
            {
                context.Writer.WritePropertyName("FileUseCaseType");
                context.Writer.WriteStringValue(publicRequest.FileUseCaseType);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetUrlExpiryInSeconds())
            {
                context.Writer.WritePropertyName("UrlExpiryInSeconds");
                context.Writer.WriteNumberValue(publicRequest.UrlExpiryInSeconds.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly StartAttachedFileUploadRequestMarshaller _instance = new();

        internal static StartAttachedFileUploadRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartAttachedFileUploadRequestMarshaller Instance => _instance;
    }
}
