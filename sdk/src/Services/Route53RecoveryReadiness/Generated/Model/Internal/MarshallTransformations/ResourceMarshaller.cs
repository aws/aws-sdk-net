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
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryReadiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Resource Marshaller
    /// </summary>
    public class ResourceMarshaller : IRequestMarshaller<Resource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Resource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComponentId())
            {
                context.Writer.WritePropertyName("componentId");
                context.Writer.WriteStringValue(requestObject.ComponentId);
            }

            if(requestObject.IsSetDnsTargetResource())
            {
                context.Writer.WritePropertyName("dnsTargetResource");
                context.Writer.WriteStartObject();

                var marshaller = DNSTargetResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DnsTargetResource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReadinessScopes())
            {
                context.Writer.WritePropertyName("readinessScopes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadinessScopesListValue in requestObject.ReadinessScopes)
                {
                        context.Writer.WriteStringValue(requestObjectReadinessScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("resourceArn");
                context.Writer.WriteStringValue(requestObject.ResourceArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceMarshaller Instance = new ResourceMarshaller();

    }
}