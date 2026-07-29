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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the ListSessions operation.
    /// Lists the sessions that the caller created in the last 24 hours. By default, only
    /// sessions with a status of <c>AVAILABLE</c> or <c>BUSY</c> are returned. You can filter
    /// the results by session status, compute target (cluster or serverless workgroup), or
    /// database. To retrieve the metadata for a single session, provide the <c>SessionId</c>
    /// parameter. Use <c>NextToken</c> to page through the session list.
    /// 
    ///  
    /// <para>
    /// Returns only the sessions that the caller created. When identity-enhanced role sessions
    /// are used, you must provide either the <c>ClusterIdentifier</c> or <c>WorkgroupName</c>
    /// parameter to ensure that the AWS IAM Identity Center user can only access the Amazon
    /// Redshift IAM Identity Center applications they are assigned. For more information,
    /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html">
    /// Trusted identity propagation overview</a>.
    /// </para>
    /// </summary>
    public partial class ListSessionsRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clusterIdentifier;
        private string _database;
        private int? _maxResults;
        private string _nextToken;
        private bool? _roleLevel;
        private string _sessionId;
        private SessionStatusString _status;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. Only sessions on this cluster are returned. When providing
        /// <c>ClusterIdentifier</c>, then <c>WorkgroupName</c> can't be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. Only sessions connected to this database are returned.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of sessions to return in the response. If more sessions exist than
        /// fit in one response, the operation returns <c>NextToken</c> to paginate the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RoleLevel. 
        /// <para>
        /// Specifies whether to return all sessions created by the caller's IAM role, including
        /// sessions from previous IAM sessions. If false, only sessions created in the current
        /// IAM session are returned. The default is true.
        /// </para>
        /// </summary>
        public bool? RoleLevel
        {
            get { return this._roleLevel; }
            set { this._roleLevel = value; }
        }

        // Check to see if RoleLevel property is set
        internal bool IsSetRoleLevel()
        {
            return this._roleLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of a specific session to return metadata for. This value is a universally
        /// unique identifier (UUID) generated by Amazon Redshift Data API. When you provide <c>SessionId</c>,
        /// you can't specify <c>Status</c>, <c>ClusterIdentifier</c>, <c>WorkgroupName</c>, or
        /// <c>Database</c>.
        /// </para>
        /// </summary>
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sessions to list. If no status is specified, sessions with a status
        /// of <c>AVAILABLE</c> or <c>BUSY</c> are returned. Status values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AVAILABLE – The session is open and ready to run a SQL statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BUSY – The session is currently running a SQL statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSED – The session is closed and can no longer run SQL statements.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SessionStatusString Status
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
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN). Only sessions on this
        /// workgroup are returned. When providing <c>WorkgroupName</c>, then <c>ClusterIdentifier</c>
        /// can't be specified.
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