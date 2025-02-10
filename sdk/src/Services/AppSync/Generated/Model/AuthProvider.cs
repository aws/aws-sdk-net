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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an authorization provider.
    /// </summary>
    public partial class AuthProvider
    {
        private AuthenticationType _authType;
        private CognitoConfig _cognitoConfig;
        private LambdaAuthorizerConfig _lambdaAuthorizerConfig;
        private OpenIDConnectConfig _openidConnectConfig;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property CognitoConfig. 
        /// <para>
        /// Describes an Amazon Cognito user pool configuration.
        /// </para>
        /// </summary>
        public CognitoConfig CognitoConfig
        {
            get { return this._cognitoConfig; }
            set { this._cognitoConfig = value; }
        }

        // Check to see if CognitoConfig property is set
        internal bool IsSetCognitoConfig()
        {
            return this._cognitoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig.
        /// </summary>
        public LambdaAuthorizerConfig LambdaAuthorizerConfig
        {
            get { return this._lambdaAuthorizerConfig; }
            set { this._lambdaAuthorizerConfig = value; }
        }

        // Check to see if LambdaAuthorizerConfig property is set
        internal bool IsSetLambdaAuthorizerConfig()
        {
            return this._lambdaAuthorizerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDConnectConfig.
        /// </summary>
        public OpenIDConnectConfig OpenIDConnectConfig
        {
            get { return this._openidConnectConfig; }
            set { this._openidConnectConfig = value; }
        }

        // Check to see if OpenIDConnectConfig property is set
        internal bool IsSetOpenIDConnectConfig()
        {
            return this._openidConnectConfig != null;
        }

    }
}