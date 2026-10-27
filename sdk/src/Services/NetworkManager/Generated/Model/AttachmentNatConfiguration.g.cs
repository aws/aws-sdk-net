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
    /// Describes the NAT configuration of a core network attachment.
    /// </summary>
    public partial class AttachmentNatConfiguration
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property NatGatewayRules. 
        /// <para>
        /// The NAT rules of the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<NatRule> NatGatewayRules { get; set; } = AWSConfigs.InitializeCollections ? new List<NatRule>() : null;

        /// <summary>
        /// Checks to see if the NatGatewayRules property is set.
        /// </summary>
        internal bool IsSetNatGatewayRules() => this.NatGatewayRules != null && (this.NatGatewayRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NatGatewaySupport. 
        /// <para>
        /// The state of NAT gateway support on the attachment.
        /// </para>
        /// </summary>
        public NatGatewaySupportState NatGatewaySupport { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewaySupport property is set.
        /// </summary>
        internal bool IsSetNatGatewaySupport() => this.NatGatewaySupport != null;

        /// <summary>
        /// Gets and sets the property NatSystemRouteSupport. 
        /// <para>
        /// Indicates whether the core network installs system routes for the NAT CIDR blocks
        /// of the attachment's NAT rules.
        /// </para>
        /// </summary>
        public bool? NatSystemRouteSupport { get; set; }

        /// <summary>
        /// Checks to see if the NatSystemRouteSupport property is set.
        /// </summary>
        internal bool IsSetNatSystemRouteSupport() => this.NatSystemRouteSupport.HasValue;
    }
}
