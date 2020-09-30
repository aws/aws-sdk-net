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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCertificateManagerCertificateDomainValidationOption Marshaller
    /// </summary>       
    public class AwsCertificateManagerCertificateDomainValidationOptionMarshaller : IRequestMarshaller<AwsCertificateManagerCertificateDomainValidationOption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCertificateManagerCertificateDomainValidationOption requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.Write(requestObject.DomainName);
            }

            if(requestObject.IsSetResourceRecord())
            {
                context.Writer.WritePropertyName("ResourceRecord");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCertificateManagerCertificateResourceRecordMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceRecord, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValidationDomain())
            {
                context.Writer.WritePropertyName("ValidationDomain");
                context.Writer.Write(requestObject.ValidationDomain);
            }

            if(requestObject.IsSetValidationEmails())
            {
                context.Writer.WritePropertyName("ValidationEmails");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValidationEmailsListValue in requestObject.ValidationEmails)
                {
                        context.Writer.Write(requestObjectValidationEmailsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetValidationMethod())
            {
                context.Writer.WritePropertyName("ValidationMethod");
                context.Writer.Write(requestObject.ValidationMethod);
            }

            if(requestObject.IsSetValidationStatus())
            {
                context.Writer.WritePropertyName("ValidationStatus");
                context.Writer.Write(requestObject.ValidationStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsCertificateManagerCertificateDomainValidationOptionMarshaller Instance = new AwsCertificateManagerCertificateDomainValidationOptionMarshaller();

    }
}