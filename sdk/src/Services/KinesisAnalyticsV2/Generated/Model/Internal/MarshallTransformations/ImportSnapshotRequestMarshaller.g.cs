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

using Amazon.KinesisAnalyticsV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportSnapshot Request Marshaller
    /// </summary>
    public partial class ImportSnapshotRequestMarshaller : IMarshaller<IRequest, ImportSnapshotRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportSnapshotRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisAnalyticsV2");
            string target = "KinesisAnalytics_20180523.ImportSnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-23";
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
            if (publicRequest.IsSetDestinationEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("DestinationEncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnapshotEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationEncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetImportSourceConfiguration())
            {
                context.Writer.WritePropertyName("ImportSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ImportSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ImportSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSnapshotDescription())
            {
                context.Writer.WritePropertyName("SnapshotDescription");
                context.Writer.WriteStringValue(publicRequest.SnapshotDescription);
            }
            if (publicRequest.IsSetSnapshotFormat())
            {
                context.Writer.WritePropertyName("SnapshotFormat");
                context.Writer.WriteStringValue(publicRequest.SnapshotFormat);
            }
            if (publicRequest.IsSetSnapshotName())
            {
                context.Writer.WritePropertyName("SnapshotName");
                context.Writer.WriteStringValue(publicRequest.SnapshotName);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ImportSnapshotRequestMarshaller _instance = new();

        internal static ImportSnapshotRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportSnapshotRequestMarshaller Instance => _instance;
    }
}
