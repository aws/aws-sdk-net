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
    /// Response Unmarshaller for AwsCertificateManagerCertificateRenewalSummary Object
    /// </summary>  
    public class AwsCertificateManagerCertificateRenewalSummaryUnmarshaller : IUnmarshaller<AwsCertificateManagerCertificateRenewalSummary, XmlUnmarshallerContext>, IUnmarshaller<AwsCertificateManagerCertificateRenewalSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsCertificateManagerCertificateRenewalSummary IUnmarshaller<AwsCertificateManagerCertificateRenewalSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsCertificateManagerCertificateRenewalSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsCertificateManagerCertificateRenewalSummary unmarshalledObject = new AwsCertificateManagerCertificateRenewalSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DomainValidationOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller>(AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller.Instance);
                    unmarshalledObject.DomainValidationOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenewalStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RenewalStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenewalStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RenewalStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsCertificateManagerCertificateRenewalSummaryUnmarshaller _instance = new AwsCertificateManagerCertificateRenewalSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCertificateManagerCertificateRenewalSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}