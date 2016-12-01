/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build project's build input source code.
    /// </summary>
    public partial class ProjectSource
    {
        private SourceAuth _auth;
        private string _buildspec;
        private string _location;
        private SourceType _type;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// Information about the authorization settings for AWS CodeBuild to access the source
        /// code to be built.
        /// </para>
        ///  
        /// <para>
        /// This information is only for the AWS CodeBuild console's use. Your code should not
        /// get or set this information directly.
        /// </para>
        /// </summary>
        public SourceAuth Auth
        {
            get { return this._auth; }
            set { this._auth = value; }
        }

        // Check to see if Auth property is set
        internal bool IsSetAuth()
        {
            return this._auth != null;
        }

        /// <summary>
        /// Gets and sets the property Buildspec. 
        /// <para>
        /// The build spec declaration to use for this build project's related builds.
        /// </para>
        ///  
        /// <para>
        /// If this value is not specified, a build spec must be included along with the source
        /// code to be built.
        /// </para>
        /// </summary>
        public string Buildspec
        {
            get { return this._buildspec; }
            set { this._buildspec = value; }
        }

        // Check to see if Buildspec property is set
        internal bool IsSetBuildspec()
        {
            return this._buildspec != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location of the source code to be built. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For source code settings that are specified in the source action of a pipeline in
        /// AWS CodePipeline, <code>location</code> should not be specified. If it is specified,
        /// AWS CodePipeline will ignore it. This is because AWS CodePipeline uses the settings
        /// in a pipeline's source action instead of this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an AWS CodeCommit repository, the HTTPS clone URL to the repository
        /// that contains the source code and the build spec (for example, <code>https://git-codecommit.<i>region-ID</i>.amazonaws.com/v1/repos/<i>repo-name</i>
        /// </code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an Amazon Simple Storage Service (Amazon S3) input bucket, the
        /// path to the ZIP file that contains the source code (for example, <code> <i>bucket-name</i>/<i>path</i>/<i>to</i>/<i>object-name</i>.zip</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in a GitHub repository, the HTTPS clone URL, including the user name
        /// and personal access token, to the repository that contains the source code and the
        /// build spec (for example, <code>https://<i>login-user-name</i>:<i>personal-access-token</i>@github.com/<i>repo-owner-name</i>/<i>repo-name</i>.git</code>).
        /// For more information, see <a href="https://help.github.com/articles/creating-an-access-token-for-command-line-use/">Creating
        /// an Access Token for Command-Line Use</a> on the GitHub Help website.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of repository that contains the source code to be built. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CODECOMMIT</code>: The source code is in an AWS CodeCommit repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CODEPIPELINE</code>: The source code settings are specified in the source action
        /// of a pipeline in AWS CodePipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GITHUB</code>: The source code is in a GitHub repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code>: The source code is in an Amazon Simple Storage Service (Amazon S3)
        /// input bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}