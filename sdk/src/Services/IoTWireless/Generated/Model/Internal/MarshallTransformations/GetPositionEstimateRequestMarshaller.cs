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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
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
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPositionEstimate Request Marshaller
    /// </summary>       
    public class GetPositionEstimateRequestMarshaller : IMarshaller<IRequest, GetPositionEstimateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPositionEstimateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPositionEstimateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/position-estimate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCellTowers())
            {
                context.Writer.WritePropertyName("CellTowers");
                context.Writer.WriteStartObject();

                var marshaller = CellTowersMarshaller.Instance;
                marshaller.Marshall(publicRequest.CellTowers, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGnss())
            {
                context.Writer.WritePropertyName("Gnss");
                context.Writer.WriteStartObject();

                var marshaller = GnssMarshaller.Instance;
                marshaller.Marshall(publicRequest.Gnss, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIp())
            {
                context.Writer.WritePropertyName("Ip");
                context.Writer.WriteStartObject();

                var marshaller = IpMarshaller.Instance;
                marshaller.Marshall(publicRequest.Ip, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Timestamp.Value)));
            }

            if(publicRequest.IsSetWiFiAccessPoints())
            {
                context.Writer.WritePropertyName("WiFiAccessPoints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWiFiAccessPointsListValue in publicRequest.WiFiAccessPoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WiFiAccessPointMarshaller.Instance;
                    marshaller.Marshall(publicRequestWiFiAccessPointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GetPositionEstimateRequestMarshaller _instance = new GetPositionEstimateRequestMarshaller();        

        internal static GetPositionEstimateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPositionEstimateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}