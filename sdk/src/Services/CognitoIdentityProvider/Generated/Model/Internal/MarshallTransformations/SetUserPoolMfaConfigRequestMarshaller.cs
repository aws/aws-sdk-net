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
    /// SetUserPoolMfaConfig Request Marshaller
    /// </summary>       
    public class SetUserPoolMfaConfigRequestMarshaller : IMarshaller<IRequest, SetUserPoolMfaConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetUserPoolMfaConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetUserPoolMfaConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.SetUserPoolMfaConfig";
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
            if(publicRequest.IsSetEmailMfaConfiguration())
            {
                context.Writer.WritePropertyName("EmailMfaConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EmailMfaConfigTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.EmailMfaConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMfaConfiguration())
            {
                context.Writer.WritePropertyName("MfaConfiguration");
                context.Writer.WriteStringValue(publicRequest.MfaConfiguration);
            }

            if(publicRequest.IsSetSmsMfaConfiguration())
            {
                context.Writer.WritePropertyName("SmsMfaConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SmsMfaConfigTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.SmsMfaConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSoftwareTokenMfaConfiguration())
            {
                context.Writer.WritePropertyName("SoftwareTokenMfaConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SoftwareTokenMfaConfigTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.SoftwareTokenMfaConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserPoolId())
            {
                context.Writer.WritePropertyName("UserPoolId");
                context.Writer.WriteStringValue(publicRequest.UserPoolId);
            }

            if(publicRequest.IsSetWebAuthnConfiguration())
            {
                context.Writer.WritePropertyName("WebAuthnConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WebAuthnConfigurationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.WebAuthnConfiguration, context);

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
        private static SetUserPoolMfaConfigRequestMarshaller _instance = new SetUserPoolMfaConfigRequestMarshaller();        

        internal static SetUserPoolMfaConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetUserPoolMfaConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}