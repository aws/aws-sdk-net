/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickDevicesService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickDevicesService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeDeviceMethod Request Marshaller
    /// </summary>       
    public class InvokeDeviceMethodRequestMarshaller : IMarshaller<IRequest, InvokeDeviceMethodRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeDeviceMethodRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeDeviceMethodRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickDevicesService");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/devices/{deviceId}/methods";
            if (!publicRequest.IsSetDeviceId())
                throw new AmazonIoT1ClickDevicesServiceException("Request object does not have required field DeviceId set");
            uriResourcePath = uriResourcePath.Replace("{deviceId}", StringUtils.FromString(publicRequest.DeviceId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeviceMethod())
                {
                    context.Writer.WritePropertyName("deviceMethod");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceMethodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceMethod, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeviceMethodParameters())
                {
                    context.Writer.WritePropertyName("deviceMethodParameters");
                    context.Writer.Write(publicRequest.DeviceMethodParameters);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static InvokeDeviceMethodRequestMarshaller _instance = new InvokeDeviceMethodRequestMarshaller();        

        internal static InvokeDeviceMethodRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeDeviceMethodRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}