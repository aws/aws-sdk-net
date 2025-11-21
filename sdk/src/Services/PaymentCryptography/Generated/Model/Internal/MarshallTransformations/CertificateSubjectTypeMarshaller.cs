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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptography.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CertificateSubjectType Marshaller
    /// </summary>
    public class CertificateSubjectTypeMarshaller : IRequestMarshaller<CertificateSubjectType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CertificateSubjectType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetCommonName())
            {
                context.Writer.WritePropertyName("CommonName");
                context.Writer.WriteStringValue(requestObject.CommonName);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("EmailAddress");
                context.Writer.WriteStringValue(requestObject.EmailAddress);
            }

            if(requestObject.IsSetOrganization())
            {
                context.Writer.WritePropertyName("Organization");
                context.Writer.WriteStringValue(requestObject.Organization);
            }

            if(requestObject.IsSetOrganizationUnit())
            {
                context.Writer.WritePropertyName("OrganizationUnit");
                context.Writer.WriteStringValue(requestObject.OrganizationUnit);
            }

            if(requestObject.IsSetStateOrProvince())
            {
                context.Writer.WritePropertyName("StateOrProvince");
                context.Writer.WriteStringValue(requestObject.StateOrProvince);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CertificateSubjectTypeMarshaller Instance = new CertificateSubjectTypeMarshaller();

    }
}