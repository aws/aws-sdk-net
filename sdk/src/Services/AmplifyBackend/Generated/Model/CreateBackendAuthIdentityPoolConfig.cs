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
    /// Describes authorization configurations for the auth resources, configured as a part
    /// of your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthIdentityPoolConfig
    {
        private string _identityPoolName;
        private bool? _unauthenticatedLogin;

        /// <summary>
        /// Gets and sets the property IdentityPoolName. 
        /// <para>
        /// Name of the Amazon Cognito identity pool used for authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityPoolName
        {
            get { return this._identityPoolName; }
            set { this._identityPoolName = value; }
        }

        // Check to see if IdentityPoolName property is set
        internal bool IsSetIdentityPoolName()
        {
            return this._identityPoolName != null;
        }

        /// <summary>
        /// Gets and sets the property UnauthenticatedLogin. 
        /// <para>
        /// Set to true or false based on whether you want to enable guest authorization to your
        /// Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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