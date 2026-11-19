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

using Amazon.DirectConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NewPublicVirtualInterfaceAllocation Marshaller
    /// </summary>
    public partial class NewPublicVirtualInterfaceAllocationMarshaller : IRequestMarshaller<NewPublicVirtualInterfaceAllocation, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(NewPublicVirtualInterfaceAllocation requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAddressFamily())
            {
                context.Writer.WriteTextString("addressFamily");
                context.Writer.WriteTextString(requestObject.AddressFamily);
            }

            if (requestObject.IsSetAmazonAddress())
            {
                context.Writer.WriteTextString("amazonAddress");
                context.Writer.WriteTextString(requestObject.AmazonAddress);
            }

            if (requestObject.IsSetAsn())
            {
                context.Writer.WriteTextString("asn");
                context.Writer.WriteInt32(requestObject.Asn.Value);
            }

            if (requestObject.IsSetAsnLong())
            {
                context.Writer.WriteTextString("asnLong");
                context.Writer.WriteInt64(requestObject.AsnLong.Value);
            }

            if (requestObject.IsSetAuthKey())
            {
                context.Writer.WriteTextString("authKey");
                context.Writer.WriteTextString(requestObject.AuthKey);
            }

            if (requestObject.IsSetCustomerAddress())
            {
                context.Writer.WriteTextString("customerAddress");
                context.Writer.WriteTextString(requestObject.CustomerAddress);
            }

            if (requestObject.IsSetRateLimit())
            {
                context.Writer.WriteTextString("rateLimit");
                context.Writer.WriteTextString(requestObject.RateLimit);
            }

            if (requestObject.IsSetRouteFilterPrefixes())
            {
                context.Writer.WriteTextString("routeFilterPrefixes");
                context.Writer.WriteStartArray(requestObject.RouteFilterPrefixes.Count);
                foreach (var requestObjectRouteFilterPrefixesListValue in requestObject.RouteFilterPrefixes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = RouteFilterPrefixMarshaller.Instance;
                    marshaller.Marshall(requestObjectRouteFilterPrefixesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach (var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVirtualInterfaceName())
            {
                context.Writer.WriteTextString("virtualInterfaceName");
                context.Writer.WriteTextString(requestObject.VirtualInterfaceName);
            }

            if (requestObject.IsSetVlan())
            {
                context.Writer.WriteTextString("vlan");
                context.Writer.WriteInt32(requestObject.Vlan.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static NewPublicVirtualInterfaceAllocationMarshaller Instance = new NewPublicVirtualInterfaceAllocationMarshaller();
    }
}
