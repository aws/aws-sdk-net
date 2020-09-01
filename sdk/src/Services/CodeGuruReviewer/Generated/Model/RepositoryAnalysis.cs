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
    /// A code review type that analyzes all code under a specified branch in an associated
    /// respository. The assocated repository is specified using its ARN when you call <a
    /// href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">
    /// <code>CreateCodeReview</code> </a>.
    /// </summary>
    public partial class RepositoryAnalysis
    {
        private RepositoryHeadSourceCodeType _repositoryHead;

        /// <summary>
        /// Gets and sets the property RepositoryHead. 
        /// <para>
        ///  A <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">
        /// <code>SourceCodeType</code> </a> that specifies the tip of a branch in an associated
        /// repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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