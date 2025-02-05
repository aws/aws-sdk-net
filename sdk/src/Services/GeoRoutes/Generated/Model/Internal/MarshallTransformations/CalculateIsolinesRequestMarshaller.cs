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
    /// CalculateIsolines Request Marshaller
    /// </summary>       
    public class CalculateIsolinesRequestMarshaller : IMarshaller<IRequest, CalculateIsolinesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CalculateIsolinesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CalculateIsolinesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoRoutes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/isolines";
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

                var marshaller = IsolineAllowOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Allow, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetArrivalTime())
            {
                context.Writer.WritePropertyName("ArrivalTime");
                context.Writer.WriteStringValue(publicRequest.ArrivalTime);
            }

            if(publicRequest.IsSetAvoid())
            {
                context.Writer.WritePropertyName("Avoid");
                context.Writer.WriteStartObject();

                var marshaller = IsolineAvoidanceOptionsMarshaller.Instance;
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

            if(publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationListValue in publicRequest.Destination)
                {
                        context.Writer.WriteNumberValue(publicRequestDestinationListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDestinationOptions())
            {
                context.Writer.WritePropertyName("DestinationOptions");
                context.Writer.WriteStartObject();

                var marshaller = IsolineDestinationOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIsolineGeometryFormat())
            {
                context.Writer.WritePropertyName("IsolineGeometryFormat");
                context.Writer.WriteStringValue(publicRequest.IsolineGeometryFormat);
            }

            if(publicRequest.IsSetIsolineGranularity())
            {
                context.Writer.WritePropertyName("IsolineGranularity");
                context.Writer.WriteStartObject();

                var marshaller = IsolineGranularityOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.IsolineGranularity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOptimizeIsolineFor())
            {
                context.Writer.WritePropertyName("OptimizeIsolineFor");
                context.Writer.WriteStringValue(publicRequest.OptimizeIsolineFor);
            }

            if(publicRequest.IsSetOptimizeRoutingFor())
            {
                context.Writer.WritePropertyName("OptimizeRoutingFor");
                context.Writer.WriteStringValue(publicRequest.OptimizeRoutingFor);
            }

            if(publicRequest.IsSetOrigin())
            {
                context.Writer.WritePropertyName("Origin");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOriginListValue in publicRequest.Origin)
                {
                        context.Writer.WriteNumberValue(publicRequestOriginListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOriginOptions())
            {
                context.Writer.WritePropertyName("OriginOptions");
                context.Writer.WriteStartObject();

                var marshaller = IsolineOriginOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OriginOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetThresholds())
            {
                context.Writer.WritePropertyName("Thresholds");
                context.Writer.WriteStartObject();

                var marshaller = IsolineThresholdsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Thresholds, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTraffic())
            {
                context.Writer.WritePropertyName("Traffic");
                context.Writer.WriteStartObject();

                var marshaller = IsolineTrafficOptionsMarshaller.Instance;
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

                var marshaller = IsolineTravelModeOptionsMarshaller.Instance;
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
        private static CalculateIsolinesRequestMarshaller _instance = new CalculateIsolinesRequestMarshaller();        

        internal static CalculateIsolinesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CalculateIsolinesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}