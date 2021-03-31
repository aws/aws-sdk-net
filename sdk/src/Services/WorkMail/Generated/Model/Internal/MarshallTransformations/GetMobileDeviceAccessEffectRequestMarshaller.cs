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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMobileDeviceAccessEffect Request Marshaller
    /// </summary>       
    public class GetMobileDeviceAccessEffectRequestMarshaller : IMarshaller<IRequest, GetMobileDeviceAccessEffectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMobileDeviceAccessEffectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMobileDeviceAccessEffectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.GetMobileDeviceAccessEffect";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeviceModel())
                {
                    context.Writer.WritePropertyName("DeviceModel");
                    context.Writer.Write(publicRequest.DeviceModel);
                }

                if(publicRequest.IsSetDeviceOperatingSystem())
                {
                    context.Writer.WritePropertyName("DeviceOperatingSystem");
                    context.Writer.Write(publicRequest.DeviceOperatingSystem);
                }

                if(publicRequest.IsSetDeviceType())
                {
                    context.Writer.WritePropertyName("DeviceType");
                    context.Writer.Write(publicRequest.DeviceType);
                }

                if(publicRequest.IsSetDeviceUserAgent())
                {
                    context.Writer.WritePropertyName("DeviceUserAgent");
                    context.Writer.Write(publicRequest.DeviceUserAgent);
                }

                if(publicRequest.IsSetOrganizationId())
                {
                    context.Writer.WritePropertyName("OrganizationId");
                    context.Writer.Write(publicRequest.OrganizationId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetMobileDeviceAccessEffectRequestMarshaller _instance = new GetMobileDeviceAccessEffectRequestMarshaller();        

        internal static GetMobileDeviceAccessEffectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMobileDeviceAccessEffectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}