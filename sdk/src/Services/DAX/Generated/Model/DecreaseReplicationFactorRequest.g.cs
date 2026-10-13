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
    /// Container for the parameters to the DecreaseReplicationFactor operation. Removes one
    /// or more nodes from a DAX cluster. <note> <para> You cannot use <c>DecreaseReplicationFactor</c>
    /// to remove the last node in a DAX cluster. If you need to do this, use <c>DeleteCluster</c>
    /// instead. </para> </note>
    /// </summary>
    public partial class DecreaseReplicationFactorRequest : AmazonDAXRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zone(s) from which to remove nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster from which you want to remove nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property NewReplicationFactor. 
        /// <para>
        /// The new number of nodes for the DAX cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? NewReplicationFactor { get; set; }

        /// <summary>
        /// Checks to see if the NewReplicationFactor property is set.
        /// </summary>
        internal bool IsSetNewReplicationFactor() => this.NewReplicationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property NodeIdsToRemove. 
        /// <para>
        /// The unique identifiers of the nodes to be removed from the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeIdsToRemove property is set.
        /// </summary>
        internal bool IsSetNodeIdsToRemove() => this.NodeIdsToRemove != null && (this.NodeIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
