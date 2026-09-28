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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The authentication configuration of a connection.
    /// </summary>
    public partial class AuthenticationConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type of a connection.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property BasicAuthenticationCredentials. 
        /// <para>
        /// The basic authentication credentials of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public BasicAuthenticationCredentials BasicAuthenticationCredentials { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthenticationCredentials property is set.
        /// </summary>
        internal bool IsSetBasicAuthenticationCredentials() => this.BasicAuthenticationCredentials != null;

        /// <summary>
        /// Gets and sets the property CustomAuthenticationCredentials. 
        /// <para>
        /// The custom authentication credentials of a connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> CustomAuthenticationCredentials { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomAuthenticationCredentials property is set.
        /// </summary>
        internal bool IsSetCustomAuthenticationCredentials() => this.CustomAuthenticationCredentials != null && (this.CustomAuthenticationCredentials.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The KMS key ARN of a connection.
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
        /// The oAuth2 properties of a connection.
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
        /// The secret ARN of a connection.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;
    }
}
