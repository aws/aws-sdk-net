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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Defines the resource configuration when creating an auth resource in your Amplify
    /// project.
    /// </summary>
    public partial class CreateBackendAuthResourceConfig
    {
        /// <summary>
        /// Gets and sets the property AuthResources. 
        /// <para>
        /// Defines whether you want to configure only authentication or both authentication and
        /// authorization settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthResources AuthResources { get; set; }

        /// <summary>
        /// Checks to see if the AuthResources property is set.
        /// </summary>
        internal bool IsSetAuthResources() => this.AuthResources != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolConfigs. 
        /// <para>
        /// Describes the authorization configuration for the Amazon Cognito identity pool, provisioned
        /// as a part of your auth resource in the Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthIdentityPoolConfig IdentityPoolConfigs { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolConfigs property is set.
        /// </summary>
        internal bool IsSetIdentityPoolConfigs() => this.IdentityPoolConfigs != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Defines the service name to use when configuring an authentication resource in your
        /// Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Service Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property UserPoolConfigs. 
        /// <para>
        /// Describes authentication configuration for the Amazon Cognito user pool, provisioned
        /// as a part of your auth resource in the Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CreateBackendAuthUserPoolConfig UserPoolConfigs { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolConfigs property is set.
        /// </summary>
        internal bool IsSetUserPoolConfigs() => this.UserPoolConfigs != null;
    }
}
