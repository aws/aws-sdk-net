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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private AuthenticationType _authenticationType;
        private BasicAuthenticationCredentials _basicAuthenticationCredentials;
        private Dictionary<string, string> _customAuthenticationCredentials = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _kmsKeyArn;
        private OAuth2Properties _oAuth2Properties;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type of a connection.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthenticationCredentials. 
        /// <para>
        /// The basic authentication credentials of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public BasicAuthenticationCredentials BasicAuthenticationCredentials
        {
            get { return this._basicAuthenticationCredentials; }
            set { this._basicAuthenticationCredentials = value; }
        }

        // Check to see if BasicAuthenticationCredentials property is set
        internal bool IsSetBasicAuthenticationCredentials()
        {
            return this._basicAuthenticationCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAuthenticationCredentials. 
        /// <para>
        /// The custom authentication credentials of a connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> CustomAuthenticationCredentials
        {
            get { return this._customAuthenticationCredentials; }
            set { this._customAuthenticationCredentials = value; }
        }

        // Check to see if CustomAuthenticationCredentials property is set
        internal bool IsSetCustomAuthenticationCredentials()
        {
            return this._customAuthenticationCredentials != null && (this._customAuthenticationCredentials.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The KMS key ARN of a connection.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2Properties. 
        /// <para>
        /// The oAuth2 properties of a connection.
        /// </para>
        /// </summary>
        public OAuth2Properties OAuth2Properties
        {
            get { return this._oAuth2Properties; }
            set { this._oAuth2Properties = value; }
        }

        // Check to see if OAuth2Properties property is set
        internal bool IsSetOAuth2Properties()
        {
            return this._oAuth2Properties != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The secret ARN of a connection.
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

    }
}