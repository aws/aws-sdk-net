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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Specifies the source code that is analyzed in a code review. A code review can analyze
    /// the source code that is specified using a pull request diff or a branch in an associated
    /// repository.
    /// </summary>
    public partial class SourceCodeType
    {
        private CommitDiffSourceCodeType _commitDiff;
        private RepositoryHeadSourceCodeType _repositoryHead;

        /// <summary>
        /// Gets and sets the property CommitDiff. 
        /// <para>
        ///  A <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">
        /// <code>SourceCodeType</code> </a> that specifies a commit diff created by a pull request
        /// on an associated repository. 
        /// </para>
        /// </summary>
        public CommitDiffSourceCodeType CommitDiff
        {
            get { return this._commitDiff; }
            set { this._commitDiff = value; }
        }

        // Check to see if CommitDiff property is set
        internal bool IsSetCommitDiff()
        {
            return this._commitDiff != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryHead.
        /// </summary>
        public RepositoryHeadSourceCodeType RepositoryHead
        {
            get { return this._repositoryHead; }
            set { this._repositoryHead = value; }
        }

        // Check to see if RepositoryHead property is set
        internal bool IsSetRepositoryHead()
        {
            return this._repositoryHead != null;
        }

    }
}