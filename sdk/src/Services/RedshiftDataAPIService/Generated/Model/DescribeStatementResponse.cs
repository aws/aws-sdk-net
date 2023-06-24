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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// This is the response object from the DescribeStatement operation.
    /// </summary>
    public partial class DescribeStatementResponse : AmazonWebServiceResponse
    {
        private string _clusterIdentifier;
        private DateTime? _createdAt;
        private string _database;
        private string _dbUser;
        private long? _duration;
        private string _error;
        private bool? _hasResultSet;
        private string _id;
        private List<SqlParameter> _queryParameters = new List<SqlParameter>();
        private string _queryString;
        private long? _redshiftPid;
        private long? _redshiftQueryId;
        private long? _resultRows;
        private long? _resultSize;
        private string _secretArn;
        private StatusString _status;
        private List<SubStatementData> _subStatements = new List<SubStatementData>();
        private DateTime? _updatedAt;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. 
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time (UTC) when the SQL statement was submitted to run. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. 
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
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. 
        /// </para>
        /// </summary>
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of time in nanoseconds that the statement ran. 
        /// </para>
        /// </summary>
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error message from the cluster if the SQL statement encountered an error while
        /// running. 
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property HasResultSet. 
        /// <para>
        /// A value that indicates whether the statement has a result set. The result set can
        /// be empty. The value is true for an empty result set. The value is true if any substatement
        /// returns a result set.
        /// </para>
        /// </summary>
        public bool HasResultSet
        {
            get { return this._hasResultSet.GetValueOrDefault(); }
            set { this._hasResultSet = value; }
        }

        // Check to see if HasResultSet property is set
        internal bool IsSetHasResultSet()
        {
            return this._hasResultSet.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the SQL statement described. This value is a universally unique
        /// identifier (UUID) generated by Amazon Redshift Data API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// The parameters for the SQL statement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<SqlParameter> QueryParameters
        {
            get { return this._queryParameters; }
            set { this._queryParameters = value; }
        }

        // Check to see if QueryParameters property is set
        internal bool IsSetQueryParameters()
        {
            return this._queryParameters != null && this._queryParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL statement text. 
        /// </para>
        /// </summary>
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftPid. 
        /// <para>
        /// The process identifier from Amazon Redshift. 
        /// </para>
        /// </summary>
        public long RedshiftPid
        {
            get { return this._redshiftPid.GetValueOrDefault(); }
            set { this._redshiftPid = value; }
        }

        // Check to see if RedshiftPid property is set
        internal bool IsSetRedshiftPid()
        {
            return this._redshiftPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedshiftQueryId. 
        /// <para>
        /// The identifier of the query generated by Amazon Redshift. These identifiers are also
        /// available in the <code>query</code> column of the <code>STL_QUERY</code> system view.
        /// 
        /// </para>
        /// </summary>
        public long RedshiftQueryId
        {
            get { return this._redshiftQueryId.GetValueOrDefault(); }
            set { this._redshiftQueryId = value; }
        }

        // Check to see if RedshiftQueryId property is set
        internal bool IsSetRedshiftQueryId()
        {
            return this._redshiftQueryId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultRows. 
        /// <para>
        /// Either the number of rows returned from the SQL statement or the number of rows affected.
        /// If result size is greater than zero, the result rows can be the number of rows affected
        /// by SQL statements such as INSERT, UPDATE, DELETE, COPY, and others. A <code>-1</code>
        /// indicates the value is null.
        /// </para>
        /// </summary>
        public long ResultRows
        {
            get { return this._resultRows.GetValueOrDefault(); }
            set { this._resultRows = value; }
        }

        // Check to see if ResultRows property is set
        internal bool IsSetResultRows()
        {
            return this._resultRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultSize. 
        /// <para>
        /// The size in bytes of the returned results. A <code>-1</code> indicates the value is
        /// null.
        /// </para>
        /// </summary>
        public long ResultSize
        {
            get { return this._resultSize.GetValueOrDefault(); }
            set { this._resultSize = value; }
        }

        // Check to see if ResultSize property is set
        internal bool IsSetResultSize()
        {
            return this._resultSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the secret that enables access to the database.
        /// 
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

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
        public StatusString Status
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
        /// Gets and sets the property SubStatements. 
        /// <para>
        /// The SQL statements from a multiple statement run.
        /// </para>
        /// </summary>
        public List<SubStatementData> SubStatements
        {
            get { return this._subStatements; }
            set { this._subStatements = value; }
        }

        // Check to see if SubStatements property is set
        internal bool IsSetSubStatements()
        {
            return this._subStatements != null && this._subStatements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time (UTC) that the metadata for the SQL statement was last updated.
        /// An example is the time the status last changed. 
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}