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

namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// A connection between a source computer and a destination device.
    /// </summary>
    public partial class Tunnel
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the tunnel was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the tunnel.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// The destination configuration that specifies the thing name of the destination device
        /// and a service name that the local proxy uses to connect to the destination application.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfig property is set.
        /// </summary>
        internal bool IsSetDestinationConfig() => this.DestinationConfig != null;

        /// <summary>
        /// Gets and sets the property DestinationConnectionState. 
        /// <para>
        /// The connection state of the destination application.
        /// </para>
        /// </summary>
        public ConnectionState DestinationConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConnectionState property is set.
        /// </summary>
        internal bool IsSetDestinationConnectionState() => this.DestinationConnectionState != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The last time the tunnel was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SourceConnectionState. 
        /// <para>
        /// The connection state of the source application.
        /// </para>
        /// </summary>
        public ConnectionState SourceConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the SourceConnectionState property is set.
        /// </summary>
        internal bool IsSetSourceConnectionState() => this.SourceConnectionState != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a tunnel. Valid values are: Open and Closed.
        /// </para>
        /// </summary>
        public TunnelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag metadata associated with the secure tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Timeout configuration for the tunnel.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;

        /// <summary>
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TunnelArn { get; set; }

        /// <summary>
        /// Checks to see if the TunnelArn property is set.
        /// </summary>
        internal bool IsSetTunnelArn() => this.TunnelArn != null;

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// A unique alpha-numeric ID that identifies a tunnel.
        /// </para>
        /// </summary>
        public string TunnelId { get; set; }

        /// <summary>
        /// Checks to see if the TunnelId property is set.
        /// </summary>
        internal bool IsSetTunnelId() => this.TunnelId != null;
    }
}
