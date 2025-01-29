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
    /// PutGeofence Request Marshaller
    /// </summary>       
    public class PutGeofenceRequestMarshaller : IMarshaller<IRequest, PutGeofenceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutGeofenceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutGeofenceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCollectionName())
                throw new AmazonLocationServiceException("Request object does not have required field CollectionName set");
            request.AddPathResource("{CollectionName}", StringUtils.FromString(publicRequest.CollectionName));
            if (!publicRequest.IsSetGeofenceId())
                throw new AmazonLocationServiceException("Request object does not have required field GeofenceId set");
            request.AddPathResource("{GeofenceId}", StringUtils.FromString(publicRequest.GeofenceId));
            request.ResourcePath = "/geofencing/v0/collections/{CollectionName}/geofences/{GeofenceId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetGeofenceProperties())
            {
                context.Writer.WritePropertyName("GeofenceProperties");
                context.Writer.WriteStartObject();
                foreach (var publicRequestGeofencePropertiesKvp in publicRequest.GeofenceProperties)
                {
                    context.Writer.WritePropertyName(publicRequestGeofencePropertiesKvp.Key);
                    var publicRequestGeofencePropertiesValue = publicRequestGeofencePropertiesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestGeofencePropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGeometry())
            {
                context.Writer.WritePropertyName("Geometry");
                context.Writer.WriteStartObject();

                var marshaller = GeofenceGeometryMarshaller.Instance;
                marshaller.Marshall(publicRequest.Geometry, context);

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
            

            
            request.HostPrefix = $"geofencing.";

            return request;
        }
        private static PutGeofenceRequestMarshaller _instance = new PutGeofenceRequestMarshaller();        

        internal static PutGeofenceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutGeofenceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}