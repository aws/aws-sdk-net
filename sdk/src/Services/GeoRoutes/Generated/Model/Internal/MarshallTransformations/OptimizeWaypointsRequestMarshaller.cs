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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OptimizeWaypoints Request Marshaller
    /// </summary>       
    public class OptimizeWaypointsRequestMarshaller : IMarshaller<IRequest, OptimizeWaypointsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((OptimizeWaypointsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(OptimizeWaypointsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoRoutes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/optimize-waypoints";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvoid())
                {
                    context.Writer.WritePropertyName("Avoid");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationAvoidanceOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Avoid, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDepartureTime())
                {
                    context.Writer.WritePropertyName("DepartureTime");
                    context.Writer.Write(publicRequest.DepartureTime);
                }

                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("Destination");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationListValue in publicRequest.Destination)
                    {
                            context.Writer.Write(publicRequestDestinationListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDestinationOptions())
                {
                    context.Writer.WritePropertyName("DestinationOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationDestinationOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DestinationOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDriver())
                {
                    context.Writer.WritePropertyName("Driver");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationDriverOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Driver, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExclude())
                {
                    context.Writer.WritePropertyName("Exclude");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationExclusionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Exclude, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOptimizeSequencingFor())
                {
                    context.Writer.WritePropertyName("OptimizeSequencingFor");
                    context.Writer.Write(publicRequest.OptimizeSequencingFor);
                }

                if(publicRequest.IsSetOrigin())
                {
                    context.Writer.WritePropertyName("Origin");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOriginListValue in publicRequest.Origin)
                    {
                            context.Writer.Write(publicRequestOriginListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOriginOptions())
                {
                    context.Writer.WritePropertyName("OriginOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationOriginOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OriginOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTraffic())
                {
                    context.Writer.WritePropertyName("Traffic");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationTrafficOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Traffic, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTravelMode())
                {
                    context.Writer.WritePropertyName("TravelMode");
                    context.Writer.Write(publicRequest.TravelMode);
                }

                if(publicRequest.IsSetTravelModeOptions())
                {
                    context.Writer.WritePropertyName("TravelModeOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = WaypointOptimizationTravelModeOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TravelModeOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWaypoints())
                {
                    context.Writer.WritePropertyName("Waypoints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWaypointsListValue in publicRequest.Waypoints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WaypointOptimizationWaypointMarshaller.Instance;
                        marshaller.Marshall(publicRequestWaypointsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static OptimizeWaypointsRequestMarshaller _instance = new OptimizeWaypointsRequestMarshaller();        

        internal static OptimizeWaypointsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OptimizeWaypointsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}