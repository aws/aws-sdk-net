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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLag operation.
    /// Creates a link aggregation group (LAG) with the specified number of bundled physical
    /// dedicated connections between the customer network and a specific AWS Direct Connect
    /// location. A LAG is a logical interface that uses the Link Aggregation Control Protocol
    /// (LACP) to aggregate multiple interfaces, enabling you to treat them as a single interface.
    /// 
    ///  
    /// <para>
    /// All connections in a LAG must use the same bandwidth (either 1Gbps or 10Gbps) and
    /// must terminate at the same AWS Direct Connect endpoint.
    /// </para>
    ///  
    /// <para>
    /// You can have up to 10 dedicated connections per LAG. Regardless of this limit, if
    /// you request more connections for the LAG than AWS Direct Connect can allocate on a
    /// single endpoint, no LAG is created.
    /// </para>
    ///  
    /// <para>
    /// You can specify an existing physical dedicated connection or interconnect to include
    /// in the LAG (which counts towards the total number of connections). Doing so interrupts
    /// the current physical dedicated connection, and re-establishes them as a member of
    /// the LAG. The LAG will be created on the same AWS Direct Connect endpoint to which
    /// the dedicated connection terminates. Any virtual interfaces associated with the dedicated
    /// connection are automatically disassociated and re-associated with the LAG. The connection
    /// ID does not change.
    /// </para>
    ///  
    /// <para>
    /// If the AWS account used to create a LAG is a registered AWS Direct Connect Partner,
    /// the LAG is automatically enabled to host sub-connections. For a LAG owned by a partner,
    /// any associated virtual interfaces cannot be directly configured.
    /// </para>
    /// </summary>
    public partial class CreateLagRequest : AmazonDirectConnectRequest
    {
        private List<Tag> _childConnectionTags = new List<Tag>();
        private string _connectionId;
        private string _connectionsBandwidth;
        private string _lagName;
        private string _location;
        private int? _numberOfConnections;
        private string _providerName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ChildConnectionTags. 
        /// <para>
        /// The tags to associate with the automtically created LAGs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> ChildConnectionTags
        {
            get { return this._childConnectionTags; }
            set { this._childConnectionTags = value; }
        }

        // Check to see if ChildConnectionTags property is set
        internal bool IsSetChildConnectionTags()
        {
            return this._childConnectionTags != null && this._childConnectionTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of an existing dedicated connection to migrate to the LAG.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ConnectionsBandwidth. 
        /// <para>
        /// The bandwidth of the individual physical dedicated connections bundled by the LAG.
        /// The possible values are 1Gbps and 10Gbps. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionsBandwidth
        {
            get { return this._connectionsBandwidth; }
            set { this._connectionsBandwidth = value; }
        }

        // Check to see if ConnectionsBandwidth property is set
        internal bool IsSetConnectionsBandwidth()
        {
            return this._connectionsBandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LagName
        {
            get { return this._lagName; }
            set { this._lagName = value; }
        }

        // Check to see if LagName property is set
        internal bool IsSetLagName()
        {
            return this._lagName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location for the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfConnections. 
        /// <para>
        /// The number of physical dedicated connections initially provisioned and bundled by
        /// the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NumberOfConnections
        {
            get { return this._numberOfConnections.GetValueOrDefault(); }
            set { this._numberOfConnections = value; }
        }

        // Check to see if NumberOfConnections property is set
        internal bool IsSetNumberOfConnections()
        {
            return this._numberOfConnections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the LAG.
        /// </para>
        /// </summary>
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the LAG.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}