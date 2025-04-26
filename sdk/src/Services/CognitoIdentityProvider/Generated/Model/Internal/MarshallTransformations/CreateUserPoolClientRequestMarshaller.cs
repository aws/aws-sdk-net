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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessTokenValidity())
            {
                context.Writer.WritePropertyName("AccessTokenValidity");
                context.Writer.WriteNumberValue(publicRequest.AccessTokenValidity.Value);
            }

            if(publicRequest.IsSetAllowedOAuthFlows())
            {
                context.Writer.WritePropertyName("AllowedOAuthFlows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedOAuthFlowsListValue in publicRequest.AllowedOAuthFlows)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedOAuthFlowsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAllowedOAuthFlowsUserPoolClient())
            {
                context.Writer.WritePropertyName("AllowedOAuthFlowsUserPoolClient");
                context.Writer.WriteBooleanValue(publicRequest.AllowedOAuthFlowsUserPoolClient.Value);
            }

            if(publicRequest.IsSetAllowedOAuthScopes())
            {
                context.Writer.WritePropertyName("AllowedOAuthScopes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedOAuthScopesListValue in publicRequest.AllowedOAuthScopes)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedOAuthScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAnalyticsConfiguration())
            {
                context.Writer.WritePropertyName("AnalyticsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AnalyticsConfigurationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.AnalyticsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAuthSessionValidity())
            {
                context.Writer.WritePropertyName("AuthSessionValidity");
                context.Writer.WriteNumberValue(publicRequest.AuthSessionValidity.Value);
            }

            if(publicRequest.IsSetCallbackURLs())
            {
                context.Writer.WritePropertyName("CallbackURLs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCallbackURLsListValue in publicRequest.CallbackURLs)
                {
                        context.Writer.WriteStringValue(publicRequestCallbackURLsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientName())
            {
                context.Writer.WritePropertyName("ClientName");
                context.Writer.WriteStringValue(publicRequest.ClientName);
            }

            if(publicRequest.IsSetDefaultRedirectURI())
            {
                context.Writer.WritePropertyName("DefaultRedirectURI");
                context.Writer.WriteStringValue(publicRequest.DefaultRedirectURI);
            }

            if(publicRequest.IsSetEnablePropagateAdditionalUserContextData())
            {
                context.Writer.WritePropertyName("EnablePropagateAdditionalUserContextData");
                context.Writer.WriteBooleanValue(publicRequest.EnablePropagateAdditionalUserContextData.Value);
            }

            if(publicRequest.IsSetEnableTokenRevocation())
            {
                context.Writer.WritePropertyName("EnableTokenRevocation");
                context.Writer.WriteBooleanValue(publicRequest.EnableTokenRevocation.Value);
            }

            if(publicRequest.IsSetExplicitAuthFlows())
            {
                context.Writer.WritePropertyName("ExplicitAuthFlows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExplicitAuthFlowsListValue in publicRequest.ExplicitAuthFlows)
                {
                        context.Writer.WriteStringValue(publicRequestExplicitAuthFlowsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGenerateSecret())
            {
                context.Writer.WritePropertyName("GenerateSecret");
                context.Writer.WriteBooleanValue(publicRequest.GenerateSecret.Value);
            }

            if(publicRequest.IsSetIdTokenValidity())
            {
                context.Writer.WritePropertyName("IdTokenValidity");
                context.Writer.WriteNumberValue(publicRequest.IdTokenValidity.Value);
            }

            if(publicRequest.IsSetLogoutURLs())
            {
                context.Writer.WritePropertyName("LogoutURLs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLogoutURLsListValue in publicRequest.LogoutURLs)
                {
                        context.Writer.WriteStringValue(publicRequestLogoutURLsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPreventUserExistenceErrors())
            {
                context.Writer.WritePropertyName("PreventUserExistenceErrors");
                context.Writer.WriteStringValue(publicRequest.PreventUserExistenceErrors);
            }

            if(publicRequest.IsSetReadAttributes())
            {
                context.Writer.WritePropertyName("ReadAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReadAttributesListValue in publicRequest.ReadAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestReadAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRefreshTokenRotation())
            {
                context.Writer.WritePropertyName("RefreshTokenRotation");
                context.Writer.WriteStartObject();

                var marshaller = RefreshTokenRotationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.RefreshTokenRotation, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRefreshTokenValidity())
            {
                context.Writer.WritePropertyName("RefreshTokenValidity");
                context.Writer.WriteNumberValue(publicRequest.RefreshTokenValidity.Value);
            }

            if(publicRequest.IsSetSupportedIdentityProviders())
            {
                context.Writer.WritePropertyName("SupportedIdentityProviders");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSupportedIdentityProvidersListValue in publicRequest.SupportedIdentityProviders)
                {
                        context.Writer.WriteStringValue(publicRequestSupportedIdentityProvidersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTokenValidityUnits())
            {
                context.Writer.WritePropertyName("TokenValidityUnits");
                context.Writer.WriteStartObject();

                var marshaller = TokenValidityUnitsTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.TokenValidityUnits, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserPoolId())
            {
                context.Writer.WritePropertyName("UserPoolId");
                context.Writer.WriteStringValue(publicRequest.UserPoolId);
            }

            if(publicRequest.IsSetWriteAttributes())
            {
                context.Writer.WritePropertyName("WriteAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWriteAttributesListValue in publicRequest.WriteAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestWriteAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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