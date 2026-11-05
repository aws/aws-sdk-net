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

using Amazon.AWSSupport.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAttachmentUploadLinks Request Marshaller
    /// </summary>
    public partial class GetAttachmentUploadLinksRequestMarshaller : IMarshaller<IRequest, GetAttachmentUploadLinksRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAttachmentUploadLinksRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetAttachmentUploadLinksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.GetAttachmentUploadLinks";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("dryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }
            if (publicRequest.IsSetFileName())
            {
                context.Writer.WritePropertyName("fileName");
                context.Writer.WriteStringValue(publicRequest.FileName);
            }
            if (publicRequest.IsSetFileSizeBytes())
            {
                context.Writer.WritePropertyName("fileSizeBytes");
                context.Writer.WriteNumberValue(publicRequest.FileSizeBytes.Value);
            }
            if (publicRequest.IsSetUploadId())
            {
                context.Writer.WritePropertyName("uploadId");
                context.Writer.WriteStringValue(publicRequest.UploadId);
            }
            if (publicRequest.IsSetUploadRange())
            {
                context.Writer.WritePropertyName("uploadRange");
                context.Writer.WriteStartObject();

                var marshaller = UploadRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.UploadRange, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetAttachmentUploadLinksRequestMarshaller _instance = new();

        internal static GetAttachmentUploadLinksRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAttachmentUploadLinksRequestMarshaller Instance => _instance;
    }
}
