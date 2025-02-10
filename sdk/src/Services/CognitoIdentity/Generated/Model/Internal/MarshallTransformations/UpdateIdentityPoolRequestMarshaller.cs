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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
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
namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIdentityPool Request Marshaller
    /// </summary>       
    public class UpdateIdentityPoolRequestMarshaller : IMarshaller<IRequest, UpdateIdentityPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIdentityPoolRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIdentityPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.UpdateIdentityPool";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
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
            if(publicRequest.IsSetAllowClassicFlow())
            {
                context.Writer.WritePropertyName("AllowClassicFlow");
                context.Writer.WriteBooleanValue(publicRequest.AllowClassicFlow.Value);
            }

            if(publicRequest.IsSetAllowUnauthenticatedIdentities())
            {
                context.Writer.WritePropertyName("AllowUnauthenticatedIdentities");
                context.Writer.WriteBooleanValue(publicRequest.AllowUnauthenticatedIdentities.Value);
            }

            if(publicRequest.IsSetCognitoIdentityProviders())
            {
                context.Writer.WritePropertyName("CognitoIdentityProviders");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCognitoIdentityProvidersListValue in publicRequest.CognitoIdentityProviders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CognitoIdentityProviderInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequestCognitoIdentityProvidersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeveloperProviderName())
            {
                context.Writer.WritePropertyName("DeveloperProviderName");
                context.Writer.WriteStringValue(publicRequest.DeveloperProviderName);
            }

            if(publicRequest.IsSetIdentityPoolId())
            {
                context.Writer.WritePropertyName("IdentityPoolId");
                context.Writer.WriteStringValue(publicRequest.IdentityPoolId);
            }

            if(publicRequest.IsSetIdentityPoolName())
            {
                context.Writer.WritePropertyName("IdentityPoolName");
                context.Writer.WriteStringValue(publicRequest.IdentityPoolName);
            }

            if(publicRequest.IsSetIdentityPoolTags())
            {
                context.Writer.WritePropertyName("IdentityPoolTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestIdentityPoolTagsKvp in publicRequest.IdentityPoolTags)
                {
                    context.Writer.WritePropertyName(publicRequestIdentityPoolTagsKvp.Key);
                    var publicRequestIdentityPoolTagsValue = publicRequestIdentityPoolTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestIdentityPoolTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOpenIdConnectProviderARNs())
            {
                context.Writer.WritePropertyName("OpenIdConnectProviderARNs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOpenIdConnectProviderARNsListValue in publicRequest.OpenIdConnectProviderARNs)
                {
                        context.Writer.WriteStringValue(publicRequestOpenIdConnectProviderARNsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSamlProviderARNs())
            {
                context.Writer.WritePropertyName("SamlProviderARNs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSamlProviderARNsListValue in publicRequest.SamlProviderARNs)
                {
                        context.Writer.WriteStringValue(publicRequestSamlProviderARNsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSupportedLoginProviders())
            {
                context.Writer.WritePropertyName("SupportedLoginProviders");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSupportedLoginProvidersKvp in publicRequest.SupportedLoginProviders)
                {
                    context.Writer.WritePropertyName(publicRequestSupportedLoginProvidersKvp.Key);
                    var publicRequestSupportedLoginProvidersValue = publicRequestSupportedLoginProvidersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestSupportedLoginProvidersValue);
                }
                context.Writer.WriteEndObject();
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
        private static UpdateIdentityPoolRequestMarshaller _instance = new UpdateIdentityPoolRequestMarshaller();        

        internal static UpdateIdentityPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIdentityPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}