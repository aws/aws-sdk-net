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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing the authentication configuration.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// A structure containing the authentication configuration.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt sensitive authentication
        /// information. This key is used to protect credentials and other sensitive data stored
        /// within the authentication configuration.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property OAuth2Properties. 
        /// <para>
        /// The properties for OAuth2 authentication.
        /// </para>
        /// </summary>
        public OAuth2Properties OAuth2Properties { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2Properties property is set.
        /// </summary>
        internal bool IsSetOAuth2Properties() => this.OAuth2Properties != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The secret manager ARN to store credentials.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;
    }
}
