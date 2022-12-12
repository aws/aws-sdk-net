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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProfile Request Marshaller
    /// </summary>       
    public class CreateProfileRequestMarshaller : IMarshaller<IRequest, CreateProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/profiles";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountNumber())
                {
                    context.Writer.WritePropertyName("AccountNumber");
                    context.Writer.Write(publicRequest.AccountNumber);
                }

                if(publicRequest.IsSetAdditionalInformation())
                {
                    context.Writer.WritePropertyName("AdditionalInformation");
                    context.Writer.Write(publicRequest.AdditionalInformation);
                }

                if(publicRequest.IsSetAddress())
                {
                    context.Writer.WritePropertyName("Address");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Address, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("Attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBillingAddress())
                {
                    context.Writer.WritePropertyName("BillingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BillingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBirthDate())
                {
                    context.Writer.WritePropertyName("BirthDate");
                    context.Writer.Write(publicRequest.BirthDate);
                }

                if(publicRequest.IsSetBusinessEmailAddress())
                {
                    context.Writer.WritePropertyName("BusinessEmailAddress");
                    context.Writer.Write(publicRequest.BusinessEmailAddress);
                }

                if(publicRequest.IsSetBusinessName())
                {
                    context.Writer.WritePropertyName("BusinessName");
                    context.Writer.Write(publicRequest.BusinessName);
                }

                if(publicRequest.IsSetBusinessPhoneNumber())
                {
                    context.Writer.WritePropertyName("BusinessPhoneNumber");
                    context.Writer.Write(publicRequest.BusinessPhoneNumber);
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

                if(publicRequest.IsSetGender())
                {
                    context.Writer.WritePropertyName("Gender");
                    context.Writer.Write(publicRequest.Gender);
                }

                if(publicRequest.IsSetGenderString())
                {
                    context.Writer.WritePropertyName("GenderString");
                    context.Writer.Write(publicRequest.GenderString);
                }

                if(publicRequest.IsSetHomePhoneNumber())
                {
                    context.Writer.WritePropertyName("HomePhoneNumber");
                    context.Writer.Write(publicRequest.HomePhoneNumber);
                }

                if(publicRequest.IsSetLastName())
                {
                    context.Writer.WritePropertyName("LastName");
                    context.Writer.Write(publicRequest.LastName);
                }

                if(publicRequest.IsSetMailingAddress())
                {
                    context.Writer.WritePropertyName("MailingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MailingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMiddleName())
                {
                    context.Writer.WritePropertyName("MiddleName");
                    context.Writer.Write(publicRequest.MiddleName);
                }

                if(publicRequest.IsSetMobilePhoneNumber())
                {
                    context.Writer.WritePropertyName("MobilePhoneNumber");
                    context.Writer.Write(publicRequest.MobilePhoneNumber);
                }

                if(publicRequest.IsSetPartyType())
                {
                    context.Writer.WritePropertyName("PartyType");
                    context.Writer.Write(publicRequest.PartyType);
                }

                if(publicRequest.IsSetPartyTypeString())
                {
                    context.Writer.WritePropertyName("PartyTypeString");
                    context.Writer.Write(publicRequest.PartyTypeString);
                }

                if(publicRequest.IsSetPersonalEmailAddress())
                {
                    context.Writer.WritePropertyName("PersonalEmailAddress");
                    context.Writer.Write(publicRequest.PersonalEmailAddress);
                }

                if(publicRequest.IsSetPhoneNumber())
                {
                    context.Writer.WritePropertyName("PhoneNumber");
                    context.Writer.Write(publicRequest.PhoneNumber);
                }

                if(publicRequest.IsSetShippingAddress())
                {
                    context.Writer.WritePropertyName("ShippingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShippingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateProfileRequestMarshaller _instance = new CreateProfileRequestMarshaller();        

        internal static CreateProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}