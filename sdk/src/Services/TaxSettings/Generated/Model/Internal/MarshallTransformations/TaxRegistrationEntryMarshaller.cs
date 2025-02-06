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
    /// TaxRegistrationEntry Marshaller
    /// </summary>
    public class TaxRegistrationEntryMarshaller : IRequestMarshaller<TaxRegistrationEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TaxRegistrationEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalTaxInformation())
            {
                context.Writer.WritePropertyName("additionalTaxInformation");
                context.Writer.WriteStartObject();

                var marshaller = AdditionalInfoRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalTaxInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCertifiedEmailId())
            {
                context.Writer.WritePropertyName("certifiedEmailId");
                context.Writer.WriteStringValue(requestObject.CertifiedEmailId);
            }

            if(requestObject.IsSetLegalAddress())
            {
                context.Writer.WritePropertyName("legalAddress");
                context.Writer.WriteStartObject();

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.LegalAddress, context);

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

            if(requestObject.IsSetSector())
            {
                context.Writer.WritePropertyName("sector");
                context.Writer.WriteStringValue(requestObject.Sector);
            }

            if(requestObject.IsSetVerificationDetails())
            {
                context.Writer.WritePropertyName("verificationDetails");
                context.Writer.WriteStartObject();

                var marshaller = VerificationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VerificationDetails, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaxRegistrationEntryMarshaller Instance = new TaxRegistrationEntryMarshaller();

    }
}