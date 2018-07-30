/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Describes a link aggregation group (LAG). A LAG is a connection that uses the Link
    /// Aggregation Control Protocol (LACP) to logically aggregate a bundle of physical connections.
    /// Like an interconnect, it can host other connections. All connections in a LAG must
    /// terminate on the same physical AWS Direct Connect endpoint, and must be the same bandwidth.
    /// </summary>
    public partial class DeleteLagResponse : AmazonWebServiceResponse
    {
        private bool? _allowsHostedConnections;
        private string _awsDevice;
        private string _awsDeviceV2;
        private List<Connection> _connections = new List<Connection>();
        private string _connectionsBandwidth;
        private string _lagId;
        private string _lagName;
        private LagState _lagState;
        private string _location;
        private int? _minimumLinks;
        private int? _numberOfConnections;
        private string _ownerAccount;
        private string _region;

        /// <summary>
        /// Gets and sets the property AllowsHostedConnections. 
        /// <para>
        /// Indicates whether the LAG can host other connections.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        public bool AllowsHostedConnections
        {
            get { return this._allowsHostedConnections.GetValueOrDefault(); }
            set { this._allowsHostedConnections = value; }
        }

        // Check to see if AllowsHostedConnections property is set
        internal bool IsSetAllowsHostedConnections()
        {
            return this._allowsHostedConnections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsDevice. 
        /// <para>
        /// Deprecated in favor of awsDeviceV2.
        /// </para>
        ///  
        /// <para>
        /// The AWS Direct Connection endpoint that hosts the LAG.
        /// </para>
        /// </summary>
        public string AwsDevice
        {
            get { return this._awsDevice; }
            set { this._awsDevice = value; }
        }

        // Check to see if AwsDevice property is set
        internal bool IsSetAwsDevice()
        {
            return this._awsDevice != null;
        }

        /// <summary>
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The AWS Direct Connection endpoint that hosts the LAG.
        /// </para>
        /// </summary>
        public string AwsDeviceV2
        {
            get { return this._awsDeviceV2; }
            set { this._awsDeviceV2 = value; }
        }

        // Check to see if AwsDeviceV2 property is set
        internal bool IsSetAwsDeviceV2()
        {
            return this._awsDeviceV2 != null;
        }

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// A list of connections bundled by this LAG.
        /// </para>
        /// </summary>
        public List<Connection> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && this._connections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionsBandwidth. 
        /// <para>
        /// The individual bandwidth of the physical connections bundled by the LAG.
        /// </para>
        ///  
        /// <para>
        /// Available values: 1Gbps, 10Gbps
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LagId.
        /// </summary>
        public string LagId
        {
            get { return this._lagId; }
            set { this._lagId = value; }
        }

        // Check to see if LagId property is set
        internal bool IsSetLagId()
        {
            return this._lagId != null;
        }

        /// <summary>
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LagState.
        /// </summary>
        public LagState LagState
        {
            get { return this._lagState; }
            set { this._lagState = value; }
        }

        // Check to see if LagState property is set
        internal bool IsSetLagState()
        {
            return this._lagState != null;
        }

        /// <summary>
        /// Gets and sets the property Location.
        /// </summary>
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
        /// Gets and sets the property MinimumLinks. 
        /// <para>
        /// The minimum number of physical connections that must be operational for the LAG itself
        /// to be operational. If the number of operational connections drops below this setting,
        /// the LAG state changes to <code>down</code>. This value can help to ensure that a LAG
        /// is not overutilized if a significant number of its bundled connections go down.
        /// </para>
        /// </summary>
        public int MinimumLinks
        {
            get { return this._minimumLinks.GetValueOrDefault(); }
            set { this._minimumLinks = value; }
        }

        // Check to see if MinimumLinks property is set
        internal bool IsSetMinimumLinks()
        {
            return this._minimumLinks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfConnections. 
        /// <para>
        /// The number of physical connections bundled by the LAG, up to a maximum of 10.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The owner of the LAG.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Region.
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}