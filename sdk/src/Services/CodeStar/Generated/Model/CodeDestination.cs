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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// The repository to be created in AWS CodeStar. Valid values are AWS CodeCommit or GitHub.
    /// After AWS CodeStar provisions the new repository, the source code files provided with
    /// the project request are placed in the repository.
    /// </summary>
    public partial class CodeDestination
    {
        private CodeCommitCodeDestination _codeCommit;
        private GitHubCodeDestination _gitHub;

        /// <summary>
        /// Gets and sets the property CodeCommit. 
        /// <para>
        /// Information about the AWS CodeCommit repository to be created in AWS CodeStar. This
        /// is where the source code files provided with the project request will be uploaded
        /// after project creation.
        /// </para>
        /// </summary>
        public CodeCommitCodeDestination CodeCommit
        {
            get { return this._codeCommit; }
            set { this._codeCommit = value; }
        }

        // Check to see if CodeCommit property is set
        internal bool IsSetCodeCommit()
        {
            return this._codeCommit != null;
        }

        /// <summary>
        /// Gets and sets the property GitHub. 
        /// <para>
        /// Information about the GitHub repository to be created in AWS CodeStar. This is where
        /// the source code files provided with the project request will be uploaded after project
        /// creation.
        /// </para>
        /// </summary>
        public GitHubCodeDestination GitHub
        {
            get { return this._gitHub; }
            set { this._gitHub = value; }
        }

        // Check to see if GitHub property is set
        internal bool IsSetGitHub()
        {
            return this._gitHub != null;
        }

    }
}