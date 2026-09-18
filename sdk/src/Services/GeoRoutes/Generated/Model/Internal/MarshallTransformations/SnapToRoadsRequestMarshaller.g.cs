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

using Amazon.GeoRoutes.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnapToRoads Request Marshaller
    /// </summary>
    public partial class SnapToRoadsRequestMarshaller : IMarshaller<IRequest, SnapToRoadsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SnapToRoadsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SnapToRoadsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoRoutes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetKey())
            {
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            }

            request.ResourcePath = "/v2/snap-to-roads";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetSnapRadius())
            {
                context.Writer.WritePropertyName("SnapRadius");
                context.Writer.WriteNumberValue(publicRequest.SnapRadius.Value);
            }
            if (publicRequest.IsSetSnappedGeometryFormat())
            {
                context.Writer.WritePropertyName("SnappedGeometryFormat");
                context.Writer.WriteStringValue(publicRequest.SnappedGeometryFormat);
            }
            if (publicRequest.IsSetTracePoints())
            {
                context.Writer.WritePropertyName("TracePoints");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTracePointsListValue in publicRequest.TracePoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RoadSnapTracePointMarshaller.Instance;
                    marshaller.Marshall(publicRequestTracePointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTravelMode())
            {
                context.Writer.WritePropertyName("TravelMode");
                context.Writer.WriteStringValue(publicRequest.TravelMode);
            }
            if (publicRequest.IsSetTravelModeOptions())
            {
                context.Writer.WritePropertyName("TravelModeOptions");
                context.Writer.WriteStartObject();

                var marshaller = RoadSnapTravelModeOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.TravelModeOptions, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly SnapToRoadsRequestMarshaller _instance = new();

        internal static SnapToRoadsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SnapToRoadsRequestMarshaller Instance => _instance;
    }
}
