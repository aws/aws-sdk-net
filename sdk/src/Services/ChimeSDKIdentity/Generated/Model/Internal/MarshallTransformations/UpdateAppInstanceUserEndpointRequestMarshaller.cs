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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAppInstanceUserEndpoint Request Marshaller
    /// </summary>       
    public class UpdateAppInstanceUserEndpointRequestMarshaller : IMarshaller<IRequest, UpdateAppInstanceUserEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppInstanceUserEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppInstanceUserEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKIdentity");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-20";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAppInstanceUserArn())
                throw new AmazonChimeSDKIdentityException("Request object does not have required field AppInstanceUserArn set");
            request.AddPathResource("{appInstanceUserArn}", StringUtils.FromString(publicRequest.AppInstanceUserArn));
            if (!publicRequest.IsSetEndpointId())
                throw new AmazonChimeSDKIdentityException("Request object does not have required field EndpointId set");
            request.AddPathResource("{endpointId}", StringUtils.FromString(publicRequest.EndpointId));
            request.ResourcePath = "/app-instance-users/{appInstanceUserArn}/endpoints/{endpointId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowMessages())
                {
                    context.Writer.WritePropertyName("AllowMessages");
                    context.Writer.Write(publicRequest.AllowMessages);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAppInstanceUserEndpointRequestMarshaller _instance = new UpdateAppInstanceUserEndpointRequestMarshaller();        

        internal static UpdateAppInstanceUserEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppInstanceUserEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}