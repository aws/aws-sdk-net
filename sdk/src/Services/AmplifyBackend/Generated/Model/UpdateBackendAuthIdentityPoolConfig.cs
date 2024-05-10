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
    /// Describes the authorization configuration for the Amazon Cognito identity pool, provisioned
    /// as a part of your auth resource in the Amplify project.
    /// </summary>
    public partial class UpdateBackendAuthIdentityPoolConfig
    {
        private bool? _unauthenticatedLogin;

        /// <summary>
        /// Gets and sets the property UnauthenticatedLogin. 
        /// <para>
        /// A boolean value that can be set to allow or disallow guest-level authorization into
        /// your Amplify app.
        /// </para>
        /// </summary>
        public bool? UnauthenticatedLogin
        {
            get { return this._unauthenticatedLogin; }
            set { this._unauthenticatedLogin = value; }
        }

        // Check to see if UnauthenticatedLogin property is set
        internal bool IsSetUnauthenticatedLogin()
        {
            return this._unauthenticatedLogin.HasValue; 
        }

    }
}