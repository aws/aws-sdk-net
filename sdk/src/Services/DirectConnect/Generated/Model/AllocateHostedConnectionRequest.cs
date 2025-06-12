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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AllocateHostedConnection operation.
    /// Creates a hosted connection on the specified interconnect or a link aggregation group
    /// (LAG) of interconnects.
    /// 
    ///  
    /// <para>
    /// Allocates a VLAN number and a specified amount of capacity (bandwidth) for use by
    /// a hosted connection on the specified interconnect or LAG of interconnects. Amazon
    /// Web Services polices the hosted connection for the specified capacity and the Direct
    /// Connect Partner must also police the hosted connection for the specified capacity.
    /// </para>
    ///  <note> 
    /// <para>
    /// Intended for use by Direct Connect Partners only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AllocateHostedConnectionRequest : AmazonDirectConnectRequest
    {
        private string _bandwidth;
        private string _connectionId;
        private string _connectionName;
        private string _ownerAccount;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the connection. The possible values are 50Mbps, 100Mbps, 200Mbps,
        /// 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps, 10Gbps, and 25Gbps. Note that only
        /// those Direct Connect Partners who have met specific requirements are allowed to create
        /// a 1Gbps, 2Gbps, 5Gbps, 10Gbps, or 25Gbps hosted connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the interconnect or LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the hosted connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account ID of the customer for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
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

        /// <summary>
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The dedicated VLAN provisioned to the hosted connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Vlan
        {
            get { return this._vlan; }
            set { this._vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this._vlan.HasValue; 
        }

    }
}