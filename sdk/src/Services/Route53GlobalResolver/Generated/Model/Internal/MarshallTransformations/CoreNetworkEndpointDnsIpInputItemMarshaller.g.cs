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

using Amazon.Route53GlobalResolver.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CoreNetworkEndpointDnsIpInputItem Marshaller
    /// </summary>
    public partial class CoreNetworkEndpointDnsIpInputItemMarshaller : IRequestMarshaller<CoreNetworkEndpointDnsIpInputItem, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CoreNetworkEndpointDnsIpInputItem requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDnsLabel())
            {
                context.Writer.WritePropertyName("dnsLabel");
                context.Writer.WriteStringValue(requestObject.DnsLabel);
            }

            if (requestObject.IsSetIpv4Address())
            {
                context.Writer.WritePropertyName("ipv4Address");
                context.Writer.WriteStringValue(requestObject.Ipv4Address);
            }

            if (requestObject.IsSetIpv6Address())
            {
                context.Writer.WritePropertyName("ipv6Address");
                context.Writer.WriteStringValue(requestObject.Ipv6Address);
            }

            if (requestObject.IsSetRegionScope())
            {
                context.Writer.WritePropertyName("regionScope");
                context.Writer.WriteStringValue(requestObject.RegionScope);
            }

            if (requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRegionsListValue in requestObject.Regions)
                {
                    context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CoreNetworkEndpointDnsIpInputItemMarshaller Instance = new CoreNetworkEndpointDnsIpInputItemMarshaller();
    }
}
