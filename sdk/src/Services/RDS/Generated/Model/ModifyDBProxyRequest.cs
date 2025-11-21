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
    /// Container for the parameters to the ModifyDBProxy operation.
    /// Changes the settings for an existing DB proxy.
    /// </summary>
    public partial class ModifyDBProxyRequest : AmazonRDSRequest
    {
        private List<UserAuthConfig> _auth = AWSConfigs.InitializeCollections ? new List<UserAuthConfig>() : null;
        private string _dbProxyName;
        private bool? _debugLogging;
        private DefaultAuthScheme _defaultAuthScheme;
        private int? _idleClientTimeout;
        private string _newDBProxyName;
        private bool? _requireTLS;
        private string _roleArn;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The new authentication settings for the <c>DBProxy</c>.
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
        /// The identifier for the <c>DBProxy</c> to modify.
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
        /// IAM authentication to connect to the database.
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
        /// Gets and sets the property NewDBProxyName. 
        /// <para>
        /// The new identifier for the <c>DBProxy</c>. An identifier must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens; it can't end with a hyphen
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NewDBProxyName
        {
            get { return this._newDBProxyName; }
            set { this._newDBProxyName = value; }
        }

        // Check to see if NewDBProxyName property is set
        internal bool IsSetNewDBProxyName()
        {
            return this._newDBProxyName != null;
        }

        /// <summary>
        /// Gets and sets the property RequireTLS. 
        /// <para>
        /// Whether Transport Layer Security (TLS) encryption is required for connections to the
        /// proxy. By enabling this setting, you can enforce encrypted TLS connections to the
        /// proxy, even if the associated database doesn't use TLS.
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
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The new list of security groups for the <c>DBProxy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}