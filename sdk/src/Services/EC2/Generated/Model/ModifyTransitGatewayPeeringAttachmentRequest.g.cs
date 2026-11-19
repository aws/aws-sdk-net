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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTransitGatewayPeeringAttachment operation.
    /// Modifies the options for a transit gateway peering attachment. The peering attachment
    /// must be in the <c>available</c> state. <para> You can allow multipath resilience for
    /// your side of an inter-Region transit gateway peering attachment between supported
    /// Regions. Multipath resilience isn't supported for transit gateway peering attachments
    /// in the same Region. It takes effect only when both the requester and the accepter
    /// allow it. To modify the requester side, send the request in the Region of the requester
    /// transit gateway. To modify the accepter side, send the request in the Region of the
    /// accepter transit gateway. To check whether multipath resilience is in effect, use
    /// <a>DescribeTransitGatewayPeeringAttachments</a> and check <c>multipathResilienceStatus</c>.
    /// </para>
    /// </summary>
    public partial class ModifyTransitGatewayPeeringAttachmentRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to modify for the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public ModifyTransitGatewayPeeringAttachmentRequestOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;
    }
}
