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
    /// UpdateUserPool Request Marshaller
    /// </summary>       
    public class UpdateUserPoolRequestMarshaller : IMarshaller<IRequest, UpdateUserPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateUserPoolRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateUserPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.UpdateUserPool";
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
            if(publicRequest.IsSetAccountRecoverySetting())
            {
                context.Writer.WritePropertyName("AccountRecoverySetting");
                context.Writer.WriteStartObject();

                var marshaller = AccountRecoverySettingTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccountRecoverySetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAdminCreateUserConfig())
            {
                context.Writer.WritePropertyName("AdminCreateUserConfig");
                context.Writer.WriteStartObject();

                var marshaller = AdminCreateUserConfigTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdminCreateUserConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoVerifiedAttributes())
            {
                context.Writer.WritePropertyName("AutoVerifiedAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAutoVerifiedAttributesListValue in publicRequest.AutoVerifiedAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestAutoVerifiedAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("DeletionProtection");
                context.Writer.WriteStringValue(publicRequest.DeletionProtection);
            }

            if(publicRequest.IsSetDeviceConfiguration())
            {
                context.Writer.WritePropertyName("DeviceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeviceConfigurationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEmailConfiguration())
            {
                context.Writer.WritePropertyName("EmailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EmailConfigurationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.EmailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEmailVerificationMessage())
            {
                context.Writer.WritePropertyName("EmailVerificationMessage");
                context.Writer.WriteStringValue(publicRequest.EmailVerificationMessage);
            }

            if(publicRequest.IsSetEmailVerificationSubject())
            {
                context.Writer.WritePropertyName("EmailVerificationSubject");
                context.Writer.WriteStringValue(publicRequest.EmailVerificationSubject);
            }

            if(publicRequest.IsSetLambdaConfig())
            {
                context.Writer.WritePropertyName("LambdaConfig");
                context.Writer.WriteStartObject();

                var marshaller = LambdaConfigTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.LambdaConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMfaConfiguration())
            {
                context.Writer.WritePropertyName("MfaConfiguration");
                context.Writer.WriteStringValue(publicRequest.MfaConfiguration);
            }

            if(publicRequest.IsSetPolicies())
            {
                context.Writer.WritePropertyName("Policies");
                context.Writer.WriteStartObject();

                var marshaller = UserPoolPolicyTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Policies, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPoolName())
            {
                context.Writer.WritePropertyName("PoolName");
                context.Writer.WriteStringValue(publicRequest.PoolName);
            }

            if(publicRequest.IsSetSmsAuthenticationMessage())
            {
                context.Writer.WritePropertyName("SmsAuthenticationMessage");
                context.Writer.WriteStringValue(publicRequest.SmsAuthenticationMessage);
            }

            if(publicRequest.IsSetSmsConfiguration())
            {
                context.Writer.WritePropertyName("SmsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SmsConfigurationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.SmsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSmsVerificationMessage())
            {
                context.Writer.WritePropertyName("SmsVerificationMessage");
                context.Writer.WriteStringValue(publicRequest.SmsVerificationMessage);
            }

            if(publicRequest.IsSetUserAttributeUpdateSettings())
            {
                context.Writer.WritePropertyName("UserAttributeUpdateSettings");
                context.Writer.WriteStartObject();

                var marshaller = UserAttributeUpdateSettingsTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserAttributeUpdateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserPoolAddOns())
            {
                context.Writer.WritePropertyName("UserPoolAddOns");
                context.Writer.WriteStartObject();

                var marshaller = UserPoolAddOnsTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserPoolAddOns, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserPoolId())
            {
                context.Writer.WritePropertyName("UserPoolId");
                context.Writer.WriteStringValue(publicRequest.UserPoolId);
            }

            if(publicRequest.IsSetUserPoolTags())
            {
                context.Writer.WritePropertyName("UserPoolTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestUserPoolTagsKvp in publicRequest.UserPoolTags)
                {
                    context.Writer.WritePropertyName(publicRequestUserPoolTagsKvp.Key);
                    var publicRequestUserPoolTagsValue = publicRequestUserPoolTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestUserPoolTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserPoolTier())
            {
                context.Writer.WritePropertyName("UserPoolTier");
                context.Writer.WriteStringValue(publicRequest.UserPoolTier);
            }

            if(publicRequest.IsSetVerificationMessageTemplate())
            {
                context.Writer.WritePropertyName("VerificationMessageTemplate");
                context.Writer.WriteStartObject();

                var marshaller = VerificationMessageTemplateTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.VerificationMessageTemplate, context);

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
        private static UpdateUserPoolRequestMarshaller _instance = new UpdateUserPoolRequestMarshaller();        

        internal static UpdateUserPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateUserPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}