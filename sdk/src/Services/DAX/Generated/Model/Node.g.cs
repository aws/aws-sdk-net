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

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Represents an individual node within a DAX cluster.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone (AZ) in which the node has been deployed.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the node, consisting of a DNS name and a port number. Client applications
        /// can connect directly to a node endpoint, if desired (as an alternative to allowing
        /// DAX client software to intelligently route requests and responses to nodes in the
        /// DAX cluster.
        /// </para>
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property NodeCreateTime. 
        /// <para>
        /// The date and time (in UNIX epoch format) when the node was launched.
        /// </para>
        /// </summary>
        public DateTime? NodeCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the NodeCreateTime property is set.
        /// </summary>
        internal bool IsSetNodeCreateTime() => this.NodeCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// A system-generated identifier for the node.
        /// </para>
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property NodeStatus. 
        /// <para>
        /// The current status of the node. For example: <c>available</c>.
        /// </para>
        /// </summary>
        public string NodeStatus { get; set; }

        /// <summary>
        /// Checks to see if the NodeStatus property is set.
        /// </summary>
        internal bool IsSetNodeStatus() => this.NodeStatus != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupStatus. 
        /// <para>
        /// The status of the parameter group associated with this node. For example, <c>in-sync</c>.
        /// </para>
        /// </summary>
        public string ParameterGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupStatus property is set.
        /// </summary>
        internal bool IsSetParameterGroupStatus() => this.ParameterGroupStatus != null;
    }
}
