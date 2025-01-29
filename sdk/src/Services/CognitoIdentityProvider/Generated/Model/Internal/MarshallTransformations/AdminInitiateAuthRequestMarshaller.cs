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
    /// AdminInitiateAuth Request Marshaller
    /// </summary>       
    public class AdminInitiateAuthRequestMarshaller : IMarshaller<IRequest, AdminInitiateAuthRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AdminInitiateAuthRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AdminInitiateAuthRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.AdminInitiateAuth";
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
            if(publicRequest.IsSetAnalyticsMetadata())
            {
                context.Writer.WritePropertyName("AnalyticsMetadata");
                context.Writer.WriteStartObject();

                var marshaller = AnalyticsMetadataTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.AnalyticsMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAuthFlow())
            {
                context.Writer.WritePropertyName("AuthFlow");
                context.Writer.WriteStringValue(publicRequest.AuthFlow);
            }

            if(publicRequest.IsSetAuthParameters())
            {
                context.Writer.WritePropertyName("AuthParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAuthParametersKvp in publicRequest.AuthParameters)
                {
                    context.Writer.WritePropertyName(publicRequestAuthParametersKvp.Key);
                    var publicRequestAuthParametersValue = publicRequestAuthParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAuthParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
            }

            if(publicRequest.IsSetClientMetadata())
            {
                context.Writer.WritePropertyName("ClientMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestClientMetadataKvp in publicRequest.ClientMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestClientMetadataKvp.Key);
                    var publicRequestClientMetadataValue = publicRequestClientMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestClientMetadataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContextData())
            {
                context.Writer.WritePropertyName("ContextData");
                context.Writer.WriteStartObject();

                var marshaller = ContextDataTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContextData, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSession())
            {
                context.Writer.WritePropertyName("Session");
                context.Writer.WriteStringValue(publicRequest.Session);
            }

            if(publicRequest.IsSetUserPoolId())
            {
                context.Writer.WritePropertyName("UserPoolId");
                context.Writer.WriteStringValue(publicRequest.UserPoolId);
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
        private static AdminInitiateAuthRequestMarshaller _instance = new AdminInitiateAuthRequestMarshaller();        

        internal static AdminInitiateAuthRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminInitiateAuthRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}