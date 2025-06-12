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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
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
namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// A connection between a source computer and a destination device.
    /// </summary>
    public partial class Tunnel
    {
        private DateTime? _createdAt;
        private string _description;
        private DestinationConfig _destinationConfig;
        private ConnectionState _destinationConnectionState;
        private DateTime? _lastUpdatedAt;
        private ConnectionState _sourceConnectionState;
        private TunnelStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TimeoutConfig _timeoutConfig;
        private string _tunnelArn;
        private string _tunnelId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the tunnel was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the tunnel.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// The destination configuration that specifies the thing name of the destination device
        /// and a service name that the local proxy uses to connect to the destination application.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig
        {
            get { return this._destinationConfig; }
            set { this._destinationConfig = value; }
        }

        // Check to see if DestinationConfig property is set
        internal bool IsSetDestinationConfig()
        {
            return this._destinationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationConnectionState. 
        /// <para>
        /// The connection state of the destination application.
        /// </para>
        /// </summary>
        public ConnectionState DestinationConnectionState
        {
            get { return this._destinationConnectionState; }
            set { this._destinationConnectionState = value; }
        }

        // Check to see if DestinationConnectionState property is set
        internal bool IsSetDestinationConnectionState()
        {
            return this._destinationConnectionState != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The last time the tunnel was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceConnectionState. 
        /// <para>
        /// The connection state of the source application.
        /// </para>
        /// </summary>
        public ConnectionState SourceConnectionState
        {
            get { return this._sourceConnectionState; }
            set { this._sourceConnectionState = value; }
        }

        // Check to see if SourceConnectionState property is set
        internal bool IsSetSourceConnectionState()
        {
            return this._sourceConnectionState != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a tunnel. Valid values are: Open and Closed.
        /// </para>
        /// </summary>
        public TunnelStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag metadata associated with the secure tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Timeout configuration for the tunnel.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TunnelArn
        {
            get { return this._tunnelArn; }
            set { this._tunnelArn = value; }
        }

        // Check to see if TunnelArn property is set
        internal bool IsSetTunnelArn()
        {
            return this._tunnelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// A unique alpha-numeric ID that identifies a tunnel.
        /// </para>
        /// </summary>
        public string TunnelId
        {
            get { return this._tunnelId; }
            set { this._tunnelId = value; }
        }

        // Check to see if TunnelId property is set
        internal bool IsSetTunnelId()
        {
            return this._tunnelId != null;
        }

    }
}