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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AllocateConnectionOnInterconnect operation. <note>
    /// <para> Deprecated. Use <a>AllocateHostedConnection</a> instead. </para> </note> <para>
    /// Creates a hosted connection on an interconnect. </para> <para> Allocates a VLAN number
    /// and a specified amount of bandwidth for use by a hosted connection on the specified
    /// interconnect. </para> <note> <para> Intended for use by Direct Connect Partners only.
    /// </para> </note>
    /// </summary>
    public partial class AllocateConnectionOnInterconnectRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the connection. The possible values are 50Mbps, 100Mbps, 200Mbps,
        /// 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps, and 10Gbps. Note that only those Direct
        /// Connect Partners who have met specific requirements are allowed to create a 1Gbps,
        /// 2Gbps, 5Gbps or 10Gbps hosted connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the provisioned connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property InterconnectId. 
        /// <para>
        /// The ID of the interconnect on which the connection will be provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InterconnectId { get; set; }

        /// <summary>
        /// Checks to see if the InterconnectId property is set.
        /// </summary>
        internal bool IsSetInterconnectId() => this.InterconnectId != null;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account of the customer for whom the connection
        /// will be provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The dedicated VLAN provisioned to the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
