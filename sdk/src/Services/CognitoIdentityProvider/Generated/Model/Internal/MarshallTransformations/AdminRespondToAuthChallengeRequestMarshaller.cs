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
    /// AdminRespondToAuthChallenge Request Marshaller
    /// </summary>       
    public class AdminRespondToAuthChallengeRequestMarshaller : IMarshaller<IRequest, AdminRespondToAuthChallengeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AdminRespondToAuthChallengeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AdminRespondToAuthChallengeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.AdminRespondToAuthChallenge";
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

            if(publicRequest.IsSetChallengeName())
            {
                context.Writer.WritePropertyName("ChallengeName");
                context.Writer.WriteStringValue(publicRequest.ChallengeName);
            }

            if(publicRequest.IsSetChallengeResponses())
            {
                context.Writer.WritePropertyName("ChallengeResponses");
                context.Writer.WriteStartObject();
                foreach (var publicRequestChallengeResponsesKvp in publicRequest.ChallengeResponses)
                {
                    context.Writer.WritePropertyName(publicRequestChallengeResponsesKvp.Key);
                    var publicRequestChallengeResponsesValue = publicRequestChallengeResponsesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestChallengeResponsesValue);
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
        private static AdminRespondToAuthChallengeRequestMarshaller _instance = new AdminRespondToAuthChallengeRequestMarshaller();        

        internal static AdminRespondToAuthChallengeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminRespondToAuthChallengeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}