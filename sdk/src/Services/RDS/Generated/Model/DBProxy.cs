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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The data structure representing a proxy managed by the RDS Proxy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBProxies</c> action.
    /// </para>
    /// </summary>
    public partial class DBProxy
    {
        private List<UserAuthConfigInfo> _auth = AWSConfigs.InitializeCollections ? new List<UserAuthConfigInfo>() : null;
        private DateTime? _createdDate;
        private string _dbProxyArn;
        private string _dbProxyName;
        private bool? _debugLogging;
        private string _endpoint;
        private string _engineFamily;
        private int? _idleClientTimeout;
        private bool? _requireTLS;
        private string _roleArn;
        private DBProxyStatus _status;
        private DateTime? _updatedDate;
        private string _vpcId;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// One or more data structures specifying the authorization mechanism to connect to the
        /// associated RDS DB instance or Aurora DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAuthConfigInfo> Auth
        {
            get { return this._auth; }
            set { this._auth = value; }
        }

        // Check to see if Auth property is set
        internal bool IsSetAuth()
        {
            return this._auth != null && (this._auth.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the proxy was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBProxyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the proxy.
        /// </para>
        /// </summary>
        public string DBProxyArn
        {
            get { return this._dbProxyArn; }
            set { this._dbProxyArn = value; }
        }

        // Check to see if DBProxyArn property is set
        internal bool IsSetDBProxyArn()
        {
            return this._dbProxyArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the proxy. This name must be unique for all proxies owned by your
        /// Amazon Web Services account in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DBProxyName
        {
            get { return this._dbProxyName; }
            set { this._dbProxyName = value; }
        }

        // Check to see if DBProxyName property is set
        internal bool IsSetDBProxyName()
        {
            return this._dbProxyName != null;
        }

        /// <summary>
        /// Gets and sets the property DebugLogging. 
        /// <para>
        /// Indicates whether the proxy includes detailed information about SQL statements in
        /// its logs. This information helps you to debug issues involving SQL behavior or the
        /// performance and scalability of the proxy connections. The debug information includes
        /// the text of SQL statements that you submit through the proxy. Thus, only enable this
        /// setting when needed for debugging, and only when you have security measures in place
        /// to safeguard any sensitive information that appears in the logs.
        /// </para>
        /// </summary>
        public bool? DebugLogging
        {
            get { return this._debugLogging; }
            set { this._debugLogging = value; }
        }

        // Check to see if DebugLogging property is set
        internal bool IsSetDebugLogging()
        {
            return this._debugLogging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that you can use to connect to the DB proxy. You include the endpoint
        /// value in the connection string for a database client application.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EngineFamily. 
        /// <para>
        /// The kinds of databases that the proxy can connect to. This value determines which
        /// database network protocol the proxy recognizes when it interprets network traffic
        /// to and from the database. <c>MYSQL</c> supports Aurora MySQL, RDS for MariaDB, and
        /// RDS for MySQL databases. <c>POSTGRESQL</c> supports Aurora PostgreSQL and RDS for
        /// PostgreSQL databases. <c>SQLSERVER</c> supports RDS for Microsoft SQL Server databases.
        /// </para>
        /// </summary>
        public string EngineFamily
        {
            get { return this._engineFamily; }
            set { this._engineFamily = value; }
        }

        // Check to see if EngineFamily property is set
        internal bool IsSetEngineFamily()
        {
            return this._engineFamily != null;
        }

        /// <summary>
        /// Gets and sets the property IdleClientTimeout. 
        /// <para>
        /// The number of seconds a connection to the proxy can have no activity before the proxy
        /// drops the client connection. The proxy keeps the underlying database connection open
        /// and puts it back into the connection pool for reuse by later connection requests.
        /// </para>
        ///  
        /// <para>
        /// Default: 1800 (30 minutes)
        /// </para>
        ///  
        /// <para>
        /// Constraints: 1 to 28,800
        /// </para>
        /// </summary>
        public int? IdleClientTimeout
        {
            get { return this._idleClientTimeout; }
            set { this._idleClientTimeout = value; }
        }

        // Check to see if IdleClientTimeout property is set
        internal bool IsSetIdleClientTimeout()
        {
            return this._idleClientTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireTLS. 
        /// <para>
        /// Indicates whether Transport Layer Security (TLS) encryption is required for connections
        /// to the proxy.
        /// </para>
        /// </summary>
        public bool? RequireTLS
        {
            get { return this._requireTLS; }
            set { this._requireTLS = value; }
        }

        // Check to see if RequireTLS property is set
        internal bool IsSetRequireTLS()
        {
            return this._requireTLS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that the proxy uses to access Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this proxy. A status of <c>available</c> means the proxy is
        /// ready to handle requests. Other values indicate that you must wait for the proxy to
        /// be ready, or take some action to resolve an issue.
        /// </para>
        /// </summary>
        public DBProxyStatus Status
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
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The date and time when the proxy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate
        {
            get { return this._updatedDate; }
            set { this._updatedDate = value; }
        }

        // Check to see if UpdatedDate property is set
        internal bool IsSetUpdatedDate()
        {
            return this._updatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VPC ID of the DB proxy.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// Provides a list of VPC security groups that the proxy belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// The EC2 subnet IDs for the proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSubnetIds
        {
            get { return this._vpcSubnetIds; }
            set { this._vpcSubnetIds = value; }
        }

        // Check to see if VpcSubnetIds property is set
        internal bool IsSetVpcSubnetIds()
        {
            return this._vpcSubnetIds != null && (this._vpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}