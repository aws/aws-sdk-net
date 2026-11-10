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
    /// Describes a local gateway virtual interface group.
    /// </summary>
    public partial class LocalGatewayVirtualInterfaceGroup
    {
        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        public LocalGatewayVirtualInterfaceGroupConfigurationState ConfigurationState { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationState property is set.
        /// </summary>
        internal bool IsSetConfigurationState() => this.ConfigurationState != null;

        /// <summary>
        /// Gets and sets the property LocalBgpAsn. 
        /// <para>
        /// The Autonomous System Number(ASN) for the local Border Gateway Protocol (BGP).
        /// </para>
        /// </summary>
        public int? LocalBgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the LocalBgpAsn property is set.
        /// </summary>
        internal bool IsSetLocalBgpAsn() => this.LocalBgpAsn.HasValue;

        /// <summary>
        /// Gets and sets the property LocalBgpAsnExtended. 
        /// <para>
        /// The extended 32-bit ASN for the local BGP configuration.
        /// </para>
        /// </summary>
        public long? LocalBgpAsnExtended { get; set; }

        /// <summary>
        /// Checks to see if the LocalBgpAsnExtended property is set.
        /// </summary>
        internal bool IsSetLocalBgpAsnExtended() => this.LocalBgpAsnExtended.HasValue;

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayId() => this.LocalGatewayId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string LocalGatewayVirtualInterfaceGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceGroupArn property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceGroupArn() => this.LocalGatewayVirtualInterfaceGroupArn != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceGroupId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId() => this.LocalGatewayVirtualInterfaceGroupId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceIds. 
        /// <para>
        /// The IDs of the virtual interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LocalGatewayVirtualInterfaceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceIds property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceIds() => this.LocalGatewayVirtualInterfaceIds != null && (this.LocalGatewayVirtualInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway virtual interface
        /// group.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual interface group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
