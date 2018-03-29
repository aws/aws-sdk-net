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
    /// CreateUserPoolClient Request Marshaller
    /// </summary>       
    public class CreateUserPoolClientRequestMarshaller : IMarshaller<IRequest, CreateUserPoolClientRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserPoolClientRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUserPoolClientRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.CreateUserPoolClient";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowedOAuthFlows())
                {
                    context.Writer.WritePropertyName("AllowedOAuthFlows");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowedOAuthFlowsListValue in publicRequest.AllowedOAuthFlows)
                    {
                            context.Writer.Write(publicRequestAllowedOAuthFlowsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAllowedOAuthFlowsUserPoolClient())
                {
                    context.Writer.WritePropertyName("AllowedOAuthFlowsUserPoolClient");
                    context.Writer.Write(publicRequest.AllowedOAuthFlowsUserPoolClient);
                }

                if(publicRequest.IsSetAllowedOAuthScopes())
                {
                    context.Writer.WritePropertyName("AllowedOAuthScopes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowedOAuthScopesListValue in publicRequest.AllowedOAuthScopes)
                    {
                            context.Writer.Write(publicRequestAllowedOAuthScopesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAnalyticsConfiguration())
                {
                    context.Writer.WritePropertyName("AnalyticsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalyticsConfigurationTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnalyticsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCallbackURLs())
                {
                    context.Writer.WritePropertyName("CallbackURLs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCallbackURLsListValue in publicRequest.CallbackURLs)
                    {
                            context.Writer.Write(publicRequestCallbackURLsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientName())
                {
                    context.Writer.WritePropertyName("ClientName");
                    context.Writer.Write(publicRequest.ClientName);
                }

                if(publicRequest.IsSetDefaultRedirectURI())
                {
                    context.Writer.WritePropertyName("DefaultRedirectURI");
                    context.Writer.Write(publicRequest.DefaultRedirectURI);
                }

                if(publicRequest.IsSetExplicitAuthFlows())
                {
                    context.Writer.WritePropertyName("ExplicitAuthFlows");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExplicitAuthFlowsListValue in publicRequest.ExplicitAuthFlows)
                    {
                            context.Writer.Write(publicRequestExplicitAuthFlowsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGenerateSecret())
                {
                    context.Writer.WritePropertyName("GenerateSecret");
                    context.Writer.Write(publicRequest.GenerateSecret);
                }

                if(publicRequest.IsSetLogoutURLs())
                {
                    context.Writer.WritePropertyName("LogoutURLs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogoutURLsListValue in publicRequest.LogoutURLs)
                    {
                            context.Writer.Write(publicRequestLogoutURLsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReadAttributes())
                {
                    context.Writer.WritePropertyName("ReadAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReadAttributesListValue in publicRequest.ReadAttributes)
                    {
                            context.Writer.Write(publicRequestReadAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRefreshTokenValidity())
                {
                    context.Writer.WritePropertyName("RefreshTokenValidity");
                    context.Writer.Write(publicRequest.RefreshTokenValidity);
                }

                if(publicRequest.IsSetSupportedIdentityProviders())
                {
                    context.Writer.WritePropertyName("SupportedIdentityProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupportedIdentityProvidersListValue in publicRequest.SupportedIdentityProviders)
                    {
                            context.Writer.Write(publicRequestSupportedIdentityProvidersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserPoolId())
                {
                    context.Writer.WritePropertyName("UserPoolId");
                    context.Writer.Write(publicRequest.UserPoolId);
                }

                if(publicRequest.IsSetWriteAttributes())
                {
                    context.Writer.WritePropertyName("WriteAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWriteAttributesListValue in publicRequest.WriteAttributes)
                    {
                            context.Writer.Write(publicRequestWriteAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateUserPoolClientRequestMarshaller _instance = new CreateUserPoolClientRequestMarshaller();        

        internal static CreateUserPoolClientRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUserPoolClientRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}