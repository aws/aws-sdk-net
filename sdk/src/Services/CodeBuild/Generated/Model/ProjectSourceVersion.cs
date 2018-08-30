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
    /// A source identifier and its corresponding version.
    /// </summary>
    public partial class ProjectSourceVersion
    {
        private string _sourceIdentifier;
        private string _sourceVersion;

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// An identifier for a source in the build project.
        /// </para>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The source version for the corresponding source identifier. If specified, must be
        /// one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For AWS CodeCommit: the commit ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <code>pr/pull-request-ID</code> (for example <code>pr/25</code>).
        /// If a branch name is specified, the branch's HEAD commit ID will be used. If not specified,
        /// the default branch's HEAD commit ID will be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID will be used. If not specified, the default branch's HEAD commit ID
        /// will be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Simple Storage Service (Amazon S3): the version ID of the object representing
        /// the build input ZIP file to use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

    }
}