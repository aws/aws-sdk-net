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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Describes the schema of the table.
    /// </summary>
    public partial class SchemaDefinition
    {
        private List<ColumnDefinition> _allColumns = new List<ColumnDefinition>();
        private List<ClusteringKey> _clusteringKeys = new List<ClusteringKey>();
        private List<PartitionKey> _partitionKeys = new List<PartitionKey>();
        private List<StaticColumn> _staticColumns = new List<StaticColumn>();

        /// <summary>
        /// Gets and sets the property AllColumns. 
        /// <para>
        /// The regular columns of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<ColumnDefinition> AllColumns
        {
            get { return this._allColumns; }
            set { this._allColumns = value; }
        }

        // Check to see if AllColumns property is set
        internal bool IsSetAllColumns()
        {
            return this._allColumns != null && this._allColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusteringKeys. 
        /// <para>
        /// The columns that are part of the clustering key of the table.
        /// </para>
        /// </summary>
        public List<ClusteringKey> ClusteringKeys
        {
            get { return this._clusteringKeys; }
            set { this._clusteringKeys = value; }
        }

        // Check to see if ClusteringKeys property is set
        internal bool IsSetClusteringKeys()
        {
            return this._clusteringKeys != null && this._clusteringKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// The columns that are part of the partition key of the table .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<PartitionKey> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && this._partitionKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StaticColumns. 
        /// <para>
        /// The columns that have been defined as <code>STATIC</code>. Static columns store values
        /// that are shared by all rows in the same partition.
        /// </para>
        /// </summary>
        public List<StaticColumn> StaticColumns
        {
            get { return this._staticColumns; }
            set { this._staticColumns = value; }
        }

        // Check to see if StaticColumns property is set
        internal bool IsSetStaticColumns()
        {
            return this._staticColumns != null && this._staticColumns.Count > 0; 
        }

    }
}