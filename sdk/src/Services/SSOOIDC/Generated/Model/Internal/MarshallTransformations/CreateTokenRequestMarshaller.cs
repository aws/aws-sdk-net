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
    /// CreateToken Request Marshaller
    /// </summary>       
    public class CreateTokenRequestMarshaller : IMarshaller<IRequest, CreateTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOOIDC");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/token";
            request.MarshallerVersion = 2;
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

                if(publicRequest.IsSetCode())
                {
                    context.Writer.WritePropertyName("code");
                    context.Writer.Write(publicRequest.Code);
                }

                if(publicRequest.IsSetDeviceCode())
                {
                    context.Writer.WritePropertyName("deviceCode");
                    context.Writer.Write(publicRequest.DeviceCode);
                }

                if(publicRequest.IsSetGrantType())
                {
                    context.Writer.WritePropertyName("grantType");
                    context.Writer.Write(publicRequest.GrantType);
                }

                if(publicRequest.IsSetRedirectUri())
                {
                    context.Writer.WritePropertyName("redirectUri");
                    context.Writer.Write(publicRequest.RedirectUri);
                }

                if(publicRequest.IsSetRefreshToken())
                {
                    context.Writer.WritePropertyName("refreshToken");
                    context.Writer.Write(publicRequest.RefreshToken);
                }

                if(publicRequest.IsSetScope())
                {
                    context.Writer.WritePropertyName("scope");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestScopeListValue in publicRequest.Scope)
                    {
                            context.Writer.Write(publicRequestScopeListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTokenRequestMarshaller _instance = new CreateTokenRequestMarshaller();        

        internal static CreateTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}