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
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCertificateManagerCertificateDetails Marshaller
    /// </summary>
    public class AwsCertificateManagerCertificateDetailsMarshaller : IRequestMarshaller<AwsCertificateManagerCertificateDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCertificateManagerCertificateDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateAuthorityArn())
            {
                context.Writer.WritePropertyName("CertificateAuthorityArn");
                context.Writer.WriteStringValue(requestObject.CertificateAuthorityArn);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteStringValue(requestObject.CreatedAt);
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(requestObject.DomainName);
            }

            if(requestObject.IsSetDomainValidationOptions())
            {
                context.Writer.WritePropertyName("DomainValidationOptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDomainValidationOptionsListValue in requestObject.DomainValidationOptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCertificateManagerCertificateDomainValidationOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDomainValidationOptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExtendedKeyUsages())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExtendedKeyUsagesListValue in requestObject.ExtendedKeyUsages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCertificateManagerCertificateExtendedKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtendedKeyUsagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFailureReason())
            {
                context.Writer.WritePropertyName("FailureReason");
                context.Writer.WriteStringValue(requestObject.FailureReason);
            }

            if(requestObject.IsSetImportedAt())
            {
                context.Writer.WritePropertyName("ImportedAt");
                context.Writer.WriteStringValue(requestObject.ImportedAt);
            }

            if(requestObject.IsSetInUseBy())
            {
                context.Writer.WritePropertyName("InUseBy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInUseByListValue in requestObject.InUseBy)
                {
                        context.Writer.WriteStringValue(requestObjectInUseByListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIssuedAt())
            {
                context.Writer.WritePropertyName("IssuedAt");
                context.Writer.WriteStringValue(requestObject.IssuedAt);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("Issuer");
                context.Writer.WriteStringValue(requestObject.Issuer);
            }

            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.WriteStringValue(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetKeyUsages())
            {
                context.Writer.WritePropertyName("KeyUsages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKeyUsagesListValue in requestObject.KeyUsages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCertificateManagerCertificateKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeyUsagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNotAfter())
            {
                context.Writer.WritePropertyName("NotAfter");
                context.Writer.WriteStringValue(requestObject.NotAfter);
            }

            if(requestObject.IsSetNotBefore())
            {
                context.Writer.WritePropertyName("NotBefore");
                context.Writer.WriteStringValue(requestObject.NotBefore);
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = AwsCertificateManagerCertificateOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Options, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenewalEligibility())
            {
                context.Writer.WritePropertyName("RenewalEligibility");
                context.Writer.WriteStringValue(requestObject.RenewalEligibility);
            }

            if(requestObject.IsSetRenewalSummary())
            {
                context.Writer.WritePropertyName("RenewalSummary");
                context.Writer.WriteStartObject();

                var marshaller = AwsCertificateManagerCertificateRenewalSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.RenewalSummary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSerial())
            {
                context.Writer.WritePropertyName("Serial");
                context.Writer.WriteStringValue(requestObject.Serial);
            }

            if(requestObject.IsSetSignatureAlgorithm())
            {
                context.Writer.WritePropertyName("SignatureAlgorithm");
                context.Writer.WriteStringValue(requestObject.SignatureAlgorithm);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.WriteStringValue(requestObject.Subject);
            }

            if(requestObject.IsSetSubjectAlternativeNames())
            {
                context.Writer.WritePropertyName("SubjectAlternativeNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubjectAlternativeNamesListValue in requestObject.SubjectAlternativeNames)
                {
                        context.Writer.WriteStringValue(requestObjectSubjectAlternativeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCertificateManagerCertificateDetailsMarshaller Instance = new AwsCertificateManagerCertificateDetailsMarshaller();

    }
}