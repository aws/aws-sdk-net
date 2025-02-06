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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomerProfileAttributes Marshaller
    /// </summary>
    public class CustomerProfileAttributesMarshaller : IRequestMarshaller<CustomerProfileAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomerProfileAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountNumber())
            {
                context.Writer.WritePropertyName("accountNumber");
                context.Writer.WriteStringValue(requestObject.AccountNumber);
            }

            if(requestObject.IsSetAdditionalInformation())
            {
                context.Writer.WritePropertyName("additionalInformation");
                context.Writer.WriteStringValue(requestObject.AdditionalInformation);
            }

            if(requestObject.IsSetAddress1())
            {
                context.Writer.WritePropertyName("address1");
                context.Writer.WriteStringValue(requestObject.Address1);
            }

            if(requestObject.IsSetAddress2())
            {
                context.Writer.WritePropertyName("address2");
                context.Writer.WriteStringValue(requestObject.Address2);
            }

            if(requestObject.IsSetAddress3())
            {
                context.Writer.WritePropertyName("address3");
                context.Writer.WriteStringValue(requestObject.Address3);
            }

            if(requestObject.IsSetAddress4())
            {
                context.Writer.WritePropertyName("address4");
                context.Writer.WriteStringValue(requestObject.Address4);
            }

            if(requestObject.IsSetBillingAddress1())
            {
                context.Writer.WritePropertyName("billingAddress1");
                context.Writer.WriteStringValue(requestObject.BillingAddress1);
            }

            if(requestObject.IsSetBillingAddress2())
            {
                context.Writer.WritePropertyName("billingAddress2");
                context.Writer.WriteStringValue(requestObject.BillingAddress2);
            }

            if(requestObject.IsSetBillingAddress3())
            {
                context.Writer.WritePropertyName("billingAddress3");
                context.Writer.WriteStringValue(requestObject.BillingAddress3);
            }

            if(requestObject.IsSetBillingAddress4())
            {
                context.Writer.WritePropertyName("billingAddress4");
                context.Writer.WriteStringValue(requestObject.BillingAddress4);
            }

            if(requestObject.IsSetBillingCity())
            {
                context.Writer.WritePropertyName("billingCity");
                context.Writer.WriteStringValue(requestObject.BillingCity);
            }

            if(requestObject.IsSetBillingCountry())
            {
                context.Writer.WritePropertyName("billingCountry");
                context.Writer.WriteStringValue(requestObject.BillingCountry);
            }

            if(requestObject.IsSetBillingCounty())
            {
                context.Writer.WritePropertyName("billingCounty");
                context.Writer.WriteStringValue(requestObject.BillingCounty);
            }

            if(requestObject.IsSetBillingPostalCode())
            {
                context.Writer.WritePropertyName("billingPostalCode");
                context.Writer.WriteStringValue(requestObject.BillingPostalCode);
            }

            if(requestObject.IsSetBillingProvince())
            {
                context.Writer.WritePropertyName("billingProvince");
                context.Writer.WriteStringValue(requestObject.BillingProvince);
            }

            if(requestObject.IsSetBillingState())
            {
                context.Writer.WritePropertyName("billingState");
                context.Writer.WriteStringValue(requestObject.BillingState);
            }

            if(requestObject.IsSetBirthDate())
            {
                context.Writer.WritePropertyName("birthDate");
                context.Writer.WriteStringValue(requestObject.BirthDate);
            }

            if(requestObject.IsSetBusinessEmailAddress())
            {
                context.Writer.WritePropertyName("businessEmailAddress");
                context.Writer.WriteStringValue(requestObject.BusinessEmailAddress);
            }

            if(requestObject.IsSetBusinessName())
            {
                context.Writer.WritePropertyName("businessName");
                context.Writer.WriteStringValue(requestObject.BusinessName);
            }

            if(requestObject.IsSetBusinessPhoneNumber())
            {
                context.Writer.WritePropertyName("businessPhoneNumber");
                context.Writer.WriteStringValue(requestObject.BusinessPhoneNumber);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("city");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetCounty())
            {
                context.Writer.WritePropertyName("county");
                context.Writer.WriteStringValue(requestObject.County);
            }

            if(requestObject.IsSetCustom())
            {
                context.Writer.WritePropertyName("custom");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCustomKvp in requestObject.Custom)
                {
                    context.Writer.WritePropertyName(requestObjectCustomKvp.Key);
                    var requestObjectCustomValue = requestObjectCustomKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCustomValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("emailAddress");
                context.Writer.WriteStringValue(requestObject.EmailAddress);
            }

            if(requestObject.IsSetFirstName())
            {
                context.Writer.WritePropertyName("firstName");
                context.Writer.WriteStringValue(requestObject.FirstName);
            }

            if(requestObject.IsSetGender())
            {
                context.Writer.WritePropertyName("gender");
                context.Writer.WriteStringValue(requestObject.Gender);
            }

            if(requestObject.IsSetHomePhoneNumber())
            {
                context.Writer.WritePropertyName("homePhoneNumber");
                context.Writer.WriteStringValue(requestObject.HomePhoneNumber);
            }

            if(requestObject.IsSetLastName())
            {
                context.Writer.WritePropertyName("lastName");
                context.Writer.WriteStringValue(requestObject.LastName);
            }

            if(requestObject.IsSetMailingAddress1())
            {
                context.Writer.WritePropertyName("mailingAddress1");
                context.Writer.WriteStringValue(requestObject.MailingAddress1);
            }

            if(requestObject.IsSetMailingAddress2())
            {
                context.Writer.WritePropertyName("mailingAddress2");
                context.Writer.WriteStringValue(requestObject.MailingAddress2);
            }

            if(requestObject.IsSetMailingAddress3())
            {
                context.Writer.WritePropertyName("mailingAddress3");
                context.Writer.WriteStringValue(requestObject.MailingAddress3);
            }

            if(requestObject.IsSetMailingAddress4())
            {
                context.Writer.WritePropertyName("mailingAddress4");
                context.Writer.WriteStringValue(requestObject.MailingAddress4);
            }

            if(requestObject.IsSetMailingCity())
            {
                context.Writer.WritePropertyName("mailingCity");
                context.Writer.WriteStringValue(requestObject.MailingCity);
            }

            if(requestObject.IsSetMailingCountry())
            {
                context.Writer.WritePropertyName("mailingCountry");
                context.Writer.WriteStringValue(requestObject.MailingCountry);
            }

            if(requestObject.IsSetMailingCounty())
            {
                context.Writer.WritePropertyName("mailingCounty");
                context.Writer.WriteStringValue(requestObject.MailingCounty);
            }

            if(requestObject.IsSetMailingPostalCode())
            {
                context.Writer.WritePropertyName("mailingPostalCode");
                context.Writer.WriteStringValue(requestObject.MailingPostalCode);
            }

            if(requestObject.IsSetMailingProvince())
            {
                context.Writer.WritePropertyName("mailingProvince");
                context.Writer.WriteStringValue(requestObject.MailingProvince);
            }

            if(requestObject.IsSetMailingState())
            {
                context.Writer.WritePropertyName("mailingState");
                context.Writer.WriteStringValue(requestObject.MailingState);
            }

            if(requestObject.IsSetMiddleName())
            {
                context.Writer.WritePropertyName("middleName");
                context.Writer.WriteStringValue(requestObject.MiddleName);
            }

            if(requestObject.IsSetMobilePhoneNumber())
            {
                context.Writer.WritePropertyName("mobilePhoneNumber");
                context.Writer.WriteStringValue(requestObject.MobilePhoneNumber);
            }

            if(requestObject.IsSetPartyType())
            {
                context.Writer.WritePropertyName("partyType");
                context.Writer.WriteStringValue(requestObject.PartyType);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("phoneNumber");
                context.Writer.WriteStringValue(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("postalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetProfileARN())
            {
                context.Writer.WritePropertyName("profileARN");
                context.Writer.WriteStringValue(requestObject.ProfileARN);
            }

            if(requestObject.IsSetProfileId())
            {
                context.Writer.WritePropertyName("profileId");
                context.Writer.WriteStringValue(requestObject.ProfileId);
            }

            if(requestObject.IsSetProvince())
            {
                context.Writer.WritePropertyName("province");
                context.Writer.WriteStringValue(requestObject.Province);
            }

            if(requestObject.IsSetShippingAddress1())
            {
                context.Writer.WritePropertyName("shippingAddress1");
                context.Writer.WriteStringValue(requestObject.ShippingAddress1);
            }

            if(requestObject.IsSetShippingAddress2())
            {
                context.Writer.WritePropertyName("shippingAddress2");
                context.Writer.WriteStringValue(requestObject.ShippingAddress2);
            }

            if(requestObject.IsSetShippingAddress3())
            {
                context.Writer.WritePropertyName("shippingAddress3");
                context.Writer.WriteStringValue(requestObject.ShippingAddress3);
            }

            if(requestObject.IsSetShippingAddress4())
            {
                context.Writer.WritePropertyName("shippingAddress4");
                context.Writer.WriteStringValue(requestObject.ShippingAddress4);
            }

            if(requestObject.IsSetShippingCity())
            {
                context.Writer.WritePropertyName("shippingCity");
                context.Writer.WriteStringValue(requestObject.ShippingCity);
            }

            if(requestObject.IsSetShippingCountry())
            {
                context.Writer.WritePropertyName("shippingCountry");
                context.Writer.WriteStringValue(requestObject.ShippingCountry);
            }

            if(requestObject.IsSetShippingCounty())
            {
                context.Writer.WritePropertyName("shippingCounty");
                context.Writer.WriteStringValue(requestObject.ShippingCounty);
            }

            if(requestObject.IsSetShippingPostalCode())
            {
                context.Writer.WritePropertyName("shippingPostalCode");
                context.Writer.WriteStringValue(requestObject.ShippingPostalCode);
            }

            if(requestObject.IsSetShippingProvince())
            {
                context.Writer.WritePropertyName("shippingProvince");
                context.Writer.WriteStringValue(requestObject.ShippingProvince);
            }

            if(requestObject.IsSetShippingState())
            {
                context.Writer.WritePropertyName("shippingState");
                context.Writer.WriteStringValue(requestObject.ShippingState);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("state");
                context.Writer.WriteStringValue(requestObject.State);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomerProfileAttributesMarshaller Instance = new CustomerProfileAttributesMarshaller();

    }
}