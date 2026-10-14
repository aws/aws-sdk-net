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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Information about a single instance of a query execution.
    /// </summary>
    public partial class QueryExecution
    {
        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version that executed the query.
        /// </para>
        /// </summary>
        public EngineVersion EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutionParameters. 
        /// <para>
        /// A list of values for the parameters in a query. The values are applied sequentially
        /// to the parameters in the query in the order in which the parameters occur. The list
        /// of parameters is not returned in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> ExecutionParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExecutionParameters property is set.
        /// </summary>
        internal bool IsSetExecutionParameters() => this.ExecutionParameters != null && (this.ExecutionParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedQueryResultsConfiguration. 
        /// <para>
        ///  The configuration for storing results in Athena owned storage, which includes whether
        /// this feature is enabled; whether encryption configuration, if any, is used for encrypting
        /// query results. 
        /// </para>
        /// </summary>
        public ManagedQueryResultsConfiguration ManagedQueryResultsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedQueryResultsConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedQueryResultsConfiguration() => this.ManagedQueryResultsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The SQL query statements which the query execution ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 262144)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property QueryExecutionContext. 
        /// <para>
        /// The database in which the query execution occurred.
        /// </para>
        /// </summary>
        public QueryExecutionContext QueryExecutionContext { get; set; }

        /// <summary>
        /// Checks to see if the QueryExecutionContext property is set.
        /// </summary>
        internal bool IsSetQueryExecutionContext() => this.QueryExecutionContext != null;

        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique identifier for each query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QueryExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the QueryExecutionId property is set.
        /// </summary>
        internal bool IsSetQueryExecutionId() => this.QueryExecutionId != null;

        /// <summary>
        /// Gets and sets the property QueryResultsS3AccessGrantsConfiguration. 
        /// <para>
        /// Specifies whether Amazon S3 access grants are enabled for query results.
        /// </para>
        /// </summary>
        public QueryResultsS3AccessGrantsConfiguration QueryResultsS3AccessGrantsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QueryResultsS3AccessGrantsConfiguration property is set.
        /// </summary>
        internal bool IsSetQueryResultsS3AccessGrantsConfiguration() => this.QueryResultsS3AccessGrantsConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The location in Amazon S3 where query and calculation results are stored and the encryption
        /// option, if any, used for query results. These are known as "client-side settings".
        /// If workgroup settings override client-side settings, then the query uses the location
        /// for the query results and the encryption configuration that are specified for the
        /// workgroup.
        /// </para>
        /// </summary>
        public ResultConfiguration ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResultReuseConfiguration. 
        /// <para>
        /// Specifies the query result reuse behavior that was used for the query.
        /// </para>
        /// </summary>
        public ResultReuseConfiguration ResultReuseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultReuseConfiguration property is set.
        /// </summary>
        internal bool IsSetResultReuseConfiguration() => this.ResultReuseConfiguration != null;

        /// <summary>
        /// Gets and sets the property StatementType. 
        /// <para>
        /// The type of query statement that was run. <c>DDL</c> indicates DDL query statements.
        /// <c>DML</c> indicates DML (Data Manipulation Language) query statements, such as <c>CREATE
        /// TABLE AS SELECT</c>. <c>UTILITY</c> indicates query statements other than DDL and
        /// DML, such as <c>SHOW CREATE TABLE</c>, <c>EXPLAIN</c>, <c>DESCRIBE</c>, or <c>SHOW
        /// TABLES</c>.
        /// </para>
        /// </summary>
        public StatementType StatementType { get; set; }

        /// <summary>
        /// Checks to see if the StatementType property is set.
        /// </summary>
        internal bool IsSetStatementType() => this.StatementType != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Query execution statistics, such as the amount of data scanned, the amount of time
        /// that the query took to process, and the type of statement that was run.
        /// </para>
        /// </summary>
        public QueryExecutionStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The completion date, current state, submission time, and state change reason (if applicable)
        /// for the query execution.
        /// </para>
        /// </summary>
        public QueryExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubstatementType. 
        /// <para>
        /// The kind of query statement that was run.
        /// </para>
        /// </summary>
        public string SubstatementType { get; set; }

        /// <summary>
        /// Checks to see if the SubstatementType property is set.
        /// </summary>
        internal bool IsSetSubstatementType() => this.SubstatementType != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup in which the query ran.
        /// </para>
        /// </summary>
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
