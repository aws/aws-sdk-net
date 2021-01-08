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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBackendConfig operation.
    /// Updates the AWS resources that are required to access the Amplify Admin UI.
    /// </summary>
    public partial class UpdateBackendConfigRequest : AmazonAmplifyBackendRequest
    {
        private string _appId;
        private LoginAuthConfigReqObj _loginAuthConfig;

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
        /// Gets and sets the property LoginAuthConfig. 
        /// <para>
        /// Describes the Amazon Cognito configuration for Admin UI access.
        /// </para>
        /// </summary>
        public LoginAuthConfigReqObj LoginAuthConfig
        {
            get { return this._loginAuthConfig; }
            set { this._loginAuthConfig = value; }
        }

        // Check to see if LoginAuthConfig property is set
        internal bool IsSetLoginAuthConfig()
        {
            return this._loginAuthConfig != null;
        }

    }
}