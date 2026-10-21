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

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// This is the response object from the DescribeStatement operation.
    /// </summary>
    public partial class DescribeStatementResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. 
        /// </para>
        /// </summary>
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time (UTC) when the SQL statement was submitted to run. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. 
        /// </para>
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. 
        /// </para>
        /// </summary>
        public string DbUser { get; set; }

        /// <summary>
        /// Checks to see if the DbUser property is set.
        /// </summary>
        internal bool IsSetDbUser() => this.DbUser != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of time in nanoseconds that the statement ran. 
        /// </para>
        /// </summary>
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error message from the cluster if the SQL statement encountered an error while
        /// running. 
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The execution mode of the batch request. <c>TRANSACTION</c> indicates all SQL statements
        /// are run as a single transaction. <c>AUTO_COMMIT</c> indicates each SQL statement is
        /// committed individually.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMode property is set.
        /// </summary>
        internal bool IsSetExecutionMode() => this.ExecutionMode != null;

        /// <summary>
        /// Gets and sets the property HasResultSet. 
        /// <para>
        /// A value that indicates whether the statement has a result set. The result set can
        /// be empty. The value is true for an empty result set. The value is true if any substatement
        /// returns a result set.
        /// </para>
        /// </summary>
        public bool? HasResultSet { get; set; }

        /// <summary>
        /// Checks to see if the HasResultSet property is set.
        /// </summary>
        internal bool IsSetHasResultSet() => this.HasResultSet.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the SQL statement described. This value is a universally unique
        /// identifier (UUID) generated by Amazon Redshift Data API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// The parameters for the SQL statement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<SqlParameter> QueryParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<SqlParameter>() : null;

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null && (this.QueryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL statement text. 
        /// </para>
        /// </summary>
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property RedshiftPid. 
        /// <para>
        /// The process identifier from Amazon Redshift. 
        /// </para>
        /// </summary>
        public long? RedshiftPid { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftPid property is set.
        /// </summary>
        internal bool IsSetRedshiftPid() => this.RedshiftPid.HasValue;

        /// <summary>
        /// Gets and sets the property RedshiftQueryId. 
        /// <para>
        /// The identifier of the query generated by Amazon Redshift. These identifiers are also
        /// available in the <c>query_id</c> column of the <c>SYS_QUERY_HISTORY</c> system view.
        /// 
        /// </para>
        /// </summary>
        public long? RedshiftQueryId { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftQueryId property is set.
        /// </summary>
        internal bool IsSetRedshiftQueryId() => this.RedshiftQueryId.HasValue;

        /// <summary>
        /// Gets and sets the property RedshiftQueryUuid. 
        /// <para>
        /// The global unique identifier of the query generated by Amazon Redshift. These identifiers
        /// are also available in the <c>query_uuid</c> column of the <c>SYS_QUERY_HISTORY</c>
        /// system view. 
        /// </para>
        /// </summary>
        public string RedshiftQueryUuid { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftQueryUuid property is set.
        /// </summary>
        internal bool IsSetRedshiftQueryUuid() => this.RedshiftQueryUuid != null;

        /// <summary>
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// The data format of the result of the SQL statement.
        /// </para>
        /// </summary>
        public ResultFormatString ResultFormat { get; set; }

        /// <summary>
        /// Checks to see if the ResultFormat property is set.
        /// </summary>
        internal bool IsSetResultFormat() => this.ResultFormat != null;

        /// <summary>
        /// Gets and sets the property ResultRows. 
        /// <para>
        /// Either the number of rows returned from the SQL statement or the number of rows affected.
        /// If result size is greater than zero, the result rows can be the number of rows affected
        /// by SQL statements such as INSERT, UPDATE, DELETE, COPY, and others. A <c>-1</c> indicates
        /// the value is null.
        /// </para>
        /// </summary>
        public long? ResultRows { get; set; }

        /// <summary>
        /// Checks to see if the ResultRows property is set.
        /// </summary>
        internal bool IsSetResultRows() => this.ResultRows.HasValue;

        /// <summary>
        /// Gets and sets the property ResultSize. 
        /// <para>
        /// The size in bytes of the returned results. A <c>-1</c> indicates the value is null.
        /// </para>
        /// </summary>
        public long? ResultSize { get; set; }

        /// <summary>
        /// Checks to see if the ResultSize property is set.
        /// </summary>
        internal bool IsSetResultSize() => this.ResultSize.HasValue;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the secret that enables access to the database.
        /// 
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session identifier of the query.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SQL statement being described. Status values are defined as follows:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ABORTED - The query run was stopped by the user. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ALL - A status value that includes all query statuses. This value can be used to filter
        /// results. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The query run failed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FINISHED - The query has finished running. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PICKED - The query has been chosen to be run. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STARTED - The query run has started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUBMITTED - The query was submitted, but not yet processed. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusString Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubStatements. 
        /// <para>
        /// The SQL statements from a multiple statement run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubStatementData> SubStatements { get; set; } = AWSConfigs.InitializeCollections ? new List<SubStatementData>() : null;

        /// <summary>
        /// Checks to see if the SubStatements property is set.
        /// </summary>
        internal bool IsSetSubStatements() => this.SubStatements != null && (this.SubStatements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time (UTC) that the metadata for the SQL statement was last updated.
        /// An example is the time the status last changed. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
