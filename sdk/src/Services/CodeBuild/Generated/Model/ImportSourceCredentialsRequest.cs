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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ImportSourceCredentials operation.
    /// Imports the source repository credentials for an CodeBuild project that has its source
    /// code stored in a GitHub, GitHub Enterprise, or Bitbucket repository.
    /// </summary>
    public partial class ImportSourceCredentialsRequest : AmazonCodeBuildRequest
    {
        private AuthType _authType;
        private ServerType _serverType;
        private bool? _shouldOverwrite;
        private string _token;
        private string _username;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        ///  The type of authentication used to connect to a GitHub, GitHub Enterprise, or Bitbucket
        /// repository. An OAUTH connection is not supported by the API and must be created using
        /// the CodeBuild console. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthType AuthType
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
        /// Gets and sets the property ServerType. 
        /// <para>
        ///  The source provider used for this project. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerType ServerType
        {
            get { return this._serverType; }
            set { this._serverType = value; }
        }

        // Check to see if ServerType property is set
        internal bool IsSetServerType()
        {
            return this._serverType != null;
        }

        /// <summary>
        /// Gets and sets the property ShouldOverwrite. 
        /// <para>
        ///  Set to <code>false</code> to prevent overwriting the repository source credentials.
        /// Set to <code>true</code> to overwrite the repository source credentials. The default
        /// value is <code>true</code>. 
        /// </para>
        /// </summary>
        public bool ShouldOverwrite
        {
            get { return this._shouldOverwrite.GetValueOrDefault(); }
            set { this._shouldOverwrite = value; }
        }

        // Check to see if ShouldOverwrite property is set
        internal bool IsSetShouldOverwrite()
        {
            return this._shouldOverwrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        ///  For GitHub or GitHub Enterprise, this is the personal access token. For Bitbucket,
        /// this is the app password. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        ///  The Bitbucket username when the <code>authType</code> is BASIC_AUTH. This parameter
        /// is not valid for other types of source providers or connections. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}