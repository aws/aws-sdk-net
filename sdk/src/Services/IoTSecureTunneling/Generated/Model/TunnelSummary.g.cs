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
    /// Information about the tunnel.
    /// </summary>
    public partial class TunnelSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the tunnel was created.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time the tunnel was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

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
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name of the tunnel. 
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
        /// The unique alpha-numeric identifier for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelId { get; set; }

        /// <summary>
        /// Checks to see if the TunnelId property is set.
        /// </summary>
        internal bool IsSetTunnelId() => this.TunnelId != null;
    }
}
