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

using Amazon.ACMPCA.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyInformation Marshaller
    /// </summary>
    public partial class PolicyInformationMarshaller : IRequestMarshaller<PolicyInformation, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PolicyInformation requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCertPolicyId())
            {
                context.Writer.WriteTextString("CertPolicyId");
                context.Writer.WriteTextString(requestObject.CertPolicyId);
            }

            if (requestObject.IsSetPolicyQualifiers())
            {
                context.Writer.WriteTextString("PolicyQualifiers");
                context.Writer.WriteStartArray(requestObject.PolicyQualifiers.Count);
                foreach (var requestObjectPolicyQualifiersListValue in requestObject.PolicyQualifiers)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PolicyQualifierInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectPolicyQualifiersListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PolicyInformationMarshaller Instance = new PolicyInformationMarshaller();
    }
}
