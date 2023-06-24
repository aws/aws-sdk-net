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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCellTowers())
                {
                    context.Writer.WritePropertyName("CellTowers");
                    context.Writer.WriteObjectStart();

                    var marshaller = CellTowersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CellTowers, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGnss())
                {
                    context.Writer.WritePropertyName("Gnss");
                    context.Writer.WriteObjectStart();

                    var marshaller = GnssMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Gnss, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIp())
                {
                    context.Writer.WritePropertyName("Ip");
                    context.Writer.WriteObjectStart();

                    var marshaller = IpMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ip, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimestamp())
                {
                    context.Writer.WritePropertyName("Timestamp");
                    context.Writer.Write(publicRequest.Timestamp);
                }

                if(publicRequest.IsSetWiFiAccessPoints())
                {
                    context.Writer.WritePropertyName("WiFiAccessPoints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWiFiAccessPointsListValue in publicRequest.WiFiAccessPoints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WiFiAccessPointMarshaller.Instance;
                        marshaller.Marshall(publicRequestWiFiAccessPointsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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