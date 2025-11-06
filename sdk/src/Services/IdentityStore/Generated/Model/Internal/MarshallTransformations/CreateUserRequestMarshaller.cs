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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityStore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUser Request Marshaller
    /// </summary>       
    public class CreateUserRequestMarshaller : IMarshaller<IRequest, CreateUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityStore");
            string target = "AWSIdentityStore.CreateUser";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddresses())
                {
                    context.Writer.WritePropertyName("Addresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddressesListValue in publicRequest.Addresses)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AddressMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddressesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBirthdate())
                {
                    context.Writer.WritePropertyName("Birthdate");
                    context.Writer.Write(publicRequest.Birthdate);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetEmails())
                {
                    context.Writer.WritePropertyName("Emails");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEmailsListValue in publicRequest.Emails)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EmailMarshaller.Instance;
                        marshaller.Marshall(publicRequestEmailsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdentityStoreId())
                {
                    context.Writer.WritePropertyName("IdentityStoreId");
                    context.Writer.Write(publicRequest.IdentityStoreId);
                }

                if(publicRequest.IsSetLocale())
                {
                    context.Writer.WritePropertyName("Locale");
                    context.Writer.Write(publicRequest.Locale);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.WriteObjectStart();

                    var marshaller = NameMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Name, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNickName())
                {
                    context.Writer.WritePropertyName("NickName");
                    context.Writer.Write(publicRequest.NickName);
                }

                if(publicRequest.IsSetPhoneNumbers())
                {
                    context.Writer.WritePropertyName("PhoneNumbers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPhoneNumbersListValue in publicRequest.PhoneNumbers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PhoneNumberMarshaller.Instance;
                        marshaller.Marshall(publicRequestPhoneNumbersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPhotos())
                {
                    context.Writer.WritePropertyName("Photos");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPhotosListValue in publicRequest.Photos)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PhotoMarshaller.Instance;
                        marshaller.Marshall(publicRequestPhotosListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPreferredLanguage())
                {
                    context.Writer.WritePropertyName("PreferredLanguage");
                    context.Writer.Write(publicRequest.PreferredLanguage);
                }

                if(publicRequest.IsSetProfileUrl())
                {
                    context.Writer.WritePropertyName("ProfileUrl");
                    context.Writer.Write(publicRequest.ProfileUrl);
                }

                if(publicRequest.IsSetTimezone())
                {
                    context.Writer.WritePropertyName("Timezone");
                    context.Writer.Write(publicRequest.Timezone);
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("Title");
                    context.Writer.Write(publicRequest.Title);
                }

                if(publicRequest.IsSetUserName())
                {
                    context.Writer.WritePropertyName("UserName");
                    context.Writer.Write(publicRequest.UserName);
                }

                if(publicRequest.IsSetUserType())
                {
                    context.Writer.WritePropertyName("UserType");
                    context.Writer.Write(publicRequest.UserType);
                }

                if(publicRequest.IsSetWebsite())
                {
                    context.Writer.WritePropertyName("Website");
                    context.Writer.Write(publicRequest.Website);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateUserRequestMarshaller _instance = new CreateUserRequestMarshaller();        

        internal static CreateUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}