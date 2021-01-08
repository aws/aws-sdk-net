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
using System.Net;
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
    /// Response Unmarshaller for AwsCertificateManagerCertificateDetails Object
    /// </summary>  
    public class AwsCertificateManagerCertificateDetailsUnmarshaller : IUnmarshaller<AwsCertificateManagerCertificateDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsCertificateManagerCertificateDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsCertificateManagerCertificateDetails IUnmarshaller<AwsCertificateManagerCertificateDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsCertificateManagerCertificateDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsCertificateManagerCertificateDetails unmarshalledObject = new AwsCertificateManagerCertificateDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CertificateAuthorityArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CertificateAuthorityArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainValidationOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller>(AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller.Instance);
                    unmarshalledObject.DomainValidationOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtendedKeyUsages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsCertificateManagerCertificateExtendedKeyUsage, AwsCertificateManagerCertificateExtendedKeyUsageUnmarshaller>(AwsCertificateManagerCertificateExtendedKeyUsageUnmarshaller.Instance);
                    unmarshalledObject.ExtendedKeyUsages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImportedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InUseBy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InUseBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IssuedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IssuedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Issuer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Issuer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyUsages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsCertificateManagerCertificateKeyUsage, AwsCertificateManagerCertificateKeyUsageUnmarshaller>(AwsCertificateManagerCertificateKeyUsageUnmarshaller.Instance);
                    unmarshalledObject.KeyUsages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotAfter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotAfter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotBefore", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotBefore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = AwsCertificateManagerCertificateOptionsUnmarshaller.Instance;
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenewalEligibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RenewalEligibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenewalSummary", targetDepth))
                {
                    var unmarshaller = AwsCertificateManagerCertificateRenewalSummaryUnmarshaller.Instance;
                    unmarshalledObject.RenewalSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Serial", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Serial = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SignatureAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignatureAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Subject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubjectAlternativeNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SubjectAlternativeNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsCertificateManagerCertificateDetailsUnmarshaller _instance = new AwsCertificateManagerCertificateDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCertificateManagerCertificateDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}