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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private EngineVersion _engineVersion;
        private List<string> _executionParameters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManagedQueryResultsConfiguration _managedQueryResultsConfiguration;
        private string _query;
        private QueryExecutionContext _queryExecutionContext;
        private string _queryExecutionId;
        private QueryResultsS3AccessGrantsConfiguration _queryResultsS3AccessGrantsConfiguration;
        private ResultConfiguration _resultConfiguration;
        private ResultReuseConfiguration _resultReuseConfiguration;
        private StatementType _statementType;
        private QueryExecutionStatistics _statistics;
        private QueryExecutionStatus _status;
        private string _substatementType;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version that executed the query.
        /// </para>
        /// </summary>
        public EngineVersion EngineVersion
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
        /// Gets and sets the property ExecutionParameters. 
        /// <para>
        /// A list of values for the parameters in a query. The values are applied sequentially
        /// to the parameters in the query in the order in which the parameters occur. The list
        /// of parameters is not returned in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ExecutionParameters
        {
            get { return this._executionParameters; }
            set { this._executionParameters = value; }
        }

        // Check to see if ExecutionParameters property is set
        internal bool IsSetExecutionParameters()
        {
            return this._executionParameters != null && (this._executionParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedQueryResultsConfiguration. 
        /// <para>
        ///  The configuration for storing results in Athena owned storage, which includes whether
        /// this feature is enabled; whether encryption configuration, if any, is used for encrypting
        /// query results. 
        /// </para>
        /// </summary>
        public ManagedQueryResultsConfiguration ManagedQueryResultsConfiguration
        {
            get { return this._managedQueryResultsConfiguration; }
            set { this._managedQueryResultsConfiguration = value; }
        }

        // Check to see if ManagedQueryResultsConfiguration property is set
        internal bool IsSetManagedQueryResultsConfiguration()
        {
            return this._managedQueryResultsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The SQL query statements which the query execution ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=262144)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property QueryExecutionContext. 
        /// <para>
        /// The database in which the query execution occurred.
        /// </para>
        /// </summary>
        public QueryExecutionContext QueryExecutionContext
        {
            get { return this._queryExecutionContext; }
            set { this._queryExecutionContext = value; }
        }

        // Check to see if QueryExecutionContext property is set
        internal bool IsSetQueryExecutionContext()
        {
            return this._queryExecutionContext != null;
        }

        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique identifier for each query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QueryExecutionId
        {
            get { return this._queryExecutionId; }
            set { this._queryExecutionId = value; }
        }

        // Check to see if QueryExecutionId property is set
        internal bool IsSetQueryExecutionId()
        {
            return this._queryExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryResultsS3AccessGrantsConfiguration. 
        /// <para>
        /// Specifies whether Amazon S3 access grants are enabled for query results.
        /// </para>
        /// </summary>
        public QueryResultsS3AccessGrantsConfiguration QueryResultsS3AccessGrantsConfiguration
        {
            get { return this._queryResultsS3AccessGrantsConfiguration; }
            set { this._queryResultsS3AccessGrantsConfiguration = value; }
        }

        // Check to see if QueryResultsS3AccessGrantsConfiguration property is set
        internal bool IsSetQueryResultsS3AccessGrantsConfiguration()
        {
            return this._queryResultsS3AccessGrantsConfiguration != null;
        }

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
        public ResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResultReuseConfiguration. 
        /// <para>
        /// Specifies the query result reuse behavior that was used for the query.
        /// </para>
        /// </summary>
        public ResultReuseConfiguration ResultReuseConfiguration
        {
            get { return this._resultReuseConfiguration; }
            set { this._resultReuseConfiguration = value; }
        }

        // Check to see if ResultReuseConfiguration property is set
        internal bool IsSetResultReuseConfiguration()
        {
            return this._resultReuseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StatementType. 
        /// <para>
        /// The type of query statement that was run. <c>DDL</c> indicates DDL query statements.
        /// <c>DML</c> indicates DML (Data Manipulation Language) query statements, such as <c>CREATE
        /// TABLE AS SELECT</c>. <c>UTILITY</c> indicates query statements other than DDL and
        /// DML, such as <c>SHOW CREATE TABLE</c>, or <c>DESCRIBE TABLE</c>.
        /// </para>
        /// </summary>
        public StatementType StatementType
        {
            get { return this._statementType; }
            set { this._statementType = value; }
        }

        // Check to see if StatementType property is set
        internal bool IsSetStatementType()
        {
            return this._statementType != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Query execution statistics, such as the amount of data scanned, the amount of time
        /// that the query took to process, and the type of statement that was run.
        /// </para>
        /// </summary>
        public QueryExecutionStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The completion date, current state, submission time, and state change reason (if applicable)
        /// for the query execution.
        /// </para>
        /// </summary>
        public QueryExecutionStatus Status
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
        /// Gets and sets the property SubstatementType. 
        /// <para>
        /// The kind of query statement that was run.
        /// </para>
        /// </summary>
        public string SubstatementType
        {
            get { return this._substatementType; }
            set { this._substatementType = value; }
        }

        // Check to see if SubstatementType property is set
        internal bool IsSetSubstatementType()
        {
            return this._substatementType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup in which the query ran.
        /// </para>
        /// </summary>
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}