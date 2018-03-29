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
    /// CreateUserPool Request Marshaller
    /// </summary>       
    public class CreateUserPoolRequestMarshaller : IMarshaller<IRequest, CreateUserPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserPoolRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUserPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.CreateUserPool";
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
                if(publicRequest.IsSetAdminCreateUserConfig())
                {
                    context.Writer.WritePropertyName("AdminCreateUserConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AdminCreateUserConfigTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdminCreateUserConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAliasAttributes())
                {
                    context.Writer.WritePropertyName("AliasAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAliasAttributesListValue in publicRequest.AliasAttributes)
                    {
                            context.Writer.Write(publicRequestAliasAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAutoVerifiedAttributes())
                {
                    context.Writer.WritePropertyName("AutoVerifiedAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoVerifiedAttributesListValue in publicRequest.AutoVerifiedAttributes)
                    {
                            context.Writer.Write(publicRequestAutoVerifiedAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeviceConfiguration())
                {
                    context.Writer.WritePropertyName("DeviceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceConfigurationTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEmailConfiguration())
                {
                    context.Writer.WritePropertyName("EmailConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EmailConfigurationTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EmailConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEmailVerificationMessage())
                {
                    context.Writer.WritePropertyName("EmailVerificationMessage");
                    context.Writer.Write(publicRequest.EmailVerificationMessage);
                }

                if(publicRequest.IsSetEmailVerificationSubject())
                {
                    context.Writer.WritePropertyName("EmailVerificationSubject");
                    context.Writer.Write(publicRequest.EmailVerificationSubject);
                }

                if(publicRequest.IsSetLambdaConfig())
                {
                    context.Writer.WritePropertyName("LambdaConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LambdaConfigTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LambdaConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMfaConfiguration())
                {
                    context.Writer.WritePropertyName("MfaConfiguration");
                    context.Writer.Write(publicRequest.MfaConfiguration);
                }

                if(publicRequest.IsSetPolicies())
                {
                    context.Writer.WritePropertyName("Policies");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserPoolPolicyTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Policies, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPoolName())
                {
                    context.Writer.WritePropertyName("PoolName");
                    context.Writer.Write(publicRequest.PoolName);
                }

                if(publicRequest.IsSetSchema())
                {
                    context.Writer.WritePropertyName("Schema");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSchemaListValue in publicRequest.Schema)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SchemaAttributeTypeMarshaller.Instance;
                        marshaller.Marshall(publicRequestSchemaListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSmsAuthenticationMessage())
                {
                    context.Writer.WritePropertyName("SmsAuthenticationMessage");
                    context.Writer.Write(publicRequest.SmsAuthenticationMessage);
                }

                if(publicRequest.IsSetSmsConfiguration())
                {
                    context.Writer.WritePropertyName("SmsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SmsConfigurationTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SmsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSmsVerificationMessage())
                {
                    context.Writer.WritePropertyName("SmsVerificationMessage");
                    context.Writer.Write(publicRequest.SmsVerificationMessage);
                }

                if(publicRequest.IsSetUsernameAttributes())
                {
                    context.Writer.WritePropertyName("UsernameAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUsernameAttributesListValue in publicRequest.UsernameAttributes)
                    {
                            context.Writer.Write(publicRequestUsernameAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserPoolAddOns())
                {
                    context.Writer.WritePropertyName("UserPoolAddOns");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserPoolAddOnsTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserPoolAddOns, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUserPoolTags())
                {
                    context.Writer.WritePropertyName("UserPoolTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestUserPoolTagsKvp in publicRequest.UserPoolTags)
                    {
                        context.Writer.WritePropertyName(publicRequestUserPoolTagsKvp.Key);
                        var publicRequestUserPoolTagsValue = publicRequestUserPoolTagsKvp.Value;

                            context.Writer.Write(publicRequestUserPoolTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVerificationMessageTemplate())
                {
                    context.Writer.WritePropertyName("VerificationMessageTemplate");
                    context.Writer.WriteObjectStart();

                    var marshaller = VerificationMessageTemplateTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VerificationMessageTemplate, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateUserPoolRequestMarshaller _instance = new CreateUserPoolRequestMarshaller();        

        internal static CreateUserPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUserPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}