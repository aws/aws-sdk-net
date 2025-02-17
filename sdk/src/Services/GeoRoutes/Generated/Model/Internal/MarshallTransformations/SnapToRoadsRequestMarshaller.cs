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
    /// SnapToRoads Request Marshaller
    /// </summary>       
    public class SnapToRoadsRequestMarshaller : IMarshaller<IRequest, SnapToRoadsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SnapToRoadsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SnapToRoadsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoRoutes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/snap-to-roads";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSnappedGeometryFormat())
                {
                    context.Writer.WritePropertyName("SnappedGeometryFormat");
                    context.Writer.Write(publicRequest.SnappedGeometryFormat);
                }

                if(publicRequest.IsSetSnapRadius())
                {
                    context.Writer.WritePropertyName("SnapRadius");
                    context.Writer.Write(publicRequest.SnapRadius);
                }

                if(publicRequest.IsSetTracePoints())
                {
                    context.Writer.WritePropertyName("TracePoints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTracePointsListValue in publicRequest.TracePoints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RoadSnapTracePointMarshaller.Instance;
                        marshaller.Marshall(publicRequestTracePointsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                    var marshaller = RoadSnapTravelModeOptionsMarshaller.Instance;
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
        private static SnapToRoadsRequestMarshaller _instance = new SnapToRoadsRequestMarshaller();        

        internal static SnapToRoadsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapToRoadsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}