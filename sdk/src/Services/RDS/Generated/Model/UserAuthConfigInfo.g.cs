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
    /// Returns the details of authentication used by a proxy to log in as a specific database
    /// user.
    /// </summary>
    public partial class UserAuthConfigInfo
    {
        /// <summary>
        /// Gets and sets the property AuthScheme. 
        /// <para>
        /// The type of authentication that the proxy uses for connections from the proxy to the
        /// underlying database.
        /// </para>
        /// </summary>
        public AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Checks to see if the AuthScheme property is set.
        /// </summary>
        internal bool IsSetAuthScheme() => this.AuthScheme != null;

        /// <summary>
        /// Gets and sets the property ClientPasswordAuthType. 
        /// <para>
        /// The type of authentication the proxy uses for connections from clients.
        /// </para>
        /// </summary>
        public ClientPasswordAuthType ClientPasswordAuthType { get; set; }

        /// <summary>
        /// Checks to see if the ClientPasswordAuthType property is set.
        /// </summary>
        internal bool IsSetClientPasswordAuthType() => this.ClientPasswordAuthType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-specified description about the authentication used by a proxy to log in as
        /// a specific database user.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IAMAuth. 
        /// <para>
        /// Whether to require or disallow Amazon Web Services Identity and Access Management
        /// (IAM) authentication for connections to the proxy. 
        /// </para>
        /// </summary>
        public IAMAuthMode IAMAuth { get; set; }

        /// <summary>
        /// Checks to see if the IAMAuth property is set.
        /// </summary>
        internal bool IsSetIAMAuth() => this.IAMAuth != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) representing the secret that the proxy uses to authenticate
        /// to the RDS DB instance or Aurora DB cluster. These secrets are stored within Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the database user to which the proxy connects.
        /// </para>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
