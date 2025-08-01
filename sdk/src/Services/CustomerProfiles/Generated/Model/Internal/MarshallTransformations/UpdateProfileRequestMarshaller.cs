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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProfile Request Marshaller
    /// </summary>       
    public class UpdateProfileRequestMarshaller : IMarshaller<IRequest, UpdateProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/profiles";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountNumber())
            {
                context.Writer.WritePropertyName("AccountNumber");
                context.Writer.WriteStringValue(publicRequest.AccountNumber);
            }

            if(publicRequest.IsSetAdditionalInformation())
            {
                context.Writer.WritePropertyName("AdditionalInformation");
                context.Writer.WriteStringValue(publicRequest.AdditionalInformation);
            }

            if(publicRequest.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.WriteStartObject();

                var marshaller = UpdateAddressMarshaller.Instance;
                marshaller.Marshall(publicRequest.Address, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBillingAddress())
            {
                context.Writer.WritePropertyName("BillingAddress");
                context.Writer.WriteStartObject();

                var marshaller = UpdateAddressMarshaller.Instance;
                marshaller.Marshall(publicRequest.BillingAddress, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBirthDate())
            {
                context.Writer.WritePropertyName("BirthDate");
                context.Writer.WriteStringValue(publicRequest.BirthDate);
            }

            if(publicRequest.IsSetBusinessEmailAddress())
            {
                context.Writer.WritePropertyName("BusinessEmailAddress");
                context.Writer.WriteStringValue(publicRequest.BusinessEmailAddress);
            }

            if(publicRequest.IsSetBusinessName())
            {
                context.Writer.WritePropertyName("BusinessName");
                context.Writer.WriteStringValue(publicRequest.BusinessName);
            }

            if(publicRequest.IsSetBusinessPhoneNumber())
            {
                context.Writer.WritePropertyName("BusinessPhoneNumber");
                context.Writer.WriteStringValue(publicRequest.BusinessPhoneNumber);
            }

            if(publicRequest.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("EmailAddress");
                context.Writer.WriteStringValue(publicRequest.EmailAddress);
            }

            if(publicRequest.IsSetEngagementPreferences())
            {
                context.Writer.WritePropertyName("EngagementPreferences");
                context.Writer.WriteStartObject();

                var marshaller = EngagementPreferencesMarshaller.Instance;
                marshaller.Marshall(publicRequest.EngagementPreferences, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFirstName())
            {
                context.Writer.WritePropertyName("FirstName");
                context.Writer.WriteStringValue(publicRequest.FirstName);
            }

            if(publicRequest.IsSetGender())
            {
                context.Writer.WritePropertyName("Gender");
                context.Writer.WriteStringValue(publicRequest.Gender);
            }

            if(publicRequest.IsSetGenderString())
            {
                context.Writer.WritePropertyName("GenderString");
                context.Writer.WriteStringValue(publicRequest.GenderString);
            }

            if(publicRequest.IsSetHomePhoneNumber())
            {
                context.Writer.WritePropertyName("HomePhoneNumber");
                context.Writer.WriteStringValue(publicRequest.HomePhoneNumber);
            }

            if(publicRequest.IsSetLastName())
            {
                context.Writer.WritePropertyName("LastName");
                context.Writer.WriteStringValue(publicRequest.LastName);
            }

            if(publicRequest.IsSetMailingAddress())
            {
                context.Writer.WritePropertyName("MailingAddress");
                context.Writer.WriteStartObject();

                var marshaller = UpdateAddressMarshaller.Instance;
                marshaller.Marshall(publicRequest.MailingAddress, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMiddleName())
            {
                context.Writer.WritePropertyName("MiddleName");
                context.Writer.WriteStringValue(publicRequest.MiddleName);
            }

            if(publicRequest.IsSetMobilePhoneNumber())
            {
                context.Writer.WritePropertyName("MobilePhoneNumber");
                context.Writer.WriteStringValue(publicRequest.MobilePhoneNumber);
            }

            if(publicRequest.IsSetPartyType())
            {
                context.Writer.WritePropertyName("PartyType");
                context.Writer.WriteStringValue(publicRequest.PartyType);
            }

            if(publicRequest.IsSetPartyTypeString())
            {
                context.Writer.WritePropertyName("PartyTypeString");
                context.Writer.WriteStringValue(publicRequest.PartyTypeString);
            }

            if(publicRequest.IsSetPersonalEmailAddress())
            {
                context.Writer.WritePropertyName("PersonalEmailAddress");
                context.Writer.WriteStringValue(publicRequest.PersonalEmailAddress);
            }

            if(publicRequest.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.WriteStringValue(publicRequest.PhoneNumber);
            }

            if(publicRequest.IsSetProfileId())
            {
                context.Writer.WritePropertyName("ProfileId");
                context.Writer.WriteStringValue(publicRequest.ProfileId);
            }

            if(publicRequest.IsSetProfileType())
            {
                context.Writer.WritePropertyName("ProfileType");
                context.Writer.WriteStringValue(publicRequest.ProfileType);
            }

            if(publicRequest.IsSetShippingAddress())
            {
                context.Writer.WritePropertyName("ShippingAddress");
                context.Writer.WriteStartObject();

                var marshaller = UpdateAddressMarshaller.Instance;
                marshaller.Marshall(publicRequest.ShippingAddress, context);

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
        private static UpdateProfileRequestMarshaller _instance = new UpdateProfileRequestMarshaller();        

        internal static UpdateProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}