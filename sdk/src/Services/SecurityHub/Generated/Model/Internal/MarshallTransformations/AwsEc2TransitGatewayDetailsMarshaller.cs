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
    /// AwsEc2TransitGatewayDetails Marshaller
    /// </summary>
    public class AwsEc2TransitGatewayDetailsMarshaller : IRequestMarshaller<AwsEc2TransitGatewayDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2TransitGatewayDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonSideAsn())
            {
                context.Writer.WritePropertyName("AmazonSideAsn");
                context.Writer.WriteNumberValue(requestObject.AmazonSideAsn.Value);
            }

            if(requestObject.IsSetAssociationDefaultRouteTableId())
            {
                context.Writer.WritePropertyName("AssociationDefaultRouteTableId");
                context.Writer.WriteStringValue(requestObject.AssociationDefaultRouteTableId);
            }

            if(requestObject.IsSetAutoAcceptSharedAttachments())
            {
                context.Writer.WritePropertyName("AutoAcceptSharedAttachments");
                context.Writer.WriteStringValue(requestObject.AutoAcceptSharedAttachments);
            }

            if(requestObject.IsSetDefaultRouteTableAssociation())
            {
                context.Writer.WritePropertyName("DefaultRouteTableAssociation");
                context.Writer.WriteStringValue(requestObject.DefaultRouteTableAssociation);
            }

            if(requestObject.IsSetDefaultRouteTablePropagation())
            {
                context.Writer.WritePropertyName("DefaultRouteTablePropagation");
                context.Writer.WriteStringValue(requestObject.DefaultRouteTablePropagation);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDnsSupport())
            {
                context.Writer.WritePropertyName("DnsSupport");
                context.Writer.WriteStringValue(requestObject.DnsSupport);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetMulticastSupport())
            {
                context.Writer.WritePropertyName("MulticastSupport");
                context.Writer.WriteStringValue(requestObject.MulticastSupport);
            }

            if(requestObject.IsSetPropagationDefaultRouteTableId())
            {
                context.Writer.WritePropertyName("PropagationDefaultRouteTableId");
                context.Writer.WriteStringValue(requestObject.PropagationDefaultRouteTableId);
            }

            if(requestObject.IsSetTransitGatewayCidrBlocks())
            {
                context.Writer.WritePropertyName("TransitGatewayCidrBlocks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTransitGatewayCidrBlocksListValue in requestObject.TransitGatewayCidrBlocks)
                {
                        context.Writer.WriteStringValue(requestObjectTransitGatewayCidrBlocksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVpnEcmpSupport())
            {
                context.Writer.WritePropertyName("VpnEcmpSupport");
                context.Writer.WriteStringValue(requestObject.VpnEcmpSupport);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2TransitGatewayDetailsMarshaller Instance = new AwsEc2TransitGatewayDetailsMarshaller();

    }
}