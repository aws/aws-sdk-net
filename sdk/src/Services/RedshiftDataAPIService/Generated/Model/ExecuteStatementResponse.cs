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
    /// This is the response object from the ExecuteStatement operation.
    /// </summary>
    public partial class ExecuteStatementResponse : AmazonWebServiceResponse
    {
        private string _clusterIdentifier;
        private DateTime? _createdAt;
        private string _database;
        private List<string> _dbGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dbUser;
        private bool? _hasResultSet;
        private string _id;
        private long? _redshiftPid;
        private string _secretArn;
        private string _sessionId;
        private StatementStatusString _status;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This element is not returned when connecting to a serverless
        /// workgroup. 
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time (UTC) the statement was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// Gets and sets the property DbGroups. 
        /// <para>
        /// A list of colon (:) separated names of database groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DbGroups
        {
            get { return this._dbGroups; }
            set { this._dbGroups = value; }
        }

        // Check to see if DbGroups property is set
        internal bool IsSetDbGroups()
        {
            return this._dbGroups != null && (this._dbGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property HasResultSet. 
        /// <para>
        /// A value that indicates whether the statement has a result set. The result set can
        /// be empty. The value is true for an empty result set.
        /// </para>
        /// </summary>
        public bool? HasResultSet
        {
            get { return this._hasResultSet; }
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
        /// The identifier of the SQL statement whose results are to be fetched. This value is
        /// a universally unique identifier (UUID) generated by Amazon Redshift Data API. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RedshiftPid. 
        /// <para>
        /// The process identifier from Amazon Redshift. 
        /// </para>
        /// </summary>
        public long? RedshiftPid
        {
            get { return this._redshiftPid; }
            set { this._redshiftPid = value; }
        }

        // Check to see if RedshiftPid property is set
        internal bool IsSetRedshiftPid()
        {
            return this._redshiftPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. 
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session identifier of the query.
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
        /// The status of the SQL statement. Status values are defined as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ABORTED - The query run was stopped by the user. 
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
        public StatementStatusString Status
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
        /// The serverless workgroup name or Amazon Resource Name (ARN). This element is not returned
        /// when connecting to a provisioned cluster.
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