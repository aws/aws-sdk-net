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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// A set of five redundant Regional endpoints against which you can execute API calls
    /// to update or get the state of routing controls. You can host multiple control panels
    /// and routing controls on one cluster.
    /// </summary>
    public partial class Cluster
    {
        private string _clusterArn;
        private List<ClusterEndpoint> _clusterEndpoints = new List<ClusterEndpoint>();
        private string _name;
        private Status _status;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterEndpoints. 
        /// <para>
        /// Endpoints for a cluster. Specify one of these endpoints when you want to set or retrieve
        /// a routing control state in the cluster.
        /// </para>
        ///  
        /// <para>
        /// To get or update the routing control state, see the Amazon Route 53 Application Recovery
        /// Controller Routing Control Actions.
        /// </para>
        /// </summary>
        public List<ClusterEndpoint> ClusterEndpoints
        {
            get { return this._clusterEndpoints; }
            set { this._clusterEndpoints = value; }
        }

        // Check to see if ClusterEndpoints property is set
        internal bool IsSetClusterEndpoints()
        {
            return this._clusterEndpoints != null && this._clusterEndpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Deployment status of a resource. Status can be one of the following: PENDING, DEPLOYED,
        /// PENDING_DELETION.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}