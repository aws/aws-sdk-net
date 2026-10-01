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

using Amazon.IoTSiteWise.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDatasetExportJob Request Marshaller
    /// </summary>
    public partial class CreateDatasetExportJobRequestMarshaller : IMarshaller<IRequest, CreateDatasetExportJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatasetExportJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDatasetExportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetWorkspaceName())
            {
                throw new AmazonIoTSiteWiseException("Request object does not have required field WorkspaceName set");
            }
            request.AddPathResource("{workspaceName}", StringUtils.FromString(publicRequest.WorkspaceName));

            request.ResourcePath = "/workspaces/{workspaceName}/dataset-export-jobs";
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
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDestinationS3Uri())
            {
                context.Writer.WritePropertyName("destinationS3Uri");
                context.Writer.WriteStringValue(publicRequest.DestinationS3Uri);
            }
            if (publicRequest.IsSetErrorReportLocation())
            {
                context.Writer.WritePropertyName("errorReportLocation");
                context.Writer.WriteStartObject();

                var marshaller = ExportErrorReportLocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ErrorReportLocation, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Input, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"data.";

            return request;
        }

        private static readonly CreateDatasetExportJobRequestMarshaller _instance = new();

        internal static CreateDatasetExportJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDatasetExportJobRequestMarshaller Instance => _instance;
    }
}
