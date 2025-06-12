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
    /// Specifies an Amazon Redshift node.
    /// </summary>
    public partial class AmazonRedshiftNodeData
    {
        private string _accessType;
        private string _action;
        private List<AmazonRedshiftAdvancedOption> _advancedOptions = AWSConfigs.InitializeCollections ? new List<AmazonRedshiftAdvancedOption>() : null;
        private Option _catalogDatabase;
        private string _catalogRedshiftSchema;
        private string _catalogRedshiftTable;
        private Option _catalogTable;
        private Option _connection;
        private string _crawlerConnection;
        private Option _iamRole;
        private string _mergeAction;
        private string _mergeClause;
        private string _mergeWhenMatched;
        private string _mergeWhenNotMatched;
        private string _postAction;
        private string _preAction;
        private string _sampleQuery;
        private Option _schema;
        private List<Option> _selectedColumns = AWSConfigs.InitializeCollections ? new List<Option>() : null;
        private string _sourceType;
        private string _stagingTable;
        private Option _table;
        private string _tablePrefix;
        private List<Option> _tableSchema = AWSConfigs.InitializeCollections ? new List<Option>() : null;
        private string _tempDir;
        private bool? _upsert;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The access type for the Redshift connection. Can be a direct connection or catalog
        /// connections.
        /// </para>
        /// </summary>
        public string AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies how writing to a Redshift cluser will occur.
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
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Optional values when connecting to the Redshift cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AmazonRedshiftAdvancedOption> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && (this._advancedOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CatalogDatabase. 
        /// <para>
        /// The name of the Glue Data Catalog database when working with a data catalog.
        /// </para>
        /// </summary>
        public Option CatalogDatabase
        {
            get { return this._catalogDatabase; }
            set { this._catalogDatabase = value; }
        }

        // Check to see if CatalogDatabase property is set
        internal bool IsSetCatalogDatabase()
        {
            return this._catalogDatabase != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogRedshiftSchema. 
        /// <para>
        /// The Redshift schema name when working with a data catalog.
        /// </para>
        /// </summary>
        public string CatalogRedshiftSchema
        {
            get { return this._catalogRedshiftSchema; }
            set { this._catalogRedshiftSchema = value; }
        }

        // Check to see if CatalogRedshiftSchema property is set
        internal bool IsSetCatalogRedshiftSchema()
        {
            return this._catalogRedshiftSchema != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogRedshiftTable. 
        /// <para>
        /// The database table to read from.
        /// </para>
        /// </summary>
        public string CatalogRedshiftTable
        {
            get { return this._catalogRedshiftTable; }
            set { this._catalogRedshiftTable = value; }
        }

        // Check to see if CatalogRedshiftTable property is set
        internal bool IsSetCatalogRedshiftTable()
        {
            return this._catalogRedshiftTable != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogTable. 
        /// <para>
        /// The Glue Data Catalog table name when working with a data catalog.
        /// </para>
        /// </summary>
        public Option CatalogTable
        {
            get { return this._catalogTable; }
            set { this._catalogTable = value; }
        }

        // Check to see if CatalogTable property is set
        internal bool IsSetCatalogTable()
        {
            return this._catalogTable != null;
        }

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        /// The Glue connection to the Redshift cluster.
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
        /// Gets and sets the property CrawlerConnection. 
        /// <para>
        /// Specifies the name of the connection that is associated with the catalog table used.
        /// </para>
        /// </summary>
        public string CrawlerConnection
        {
            get { return this._crawlerConnection; }
            set { this._crawlerConnection = value; }
        }

        // Check to see if CrawlerConnection property is set
        internal bool IsSetCrawlerConnection()
        {
            return this._crawlerConnection != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// Optional. The role name use when connection to S3. The IAM role ill default to the
        /// role on the job when left blank.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled.
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
        /// The SQL used in a custom merge to deal with matching records.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled when
        /// an existing record matches a new record.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled when
        /// an existing record doesn't match a new record.
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
        /// The SQL used before a MERGE or APPEND with upsert is run.
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
        /// The SQL used before a MERGE or APPEND with upsert is run.
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
        /// The SQL used to fetch the data from a Redshift sources when the SourceType is 'query'.
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
        /// The Redshift schema name when working with a direct connection.
        /// </para>
        /// </summary>
        public Option Schema
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
        /// The list of column names used to determine a matching record when doing a MERGE or
        /// APPEND with upsert.
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
        /// The source type to specify whether a specific table is the source or a custom query.
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
        /// The name of the temporary staging table that is used when doing a MERGE or APPEND
        /// with upsert.
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
        /// The Redshift table name when working with a direct connection.
        /// </para>
        /// </summary>
        public Option Table
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
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// Specifies the prefix to a table.
        /// </para>
        /// </summary>
        public string TablePrefix
        {
            get { return this._tablePrefix; }
            set { this._tablePrefix = value; }
        }

        // Check to see if TablePrefix property is set
        internal bool IsSetTablePrefix()
        {
            return this._tablePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        /// The array of schema output for a given node.
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
        /// The Amazon S3 path where temporary data can be staged when copying out of the database.
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
        /// The action used on Redshift sinks when doing an APPEND.
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