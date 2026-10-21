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
    /// Container for the parameters to the ImportBackendAuth operation. Imports an existing
    /// backend authentication resource.
    /// </summary>
    public partial class ImportBackendAuthRequest : AmazonAmplifyBackendRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackendEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the BackendEnvironmentName property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentName() => this.BackendEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito identity pool.
        /// </para>
        /// </summary>
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property NativeClientId. 
        /// <para>
        /// The ID of the Amazon Cognito native client.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NativeClientId { get; set; }

        /// <summary>
        /// Checks to see if the NativeClientId property is set.
        /// </summary>
        internal bool IsSetNativeClientId() => this.NativeClientId != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;

        /// <summary>
        /// Gets and sets the property WebClientId. 
        /// <para>
        /// The ID of the Amazon Cognito web client.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WebClientId { get; set; }

        /// <summary>
        /// Checks to see if the WebClientId property is set.
        /// </summary>
        internal bool IsSetWebClientId() => this.WebClientId != null;
    }
}
