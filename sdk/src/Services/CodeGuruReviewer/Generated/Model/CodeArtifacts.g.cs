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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Code artifacts are source code artifacts and build artifacts used in a repository
    /// analysis or a pull request review.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Source code artifacts are source code files in a Git repository that are compressed
    /// into a .zip file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Build artifacts are .jar or .class files that are compressed in a .zip file.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CodeArtifacts
    {
        /// <summary>
        /// Gets and sets the property BuildArtifactsObjectKey. 
        /// <para>
        /// The S3 object key for a build artifacts .zip file that contains .jar or .class files.
        /// This is required for a code review with security analysis. For more information, see
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/working-with-cicd.html">Create
        /// code reviews with GitHub Actions</a> in the <i>Amazon CodeGuru Reviewer User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string BuildArtifactsObjectKey { get; set; }

        /// <summary>
        /// Checks to see if the BuildArtifactsObjectKey property is set.
        /// </summary>
        internal bool IsSetBuildArtifactsObjectKey() => this.BuildArtifactsObjectKey != null;

        /// <summary>
        /// Gets and sets the property SourceCodeArtifactsObjectKey. 
        /// <para>
        /// The S3 object key for a source code .zip file. This is required for all code reviews.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SourceCodeArtifactsObjectKey { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeArtifactsObjectKey property is set.
        /// </summary>
        internal bool IsSetSourceCodeArtifactsObjectKey() => this.SourceCodeArtifactsObjectKey != null;
    }
}
