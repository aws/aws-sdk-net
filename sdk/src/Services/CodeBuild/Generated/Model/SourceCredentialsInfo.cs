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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the credentials for a GitHub, GitHub Enterprise, GitLab, GitLab
    /// Self Managed, or Bitbucket repository.
    /// </summary>
    public partial class SourceCredentialsInfo
    {
        private string _arn;
        private AuthType _authType;
        private string _resource;
        private ServerType _serverType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        ///  The type of authentication used by the credentials. Valid options are OAUTH, BASIC_AUTH,
        /// PERSONAL_ACCESS_TOKEN, CODECONNECTIONS, or SECRETS_MANAGER. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// The connection ARN if your authType is CODECONNECTIONS or SECRETS_MANAGER.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        ///  The type of source provider. The valid options are GITHUB, GITHUB_ENTERPRISE, GITLAB,
        /// GITLAB_SELF_MANAGED, or BITBUCKET. 
        /// </para>
        /// </summary>
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

    }
}