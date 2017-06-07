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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeviceDefinitionVersion Request Marshaller
    /// </summary>       
    public class CreateDeviceDefinitionVersionRequestMarshaller : IMarshaller<IRequest, CreateDeviceDefinitionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeviceDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeviceDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/greengrass/definition/devices/{DeviceDefinitionId}/versions";
            if (!publicRequest.IsSetDeviceDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field DeviceDefinitionId set");
            uriResourcePath = uriResourcePath.Replace("{DeviceDefinitionId}", StringUtils.FromString(publicRequest.DeviceDefinitionId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDevices())
                {
                    context.Writer.WritePropertyName("Devices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDevicesListValue in publicRequest.Devices)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DeviceMarshaller.Instance;
                        marshaller.Marshall(publicRequestDevicesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAmznClientToken())
                request.Headers["X-Amzn-Client-Token"] = publicRequest.AmznClientToken;

            return request;
        }


    }
}