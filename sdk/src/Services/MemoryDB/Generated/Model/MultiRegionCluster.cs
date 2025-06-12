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
    /// Represents a multi-Region cluster.
    /// </summary>
    public partial class MultiRegionCluster
    {
        private string _arn;
        private List<RegionalCluster> _clusters = AWSConfigs.InitializeCollections ? new List<RegionalCluster>() : null;
        private string _description;
        private string _engine;
        private string _engineVersion;
        private string _multiRegionClusterName;
        private string _multiRegionParameterGroupName;
        private string _nodeType;
        private int? _numberOfShards;
        private string _status;
        private bool? _tlsEnabled;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the multi-Region cluster.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// The clusters in this multi-Region cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionalCluster> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the multi-Region cluster.
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
        /// The name of the engine used by the multi-Region cluster.
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
        /// The version of the engine used by the multi-Region cluster.
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
        /// The name of the multi-Region cluster.
        /// </para>
        /// </summary>
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
        /// The name of the multi-Region parameter group associated with the cluster.
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
        /// The node type used by the multi-Region cluster.
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
        /// Gets and sets the property NumberOfShards. 
        /// <para>
        /// The number of shards in the multi-Region cluster.
        /// </para>
        /// </summary>
        public int? NumberOfShards
        {
            get { return this._numberOfShards; }
            set { this._numberOfShards = value; }
        }

        // Check to see if NumberOfShards property is set
        internal bool IsSetNumberOfShards()
        {
            return this._numberOfShards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the multi-Region cluster.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// Indiciates if the multi-Region cluster is TLS enabled.
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