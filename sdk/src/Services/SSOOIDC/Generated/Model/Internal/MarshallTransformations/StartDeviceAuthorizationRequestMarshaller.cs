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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOOIDC.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSOOIDC.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDeviceAuthorization Request Marshaller
    /// </summary>       
    public class StartDeviceAuthorizationRequestMarshaller : IMarshaller<IRequest, StartDeviceAuthorizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDeviceAuthorizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDeviceAuthorizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOOIDC");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/device_authorization";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("clientId");
                    context.Writer.Write(publicRequest.ClientId);
                }

                if(publicRequest.IsSetClientSecret())
                {
                    context.Writer.WritePropertyName("clientSecret");
                    context.Writer.Write(publicRequest.ClientSecret);
                }

                if(publicRequest.IsSetStartUrl())
                {
                    context.Writer.WritePropertyName("startUrl");
                    context.Writer.Write(publicRequest.StartUrl);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartDeviceAuthorizationRequestMarshaller _instance = new StartDeviceAuthorizationRequestMarshaller();        

        internal static StartDeviceAuthorizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDeviceAuthorizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}