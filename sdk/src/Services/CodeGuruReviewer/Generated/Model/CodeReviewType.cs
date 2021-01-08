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
    /// The type of a code review. There are two code review types: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>PullRequest</code> - A code review that is automatically triggered by a pull
    /// request on an assocaited repository. Because this type of code review is automatically
    /// generated, you cannot specify this code review type using <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">
    /// <code>CreateCodeReview</code> </a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RepositoryAnalysis</code> - A code review that analyzes all code under a specified
    /// branch in an associated respository. The assocated repository is specified using its
    /// ARN in <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">
    /// <code>CreateCodeReview</code> </a>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CodeReviewType
    {
        private RepositoryAnalysis _repositoryAnalysis;

        /// <summary>
        /// Gets and sets the property RepositoryAnalysis. 
        /// <para>
        ///  A code review that analyzes all code under a specified branch in an associated respository.
        /// The assocated repository is specified using its ARN in <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">
        /// <code>CreateCodeReview</code> </a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryAnalysis RepositoryAnalysis
        {
            get { return this._repositoryAnalysis; }
            set { this._repositoryAnalysis = value; }
        }

        // Check to see if RepositoryAnalysis property is set
        internal bool IsSetRepositoryAnalysis()
        {
            return this._repositoryAnalysis != null;
        }

    }
}