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
    /// Describes an Outpost link aggregation group (LAG).
    /// </summary>
    public partial class OutpostLag
    {
        private List<string> _localGatewayVirtualInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _outpostArn;
        private string _outpostLagId;
        private string _ownerId;
        private List<string> _serviceLinkVirtualInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceIds. 
        /// <para>
        /// The IDs of the local gateway virtual interfaces associated with the Outpost LAG.
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the Outpost LAG.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// The ID of the Outpost LAG.
        /// </para>
        /// </summary>
        public string OutpostLagId
        {
            get { return this._outpostLagId; }
            set { this._outpostLagId = value; }
        }

        // Check to see if OutpostLagId property is set
        internal bool IsSetOutpostLagId()
        {
            return this._outpostLagId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Outpost LAG owner.
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
        /// Gets and sets the property ServiceLinkVirtualInterfaceIds. 
        /// <para>
        /// The service link virtual interface IDs associated with the Outpost LAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceLinkVirtualInterfaceIds
        {
            get { return this._serviceLinkVirtualInterfaceIds; }
            set { this._serviceLinkVirtualInterfaceIds = value; }
        }

        // Check to see if ServiceLinkVirtualInterfaceIds property is set
        internal bool IsSetServiceLinkVirtualInterfaceIds()
        {
            return this._serviceLinkVirtualInterfaceIds != null && (this._serviceLinkVirtualInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Outpost LAG.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the Outpost LAG.
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