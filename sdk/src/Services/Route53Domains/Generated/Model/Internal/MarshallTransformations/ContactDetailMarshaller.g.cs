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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Route53Domains.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContactDetail Marshaller
    /// </summary>
    public partial class ContactDetailMarshaller : IRequestMarshaller<ContactDetail, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ContactDetail requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAddressLine1())
            {
                context.Writer.WriteTextString("AddressLine1");
                context.Writer.WriteTextString(requestObject.AddressLine1);
            }

            if (requestObject.IsSetAddressLine2())
            {
                context.Writer.WriteTextString("AddressLine2");
                context.Writer.WriteTextString(requestObject.AddressLine2);
            }

            if (requestObject.IsSetCity())
            {
                context.Writer.WriteTextString("City");
                context.Writer.WriteTextString(requestObject.City);
            }

            if (requestObject.IsSetContactType())
            {
                context.Writer.WriteTextString("ContactType");
                context.Writer.WriteTextString(requestObject.ContactType);
            }

            if (requestObject.IsSetCountryCode())
            {
                context.Writer.WriteTextString("CountryCode");
                context.Writer.WriteTextString(requestObject.CountryCode);
            }

            if (requestObject.IsSetEmail())
            {
                context.Writer.WriteTextString("Email");
                context.Writer.WriteTextString(requestObject.Email);
            }

            if (requestObject.IsSetExtraParams())
            {
                context.Writer.WriteTextString("ExtraParams");
                context.Writer.WriteStartArray(requestObject.ExtraParams.Count);
                foreach (var requestObjectExtraParamsListValue in requestObject.ExtraParams)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ExtraParamMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraParamsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetFax())
            {
                context.Writer.WriteTextString("Fax");
                context.Writer.WriteTextString(requestObject.Fax);
            }

            if (requestObject.IsSetFirstName())
            {
                context.Writer.WriteTextString("FirstName");
                context.Writer.WriteTextString(requestObject.FirstName);
            }

            if (requestObject.IsSetLastName())
            {
                context.Writer.WriteTextString("LastName");
                context.Writer.WriteTextString(requestObject.LastName);
            }

            if (requestObject.IsSetOrganizationName())
            {
                context.Writer.WriteTextString("OrganizationName");
                context.Writer.WriteTextString(requestObject.OrganizationName);
            }

            if (requestObject.IsSetPhoneNumber())
            {
                context.Writer.WriteTextString("PhoneNumber");
                context.Writer.WriteTextString(requestObject.PhoneNumber);
            }

            if (requestObject.IsSetState())
            {
                context.Writer.WriteTextString("State");
                context.Writer.WriteTextString(requestObject.State);
            }

            if (requestObject.IsSetZipCode())
            {
                context.Writer.WriteTextString("ZipCode");
                context.Writer.WriteTextString(requestObject.ZipCode);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ContactDetailMarshaller Instance = new ContactDetailMarshaller();
    }
}
