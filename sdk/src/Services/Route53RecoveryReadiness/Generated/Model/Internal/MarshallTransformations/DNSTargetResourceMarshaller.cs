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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryReadiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53RecoveryReadiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DNSTargetResource Marshaller
    /// </summary>
    public class DNSTargetResourceMarshaller : IRequestMarshaller<DNSTargetResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DNSTargetResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("domainName");
                context.Writer.Write(requestObject.DomainName);
            }

            if(requestObject.IsSetHostedZoneArn())
            {
                context.Writer.WritePropertyName("hostedZoneArn");
                context.Writer.Write(requestObject.HostedZoneArn);
            }

            if(requestObject.IsSetRecordSetId())
            {
                context.Writer.WritePropertyName("recordSetId");
                context.Writer.Write(requestObject.RecordSetId);
            }

            if(requestObject.IsSetRecordType())
            {
                context.Writer.WritePropertyName("recordType");
                context.Writer.Write(requestObject.RecordType);
            }

            if(requestObject.IsSetTargetResource())
            {
                context.Writer.WritePropertyName("targetResource");
                context.Writer.WriteObjectStart();

                var marshaller = TargetResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetResource, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DNSTargetResourceMarshaller Instance = new DNSTargetResourceMarshaller();

    }
}