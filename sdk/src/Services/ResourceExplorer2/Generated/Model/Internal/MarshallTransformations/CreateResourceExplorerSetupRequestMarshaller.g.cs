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

using Amazon.ResourceExplorer2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ResourceExplorer2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateResourceExplorerSetup Request Marshaller
    /// </summary>
    public partial class CreateResourceExplorerSetupRequestMarshaller : IMarshaller<IRequest, CreateResourceExplorerSetupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResourceExplorerSetupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateResourceExplorerSetupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceExplorer2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateResourceExplorerSetup";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAggregatorRegions())
            {
                context.Writer.WritePropertyName("AggregatorRegions");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAggregatorRegionsListValue in publicRequest.AggregatorRegions)
                {
                    context.Writer.WriteStringValue(publicRequestAggregatorRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRegionList())
            {
                context.Writer.WritePropertyName("RegionList");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRegionListListValue in publicRequest.RegionList)
                {
                    context.Writer.WriteStringValue(publicRequestRegionListListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetViewName())
            {
                context.Writer.WritePropertyName("ViewName");
                context.Writer.WriteStringValue(publicRequest.ViewName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateResourceExplorerSetupRequestMarshaller _instance = new();

        internal static CreateResourceExplorerSetupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateResourceExplorerSetupRequestMarshaller Instance => _instance;
    }
}
