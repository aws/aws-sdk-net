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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the build input source code for this build project.
    /// </summary>
    public partial class AwsCodeBuildProjectSource
    {
        /// <summary>
        /// Gets and sets the property GitCloneDepth. 
        /// <para>
        /// Information about the Git clone depth for the build project.
        /// </para>
        /// </summary>
        public int? GitCloneDepth { get; set; }

        /// <summary>
        /// Checks to see if the GitCloneDepth property is set.
        /// </summary>
        internal bool IsSetGitCloneDepth() => this.GitCloneDepth.HasValue;

        /// <summary>
        /// Gets and sets the property InsecureSsl. 
        /// <para>
        /// Whether to ignore SSL warnings while connecting to the project source code.
        /// </para>
        /// </summary>
        public bool? InsecureSsl { get; set; }

        /// <summary>
        /// Checks to see if the InsecureSsl property is set.
        /// </summary>
        internal bool IsSetInsecureSsl() => this.InsecureSsl.HasValue;

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
        /// CodePipeline, location should not be specified. If it is specified, CodePipeline ignores
        /// it. This is because CodePipeline uses the settings in a pipeline's source action instead
        /// of this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an CodeCommit repository, the HTTPS clone URL to the repository
        /// that contains the source code and the build spec file (for example, <c>https://git-codecommit.region-ID.amazonaws.com/v1/repos/repo-name</c>
        /// ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an S3 input bucket, one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The path to the ZIP file that contains the source code (for example, <c>bucket-name/path/to/object-name.zip</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The path to the folder that contains the source code (for example, <c>bucket-name/path/to/source-code/folder/</c>).
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
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of repository that contains the source code to be built. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BITBUCKET</c> - The source code is in a Bitbucket repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CODECOMMIT</c> - The source code is in an CodeCommit repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CODEPIPELINE</c> - The source code settings are specified in the source action
        /// of a pipeline in CodePipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITHUB</c> - The source code is in a GitHub repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITHUB_ENTERPRISE</c> - The source code is in a GitHub Enterprise repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_SOURCE</c> - The project does not have input source code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> - The source code is in an S3 input bucket. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
