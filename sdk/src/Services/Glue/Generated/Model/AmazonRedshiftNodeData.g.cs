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
    /// Specifies an Amazon Redshift node.
    /// </summary>
    public partial class AmazonRedshiftNodeData
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The access type for the Redshift connection. Can be a direct connection or catalog
        /// connections.
        /// </para>
        /// </summary>
        public string AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies how writing to a Redshift cluser will occur.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Optional values when connecting to the Redshift cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AmazonRedshiftAdvancedOption> AdvancedOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AmazonRedshiftAdvancedOption>() : null;

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null && (this.AdvancedOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CatalogDatabase. 
        /// <para>
        /// The name of the Glue Data Catalog database when working with a data catalog.
        /// </para>
        /// </summary>
        public Option CatalogDatabase { get; set; }

        /// <summary>
        /// Checks to see if the CatalogDatabase property is set.
        /// </summary>
        internal bool IsSetCatalogDatabase() => this.CatalogDatabase != null;

        /// <summary>
        /// Gets and sets the property CatalogRedshiftSchema. 
        /// <para>
        /// The Redshift schema name when working with a data catalog.
        /// </para>
        /// </summary>
        public string CatalogRedshiftSchema { get; set; }

        /// <summary>
        /// Checks to see if the CatalogRedshiftSchema property is set.
        /// </summary>
        internal bool IsSetCatalogRedshiftSchema() => this.CatalogRedshiftSchema != null;

        /// <summary>
        /// Gets and sets the property CatalogRedshiftTable. 
        /// <para>
        /// The database table to read from.
        /// </para>
        /// </summary>
        public string CatalogRedshiftTable { get; set; }

        /// <summary>
        /// Checks to see if the CatalogRedshiftTable property is set.
        /// </summary>
        internal bool IsSetCatalogRedshiftTable() => this.CatalogRedshiftTable != null;

        /// <summary>
        /// Gets and sets the property CatalogTable. 
        /// <para>
        /// The Glue Data Catalog table name when working with a data catalog.
        /// </para>
        /// </summary>
        public Option CatalogTable { get; set; }

        /// <summary>
        /// Checks to see if the CatalogTable property is set.
        /// </summary>
        internal bool IsSetCatalogTable() => this.CatalogTable != null;

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        /// The Glue connection to the Redshift cluster.
        /// </para>
        /// </summary>
        public Option Connection { get; set; }

        /// <summary>
        /// Checks to see if the Connection property is set.
        /// </summary>
        internal bool IsSetConnection() => this.Connection != null;

        /// <summary>
        /// Gets and sets the property CrawlerConnection. 
        /// <para>
        /// Specifies the name of the connection that is associated with the catalog table used.
        /// </para>
        /// </summary>
        public string CrawlerConnection { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerConnection property is set.
        /// </summary>
        internal bool IsSetCrawlerConnection() => this.CrawlerConnection != null;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// Optional. The role name use when connection to S3. The IAM role ill default to the
        /// role on the job when left blank.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled.
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
        /// The SQL used in a custom merge to deal with matching records.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled when
        /// an existing record matches a new record.
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
        /// The action used when to detemine how a MERGE in a Redshift sink will be handled when
        /// an existing record doesn't match a new record.
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
        /// The SQL used before a MERGE or APPEND with upsert is run.
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
        /// The SQL used before a MERGE or APPEND with upsert is run.
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
        /// The SQL used to fetch the data from a Redshift sources when the SourceType is 'query'.
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
        /// The Redshift schema name when working with a direct connection.
        /// </para>
        /// </summary>
        public Option Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SelectedColumns. 
        /// <para>
        /// The list of column names used to determine a matching record when doing a MERGE or
        /// APPEND with upsert.
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
        /// The source type to specify whether a specific table is the source or a custom query.
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
        /// The name of the temporary staging table that is used when doing a MERGE or APPEND
        /// with upsert.
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
        /// The Redshift table name when working with a direct connection.
        /// </para>
        /// </summary>
        public Option Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// Specifies the prefix to a table.
        /// </para>
        /// </summary>
        public string TablePrefix { get; set; }

        /// <summary>
        /// Checks to see if the TablePrefix property is set.
        /// </summary>
        internal bool IsSetTablePrefix() => this.TablePrefix != null;

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        /// The array of schema output for a given node.
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
        /// The Amazon S3 path where temporary data can be staged when copying out of the database.
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
        /// The action used on Redshift sinks when doing an APPEND.
        /// </para>
        /// </summary>
        public bool? Upsert { get; set; }

        /// <summary>
        /// Checks to see if the Upsert property is set.
        /// </summary>
        internal bool IsSetUpsert() => this.Upsert.HasValue;
    }
}
