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
    /// Container for the parameters to the CreateLag operation. Creates a link aggregation
    /// group (LAG) with the specified number of bundled physical dedicated connections between
    /// the customer network and a specific Direct Connect location. A LAG is a logical interface
    /// that uses the Link Aggregation Control Protocol (LACP) to aggregate multiple interfaces,
    /// enabling you to treat them as a single interface. <para> All connections in a LAG
    /// must use the same bandwidth (either 1Gbps, 10Gbps, 100Gbps, or 400Gbps) and must terminate
    /// at the same Direct Connect endpoint. </para> <para> You can have up to 10 dedicated
    /// connections per location. Regardless of this limit, if you request more connections
    /// for the LAG than Direct Connect can allocate on a single endpoint, no LAG is created..
    /// </para> <para> You can specify an existing physical dedicated connection or interconnect
    /// to include in the LAG (which counts towards the total number of connections). Doing
    /// so interrupts the current physical dedicated connection, and re-establishes them as
    /// a member of the LAG. The LAG will be created on the same Direct Connect endpoint to
    /// which the dedicated connection terminates. Any virtual interfaces associated with
    /// the dedicated connection are automatically disassociated and re-associated with the
    /// LAG. The connection ID does not change. </para> <para> If the Amazon Web Services
    /// account used to create a LAG is a registered Direct Connect Partner, the LAG is automatically
    /// enabled to host sub-connections. For a LAG owned by a partner, any associated virtual
    /// interfaces cannot be directly configured. </para>
    /// </summary>
    public partial class CreateLagRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode for the LAG.
        /// </para>
        /// </summary>
        public RequestBillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property ChildConnectionTags. 
        /// <para>
        /// The tags to associate with the automtically created LAGs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> ChildConnectionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the ChildConnectionTags property is set.
        /// </summary>
        internal bool IsSetChildConnectionTags() => this.ChildConnectionTags != null && (this.ChildConnectionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of an existing dedicated connection to migrate to the LAG.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ConnectionsBandwidth. 
        /// <para>
        /// The bandwidth of the individual physical dedicated connections bundled by the LAG.
        /// The possible values are 1Gbps,10Gbps, 100Gbps, and 400Gbps. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionsBandwidth { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionsBandwidth property is set.
        /// </summary>
        internal bool IsSetConnectionsBandwidth() => this.ConnectionsBandwidth != null;

        /// <summary>
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LagName { get; set; }

        /// <summary>
        /// Checks to see if the LagName property is set.
        /// </summary>
        internal bool IsSetLagName() => this.LagName != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location for the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property NumberOfConnections. 
        /// <para>
        /// The number of physical dedicated connections initially provisioned and bundled by
        /// the LAG. You can have a maximum of four connections when the port speed is 1Gbps or
        /// 10Gbps, or two when the port speed is 100Gbps or 400Gbps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? NumberOfConnections { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfConnections property is set.
        /// </summary>
        internal bool IsSetNumberOfConnections() => this.NumberOfConnections.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the LAG.
        /// </para>
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property RequestMACSec. 
        /// <para>
        /// Indicates whether the connection will support MAC Security (MACsec).
        /// </para>
        ///  <note> 
        /// <para>
        /// All connections in the LAG must be capable of supporting MAC Security (MACsec). For
        /// information about MAC Security (MACsec) prerequisties, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/direct-connect-mac-sec-getting-started.html#mac-sec-prerequisites">MACsec
        /// prerequisties</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? RequestMACSec { get; set; }

        /// <summary>
        /// Checks to see if the RequestMACSec property is set.
        /// </summary>
        internal bool IsSetRequestMACSec() => this.RequestMACSec.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the LAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
