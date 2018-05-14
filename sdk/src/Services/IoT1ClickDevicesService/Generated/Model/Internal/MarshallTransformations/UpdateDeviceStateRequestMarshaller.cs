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
    /// UpdateDeviceState Request Marshaller
    /// </summary>       
    public class UpdateDeviceStateRequestMarshaller : IMarshaller<IRequest, UpdateDeviceStateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeviceStateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDeviceStateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickDevicesService");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/devices/{deviceId}/state";
            if (!publicRequest.IsSetDeviceId())
                throw new AmazonIoT1ClickDevicesServiceException("Request object does not have required field DeviceId set");
            uriResourcePath = uriResourcePath.Replace("{deviceId}", StringUtils.FromString(publicRequest.DeviceId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDeviceStateRequestMarshaller _instance = new UpdateDeviceStateRequestMarshaller();        

        internal static UpdateDeviceStateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDeviceStateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}