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
    /// Container for the parameters to the CreateMultiRegionCluster operation.
    /// Creates a new multi-Region cluster.
    /// </summary>
    public partial class CreateMultiRegionClusterRequest : AmazonMemoryDBRequest
    {
        private string _description;
        private string _engine;
        private string _engineVersion;
        private string _multiRegionClusterNameSuffix;
        private string _multiRegionParameterGroupName;
        private string _nodeType;
        private int? _numShards;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _tlsEnabled;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the multi-Region cluster.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the engine to be used for the multi-Region cluster.
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
        /// Gets and sets the property MultiRegionClusterNameSuffix. 
        /// <para>
        /// A suffix to be added to the Multi-Region cluster name. Amazon MemoryDB automatically
        /// applies a prefix to the Multi-Region cluster Name when it is created. Each Amazon
        /// Region has its own prefix. For instance, a Multi-Region cluster Name created in the
        /// US-West-1 region will begin with "virxk", along with the suffix name you provide.
        /// The suffix guarantees uniqueness of the Multi-Region cluster name across multiple
        /// regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MultiRegionClusterNameSuffix
        {
            get { return this._multiRegionClusterNameSuffix; }
            set { this._multiRegionClusterNameSuffix = value; }
        }

        // Check to see if MultiRegionClusterNameSuffix property is set
        internal bool IsSetMultiRegionClusterNameSuffix()
        {
            return this._multiRegionClusterNameSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The name of the multi-Region parameter group to be associated with the cluster.
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
        /// The node type to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards for the multi-Region cluster.
        /// </para>
        /// </summary>
        public int? NumShards
        {
            get { return this._numShards; }
            set { this._numShards = value; }
        }

        // Check to see if NumShards property is set
        internal bool IsSetNumShards()
        {
            return this._numShards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be applied to the multi-Region cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// Whether to enable TLS encryption for the multi-Region cluster.
        /// </para>
        /// </summary>
        public bool? TLSEnabled
        {
            get { return this._tlsEnabled; }
            set { this._tlsEnabled = value; }
        }

        // Check to see if TLSEnabled property is set
        internal bool IsSetTLSEnabled()
        {
            return this._tlsEnabled.HasValue; 
        }

    }
}