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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CalculateRouteMatrix Request Marshaller
    /// </summary>       
    public class CalculateRouteMatrixRequestMarshaller : IMarshaller<IRequest, CalculateRouteMatrixRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CalculateRouteMatrixRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CalculateRouteMatrixRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoRoutes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/route-matrix";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllow())
            {
                context.Writer.WritePropertyName("Allow");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixAllowOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Allow, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAvoid())
            {
                context.Writer.WritePropertyName("Avoid");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixAvoidanceOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Avoid, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDepartNow())
            {
                context.Writer.WritePropertyName("DepartNow");
                context.Writer.WriteBooleanValue(publicRequest.DepartNow.Value);
            }

            if(publicRequest.IsSetDepartureTime())
            {
                context.Writer.WritePropertyName("DepartureTime");
                context.Writer.WriteStringValue(publicRequest.DepartureTime);
            }

            if(publicRequest.IsSetDestinations())
            {
                context.Writer.WritePropertyName("Destinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RouteMatrixDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetExclude())
            {
                context.Writer.WritePropertyName("Exclude");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixExclusionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Exclude, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOptimizeRoutingFor())
            {
                context.Writer.WritePropertyName("OptimizeRoutingFor");
                context.Writer.WriteStringValue(publicRequest.OptimizeRoutingFor);
            }

            if(publicRequest.IsSetOrigins())
            {
                context.Writer.WritePropertyName("Origins");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOriginsListValue in publicRequest.Origins)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RouteMatrixOriginMarshaller.Instance;
                    marshaller.Marshall(publicRequestOriginsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoutingBoundary())
            {
                context.Writer.WritePropertyName("RoutingBoundary");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixBoundaryMarshaller.Instance;
                marshaller.Marshall(publicRequest.RoutingBoundary, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTraffic())
            {
                context.Writer.WritePropertyName("Traffic");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixTrafficOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Traffic, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTravelMode())
            {
                context.Writer.WritePropertyName("TravelMode");
                context.Writer.WriteStringValue(publicRequest.TravelMode);
            }

            if(publicRequest.IsSetTravelModeOptions())
            {
                context.Writer.WritePropertyName("TravelModeOptions");
                context.Writer.WriteStartObject();

                var marshaller = RouteMatrixTravelModeOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.TravelModeOptions, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static CalculateRouteMatrixRequestMarshaller _instance = new CalculateRouteMatrixRequestMarshaller();        

        internal static CalculateRouteMatrixRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CalculateRouteMatrixRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}