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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private LocalGatewayVirtualInterfaceGroupConfigurationState _configurationState;
        private int? _localBgpAsn;
        private long? _localBgpAsnExtended;
        private string _localGatewayId;
        private string _localGatewayVirtualInterfaceGroupArn;
        private string _localGatewayVirtualInterfaceGroupId;
        private List<string> _localGatewayVirtualInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ownerId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        public LocalGatewayVirtualInterfaceGroupConfigurationState ConfigurationState
        {
            get { return this._configurationState; }
            set { this._configurationState = value; }
        }

        // Check to see if ConfigurationState property is set
        internal bool IsSetConfigurationState()
        {
            return this._configurationState != null;
        }

        /// <summary>
        /// Gets and sets the property LocalBgpAsn. 
        /// <para>
        /// The Autonomous System Number(ASN) for the local Border Gateway Protocol (BGP).
        /// </para>
        /// </summary>
        public int? LocalBgpAsn
        {
            get { return this._localBgpAsn; }
            set { this._localBgpAsn = value; }
        }

        // Check to see if LocalBgpAsn property is set
        internal bool IsSetLocalBgpAsn()
        {
            return this._localBgpAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalBgpAsnExtended. 
        /// <para>
        /// The extended 32-bit ASN for the local BGP configuration.
        /// </para>
        /// </summary>
        public long? LocalBgpAsnExtended
        {
            get { return this._localBgpAsnExtended; }
            set { this._localBgpAsnExtended = value; }
        }

        // Check to see if LocalBgpAsnExtended property is set
        internal bool IsSetLocalBgpAsnExtended()
        {
            return this._localBgpAsnExtended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string LocalGatewayVirtualInterfaceGroupArn
        {
            get { return this._localGatewayVirtualInterfaceGroupArn; }
            set { this._localGatewayVirtualInterfaceGroupArn = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceGroupArn property is set
        internal bool IsSetLocalGatewayVirtualInterfaceGroupArn()
        {
            return this._localGatewayVirtualInterfaceGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId
        {
            get { return this._localGatewayVirtualInterfaceGroupId; }
            set { this._localGatewayVirtualInterfaceGroupId = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceGroupId property is set
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId()
        {
            return this._localGatewayVirtualInterfaceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceIds. 
        /// <para>
        /// The IDs of the virtual interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LocalGatewayVirtualInterfaceIds
        {
            get { return this._localGatewayVirtualInterfaceIds; }
            set { this._localGatewayVirtualInterfaceIds = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceIds property is set
        internal bool IsSetLocalGatewayVirtualInterfaceIds()
        {
            return this._localGatewayVirtualInterfaceIds != null && (this._localGatewayVirtualInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway virtual interface
        /// group.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual interface group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}