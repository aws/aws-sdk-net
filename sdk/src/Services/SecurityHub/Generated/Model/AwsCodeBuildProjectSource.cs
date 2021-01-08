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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the build input source code for this build project.
    /// </summary>
    public partial class AwsCodeBuildProjectSource
    {
        private int? _gitCloneDepth;
        private bool? _insecureSsl;
        private string _location;
        private string _type;

        /// <summary>
        /// Gets and sets the property GitCloneDepth. 
        /// <para>
        /// Information about the Git clone depth for the build project.
        /// </para>
        /// </summary>
        public int GitCloneDepth
        {
            get { return this._gitCloneDepth.GetValueOrDefault(); }
            set { this._gitCloneDepth = value; }
        }

        // Check to see if GitCloneDepth property is set
        internal bool IsSetGitCloneDepth()
        {
            return this._gitCloneDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InsecureSsl. 
        /// <para>
        /// Whether to ignore SSL warnings while connecting to the project source code.
        /// </para>
        /// </summary>
        public bool InsecureSsl
        {
            get { return this._insecureSsl.GetValueOrDefault(); }
            set { this._insecureSsl = value; }
        }

        // Check to see if InsecureSsl property is set
        internal bool IsSetInsecureSsl()
        {
            return this._insecureSsl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location of the source code to be built.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For source code settings that are specified in the source action of a pipeline in
        /// AWS CodePipeline, location should not be specified. If it is specified, AWS CodePipeline
        /// ignores it. This is because AWS CodePipeline uses the settings in a pipeline's source
        /// action instead of this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an AWS CodeCommit repository, the HTTPS clone URL to the repository
        /// that contains the source code and the build spec file (for example, <code>https://git-codecommit.region-ID.amazonaws.com/v1/repos/repo-name</code>
        /// ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an S3 input bucket, one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The path to the ZIP file that contains the source code (for example, <code>bucket-name/path/to/object-name.zip</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The path to the folder that contains the source code (for example, <code>bucket-name/path/to/source-code/folder/</code>).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For source code in a GitHub repository, the HTTPS clone URL to the repository that
        /// contains the source and the build spec file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in a Bitbucket repository, the HTTPS clone URL to the repository that
        /// contains the source and the build spec file. 
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
        /// The type of repository that contains the source code to be built. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BITBUCKET</code> - The source code is in a Bitbucket repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CODECOMMIT</code> - The source code is in an AWS CodeCommit repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CODEPIPELINE</code> - The source code settings are specified in the source
        /// action of a pipeline in AWS CodePipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GITHUB</code> - The source code is in a GitHub repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GITHUB_ENTERPRISE</code> - The source code is in a GitHub Enterprise repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_SOURCE</code> - The project does not have input source code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code> - The source code is in an S3 input bucket. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
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