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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Defines the resource configuration when updating an authentication resource in your
    /// Amplify project.
    /// </summary>
    public partial class UpdateBackendAuthResourceConfig
    {
        private AuthResources _authResources;
        private UpdateBackendAuthIdentityPoolConfig _identityPoolConfigs;
        private Service _service;
        private UpdateBackendAuthUserPoolConfig _userPoolConfigs;

        /// <summary>
        /// Gets and sets the property AuthResources. 
        /// <para>
        /// Defines the service name to use when configuring an authentication resource in your
        /// Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthResources AuthResources
        {
            get { return this._authResources; }
            set { this._authResources = value; }
        }

        // Check to see if AuthResources property is set
        internal bool IsSetAuthResources()
        {
            return this._authResources != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolConfigs. 
        /// <para>
        /// Describes the authorization configuration for the Amazon Cognito identity pool, provisioned
        /// as a part of your auth resource in the Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthIdentityPoolConfig IdentityPoolConfigs
        {
            get { return this._identityPoolConfigs; }
            set { this._identityPoolConfigs = value; }
        }

        // Check to see if IdentityPoolConfigs property is set
        internal bool IsSetIdentityPoolConfigs()
        {
            return this._identityPoolConfigs != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Defines the service name to use when configuring an authentication resource in your
        /// Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Service Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolConfigs. 
        /// <para>
        /// Describes the authentication configuration for the Amazon Cognito user pool, provisioned
        /// as a part of your auth resource in the Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateBackendAuthUserPoolConfig UserPoolConfigs
        {
            get { return this._userPoolConfigs; }
            set { this._userPoolConfigs = value; }
        }

        // Check to see if UserPoolConfigs property is set
        internal bool IsSetUserPoolConfigs()
        {
            return this._userPoolConfigs != null;
        }

    }
}