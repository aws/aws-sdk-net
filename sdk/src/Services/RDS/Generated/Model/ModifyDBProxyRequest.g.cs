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
    /// Container for the parameters to the ModifyDBProxy operation. Changes the settings
    /// for an existing DB proxy.
    /// </summary>
    public partial class ModifyDBProxyRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The new authentication settings for the <c>DBProxy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<UserAuthConfig> Auth { get; set; } = AWSConfigs.InitializeCollections ? new List<UserAuthConfig>() : null;

        /// <summary>
        /// Checks to see if the Auth property is set.
        /// </summary>
        internal bool IsSetAuth() => this.Auth != null && (this.Auth.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the <c>DBProxy</c> to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
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
        public DefaultAuthScheme DefaultAuthScheme { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAuthScheme property is set.
        /// </summary>
        internal bool IsSetDefaultAuthScheme() => this.DefaultAuthScheme != null;

        /// <summary>
        /// Gets and sets the property IdleClientTimeout. 
        /// <para>
        /// The number of seconds that a connection to the proxy can be inactive before the proxy
        /// disconnects it. You can set this value higher or lower than the connection timeout
        /// limit for the associated database.
        /// </para>
        /// </summary>
        public int? IdleClientTimeout { get; set; }

        /// <summary>
        /// Checks to see if the IdleClientTimeout property is set.
        /// </summary>
        internal bool IsSetIdleClientTimeout() => this.IdleClientTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property NewDBProxyName. 
        /// <para>
        /// The new identifier for the <c>DBProxy</c>. An identifier must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens; it can't end with a hyphen
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string NewDBProxyName { get; set; }

        /// <summary>
        /// Checks to see if the NewDBProxyName property is set.
        /// </summary>
        internal bool IsSetNewDBProxyName() => this.NewDBProxyName != null;

        /// <summary>
        /// Gets and sets the property RequireTLS. 
        /// <para>
        /// Whether Transport Layer Security (TLS) encryption is required for connections to the
        /// proxy. By enabling this setting, you can enforce encrypted TLS connections to the
        /// proxy, even if the associated database doesn't use TLS.
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
        /// The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets
        /// in Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The new list of security groups for the <c>DBProxy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
