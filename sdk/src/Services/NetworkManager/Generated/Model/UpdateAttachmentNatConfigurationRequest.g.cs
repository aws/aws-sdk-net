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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAttachmentNatConfiguration operation. Updates
    /// the NAT configuration of a core network attachment. You can enable or disable NAT
    /// gateway support, specify whether the core network installs system routes for the NAT
    /// CIDR blocks, and replace the NAT rules of the attachment. Specify at least one of
    /// <c>NatGatewaySupport</c>, <c>NatSystemRouteSupport</c>, or <c>NatGatewayRules</c>.
    /// <para> Only the core network owner can update the NAT configuration of an attachment.
    /// The attachment must be in the <c>AVAILABLE</c>, <c>PENDING_ATTACHMENT_ACCEPTANCE</c>,
    /// or <c>PENDING_TAG_ACCEPTANCE</c> state. Changes are applied asynchronously, and the
    /// attachment is in the <c>UPDATING</c> state while they are applied. If the attachment
    /// is pending acceptance, the NAT configuration is stored and is applied after the attachment
    /// is accepted. </para>
    /// </summary>
    public partial class UpdateAttachmentNatConfigurationRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment to update the NAT configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property NatGatewayRules. 
        /// <para>
        /// The complete set of NAT rules for the attachment, up to 50 rules. The rules that you
        /// specify replace the existing rules of the attachment, matched by rule number. Existing
        /// rules that aren't included in the request are deleted. To delete all NAT rules, specify
        /// an empty list. You can delete all NAT rules only when NAT gateway support is disabled,
        /// or when you disable it in the same request. If you omit this parameter, the existing
        /// rules are unchanged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<NatRuleRequest> NatGatewayRules { get; set; } = AWSConfigs.InitializeCollections ? new List<NatRuleRequest>() : null;

        /// <summary>
        /// Checks to see if the NatGatewayRules property is set.
        /// </summary>
        internal bool IsSetNatGatewayRules() => this.NatGatewayRules != null && (this.NatGatewayRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NatGatewaySupport. 
        /// <para>
        /// Specifies whether to enable or disable NAT gateway support on the attachment. When
        /// you disable NAT gateway support, the attachment keeps its NAT rules but doesn't apply
        /// them. To enable NAT gateway support, the attachment must have at least one NAT rule,
        /// either specified in this request or already configured on the attachment. If you omit
        /// this parameter, NAT gateway support is unchanged.
        /// </para>
        /// </summary>
        public NatGatewaySupportValue NatGatewaySupport { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewaySupport property is set.
        /// </summary>
        internal bool IsSetNatGatewaySupport() => this.NatGatewaySupport != null;

        /// <summary>
        /// Gets and sets the property NatSystemRouteSupport. 
        /// <para>
        /// Specifies whether the core network installs system routes for the NAT CIDR blocks
        /// of the attachment's NAT rules. System routes have a route type of <c>SYSTEM</c>. NAT
        /// is applied to traffic whether or not this option is enabled. If you omit this parameter,
        /// the current value is unchanged.
        /// </para>
        /// </summary>
        public bool? NatSystemRouteSupport { get; set; }

        /// <summary>
        /// Checks to see if the NatSystemRouteSupport property is set.
        /// </summary>
        internal bool IsSetNatSystemRouteSupport() => this.NatSystemRouteSupport.HasValue;
    }
}
