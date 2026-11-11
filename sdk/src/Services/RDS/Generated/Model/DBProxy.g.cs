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
        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// One or more data structures specifying the authorization mechanism to connect to the
        /// associated RDS DB instance or Aurora DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAuthConfigInfo> Auth { get; set; } = AWSConfigs.InitializeCollections ? new List<UserAuthConfigInfo>() : null;

        /// <summary>
        /// Checks to see if the Auth property is set.
        /// </summary>
        internal bool IsSetAuth() => this.Auth != null && (this.Auth.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the proxy was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DBProxyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the proxy.
        /// </para>
        /// </summary>
        public string DBProxyArn { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyArn property is set.
        /// </summary>
        internal bool IsSetDBProxyArn() => this.DBProxyArn != null;

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the proxy. This name must be unique for all proxies owned by your
        /// Amazon Web Services account in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DBProxyName { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyName property is set.
        /// </summary>
        internal bool IsSetDBProxyName() => this.DBProxyName != null;

        /// <summary>
        /// Gets and sets the property DebugLogging. 
        /// <para>
        /// Specifies whether the proxy logs detailed connection and query information. When you
        /// enable <c>DebugLogging</c>, the proxy captures connection details and connection pool
        /// behavior from your queries. Debug logging increases CloudWatch costs and can impact
        /// proxy performance. Enable this option only when you need to troubleshoot connection
        /// or performance issues.
        /// </para>
        /// </summary>
        public bool? DebugLogging { get; set; }

        /// <summary>
        /// Checks to see if the DebugLogging property is set.
        /// </summary>
        internal bool IsSetDebugLogging() => this.DebugLogging.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultAuthScheme. 
        /// <para>
        /// The default authentication scheme that the proxy uses for client connections to the
        /// proxy and connections from the proxy to the underlying database. Valid values are
        /// <c>NONE</c> and <c>IAM_AUTH</c>. When set to <c>IAM_AUTH</c>, the proxy uses end-to-end
        /// IAM authentication to connect to the database. 
        /// </para>
        /// </summary>
        public string DefaultAuthScheme { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAuthScheme property is set.
        /// </summary>
        internal bool IsSetDefaultAuthScheme() => this.DefaultAuthScheme != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that you can use to connect to the DB proxy. You include the endpoint
        /// value in the connection string for a database client application.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointNetworkType. 
        /// <para>
        /// The network type of the DB proxy endpoint. The network type determines the IP version
        /// that the proxy endpoint supports.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> - The proxy endpoint supports IPv4 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IPV6</c> - The proxy endpoint supports IPv6 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> - The proxy endpoint supports both IPv4 and IPv6.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointNetworkType EndpointNetworkType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointNetworkType property is set.
        /// </summary>
        internal bool IsSetEndpointNetworkType() => this.EndpointNetworkType != null;

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
        public string EngineFamily { get; set; }

        /// <summary>
        /// Checks to see if the EngineFamily property is set.
        /// </summary>
        internal bool IsSetEngineFamily() => this.EngineFamily != null;

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
        public int? IdleClientTimeout { get; set; }

        /// <summary>
        /// Checks to see if the IdleClientTimeout property is set.
        /// </summary>
        internal bool IsSetIdleClientTimeout() => this.IdleClientTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property RequireTLS. 
        /// <para>
        /// Indicates whether Transport Layer Security (TLS) encryption is required for connections
        /// to the proxy.
        /// </para>
        /// </summary>
        public bool? RequireTLS { get; set; }

        /// <summary>
        /// Checks to see if the RequireTLS property is set.
        /// </summary>
        internal bool IsSetRequireTLS() => this.RequireTLS.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that the proxy uses to access Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this proxy. A status of <c>available</c> means the proxy is
        /// ready to handle requests. Other values indicate that you must wait for the proxy to
        /// be ready, or take some action to resolve an issue.
        /// </para>
        /// </summary>
        public DBProxyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetConnectionNetworkType. 
        /// <para>
        /// The network type that the proxy uses to connect to the target database. The network
        /// type determines the IP version that the proxy uses for connections to the database.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> - The proxy connects to the database using IPv4 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IPV6</c> - The proxy connects to the database using IPv6 only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetConnectionNetworkType TargetConnectionNetworkType { get; set; }

        /// <summary>
        /// Checks to see if the TargetConnectionNetworkType property is set.
        /// </summary>
        internal bool IsSetTargetConnectionNetworkType() => this.TargetConnectionNetworkType != null;

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The date and time when the proxy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedDate property is set.
        /// </summary>
        internal bool IsSetUpdatedDate() => this.UpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VPC ID of the DB proxy.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// Provides a list of VPC security groups that the proxy belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// The EC2 subnet IDs for the proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSubnetIds property is set.
        /// </summary>
        internal bool IsSetVpcSubnetIds() => this.VpcSubnetIds != null && (this.VpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
