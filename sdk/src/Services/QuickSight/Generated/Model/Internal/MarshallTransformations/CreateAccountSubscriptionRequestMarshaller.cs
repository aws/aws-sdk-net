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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAccountSubscription Request Marshaller
    /// </summary>       
    public class CreateAccountSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateAccountSubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAccountSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAccountSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/account/{AwsAccountId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountName())
                {
                    context.Writer.WritePropertyName("AccountName");
                    context.Writer.Write(publicRequest.AccountName);
                }

                if(publicRequest.IsSetActiveDirectoryName())
                {
                    context.Writer.WritePropertyName("ActiveDirectoryName");
                    context.Writer.Write(publicRequest.ActiveDirectoryName);
                }

                if(publicRequest.IsSetAdminGroup())
                {
                    context.Writer.WritePropertyName("AdminGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdminGroupListValue in publicRequest.AdminGroup)
                    {
                            context.Writer.Write(publicRequestAdminGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAdminProGroup())
                {
                    context.Writer.WritePropertyName("AdminProGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdminProGroupListValue in publicRequest.AdminProGroup)
                    {
                            context.Writer.Write(publicRequestAdminProGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthenticationMethod())
                {
                    context.Writer.WritePropertyName("AuthenticationMethod");
                    context.Writer.Write(publicRequest.AuthenticationMethod);
                }

                if(publicRequest.IsSetAuthorGroup())
                {
                    context.Writer.WritePropertyName("AuthorGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthorGroupListValue in publicRequest.AuthorGroup)
                    {
                            context.Writer.Write(publicRequestAuthorGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthorProGroup())
                {
                    context.Writer.WritePropertyName("AuthorProGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthorProGroupListValue in publicRequest.AuthorProGroup)
                    {
                            context.Writer.Write(publicRequestAuthorProGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetContactNumber())
                {
                    context.Writer.WritePropertyName("ContactNumber");
                    context.Writer.Write(publicRequest.ContactNumber);
                }

                if(publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WritePropertyName("DirectoryId");
                    context.Writer.Write(publicRequest.DirectoryId);
                }

                if(publicRequest.IsSetEdition())
                {
                    context.Writer.WritePropertyName("Edition");
                    context.Writer.Write(publicRequest.Edition);
                }

                if(publicRequest.IsSetEmailAddress())
                {
                    context.Writer.WritePropertyName("EmailAddress");
                    context.Writer.Write(publicRequest.EmailAddress);
                }

                if(publicRequest.IsSetFirstName())
                {
                    context.Writer.WritePropertyName("FirstName");
                    context.Writer.Write(publicRequest.FirstName);
                }

                if(publicRequest.IsSetIAMIdentityCenterInstanceArn())
                {
                    context.Writer.WritePropertyName("IAMIdentityCenterInstanceArn");
                    context.Writer.Write(publicRequest.IAMIdentityCenterInstanceArn);
                }

                if(publicRequest.IsSetLastName())
                {
                    context.Writer.WritePropertyName("LastName");
                    context.Writer.Write(publicRequest.LastName);
                }

                if(publicRequest.IsSetNotificationEmail())
                {
                    context.Writer.WritePropertyName("NotificationEmail");
                    context.Writer.Write(publicRequest.NotificationEmail);
                }

                if(publicRequest.IsSetReaderGroup())
                {
                    context.Writer.WritePropertyName("ReaderGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReaderGroupListValue in publicRequest.ReaderGroup)
                    {
                            context.Writer.Write(publicRequestReaderGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReaderProGroup())
                {
                    context.Writer.WritePropertyName("ReaderProGroup");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReaderProGroupListValue in publicRequest.ReaderProGroup)
                    {
                            context.Writer.Write(publicRequestReaderProGroupListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRealm())
                {
                    context.Writer.WritePropertyName("Realm");
                    context.Writer.Write(publicRequest.Realm);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAccountSubscriptionRequestMarshaller _instance = new CreateAccountSubscriptionRequestMarshaller();        

        internal static CreateAccountSubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAccountSubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}