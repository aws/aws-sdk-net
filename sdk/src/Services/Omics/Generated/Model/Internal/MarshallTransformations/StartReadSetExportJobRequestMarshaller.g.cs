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

using Amazon.Omics.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartReadSetExportJob Request Marshaller
    /// </summary>
    public partial class StartReadSetExportJobRequestMarshaller : IMarshaller<IRequest, StartReadSetExportJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartReadSetExportJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartReadSetExportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSequenceStoreId())
            {
                throw new AmazonOmicsException("Request object does not have required field SequenceStoreId set");
            }
            request.AddPathResource("{sequenceStoreId}", StringUtils.FromString(publicRequest.SequenceStoreId));

            request.ResourcePath = "/sequencestore/{sequenceStoreId}/exportjob";
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
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            if (publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(publicRequest.Destination);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSourcesListValue in publicRequest.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExportReadSetMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"control-storage-";

            return request;
        }

        private static readonly StartReadSetExportJobRequestMarshaller _instance = new();

        internal static StartReadSetExportJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartReadSetExportJobRequestMarshaller Instance => _instance;
    }
}
