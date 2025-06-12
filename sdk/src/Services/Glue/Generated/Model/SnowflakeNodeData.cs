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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _action;
        private Dictionary<string, string> _additionalOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _autoPushdown;
        private Option _connection;
        private string _database;
        private Option _iamRole;
        private string _mergeAction;
        private string _mergeClause;
        private string _mergeWhenMatched;
        private string _mergeWhenNotMatched;
        private string _postAction;
        private string _preAction;
        private string _sampleQuery;
        private string _schema;
        private List<Option> _selectedColumns = AWSConfigs.InitializeCollections ? new List<Option>() : null;
        private string _sourceType;
        private string _stagingTable;
        private string _table;
        private List<Option> _tableSchema = AWSConfigs.InitializeCollections ? new List<Option>() : null;
        private string _tempDir;
        private bool? _upsert;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies what action to take when writing to a table with preexisting data. Valid
        /// values: <c> append</c>, <c>merge</c>, <c>truncate</c>, <c>drop</c>.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional options passed to the Snowflake connector. If options are specified
        /// elsewhere in this node, this will take precedence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null && (this._additionalOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoPushdown. 
        /// <para>
        /// Specifies whether automatic query pushdown is enabled. If pushdown is enabled, then
        /// when a query is run on Spark, if part of the query can be "pushed down" to the Snowflake
        /// server, it is pushed down. This improves performance of some queries.
        /// </para>
        /// </summary>
        public bool? AutoPushdown
        {
            get { return this._autoPushdown; }
            set { this._autoPushdown = value; }
        }

        // Check to see if AutoPushdown property is set
        internal bool IsSetAutoPushdown()
        {
            return this._autoPushdown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        /// Specifies a Glue Data Catalog Connection to a Snowflake endpoint.
        /// </para>
        /// </summary>
        public Option Connection
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        // Check to see if Connection property is set
        internal bool IsSetConnection()
        {
            return this._connection != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Specifies a Snowflake database for your node to use.
        /// </para>
        /// </summary>
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public Option IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property MergeAction. 
        /// <para>
        /// Specifies a merge action. Valid values: <c>simple</c>, <c>custom</c>. If simple, merge
        /// behavior is defined by <c>MergeWhenMatched</c> and <c> MergeWhenNotMatched</c>. If
        /// custom, defined by <c>MergeClause</c>.
        /// </para>
        /// </summary>
        public string MergeAction
        {
            get { return this._mergeAction; }
            set { this._mergeAction = value; }
        }

        // Check to see if MergeAction property is set
        internal bool IsSetMergeAction()
        {
            return this._mergeAction != null;
        }

        /// <summary>
        /// Gets and sets the property MergeClause. 
        /// <para>
        /// A SQL statement that specifies a custom merge behavior.
        /// </para>
        /// </summary>
        public string MergeClause
        {
            get { return this._mergeClause; }
            set { this._mergeClause = value; }
        }

        // Check to see if MergeClause property is set
        internal bool IsSetMergeClause()
        {
            return this._mergeClause != null;
        }

        /// <summary>
        /// Gets and sets the property MergeWhenMatched. 
        /// <para>
        /// Specifies how to resolve records that match preexisting data when merging. Valid values:
        /// <c> update</c>, <c>delete</c>.
        /// </para>
        /// </summary>
        public string MergeWhenMatched
        {
            get { return this._mergeWhenMatched; }
            set { this._mergeWhenMatched = value; }
        }

        // Check to see if MergeWhenMatched property is set
        internal bool IsSetMergeWhenMatched()
        {
            return this._mergeWhenMatched != null;
        }

        /// <summary>
        /// Gets and sets the property MergeWhenNotMatched. 
        /// <para>
        /// Specifies how to process records that do not match preexisting data when merging.
        /// Valid values: <c>insert</c>, <c>none</c>.
        /// </para>
        /// </summary>
        public string MergeWhenNotMatched
        {
            get { return this._mergeWhenNotMatched; }
            set { this._mergeWhenNotMatched = value; }
        }

        // Check to see if MergeWhenNotMatched property is set
        internal bool IsSetMergeWhenNotMatched()
        {
            return this._mergeWhenNotMatched != null;
        }

        /// <summary>
        /// Gets and sets the property PostAction. 
        /// <para>
        /// A SQL string run after the Snowflake connector performs its standard actions.
        /// </para>
        /// </summary>
        public string PostAction
        {
            get { return this._postAction; }
            set { this._postAction = value; }
        }

        // Check to see if PostAction property is set
        internal bool IsSetPostAction()
        {
            return this._postAction != null;
        }

        /// <summary>
        /// Gets and sets the property PreAction. 
        /// <para>
        /// A SQL string run before the Snowflake connector performs its standard actions.
        /// </para>
        /// </summary>
        public string PreAction
        {
            get { return this._preAction; }
            set { this._preAction = value; }
        }

        // Check to see if PreAction property is set
        internal bool IsSetPreAction()
        {
            return this._preAction != null;
        }

        /// <summary>
        /// Gets and sets the property SampleQuery. 
        /// <para>
        /// A SQL string used to retrieve data with the <c>query</c> sourcetype.
        /// </para>
        /// </summary>
        public string SampleQuery
        {
            get { return this._sampleQuery; }
            set { this._sampleQuery = value; }
        }

        // Check to see if SampleQuery property is set
        internal bool IsSetSampleQuery()
        {
            return this._sampleQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Specifies a Snowflake database schema for your node to use.
        /// </para>
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedColumns. 
        /// <para>
        /// Specifies the columns combined to identify a record when detecting matches for merges
        /// and upserts. A list of structures with <c>value</c>, <c>label</c> and <c> description</c>
        /// keys. Each structure describes a column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Option> SelectedColumns
        {
            get { return this._selectedColumns; }
            set { this._selectedColumns = value; }
        }

        // Check to see if SelectedColumns property is set
        internal bool IsSetSelectedColumns()
        {
            return this._selectedColumns != null && (this._selectedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies how retrieved data is specified. Valid values: <c>"table"</c>, <c> "query"</c>.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StagingTable. 
        /// <para>
        /// The name of a staging table used when performing <c>merge</c> or upsert <c>append</c>
        /// actions. Data is written to this table, then moved to <c>table</c> by a generated
        /// postaction.
        /// </para>
        /// </summary>
        public string StagingTable
        {
            get { return this._stagingTable; }
            set { this._stagingTable = value; }
        }

        // Check to see if StagingTable property is set
        internal bool IsSetStagingTable()
        {
            return this._stagingTable != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// Specifies a Snowflake table for your node to use.
        /// </para>
        /// </summary>
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        /// Manually defines the target schema for the node. A list of structures with <c>value</c>
        /// , <c>label</c> and <c>description</c> keys. Each structure defines a column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Option> TableSchema
        {
            get { return this._tableSchema; }
            set { this._tableSchema = value; }
        }

        // Check to see if TableSchema property is set
        internal bool IsSetTableSchema()
        {
            return this._tableSchema != null && (this._tableSchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TempDir. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public string TempDir
        {
            get { return this._tempDir; }
            set { this._tempDir = value; }
        }

        // Check to see if TempDir property is set
        internal bool IsSetTempDir()
        {
            return this._tempDir != null;
        }

        /// <summary>
        /// Gets and sets the property Upsert. 
        /// <para>
        /// Used when Action is <c>append</c>. Specifies the resolution behavior when a row already
        /// exists. If true, preexisting rows will be updated. If false, those rows will be inserted.
        /// </para>
        /// </summary>
        public bool? Upsert
        {
            get { return this._upsert; }
            set { this._upsert = value; }
        }

        // Check to see if Upsert property is set
        internal bool IsSetUpsert()
        {
            return this._upsert.HasValue; 
        }

    }
}