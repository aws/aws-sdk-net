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
    /// Container for the parameters to the ImportBackendAuth operation.
    /// Imports an existing backend authentication resource.
    /// </summary>
    public partial class ImportBackendAuthRequest : AmazonAmplifyBackendRequest
    {
        private string _appId;
        private string _backendEnvironmentName;
        private string _identityPoolId;
        private string _nativeClientId;
        private string _userPoolId;
        private string _webClientId;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackendEnvironmentName
        {
            get { return this._backendEnvironmentName; }
            set { this._backendEnvironmentName = value; }
        }

        // Check to see if BackendEnvironmentName property is set
        internal bool IsSetBackendEnvironmentName()
        {
            return this._backendEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito identity pool.
        /// </para>
        /// </summary>
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property NativeClientId. 
        /// <para>
        /// The ID of the Amazon Cognito native client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NativeClientId
        {
            get { return this._nativeClientId; }
            set { this._nativeClientId = value; }
        }

        // Check to see if NativeClientId property is set
        internal bool IsSetNativeClientId()
        {
            return this._nativeClientId != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property WebClientId. 
        /// <para>
        /// The ID of the Amazon Cognito web client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WebClientId
        {
            get { return this._webClientId; }
            set { this._webClientId = value; }
        }

        // Check to see if WebClientId property is set
        internal bool IsSetWebClientId()
        {
            return this._webClientId != null;
        }

    }
}