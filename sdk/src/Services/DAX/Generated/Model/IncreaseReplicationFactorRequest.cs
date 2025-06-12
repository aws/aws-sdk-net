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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the IncreaseReplicationFactor operation.
    /// Adds one or more nodes to a DAX cluster.
    /// </summary>
    public partial class IncreaseReplicationFactorRequest : AmazonDAXRequest
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clusterName;
        private int? _newReplicationFactor;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones (AZs) in which the cluster nodes will be created. All nodes
        /// belonging to the cluster are placed in these Availability Zones. Use this parameter
        /// if you want to distribute the nodes across multiple AZs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster that will receive additional nodes.
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
        public int? NewReplicationFactor
        {
            get { return this._newReplicationFactor; }
            set { this._newReplicationFactor = value; }
        }

        // Check to see if NewReplicationFactor property is set
        internal bool IsSetNewReplicationFactor()
        {
            return this._newReplicationFactor.HasValue; 
        }

    }
}