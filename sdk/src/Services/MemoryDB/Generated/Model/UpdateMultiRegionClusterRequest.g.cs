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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMultiRegionCluster operation. Updates the
    /// configuration of an existing multi-Region cluster.
    /// </summary>
    public partial class UpdateMultiRegionClusterRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new engine version to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MultiRegionClusterName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterName property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterName() => this.MultiRegionClusterName != null;

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The new multi-Region parameter group to be associated with the cluster.
        /// </para>
        /// </summary>
        public string MultiRegionParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionParameterGroupName property is set.
        /// </summary>
        internal bool IsSetMultiRegionParameterGroupName() => this.MultiRegionParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property ShardConfiguration.
        /// </summary>
        public ShardConfigurationRequest ShardConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ShardConfiguration property is set.
        /// </summary>
        internal bool IsSetShardConfiguration() => this.ShardConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdateStrategy. 
        /// <para>
        /// The strategy to use for the update operation. Supported values are "coordinated" or
        /// "uncoordinated".
        /// </para>
        /// </summary>
        public UpdateStrategy UpdateStrategy { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStrategy property is set.
        /// </summary>
        internal bool IsSetUpdateStrategy() => this.UpdateStrategy != null;
    }
}
