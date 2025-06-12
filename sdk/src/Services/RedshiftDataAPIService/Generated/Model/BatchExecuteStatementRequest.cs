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
    /// Container for the parameters to the BatchExecuteStatement operation.
    /// Runs one or more SQL statements, which can be data manipulation language (DML) or
    /// data definition language (DDL). Depending on the authorization method, use one of
    /// the following combinations of request parameters: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
    /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
    /// specified secret contains credentials to connect to the <c>database</c> you specify.
    /// When you are connecting to a cluster, you also supply the database name, If you provide
    /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
    /// stored in the secret. When you are connecting to a serverless workgroup, you also
    /// supply the database name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Temporary credentials - when connecting to your data warehouse, choose one of the
    /// following options:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When connecting to a serverless workgroup, specify the workgroup name and database
    /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
    /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
    /// operation is required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
    /// the database name. The database user name is derived from the IAM identity. For example,
    /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
    /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When connecting to a cluster as a database user, specify the cluster identifier, the
    /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
    /// operation is required.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For more information about the Amazon Redshift Data API and CLI usage examples, see
    /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
    /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
    /// </para>
    /// </summary>
    public partial class BatchExecuteStatementRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clientToken;
        private string _clusterIdentifier;
        private string _database;
        private string _dbUser;
        private ResultFormatString _resultFormat;
        private string _secretArn;
        private string _sessionId;
        private int? _sessionKeepAliveSeconds;
        private List<string> _sqls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _statementName;
        private bool? _withEvent;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This parameter is required when connecting to a cluster and
        /// authenticating using either Secrets Manager or temporary credentials. 
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
        /// The name of the database. This parameter is required when authenticating using either
        /// Secrets Manager or temporary credentials. 
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
        /// The database user name. This parameter is required when connecting to a cluster as
        /// a database user and authenticating using temporary credentials. 
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
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// The data format of the result of the SQL statement. If no format is specified, the
        /// default is JSON.
        /// </para>
        /// </summary>
        public ResultFormatString ResultFormat
        {
            get { return this._resultFormat; }
            set { this._resultFormat = value; }
        }

        // Check to see if ResultFormat property is set
        internal bool IsSetResultFormat()
        {
            return this._resultFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. This parameter
        /// is required when authenticating using Secrets Manager. 
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
        /// Gets and sets the property SessionKeepAliveSeconds. 
        /// <para>
        /// The number of seconds to keep the session alive after the query finishes. The maximum
        /// time a session can keep alive is 24 hours. After 24 hours, the session is forced closed
        /// and the query is terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=86400)]
        public int? SessionKeepAliveSeconds
        {
            get { return this._sessionKeepAliveSeconds; }
            set { this._sessionKeepAliveSeconds = value; }
        }

        // Check to see if SessionKeepAliveSeconds property is set
        internal bool IsSetSessionKeepAliveSeconds()
        {
            return this._sessionKeepAliveSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sqls. 
        /// <para>
        /// One or more SQL statements to run. <pre><c> The SQL statements are run as a single
        /// transaction. They run serially in the order of the array. Subsequent SQL statements
        /// don't start until the previous statement in the array completes. If any SQL statement
        /// fails, then because they are run as one transaction, all work is rolled back.&lt;/p&gt;
        /// </c></pre>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public List<string> Sqls
        {
            get { return this._sqls; }
            set { this._sqls = value; }
        }

        // Check to see if Sqls property is set
        internal bool IsSetSqls()
        {
            return this._sqls != null && (this._sqls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statements. You can name the SQL statements when you create them
        /// to identify the query. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatementName
        {
            get { return this._statementName; }
            set { this._statementName = value; }
        }

        // Check to see if StatementName property is set
        internal bool IsSetStatementName()
        {
            return this._statementName != null;
        }

        /// <summary>
        /// Gets and sets the property WithEvent. 
        /// <para>
        /// A value that indicates whether to send an event to the Amazon EventBridge event bus
        /// after the SQL statements run. 
        /// </para>
        /// </summary>
        public bool? WithEvent
        {
            get { return this._withEvent; }
            set { this._withEvent = value; }
        }

        // Check to see if WithEvent property is set
        internal bool IsSetWithEvent()
        {
            return this._withEvent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN). This parameter is required
        /// when connecting to a serverless workgroup and authenticating using either Secrets
        /// Manager or temporary credentials.
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