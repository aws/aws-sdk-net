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

using Amazon.SecurityHub.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsCertificateManagerCertificateDomainValidationOption Object
    /// </summary>
    public partial class AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller : IJsonUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AwsCertificateManagerCertificateDomainValidationOption Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AwsCertificateManagerCertificateDomainValidationOption();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DomainName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ResourceRecord", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCertificateManagerCertificateResourceRecordUnmarshaller.Instance;
                    unmarshalledObject.ResourceRecord = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ValidationDomain", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ValidationEmails", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ValidationEmails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ValidationMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ValidationStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller _instance = new AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller Instance => _instance;
    }
}
