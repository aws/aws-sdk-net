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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContactDetail Marshaller
    /// </summary>       
    public class ContactDetailMarshaller : IRequestMarshaller<ContactDetail, JsonMarshallerContext> 
    {
        public void Marshall(ContactDetail requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAddressLine1())
            {
                context.Writer.WritePropertyName("AddressLine1");
                context.Writer.Write(requestObject.AddressLine1);
            }

            if(requestObject.IsSetAddressLine2())
            {
                context.Writer.WritePropertyName("AddressLine2");
                context.Writer.Write(requestObject.AddressLine2);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.Write(requestObject.City);
            }

            if(requestObject.IsSetContactType())
            {
                context.Writer.WritePropertyName("ContactType");
                context.Writer.Write(requestObject.ContactType);
            }

            if(requestObject.IsSetCountryCode())
            {
                context.Writer.WritePropertyName("CountryCode");
                context.Writer.Write(requestObject.CountryCode);
            }

            if(requestObject.IsSetEmail())
            {
                context.Writer.WritePropertyName("Email");
                context.Writer.Write(requestObject.Email);
            }

            if(requestObject.IsSetExtraParams())
            {
                context.Writer.WritePropertyName("ExtraParams");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtraParamsListValue in requestObject.ExtraParams)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExtraParamMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraParamsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFax())
            {
                context.Writer.WritePropertyName("Fax");
                context.Writer.Write(requestObject.Fax);
            }

            if(requestObject.IsSetFirstName())
            {
                context.Writer.WritePropertyName("FirstName");
                context.Writer.Write(requestObject.FirstName);
            }

            if(requestObject.IsSetLastName())
            {
                context.Writer.WritePropertyName("LastName");
                context.Writer.Write(requestObject.LastName);
            }

            if(requestObject.IsSetOrganizationName())
            {
                context.Writer.WritePropertyName("OrganizationName");
                context.Writer.Write(requestObject.OrganizationName);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.Write(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

            if(requestObject.IsSetZipCode())
            {
                context.Writer.WritePropertyName("ZipCode");
                context.Writer.Write(requestObject.ZipCode);
            }

        }

        public readonly static ContactDetailMarshaller Instance = new ContactDetailMarshaller();

    }
}