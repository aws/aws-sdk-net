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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SupplementalTaxRegistrationEntry Marshaller
    /// </summary>
    public class SupplementalTaxRegistrationEntryMarshaller : IRequestMarshaller<SupplementalTaxRegistrationEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SupplementalTaxRegistrationEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("address");
                context.Writer.WriteStartObject();

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.Address, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLegalName())
            {
                context.Writer.WritePropertyName("legalName");
                context.Writer.WriteStringValue(requestObject.LegalName);
            }

            if(requestObject.IsSetRegistrationId())
            {
                context.Writer.WritePropertyName("registrationId");
                context.Writer.WriteStringValue(requestObject.RegistrationId);
            }

            if(requestObject.IsSetRegistrationType())
            {
                context.Writer.WritePropertyName("registrationType");
                context.Writer.WriteStringValue(requestObject.RegistrationType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SupplementalTaxRegistrationEntryMarshaller Instance = new SupplementalTaxRegistrationEntryMarshaller();

    }
}