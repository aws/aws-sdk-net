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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DecreaseReplicationFactor operation.
    /// Removes one or more nodes from a DAX cluster.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use <code>DecreaseReplicationFactor</code> to remove the last node in a
    /// DAX cluster. If you need to do this, use <code>DeleteCluster</code> instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DecreaseReplicationFactorRequest : AmazonDAXRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private string _clusterName;
        private int? _newReplicationFactor;
        private List<string> _nodeIdsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zone(s) from which to remove nodes.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster from which you want to remove nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property NewReplicationFactor. 
        /// <para>
        /// The new number of nodes for the DAX cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NewReplicationFactor
        {
            get { return this._newReplicationFactor.GetValueOrDefault(); }
            set { this._newReplicationFactor = value; }
        }

        // Check to see if NewReplicationFactor property is set
        internal bool IsSetNewReplicationFactor()
        {
            return this._newReplicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeIdsToRemove. 
        /// <para>
        /// The unique identifiers of the nodes to be removed from the cluster.
        /// </para>
        /// </summary>
        public List<string> NodeIdsToRemove
        {
            get { return this._nodeIdsToRemove; }
            set { this._nodeIdsToRemove = value; }
        }

        // Check to see if NodeIdsToRemove property is set
        internal bool IsSetNodeIdsToRemove()
        {
            return this._nodeIdsToRemove != null && this._nodeIdsToRemove.Count > 0; 
        }

    }
}