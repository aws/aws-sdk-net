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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIdentityProvider Request Marshaller
    /// </summary>       
    public class CreateIdentityProviderRequestMarshaller : IMarshaller<IRequest, CreateIdentityProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIdentityProviderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIdentityProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.CreateIdentityProvider";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-18";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeMapping())
                {
                    context.Writer.WritePropertyName("AttributeMapping");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributeMappingKvp in publicRequest.AttributeMapping)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributeMappingKvp.Key);
                        var publicRequestAttributeMappingValue = publicRequestAttributeMappingKvp.Value;

                            context.Writer.Write(publicRequestAttributeMappingValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdpIdentifiers())
                {
                    context.Writer.WritePropertyName("IdpIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdpIdentifiersListValue in publicRequest.IdpIdentifiers)
                    {
                            context.Writer.Write(publicRequestIdpIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProviderDetails())
                {
                    context.Writer.WritePropertyName("ProviderDetails");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestProviderDetailsKvp in publicRequest.ProviderDetails)
                    {
                        context.Writer.WritePropertyName(publicRequestProviderDetailsKvp.Key);
                        var publicRequestProviderDetailsValue = publicRequestProviderDetailsKvp.Value;

                            context.Writer.Write(publicRequestProviderDetailsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProviderName())
                {
                    context.Writer.WritePropertyName("ProviderName");
                    context.Writer.Write(publicRequest.ProviderName);
                }

                if(publicRequest.IsSetProviderType())
                {
                    context.Writer.WritePropertyName("ProviderType");
                    context.Writer.Write(publicRequest.ProviderType);
                }

                if(publicRequest.IsSetUserPoolId())
                {
                    context.Writer.WritePropertyName("UserPoolId");
                    context.Writer.Write(publicRequest.UserPoolId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIdentityProviderRequestMarshaller _instance = new CreateIdentityProviderRequestMarshaller();        

        internal static CreateIdentityProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIdentityProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}