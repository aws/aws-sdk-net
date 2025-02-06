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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Account.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Account.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContactInformation Marshaller
    /// </summary>
    public class ContactInformationMarshaller : IRequestMarshaller<ContactInformation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContactInformation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressLine1())
            {
                context.Writer.WritePropertyName("AddressLine1");
                context.Writer.WriteStringValue(requestObject.AddressLine1);
            }

            if(requestObject.IsSetAddressLine2())
            {
                context.Writer.WritePropertyName("AddressLine2");
                context.Writer.WriteStringValue(requestObject.AddressLine2);
            }

            if(requestObject.IsSetAddressLine3())
            {
                context.Writer.WritePropertyName("AddressLine3");
                context.Writer.WriteStringValue(requestObject.AddressLine3);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetCompanyName())
            {
                context.Writer.WritePropertyName("CompanyName");
                context.Writer.WriteStringValue(requestObject.CompanyName);
            }

            if(requestObject.IsSetCountryCode())
            {
                context.Writer.WritePropertyName("CountryCode");
                context.Writer.WriteStringValue(requestObject.CountryCode);
            }

            if(requestObject.IsSetDistrictOrCounty())
            {
                context.Writer.WritePropertyName("DistrictOrCounty");
                context.Writer.WriteStringValue(requestObject.DistrictOrCounty);
            }

            if(requestObject.IsSetFullName())
            {
                context.Writer.WritePropertyName("FullName");
                context.Writer.WriteStringValue(requestObject.FullName);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.WriteStringValue(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetStateOrRegion())
            {
                context.Writer.WritePropertyName("StateOrRegion");
                context.Writer.WriteStringValue(requestObject.StateOrRegion);
            }

            if(requestObject.IsSetWebsiteUrl())
            {
                context.Writer.WritePropertyName("WebsiteUrl");
                context.Writer.WriteStringValue(requestObject.WebsiteUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContactInformationMarshaller Instance = new ContactInformationMarshaller();

    }
}