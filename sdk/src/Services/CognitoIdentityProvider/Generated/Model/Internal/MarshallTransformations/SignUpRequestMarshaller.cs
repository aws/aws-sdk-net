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
    /// SignUp Request Marshaller
    /// </summary>       
    public class SignUpRequestMarshaller : IMarshaller<IRequest, SignUpRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SignUpRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SignUpRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.SignUp";
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

            if(publicRequest.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(publicRequest.Password);
            }

            if(publicRequest.IsSetSecretHash())
            {
                context.Writer.WritePropertyName("SecretHash");
                context.Writer.WriteStringValue(publicRequest.SecretHash);
            }

            if(publicRequest.IsSetUserAttributes())
            {
                context.Writer.WritePropertyName("UserAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUserAttributesListValue in publicRequest.UserAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequestUserAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUserContextData())
            {
                context.Writer.WritePropertyName("UserContextData");
                context.Writer.WriteStartObject();

                var marshaller = UserContextDataTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserContextData, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(publicRequest.Username);
            }

            if(publicRequest.IsSetValidationData())
            {
                context.Writer.WritePropertyName("ValidationData");
                context.Writer.WriteStartArray();
                foreach(var publicRequestValidationDataListValue in publicRequest.ValidationData)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequestValidationDataListValue, context);

                    context.Writer.WriteEndObject();
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
        private static SignUpRequestMarshaller _instance = new SignUpRequestMarshaller();        

        internal static SignUpRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SignUpRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}