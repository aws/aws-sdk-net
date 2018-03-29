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
    /// AdminCreateUser Request Marshaller
    /// </summary>       
    public class AdminCreateUserRequestMarshaller : IMarshaller<IRequest, AdminCreateUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AdminCreateUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AdminCreateUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.AdminCreateUser";
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
                if(publicRequest.IsSetDesiredDeliveryMediums())
                {
                    context.Writer.WritePropertyName("DesiredDeliveryMediums");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDesiredDeliveryMediumsListValue in publicRequest.DesiredDeliveryMediums)
                    {
                            context.Writer.Write(publicRequestDesiredDeliveryMediumsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetForceAliasCreation())
                {
                    context.Writer.WritePropertyName("ForceAliasCreation");
                    context.Writer.Write(publicRequest.ForceAliasCreation);
                }

                if(publicRequest.IsSetMessageAction())
                {
                    context.Writer.WritePropertyName("MessageAction");
                    context.Writer.Write(publicRequest.MessageAction);
                }

                if(publicRequest.IsSetTemporaryPassword())
                {
                    context.Writer.WritePropertyName("TemporaryPassword");
                    context.Writer.Write(publicRequest.TemporaryPassword);
                }

                if(publicRequest.IsSetUserAttributes())
                {
                    context.Writer.WritePropertyName("UserAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserAttributesListValue in publicRequest.UserAttributes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeTypeMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserAttributesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUsername())
                {
                    context.Writer.WritePropertyName("Username");
                    context.Writer.Write(publicRequest.Username);
                }

                if(publicRequest.IsSetUserPoolId())
                {
                    context.Writer.WritePropertyName("UserPoolId");
                    context.Writer.Write(publicRequest.UserPoolId);
                }

                if(publicRequest.IsSetValidationData())
                {
                    context.Writer.WritePropertyName("ValidationData");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestValidationDataListValue in publicRequest.ValidationData)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeTypeMarshaller.Instance;
                        marshaller.Marshall(publicRequestValidationDataListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AdminCreateUserRequestMarshaller _instance = new AdminCreateUserRequestMarshaller();        

        internal static AdminCreateUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminCreateUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}