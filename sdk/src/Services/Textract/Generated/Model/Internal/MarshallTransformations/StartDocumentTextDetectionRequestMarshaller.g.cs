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

using Amazon.Textract.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDocumentTextDetection Request Marshaller
    /// </summary>
    public partial class StartDocumentTextDetectionRequestMarshaller : IMarshaller<IRequest, StartDocumentTextDetectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDocumentTextDetectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartDocumentTextDetectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Textract");
            string target = "Textract.StartDocumentTextDetection";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-27";
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
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            if (publicRequest.IsSetDocumentLocation())
            {
                context.Writer.WritePropertyName("DocumentLocation");
                context.Writer.WriteStartObject();

                var marshaller = DocumentLocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DocumentLocation, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetJobTag())
            {
                context.Writer.WritePropertyName("JobTag");
                context.Writer.WriteStringValue(publicRequest.JobTag);
            }
            if (publicRequest.IsSetKMSKeyId())
            {
                context.Writer.WritePropertyName("KMSKeyId");
                context.Writer.WriteStringValue(publicRequest.KMSKeyId);
            }
            if (publicRequest.IsSetNotificationChannel())
            {
                context.Writer.WritePropertyName("NotificationChannel");
                context.Writer.WriteStartObject();

                var marshaller = NotificationChannelMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationChannel, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartDocumentTextDetectionRequestMarshaller _instance = new();

        internal static StartDocumentTextDetectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartDocumentTextDetectionRequestMarshaller Instance => _instance;
    }
}
