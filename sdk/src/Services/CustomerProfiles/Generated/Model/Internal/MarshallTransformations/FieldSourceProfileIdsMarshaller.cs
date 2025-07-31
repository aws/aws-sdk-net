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

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FieldSourceProfileIds Marshaller
    /// </summary>
    public class FieldSourceProfileIdsMarshaller : IRequestMarshaller<FieldSourceProfileIds, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldSourceProfileIds requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountNumber())
            {
                context.Writer.WritePropertyName("AccountNumber");
                context.Writer.Write(requestObject.AccountNumber);
            }

            if(requestObject.IsSetAdditionalInformation())
            {
                context.Writer.WritePropertyName("AdditionalInformation");
                context.Writer.Write(requestObject.AdditionalInformation);
            }

            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.Write(requestObject.Address);
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.Write(requestObjectAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBillingAddress())
            {
                context.Writer.WritePropertyName("BillingAddress");
                context.Writer.Write(requestObject.BillingAddress);
            }

            if(requestObject.IsSetBirthDate())
            {
                context.Writer.WritePropertyName("BirthDate");
                context.Writer.Write(requestObject.BirthDate);
            }

            if(requestObject.IsSetBusinessEmailAddress())
            {
                context.Writer.WritePropertyName("BusinessEmailAddress");
                context.Writer.Write(requestObject.BusinessEmailAddress);
            }

            if(requestObject.IsSetBusinessName())
            {
                context.Writer.WritePropertyName("BusinessName");
                context.Writer.Write(requestObject.BusinessName);
            }

            if(requestObject.IsSetBusinessPhoneNumber())
            {
                context.Writer.WritePropertyName("BusinessPhoneNumber");
                context.Writer.Write(requestObject.BusinessPhoneNumber);
            }

            if(requestObject.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("EmailAddress");
                context.Writer.Write(requestObject.EmailAddress);
            }

            if(requestObject.IsSetEngagementPreferences())
            {
                context.Writer.WritePropertyName("EngagementPreferences");
                context.Writer.Write(requestObject.EngagementPreferences);
            }

            if(requestObject.IsSetFirstName())
            {
                context.Writer.WritePropertyName("FirstName");
                context.Writer.Write(requestObject.FirstName);
            }

            if(requestObject.IsSetGender())
            {
                context.Writer.WritePropertyName("Gender");
                context.Writer.Write(requestObject.Gender);
            }

            if(requestObject.IsSetHomePhoneNumber())
            {
                context.Writer.WritePropertyName("HomePhoneNumber");
                context.Writer.Write(requestObject.HomePhoneNumber);
            }

            if(requestObject.IsSetLastName())
            {
                context.Writer.WritePropertyName("LastName");
                context.Writer.Write(requestObject.LastName);
            }

            if(requestObject.IsSetMailingAddress())
            {
                context.Writer.WritePropertyName("MailingAddress");
                context.Writer.Write(requestObject.MailingAddress);
            }

            if(requestObject.IsSetMiddleName())
            {
                context.Writer.WritePropertyName("MiddleName");
                context.Writer.Write(requestObject.MiddleName);
            }

            if(requestObject.IsSetMobilePhoneNumber())
            {
                context.Writer.WritePropertyName("MobilePhoneNumber");
                context.Writer.Write(requestObject.MobilePhoneNumber);
            }

            if(requestObject.IsSetPartyType())
            {
                context.Writer.WritePropertyName("PartyType");
                context.Writer.Write(requestObject.PartyType);
            }

            if(requestObject.IsSetPersonalEmailAddress())
            {
                context.Writer.WritePropertyName("PersonalEmailAddress");
                context.Writer.Write(requestObject.PersonalEmailAddress);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.Write(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetProfileType())
            {
                context.Writer.WritePropertyName("ProfileType");
                context.Writer.Write(requestObject.ProfileType);
            }

            if(requestObject.IsSetShippingAddress())
            {
                context.Writer.WritePropertyName("ShippingAddress");
                context.Writer.Write(requestObject.ShippingAddress);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldSourceProfileIdsMarshaller Instance = new FieldSourceProfileIdsMarshaller();

    }
}