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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// A peering connection between an ODB network and either another ODB network or a customer-owned
    /// VPC.
    /// </summary>
    public partial class OdbPeeringConnection
    {
        private DateTime? _createdAt;
        private string _displayName;
        private string _odbNetworkArn;
        private string _odbPeeringConnectionArn;
        private string _odbPeeringConnectionId;
        private string _odbPeeringConnectionType;
        private string _peerNetworkArn;
        private float? _percentProgress;
        private ResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the ODB peering connection was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the ODB peering connection.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network that initiated the peering connection.
        /// </para>
        /// </summary>
        public string OdbNetworkArn
        {
            get { return this._odbNetworkArn; }
            set { this._odbNetworkArn = value; }
        }

        // Check to see if OdbNetworkArn property is set
        internal bool IsSetOdbNetworkArn()
        {
            return this._odbNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB peering connection.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:odb:us-east-1:123456789012:odb-peering-connection/odbpcx-abcdefgh12345678</c>
        /// 
        /// </para>
        /// </summary>
        public string OdbPeeringConnectionArn
        {
            get { return this._odbPeeringConnectionArn; }
            set { this._odbPeeringConnectionArn = value; }
        }

        // Check to see if OdbPeeringConnectionArn property is set
        internal bool IsSetOdbPeeringConnectionArn()
        {
            return this._odbPeeringConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The unique identifier of the ODB peering connection. A sample ID is <c>odbpcx-abcdefgh12345678</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbPeeringConnectionId
        {
            get { return this._odbPeeringConnectionId; }
            set { this._odbPeeringConnectionId = value; }
        }

        // Check to see if OdbPeeringConnectionId property is set
        internal bool IsSetOdbPeeringConnectionId()
        {
            return this._odbPeeringConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionType. 
        /// <para>
        /// The type of the ODB peering connection.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>ODB-VPC | ODB-ODB</c> 
        /// </para>
        /// </summary>
        public string OdbPeeringConnectionType
        {
            get { return this._odbPeeringConnectionType; }
            set { this._odbPeeringConnectionType = value; }
        }

        // Check to see if OdbPeeringConnectionType property is set
        internal bool IsSetOdbPeeringConnectionType()
        {
            return this._odbPeeringConnectionType != null;
        }

        /// <summary>
        /// Gets and sets the property PeerNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer network.
        /// </para>
        /// </summary>
        public string PeerNetworkArn
        {
            get { return this._peerNetworkArn; }
            set { this._peerNetworkArn = value; }
        }

        // Check to see if PeerNetworkArn property is set
        internal bool IsSetPeerNetworkArn()
        {
            return this._peerNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The percentage progress of the ODB peering connection creation or deletion.
        /// </para>
        /// </summary>
        public float? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ODB peering connection.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>provisioning | active | terminating | terminated | failed</c> 
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the ODB peering connection.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}