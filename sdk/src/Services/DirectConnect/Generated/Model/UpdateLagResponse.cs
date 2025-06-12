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
    /// Information about a link aggregation group (LAG).
    /// </summary>
    public partial class UpdateLagResponse : AmazonWebServiceResponse
    {
        private bool? _allowsHostedConnections;
        private string _awsDevice;
        private string _awsDeviceV2;
        private string _awsLogicalDeviceId;
        private List<Connection> _connections = AWSConfigs.InitializeCollections ? new List<Connection>() : null;
        private string _connectionsBandwidth;
        private string _encryptionMode;
        private HasLogicalRedundancy _hasLogicalRedundancy;
        private bool? _jumboFrameCapable;
        private string _lagId;
        private string _lagName;
        private LagState _lagState;
        private string _location;
        private bool? _macSecCapable;
        private List<MacSecKey> _macSecKeys = AWSConfigs.InitializeCollections ? new List<MacSecKey>() : null;
        private int? _minimumLinks;
        private int? _numberOfConnections;
        private string _ownerAccount;
        private string _providerName;
        private string _region;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AllowsHostedConnections. 
        /// <para>
        /// Indicates whether the LAG can host other connections.
        /// </para>
        /// </summary>
        public bool? AllowsHostedConnections
        {
            get { return this._allowsHostedConnections; }
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
        /// The Direct Connect endpoint that hosts the LAG.
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
        /// The Direct Connect endpoint that hosts the LAG.
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
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId
        {
            get { return this._awsLogicalDeviceId; }
            set { this._awsLogicalDeviceId = value; }
        }

        // Check to see if AwsLogicalDeviceId property is set
        internal bool IsSetAwsLogicalDeviceId()
        {
            return this._awsLogicalDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The connections bundled by the LAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Connection> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && (this._connections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionsBandwidth. 
        /// <para>
        /// The individual bandwidth of the physical connections bundled by the LAG. The possible
        /// values are 1Gbps, 10Gbps, 100Gbps, or 400 Gbps.. 
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
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The LAG MAC Security (MACsec) encryption mode.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>no_encrypt</c>, <c>should_encrypt</c>, and <c>must_encrypt</c>.
        /// </para>
        /// </summary>
        public string EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property HasLogicalRedundancy. 
        /// <para>
        /// Indicates whether the LAG supports a secondary BGP peer in the same address family
        /// (IPv4/IPv6).
        /// </para>
        /// </summary>
        public HasLogicalRedundancy HasLogicalRedundancy
        {
            get { return this._hasLogicalRedundancy; }
            set { this._hasLogicalRedundancy = value; }
        }

        // Check to see if HasLogicalRedundancy property is set
        internal bool IsSetHasLogicalRedundancy()
        {
            return this._hasLogicalRedundancy != null;
        }

        /// <summary>
        /// Gets and sets the property JumboFrameCapable. 
        /// <para>
        /// Indicates whether jumbo frames are supported.
        /// </para>
        /// </summary>
        public bool? JumboFrameCapable
        {
            get { return this._jumboFrameCapable; }
            set { this._jumboFrameCapable = value; }
        }

        // Check to see if JumboFrameCapable property is set
        internal bool IsSetJumboFrameCapable()
        {
            return this._jumboFrameCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
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
        /// <para>
        /// The state of the LAG. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of a LAG. The LAG stays in the requested state
        /// until the Letter of Authorization (LOA) is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The LAG has been approved and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The network link is established and the LAG is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The LAG is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The LAG is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the LAG is not available.
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        /// The location of the LAG.
        /// </para>
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
        /// Gets and sets the property MacSecCapable. 
        /// <para>
        /// Indicates whether the LAG supports MAC Security (MACsec).
        /// </para>
        /// </summary>
        public bool? MacSecCapable
        {
            get { return this._macSecCapable; }
            set { this._macSecCapable = value; }
        }

        // Check to see if MacSecCapable property is set
        internal bool IsSetMacSecCapable()
        {
            return this._macSecCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MacSecKeys. 
        /// <para>
        /// The MAC Security (MACsec) security keys associated with the LAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MacSecKey> MacSecKeys
        {
            get { return this._macSecKeys; }
            set { this._macSecKeys = value; }
        }

        // Check to see if MacSecKeys property is set
        internal bool IsSetMacSecKeys()
        {
            return this._macSecKeys != null && (this._macSecKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinimumLinks. 
        /// <para>
        /// The minimum number of physical dedicated connections that must be operational for
        /// the LAG itself to be operational.
        /// </para>
        /// </summary>
        public int? MinimumLinks
        {
            get { return this._minimumLinks; }
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
        /// The number of physical dedicated connections initially provisioned and bundled by
        /// the LAG. You can have a maximum of four connections when the port speed is 1 Gbps
        /// or 10 Gbps, or two when the port speed is 100 Gbps or 400 Gbps.
        /// </para>
        /// </summary>
        public int? NumberOfConnections
        {
            get { return this._numberOfConnections; }
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
        /// The ID of the Amazon Web Services account that owns the LAG.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the connection is located.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the LAG.
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

    }
}