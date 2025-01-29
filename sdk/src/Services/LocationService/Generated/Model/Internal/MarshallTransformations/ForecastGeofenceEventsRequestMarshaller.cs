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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ForecastGeofenceEvents Request Marshaller
    /// </summary>       
    public class ForecastGeofenceEventsRequestMarshaller : IMarshaller<IRequest, ForecastGeofenceEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ForecastGeofenceEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ForecastGeofenceEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCollectionName())
                throw new AmazonLocationServiceException("Request object does not have required field CollectionName set");
            request.AddPathResource("{CollectionName}", StringUtils.FromString(publicRequest.CollectionName));
            request.ResourcePath = "/geofencing/v0/collections/{CollectionName}/forecast-geofence-events";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeviceState())
            {
                context.Writer.WritePropertyName("DeviceState");
                context.Writer.WriteStartObject();

                var marshaller = ForecastGeofenceEventsDeviceStateMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceState, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDistanceUnit())
            {
                context.Writer.WritePropertyName("DistanceUnit");
                context.Writer.WriteStringValue(publicRequest.DistanceUnit);
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetSpeedUnit())
            {
                context.Writer.WritePropertyName("SpeedUnit");
                context.Writer.WriteStringValue(publicRequest.SpeedUnit);
            }

            if(publicRequest.IsSetTimeHorizonMinutes())
            {
                context.Writer.WritePropertyName("TimeHorizonMinutes");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.TimeHorizonMinutes.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.TimeHorizonMinutes.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.TimeHorizonMinutes.Value);
                }
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"geofencing.";

            return request;
        }
        private static ForecastGeofenceEventsRequestMarshaller _instance = new ForecastGeofenceEventsRequestMarshaller();        

        internal static ForecastGeofenceEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ForecastGeofenceEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}