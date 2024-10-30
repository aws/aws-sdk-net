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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllow())
                {
                    context.Writer.WritePropertyName("Allow");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteMatrixAllowOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Allow, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAvoid())
                {
                    context.Writer.WritePropertyName("Avoid");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteMatrixAvoidanceOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Avoid, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDepartNow())
                {
                    context.Writer.WritePropertyName("DepartNow");
                    context.Writer.Write(publicRequest.DepartNow);
                }

                if(publicRequest.IsSetDepartureTime())
                {
                    context.Writer.WritePropertyName("DepartureTime");
                    context.Writer.Write(publicRequest.DepartureTime);
                }

                if(publicRequest.IsSetDestinations())
                {
                    context.Writer.WritePropertyName("Destinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RouteMatrixDestinationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetExclude())
                {
                    context.Writer.WritePropertyName("Exclude");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteMatrixExclusionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Exclude, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOptimizeRoutingFor())
                {
                    context.Writer.WritePropertyName("OptimizeRoutingFor");
                    context.Writer.Write(publicRequest.OptimizeRoutingFor);
                }

                if(publicRequest.IsSetOrigins())
                {
                    context.Writer.WritePropertyName("Origins");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOriginsListValue in publicRequest.Origins)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RouteMatrixOriginMarshaller.Instance;
                        marshaller.Marshall(publicRequestOriginsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoutingBoundary())
                {
                    context.Writer.WritePropertyName("RoutingBoundary");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteMatrixBoundaryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RoutingBoundary, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTraffic())
                {
                    context.Writer.WritePropertyName("Traffic");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteMatrixTrafficOptionsMarshaller.Instance;
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

                    var marshaller = RouteMatrixTravelModeOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TravelModeOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

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