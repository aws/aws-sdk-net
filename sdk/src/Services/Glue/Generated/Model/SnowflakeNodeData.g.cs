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
    /// Specifies configuration for Snowflake nodes in Glue Studio.
    /// </summary>
    public partial class SnowflakeNodeData
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies what action to take when writing to a table with preexisting data. Valid
        /// values: <c> append</c>, <c>merge</c>, <c>truncate</c>, <c>drop</c>.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional options passed to the Snowflake connector. If options are specified
        /// elsewhere in this node, this will take precedence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalOptions() => this.AdditionalOptions != null && (this.AdditionalOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoPushdown. 
        /// <para>
        /// Specifies whether automatic query pushdown is enabled. If pushdown is enabled, then
        /// when a query is run on Spark, if part of the query can be "pushed down" to the Snowflake
        /// server, it is pushed down. This improves performance of some queries.
        /// </para>
        /// </summary>
        public bool? AutoPushdown { get; set; }

        /// <summary>
        /// Checks to see if the AutoPushdown property is set.
        /// </summary>
        internal bool IsSetAutoPushdown() => this.AutoPushdown.HasValue;

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        /// Specifies a Glue Data Catalog Connection to a Snowflake endpoint.
        /// </para>
        /// </summary>
        public Option Connection { get; set; }

        /// <summary>
        /// Checks to see if the Connection property is set.
        /// </summary>
        internal bool IsSetConnection() => this.Connection != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Specifies a Snowflake database for your node to use.
        /// </para>
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public Option IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property MergeAction. 
        /// <para>
        /// Specifies a merge action. Valid values: <c>simple</c>, <c>custom</c>. If simple, merge
        /// behavior is defined by <c>MergeWhenMatched</c> and <c> MergeWhenNotMatched</c>. If
        /// custom, defined by <c>MergeClause</c>.
        /// </para>
        /// </summary>
        public string MergeAction { get; set; }

        /// <summary>
        /// Checks to see if the MergeAction property is set.
        /// </summary>
        internal bool IsSetMergeAction() => this.MergeAction != null;

        /// <summary>
        /// Gets and sets the property MergeClause. 
        /// <para>
        /// A SQL statement that specifies a custom merge behavior.
        /// </para>
        /// </summary>
        public string MergeClause { get; set; }

        /// <summary>
        /// Checks to see if the MergeClause property is set.
        /// </summary>
        internal bool IsSetMergeClause() => this.MergeClause != null;

        /// <summary>
        /// Gets and sets the property MergeWhenMatched. 
        /// <para>
        /// Specifies how to resolve records that match preexisting data when merging. Valid values:
        /// <c> update</c>, <c>delete</c>.
        /// </para>
        /// </summary>
        public string MergeWhenMatched { get; set; }

        /// <summary>
        /// Checks to see if the MergeWhenMatched property is set.
        /// </summary>
        internal bool IsSetMergeWhenMatched() => this.MergeWhenMatched != null;

        /// <summary>
        /// Gets and sets the property MergeWhenNotMatched. 
        /// <para>
        /// Specifies how to process records that do not match preexisting data when merging.
        /// Valid values: <c>insert</c>, <c>none</c>.
        /// </para>
        /// </summary>
        public string MergeWhenNotMatched { get; set; }

        /// <summary>
        /// Checks to see if the MergeWhenNotMatched property is set.
        /// </summary>
        internal bool IsSetMergeWhenNotMatched() => this.MergeWhenNotMatched != null;

        /// <summary>
        /// Gets and sets the property PostAction. 
        /// <para>
        /// A SQL string run after the Snowflake connector performs its standard actions.
        /// </para>
        /// </summary>
        public string PostAction { get; set; }

        /// <summary>
        /// Checks to see if the PostAction property is set.
        /// </summary>
        internal bool IsSetPostAction() => this.PostAction != null;

        /// <summary>
        /// Gets and sets the property PreAction. 
        /// <para>
        /// A SQL string run before the Snowflake connector performs its standard actions.
        /// </para>
        /// </summary>
        public string PreAction { get; set; }

        /// <summary>
        /// Checks to see if the PreAction property is set.
        /// </summary>
        internal bool IsSetPreAction() => this.PreAction != null;

        /// <summary>
        /// Gets and sets the property SampleQuery. 
        /// <para>
        /// A SQL string used to retrieve data with the <c>query</c> sourcetype.
        /// </para>
        /// </summary>
        public string SampleQuery { get; set; }

        /// <summary>
        /// Checks to see if the SampleQuery property is set.
        /// </summary>
        internal bool IsSetSampleQuery() => this.SampleQuery != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Specifies a Snowflake database schema for your node to use.
        /// </para>
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SelectedColumns. 
        /// <para>
        /// Specifies the columns combined to identify a record when detecting matches for merges
        /// and upserts. A list of structures with <c>value</c>, <c>label</c> and <c> description</c>
        /// keys. Each structure describes a column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Option> SelectedColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<Option>() : null;

        /// <summary>
        /// Checks to see if the SelectedColumns property is set.
        /// </summary>
        internal bool IsSetSelectedColumns() => this.SelectedColumns != null && (this.SelectedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies how retrieved data is specified. Valid values: <c>"table"</c>, <c> "query"</c>.
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property StagingTable. 
        /// <para>
        /// The name of a staging table used when performing <c>merge</c> or upsert <c>append</c>
        /// actions. Data is written to this table, then moved to <c>table</c> by a generated
        /// postaction.
        /// </para>
        /// </summary>
        public string StagingTable { get; set; }

        /// <summary>
        /// Checks to see if the StagingTable property is set.
        /// </summary>
        internal bool IsSetStagingTable() => this.StagingTable != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// Specifies a Snowflake table for your node to use.
        /// </para>
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        /// Manually defines the target schema for the node. A list of structures with <c>value</c>
        /// , <c>label</c> and <c>description</c> keys. Each structure defines a column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Option> TableSchema { get; set; } = AWSConfigs.InitializeCollections ? new List<Option>() : null;

        /// <summary>
        /// Checks to see if the TableSchema property is set.
        /// </summary>
        internal bool IsSetTableSchema() => this.TableSchema != null && (this.TableSchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TempDir. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public string TempDir { get; set; }

        /// <summary>
        /// Checks to see if the TempDir property is set.
        /// </summary>
        internal bool IsSetTempDir() => this.TempDir != null;

        /// <summary>
        /// Gets and sets the property Upsert. 
        /// <para>
        /// Used when Action is <c>append</c>. Specifies the resolution behavior when a row already
        /// exists. If true, preexisting rows will be updated. If false, those rows will be inserted.
        /// </para>
        /// </summary>
        public bool? Upsert { get; set; }

        /// <summary>
        /// Checks to see if the Upsert property is set.
        /// </summary>
        internal bool IsSetUpsert() => this.Upsert.HasValue;
    }
}
