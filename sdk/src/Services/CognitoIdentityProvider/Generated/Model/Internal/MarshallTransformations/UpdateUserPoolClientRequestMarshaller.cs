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
    /// UpdateUserPoolClient Request Marshaller
    /// </summary>       
    public class UpdateUserPoolClientRequestMarshaller : IMarshaller<IRequest, UpdateUserPoolClientRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateUserPoolClientRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateUserPoolClientRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.UpdateUserPoolClient";
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
                if(publicRequest.IsSetAccessTokenValidity())
                {
                    context.Writer.WritePropertyName("AccessTokenValidity");
                    context.Writer.Write(publicRequest.AccessTokenValidity);
                }

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

                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("ClientId");
                    context.Writer.Write(publicRequest.ClientId);
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

                if(publicRequest.IsSetIdTokenValidity())
                {
                    context.Writer.WritePropertyName("IdTokenValidity");
                    context.Writer.Write(publicRequest.IdTokenValidity);
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

                if(publicRequest.IsSetPreventUserExistenceErrors())
                {
                    context.Writer.WritePropertyName("PreventUserExistenceErrors");
                    context.Writer.Write(publicRequest.PreventUserExistenceErrors);
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

                if(publicRequest.IsSetTokenValidityUnits())
                {
                    context.Writer.WritePropertyName("TokenValidityUnits");
                    context.Writer.WriteObjectStart();

                    var marshaller = TokenValidityUnitsTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TokenValidityUnits, context);

                    context.Writer.WriteObjectEnd();
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
        private static UpdateUserPoolClientRequestMarshaller _instance = new UpdateUserPoolClientRequestMarshaller();        

        internal static UpdateUserPoolClientRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateUserPoolClientRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}