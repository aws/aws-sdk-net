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
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProfileAttributes Marshaller
    /// </summary>
    public class ProfileAttributesMarshaller : IRequestMarshaller<ProfileAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProfileAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountNumber())
            {
                context.Writer.WritePropertyName("AccountNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.AccountNumber, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAdditionalInformation())
            {
                context.Writer.WritePropertyName("AdditionalInformation");
                context.Writer.WriteStartObject();

                var marshaller = ExtraLengthValueProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.WriteStartObject();

                var marshaller = AddressDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.Address, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBillingAddress())
            {
                context.Writer.WritePropertyName("BillingAddress");
                context.Writer.WriteStartObject();

                var marshaller = AddressDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.BillingAddress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBirthDate())
            {
                context.Writer.WritePropertyName("BirthDate");
                context.Writer.WriteStartObject();

                var marshaller = DateDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.BirthDate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBusinessEmailAddress())
            {
                context.Writer.WritePropertyName("BusinessEmailAddress");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.BusinessEmailAddress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBusinessName())
            {
                context.Writer.WritePropertyName("BusinessName");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.BusinessName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBusinessPhoneNumber())
            {
                context.Writer.WritePropertyName("BusinessPhoneNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.BusinessPhoneNumber, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("EmailAddress");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.EmailAddress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirstName())
            {
                context.Writer.WritePropertyName("FirstName");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.FirstName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGenderString())
            {
                context.Writer.WritePropertyName("GenderString");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.GenderString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHomePhoneNumber())
            {
                context.Writer.WritePropertyName("HomePhoneNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.HomePhoneNumber, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastName())
            {
                context.Writer.WritePropertyName("LastName");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.LastName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMailingAddress())
            {
                context.Writer.WritePropertyName("MailingAddress");
                context.Writer.WriteStartObject();

                var marshaller = AddressDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.MailingAddress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMiddleName())
            {
                context.Writer.WritePropertyName("MiddleName");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.MiddleName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMobilePhoneNumber())
            {
                context.Writer.WritePropertyName("MobilePhoneNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.MobilePhoneNumber, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPartyTypeString())
            {
                context.Writer.WritePropertyName("PartyTypeString");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.PartyTypeString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPersonalEmailAddress())
            {
                context.Writer.WritePropertyName("PersonalEmailAddress");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.PersonalEmailAddress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProfileDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.PhoneNumber, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProfileType())
            {
                context.Writer.WritePropertyName("ProfileType");
                context.Writer.WriteStartObject();

                var marshaller = ProfileTypeDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.ProfileType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetShippingAddress())
            {
                context.Writer.WritePropertyName("ShippingAddress");
                context.Writer.WriteStartObject();

                var marshaller = AddressDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.ShippingAddress, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProfileAttributesMarshaller Instance = new ProfileAttributesMarshaller();

    }
}