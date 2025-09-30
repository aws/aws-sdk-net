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
    /// Container for the parameters to the CreateDBProxy operation.
    /// Creates a new DB proxy.
    /// </summary>
    public partial class CreateDBProxyRequest : AmazonRDSRequest
    {
        private List<UserAuthConfig> _auth = AWSConfigs.InitializeCollections ? new List<UserAuthConfig>() : null;
        private string _dbProxyName;
        private bool? _debugLogging;
        private DefaultAuthScheme _defaultAuthScheme;
        private EndpointNetworkType _endpointNetworkType;
        private EngineFamily _engineFamily;
        private int? _idleClientTimeout;
        private bool? _requireTLS;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TargetConnectionNetworkType _targetConnectionNetworkType;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The authorization mechanism that the proxy uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<UserAuthConfig> Auth
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
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the proxy. This name must be unique for all proxies owned by your
        /// Amazon Web Services account in the specified Amazon Web Services Region. An identifier
        /// must begin with a letter and must contain only ASCII letters, digits, and hyphens;
        /// it can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Specifies whether the proxy logs detailed connection and query information. When you
        /// enable <c>DebugLogging</c>, the proxy captures connection details and connection pool
        /// behavior from your queries. Debug logging increases CloudWatch costs and can impact
        /// proxy performance. Enable this option only when you need to troubleshoot connection
        /// or performance issues.
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
        /// Gets and sets the property DefaultAuthScheme. 
        /// <para>
        /// The default authentication scheme that the proxy uses for client connections to the
        /// proxy and connections from the proxy to the underlying database. Valid values are
        /// <c>NONE</c> and <c>IAM_AUTH</c>. When set to <c>IAM_AUTH</c>, the proxy uses end-to-end
        /// IAM authentication to connect to the database. If you don't specify <c>DefaultAuthScheme</c>
        /// or specify this parameter as <c>NONE</c>, you must specify the <c>Auth</c> option.
        /// </para>
        /// </summary>
        public DefaultAuthScheme DefaultAuthScheme
        {
            get { return this._defaultAuthScheme; }
            set { this._defaultAuthScheme = value; }
        }

        // Check to see if DefaultAuthScheme property is set
        internal bool IsSetDefaultAuthScheme()
        {
            return this._defaultAuthScheme != null;
        }

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
        /// <para>
        /// Default: <c>IPV4</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>IPV6</c> or <c>DUAL</c>, the VPC and all subnets must have an IPv6
        /// CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>IPV6</c> or <c>DUAL</c>, the VPC tenancy cannot be <c>dedicated</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointNetworkType EndpointNetworkType
        {
            get { return this._endpointNetworkType; }
            set { this._endpointNetworkType = value; }
        }

        // Check to see if EndpointNetworkType property is set
        internal bool IsSetEndpointNetworkType()
        {
            return this._endpointNetworkType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineFamily. 
        /// <para>
        /// The kinds of databases that the proxy can connect to. This value determines which
        /// database network protocol the proxy recognizes when it interprets network traffic
        /// to and from the database. For Aurora MySQL, RDS for MariaDB, and RDS for MySQL databases,
        /// specify <c>MYSQL</c>. For Aurora PostgreSQL and RDS for PostgreSQL databases, specify
        /// <c>POSTGRESQL</c>. For RDS for Microsoft SQL Server, specify <c>SQLSERVER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngineFamily EngineFamily
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
        /// The number of seconds that a connection to the proxy can be inactive before the proxy
        /// disconnects it. You can set this value higher or lower than the connection timeout
        /// limit for the associated database.
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
        /// Specifies whether Transport Layer Security (TLS) encryption is required for connections
        /// to the proxy. By enabling this setting, you can enforce encrypted TLS connections
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
        /// The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets
        /// in Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional set of key-value pairs to associate arbitrary data of your choosing with
        /// the proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// <para>
        /// Default: <c>IPV4</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>IPV6</c>, the database must support dual-stack mode. RDS doesn't
        /// support IPv6-only databases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All targets registered with the proxy must be compatible with the specified network
        /// type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetConnectionNetworkType TargetConnectionNetworkType
        {
            get { return this._targetConnectionNetworkType; }
            set { this._targetConnectionNetworkType = value; }
        }

        // Check to see if TargetConnectionNetworkType property is set
        internal bool IsSetTargetConnectionNetworkType()
        {
            return this._targetConnectionNetworkType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// One or more VPC security group IDs to associate with the new proxy.
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
        /// One or more VPC subnet IDs to associate with the new proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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