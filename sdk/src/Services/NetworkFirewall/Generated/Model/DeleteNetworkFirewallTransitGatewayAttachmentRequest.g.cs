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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkFirewallTransitGatewayAttachment
    /// operation. Deletes a transit gateway attachment from a Network Firewall. Either the
    /// firewall owner or the transit gateway owner can delete the attachment. <important>
    /// <para> After you delete a transit gateway attachment, traffic will no longer flow
    /// through the firewall endpoints. </para> </important> <para> After you initiate the
    /// delete operation, use <a>DescribeFirewall</a> to monitor the deletion status. </para>
    /// </summary>
    public partial class DeleteNetworkFirewallTransitGatewayAttachmentRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// Required. The unique identifier of the transit gateway attachment to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;
    }
}
