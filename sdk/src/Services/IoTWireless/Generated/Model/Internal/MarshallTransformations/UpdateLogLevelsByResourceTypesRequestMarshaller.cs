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
    /// UpdateLogLevelsByResourceTypes Request Marshaller
    /// </summary>       
    public class UpdateLogLevelsByResourceTypesRequestMarshaller : IMarshaller<IRequest, UpdateLogLevelsByResourceTypesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLogLevelsByResourceTypesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLogLevelsByResourceTypesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/log-levels";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultLogLevel())
                {
                    context.Writer.WritePropertyName("DefaultLogLevel");
                    context.Writer.Write(publicRequest.DefaultLogLevel);
                }

                if(publicRequest.IsSetWirelessDeviceLogOptions())
                {
                    context.Writer.WritePropertyName("WirelessDeviceLogOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessDeviceLogOptionsListValue in publicRequest.WirelessDeviceLogOptions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WirelessDeviceLogOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestWirelessDeviceLogOptionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWirelessGatewayLogOptions())
                {
                    context.Writer.WritePropertyName("WirelessGatewayLogOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessGatewayLogOptionsListValue in publicRequest.WirelessGatewayLogOptions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WirelessGatewayLogOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestWirelessGatewayLogOptionsListValue, context);

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
        private static UpdateLogLevelsByResourceTypesRequestMarshaller _instance = new UpdateLogLevelsByResourceTypesRequestMarshaller();        

        internal static UpdateLogLevelsByResourceTypesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLogLevelsByResourceTypesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}