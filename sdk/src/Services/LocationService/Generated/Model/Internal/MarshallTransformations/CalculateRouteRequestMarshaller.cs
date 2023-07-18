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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CalculateRoute Request Marshaller
    /// </summary>       
    public class CalculateRouteRequestMarshaller : IMarshaller<IRequest, CalculateRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CalculateRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CalculateRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCalculatorName())
                throw new AmazonLocationServiceException("Request object does not have required field CalculatorName set");
            request.AddPathResource("{CalculatorName}", StringUtils.FromString(publicRequest.CalculatorName));
            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/routes/v0/calculators/{CalculatorName}/calculate/route";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCarModeOptions())
                {
                    context.Writer.WritePropertyName("CarModeOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = CalculateRouteCarModeOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CarModeOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDepartNow())
                {
                    context.Writer.WritePropertyName("DepartNow");
                    context.Writer.Write(publicRequest.DepartNow);
                }

                if(publicRequest.IsSetDeparturePosition())
                {
                    context.Writer.WritePropertyName("DeparturePosition");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDeparturePositionListValue in publicRequest.DeparturePosition)
                    {
                            context.Writer.Write(publicRequestDeparturePositionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDepartureTime())
                {
                    context.Writer.WritePropertyName("DepartureTime");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601(publicRequest.DepartureTime));
                }

                if(publicRequest.IsSetDestinationPosition())
                {
                    context.Writer.WritePropertyName("DestinationPosition");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationPositionListValue in publicRequest.DestinationPosition)
                    {
                            context.Writer.Write(publicRequestDestinationPositionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDistanceUnit())
                {
                    context.Writer.WritePropertyName("DistanceUnit");
                    context.Writer.Write(publicRequest.DistanceUnit);
                }

                if(publicRequest.IsSetIncludeLegGeometry())
                {
                    context.Writer.WritePropertyName("IncludeLegGeometry");
                    context.Writer.Write(publicRequest.IncludeLegGeometry);
                }

                if(publicRequest.IsSetTravelMode())
                {
                    context.Writer.WritePropertyName("TravelMode");
                    context.Writer.Write(publicRequest.TravelMode);
                }

                if(publicRequest.IsSetTruckModeOptions())
                {
                    context.Writer.WritePropertyName("TruckModeOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = CalculateRouteTruckModeOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TruckModeOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWaypointPositions())
                {
                    context.Writer.WritePropertyName("WaypointPositions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWaypointPositionsListValue in publicRequest.WaypointPositions)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestWaypointPositionsListValueListValue in publicRequestWaypointPositionsListValue)
                        {
                                context.Writer.Write(publicRequestWaypointPositionsListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;
            
            request.HostPrefix = $"routes.";

            return request;
        }
        private static CalculateRouteRequestMarshaller _instance = new CalculateRouteRequestMarshaller();        

        internal static CalculateRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CalculateRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}