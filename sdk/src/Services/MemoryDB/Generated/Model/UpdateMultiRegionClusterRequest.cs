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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
    /// Container for the parameters to the UpdateMultiRegionCluster operation.
    /// Updates the configuration of an existing multi-Region cluster.
    /// </summary>
    public partial class UpdateMultiRegionClusterRequest : AmazonMemoryDBRequest
    {
        private string _description;
        private string _engineVersion;
        private string _multiRegionClusterName;
        private string _multiRegionParameterGroupName;
        private string _nodeType;
        private ShardConfigurationRequest _shardConfiguration;
        private UpdateStrategy _updateStrategy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the multi-Region cluster.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new engine version to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MultiRegionClusterName
        {
            get { return this._multiRegionClusterName; }
            set { this._multiRegionClusterName = value; }
        }

        // Check to see if MultiRegionClusterName property is set
        internal bool IsSetMultiRegionClusterName()
        {
            return this._multiRegionClusterName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The new multi-Region parameter group to be associated with the cluster.
        /// </para>
        /// </summary>
        public string MultiRegionParameterGroupName
        {
            get { return this._multiRegionParameterGroupName; }
            set { this._multiRegionParameterGroupName = value; }
        }

        // Check to see if MultiRegionParameterGroupName property is set
        internal bool IsSetMultiRegionParameterGroupName()
        {
            return this._multiRegionParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The new node type to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property ShardConfiguration.
        /// </summary>
        public ShardConfigurationRequest ShardConfiguration
        {
            get { return this._shardConfiguration; }
            set { this._shardConfiguration = value; }
        }

        // Check to see if ShardConfiguration property is set
        internal bool IsSetShardConfiguration()
        {
            return this._shardConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStrategy. 
        /// <para>
        /// The strategy to use for the update operation. Supported values are "coordinated" or
        /// "uncoordinated".
        /// </para>
        /// </summary>
        public UpdateStrategy UpdateStrategy
        {
            get { return this._updateStrategy; }
            set { this._updateStrategy = value; }
        }

        // Check to see if UpdateStrategy property is set
        internal bool IsSetUpdateStrategy()
        {
            return this._updateStrategy != null;
        }

    }
}