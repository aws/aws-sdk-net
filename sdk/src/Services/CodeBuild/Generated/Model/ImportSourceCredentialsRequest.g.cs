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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ImportSourceCredentials operation. Imports the
    /// source repository credentials for an CodeBuild project that has its source code stored
    /// in a GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or Bitbucket repository.
    /// </summary>
    public partial class ImportSourceCredentialsRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        ///  The type of authentication used to connect to a GitHub, GitHub Enterprise, GitLab,
        /// GitLab Self Managed, or Bitbucket repository. An OAUTH connection is not supported
        /// by the API and must be created using the CodeBuild console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        ///  The source provider used for this project. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Checks to see if the ServerType property is set.
        /// </summary>
        internal bool IsSetServerType() => this.ServerType != null;

        /// <summary>
        /// Gets and sets the property ShouldOverwrite. 
        /// <para>
        ///  Set to <c>false</c> to prevent overwriting the repository source credentials. Set
        /// to <c>true</c> to overwrite the repository source credentials. The default value is
        /// <c>true</c>. 
        /// </para>
        /// </summary>
        public bool? ShouldOverwrite { get; set; }

        /// <summary>
        /// Checks to see if the ShouldOverwrite property is set.
        /// </summary>
        internal bool IsSetShouldOverwrite() => this.ShouldOverwrite.HasValue;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        ///  For GitHub or GitHub Enterprise, this is the personal access token. For Bitbucket,
        /// this is either the access token or the app password. For the <c>authType</c> CODECONNECTIONS,
        /// this is the <c>connectionArn</c>. For the <c>authType</c> SECRETS_MANAGER, this is
        /// the <c>secretArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        ///  The Bitbucket username when the <c>authType</c> is BASIC_AUTH. This parameter is
        /// not valid for other types of source providers or connections. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
