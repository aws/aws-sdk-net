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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of an ODB peering connection.
    /// </summary>
    public partial class OdbPeeringConnectionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the ODB peering connection was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the ODB peering connection.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network that initiated the peering connection.
        /// </para>
        /// </summary>
        public string OdbNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkArn property is set.
        /// </summary>
        internal bool IsSetOdbNetworkArn() => this.OdbNetworkArn != null;

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB peering connection.
        /// </para>
        /// </summary>
        public string OdbPeeringConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbPeeringConnectionArn property is set.
        /// </summary>
        internal bool IsSetOdbPeeringConnectionArn() => this.OdbPeeringConnectionArn != null;

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The unique identifier of the ODB peering connection. A sample ID is <c>odbpcx-abcdefgh12345678</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the OdbPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetOdbPeeringConnectionId() => this.OdbPeeringConnectionId != null;

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
        public string OdbPeeringConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the OdbPeeringConnectionType property is set.
        /// </summary>
        internal bool IsSetOdbPeeringConnectionType() => this.OdbPeeringConnectionType != null;

        /// <summary>
        /// Gets and sets the property PeerNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer network.
        /// </para>
        /// </summary>
        public string PeerNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the PeerNetworkArn property is set.
        /// </summary>
        internal bool IsSetPeerNetworkArn() => this.PeerNetworkArn != null;

        /// <summary>
        /// Gets and sets the property PeerNetworkCidrs. 
        /// <para>
        /// The CIDR blocks associated with the peering connection. These CIDR blocks define the
        /// IP address ranges that can communicate through the peering connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeerNetworkCidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerNetworkCidrs property is set.
        /// </summary>
        internal bool IsSetPeerNetworkCidrs() => this.PeerNetworkCidrs != null && (this.PeerNetworkCidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The percentage progress of the ODB peering connection creation or deletion.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ODB peering connection.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the ODB peering connection.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
