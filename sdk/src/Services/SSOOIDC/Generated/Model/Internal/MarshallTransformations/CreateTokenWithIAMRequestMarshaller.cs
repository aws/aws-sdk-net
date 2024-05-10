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

#pragma warning disable CS0612,CS0618
namespace Amazon.SSOOIDC.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTokenWithIAM Request Marshaller
    /// </summary>       
    public class CreateTokenWithIAMRequestMarshaller : IMarshaller<IRequest, CreateTokenWithIAMRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTokenWithIAMRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTokenWithIAMRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOOIDC");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-10";
            request.HttpMethod = "POST";

            request.AddSubResource("aws_iam", "t");
            request.ResourcePath = "/token";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssertion())
                {
                    context.Writer.WritePropertyName("assertion");
                    context.Writer.Write(publicRequest.Assertion);
                }

                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("clientId");
                    context.Writer.Write(publicRequest.ClientId);
                }

                if(publicRequest.IsSetCode())
                {
                    context.Writer.WritePropertyName("code");
                    context.Writer.Write(publicRequest.Code);
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

                if(publicRequest.IsSetRequestedTokenType())
                {
                    context.Writer.WritePropertyName("requestedTokenType");
                    context.Writer.Write(publicRequest.RequestedTokenType);
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

                if(publicRequest.IsSetSubjectToken())
                {
                    context.Writer.WritePropertyName("subjectToken");
                    context.Writer.Write(publicRequest.SubjectToken);
                }

                if(publicRequest.IsSetSubjectTokenType())
                {
                    context.Writer.WritePropertyName("subjectTokenType");
                    context.Writer.Write(publicRequest.SubjectTokenType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTokenWithIAMRequestMarshaller _instance = new CreateTokenWithIAMRequestMarshaller();        

        internal static CreateTokenWithIAMRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTokenWithIAMRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}