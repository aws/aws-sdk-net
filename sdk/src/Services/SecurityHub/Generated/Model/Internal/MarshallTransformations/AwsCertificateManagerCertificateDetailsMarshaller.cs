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
            if(requestObject.IsSetCertificateAuthorityArn())
            {
                context.Writer.WritePropertyName("CertificateAuthorityArn");
                context.Writer.Write(requestObject.CertificateAuthorityArn);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.Write(requestObject.CreatedAt);
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.Write(requestObject.DomainName);
            }

            if(requestObject.IsSetDomainValidationOptions())
            {
                context.Writer.WritePropertyName("DomainValidationOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDomainValidationOptionsListValue in requestObject.DomainValidationOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsCertificateManagerCertificateDomainValidationOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDomainValidationOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExtendedKeyUsages())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtendedKeyUsagesListValue in requestObject.ExtendedKeyUsages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsCertificateManagerCertificateExtendedKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtendedKeyUsagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFailureReason())
            {
                context.Writer.WritePropertyName("FailureReason");
                context.Writer.Write(requestObject.FailureReason);
            }

            if(requestObject.IsSetImportedAt())
            {
                context.Writer.WritePropertyName("ImportedAt");
                context.Writer.Write(requestObject.ImportedAt);
            }

            if(requestObject.IsSetInUseBy())
            {
                context.Writer.WritePropertyName("InUseBy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInUseByListValue in requestObject.InUseBy)
                {
                        context.Writer.Write(requestObjectInUseByListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIssuedAt())
            {
                context.Writer.WritePropertyName("IssuedAt");
                context.Writer.Write(requestObject.IssuedAt);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("Issuer");
                context.Writer.Write(requestObject.Issuer);
            }

            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.Write(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetKeyUsages())
            {
                context.Writer.WritePropertyName("KeyUsages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKeyUsagesListValue in requestObject.KeyUsages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsCertificateManagerCertificateKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeyUsagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNotAfter())
            {
                context.Writer.WritePropertyName("NotAfter");
                context.Writer.Write(requestObject.NotAfter);
            }

            if(requestObject.IsSetNotBefore())
            {
                context.Writer.WritePropertyName("NotBefore");
                context.Writer.Write(requestObject.NotBefore);
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCertificateManagerCertificateOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Options, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRenewalEligibility())
            {
                context.Writer.WritePropertyName("RenewalEligibility");
                context.Writer.Write(requestObject.RenewalEligibility);
            }

            if(requestObject.IsSetRenewalSummary())
            {
                context.Writer.WritePropertyName("RenewalSummary");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCertificateManagerCertificateRenewalSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.RenewalSummary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSerial())
            {
                context.Writer.WritePropertyName("Serial");
                context.Writer.Write(requestObject.Serial);
            }

            if(requestObject.IsSetSignatureAlgorithm())
            {
                context.Writer.WritePropertyName("SignatureAlgorithm");
                context.Writer.Write(requestObject.SignatureAlgorithm);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.Write(requestObject.Subject);
            }

            if(requestObject.IsSetSubjectAlternativeNames())
            {
                context.Writer.WritePropertyName("SubjectAlternativeNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubjectAlternativeNamesListValue in requestObject.SubjectAlternativeNames)
                {
                        context.Writer.Write(requestObjectSubjectAlternativeNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsCertificateManagerCertificateDetailsMarshaller Instance = new AwsCertificateManagerCertificateDetailsMarshaller();

    }
}