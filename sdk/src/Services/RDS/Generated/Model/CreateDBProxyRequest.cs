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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBProxy operation.
    /// Creates a new DB proxy.
    /// </summary>
    public partial class CreateDBProxyRequest : AmazonRDSRequest
    {
        private List<UserAuthConfig> _auth = new List<UserAuthConfig>();
        private string _dbProxyName;
        private bool? _debugLogging;
        private EngineFamily _engineFamily;
        private int? _idleClientTimeout;
        private bool? _requireTLS;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _vpcSecurityGroupIds = new List<string>();
        private List<string> _vpcSubnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The authorization mechanism that the proxy uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UserAuthConfig> Auth
        {
            get { return this._auth; }
            set { this._auth = value; }
        }

        // Check to see if Auth property is set
        internal bool IsSetAuth()
        {
            return this._auth != null && this._auth.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the proxy. This name must be unique for all proxies owned by your
        /// AWS account in the specified AWS Region. An identifier must begin with a letter and
        /// must contain only ASCII letters, digits, and hyphens; it can't end with a hyphen or
        /// contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Whether the proxy includes detailed information about SQL statements in its logs.
        /// This information helps you to debug issues involving SQL behavior or the performance
        /// and scalability of the proxy connections. The debug information includes the text
        /// of SQL statements that you submit through the proxy. Thus, only enable this setting
        /// when needed for debugging, and only when you have security measures in place to safeguard
        /// any sensitive information that appears in the logs.
        /// </para>
        /// </summary>
        public bool DebugLogging
        {
            get { return this._debugLogging.GetValueOrDefault(); }
            set { this._debugLogging = value; }
        }

        // Check to see if DebugLogging property is set
        internal bool IsSetDebugLogging()
        {
            return this._debugLogging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineFamily. 
        /// <para>
        /// The kinds of databases that the proxy can connect to. This value determines which
        /// database network protocol the proxy recognizes when it interprets network traffic
        /// to and from the database. The engine family applies to MySQL and PostgreSQL for both
        /// RDS and Aurora.
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
        public int IdleClientTimeout
        {
            get { return this._idleClientTimeout.GetValueOrDefault(); }
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
        /// A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption
        /// is required for connections to the proxy. By enabling this setting, you can enforce
        /// encrypted TLS connections to the proxy.
        /// </para>
        /// </summary>
        public bool RequireTLS
        {
            get { return this._requireTLS.GetValueOrDefault(); }
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
        /// in AWS Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// One or more VPC security group IDs to associate with the new proxy.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// One or more VPC subnet IDs to associate with the new proxy.
        /// </para>
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
            return this._vpcSubnetIds != null && this._vpcSubnetIds.Count > 0; 
        }

    }
}