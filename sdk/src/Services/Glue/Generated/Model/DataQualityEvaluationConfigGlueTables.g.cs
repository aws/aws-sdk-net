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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Identifies the Glue Data Catalog tables that a data quality evaluation configuration
    /// applies to.
    /// </summary>
    public partial class DataQualityEvaluationConfigGlueTables
    {
        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Options for reading the table. The following keys are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pushDownPredicate</c>: to filter on partitions without having to list and read
        /// all the files in your dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>catalogPartitionPredicate</c>: to use server-side partition pruning using partition
        /// indexes in the Glue Data Catalog.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> AdditionalOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalOptions() => this.AdditionalOptions != null && (this.AdditionalOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// A unique identifier for the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// A database name in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property PreProcessingQuery. 
        /// <para>
        /// SQL Query of SparkSQL format that can be used to pre-process the data for the table
        /// in Glue Data Catalog, before running the Data Quality Operation.
        /// </para>
        ///  
        /// <para>
        /// For the <c>CATALOG</c> and <c>DATABASE</c> levels, use the <c>{{DATABASE_NAME}}</c>
        /// and <c>{{TABLE_NAME}}</c> placeholders, which are filled in for each table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string PreProcessingQuery { get; set; }

        /// <summary>
        /// Checks to see if the PreProcessingQuery property is set.
        /// </summary>
        internal bool IsSetPreProcessingQuery() => this.PreProcessingQuery != null;

        /// <summary>
        /// Gets and sets the property TableNamePattern. 
        /// <para>
        /// For the <c>CATALOG</c> and <c>DATABASE</c> levels, a glob pattern, such as <c>orders_*</c>,
        /// that selects tables. If you don't specify a pattern, every table at the level is in
        /// scope. For the <c>TABLE</c> level, the name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TableNamePattern { get; set; }

        /// <summary>
        /// Checks to see if the TableNamePattern property is set.
        /// </summary>
        internal bool IsSetTableNamePattern() => this.TableNamePattern != null;
    }
}
