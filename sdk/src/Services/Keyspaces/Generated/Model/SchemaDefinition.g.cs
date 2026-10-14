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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Describes the schema of the table.
    /// </summary>
    public partial class SchemaDefinition
    {
        /// <summary>
        /// Gets and sets the property AllColumns. 
        /// <para>
        /// The regular columns of the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<ColumnDefinition> AllColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnDefinition>() : null;

        /// <summary>
        /// Checks to see if the AllColumns property is set.
        /// </summary>
        internal bool IsSetAllColumns() => this.AllColumns != null && (this.AllColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusteringKeys. 
        /// <para>
        /// The columns that are part of the clustering key of the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusteringKey> ClusteringKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusteringKey>() : null;

        /// <summary>
        /// Checks to see if the ClusteringKeys property is set.
        /// </summary>
        internal bool IsSetClusteringKeys() => this.ClusteringKeys != null && (this.ClusteringKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// The columns that are part of the partition key of the table .
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<PartitionKey> PartitionKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<PartitionKey>() : null;

        /// <summary>
        /// Checks to see if the PartitionKeys property is set.
        /// </summary>
        internal bool IsSetPartitionKeys() => this.PartitionKeys != null && (this.PartitionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StaticColumns. 
        /// <para>
        /// The columns that have been defined as <c>STATIC</c>. Static columns store values that
        /// are shared by all rows in the same partition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StaticColumn> StaticColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<StaticColumn>() : null;

        /// <summary>
        /// Checks to see if the StaticColumns property is set.
        /// </summary>
        internal bool IsSetStaticColumns() => this.StaticColumns != null && (this.StaticColumns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
