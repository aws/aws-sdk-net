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
    /// Returns the details of authentication used by a proxy to log in as a specific database
    /// user.
    /// </summary>
    public partial class UserAuthConfigInfo
    {
        private AuthScheme _authScheme;
        private ClientPasswordAuthType _clientPasswordAuthType;
        private string _description;
        private IAMAuthMode _iamAuth;
        private string _secretArn;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AuthScheme. 
        /// <para>
        /// The type of authentication that the proxy uses for connections from the proxy to the
        /// underlying database.
        /// </para>
        /// </summary>
        public AuthScheme AuthScheme
        {
            get { return this._authScheme; }
            set { this._authScheme = value; }
        }

        // Check to see if AuthScheme property is set
        internal bool IsSetAuthScheme()
        {
            return this._authScheme != null;
        }

        /// <summary>
        /// Gets and sets the property ClientPasswordAuthType. 
        /// <para>
        /// The type of authentication the proxy uses for connections from clients.
        /// </para>
        /// </summary>
        public ClientPasswordAuthType ClientPasswordAuthType
        {
            get { return this._clientPasswordAuthType; }
            set { this._clientPasswordAuthType = value; }
        }

        // Check to see if ClientPasswordAuthType property is set
        internal bool IsSetClientPasswordAuthType()
        {
            return this._clientPasswordAuthType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-specified description about the authentication used by a proxy to log in as
        /// a specific database user.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IAMAuth. 
        /// <para>
        /// Whether to require or disallow Amazon Web Services Identity and Access Management
        /// (IAM) authentication for connections to the proxy. The <code>ENABLED</code> value
        /// is valid only for proxies with RDS for Microsoft SQL Server.
        /// </para>
        /// </summary>
        public IAMAuthMode IAMAuth
        {
            get { return this._iamAuth; }
            set { this._iamAuth = value; }
        }

        // Check to see if IAMAuth property is set
        internal bool IsSetIAMAuth()
        {
            return this._iamAuth != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) representing the secret that the proxy uses to authenticate
        /// to the RDS DB instance or Aurora DB cluster. These secrets are stored within Amazon
        /// Secrets Manager.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the database user to which the proxy connects.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}