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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// The type of a code review. There are two code review types:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>PullRequest</c> - A code review that is automatically triggered by a pull request
    /// on an associated repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RepositoryAnalysis</c> - A code review that analyzes all code under a specified
    /// branch in an associated repository. The associated repository is specified using its
    /// ARN in <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">CreateCodeReview</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CodeReviewType
    {
        private List<string> _analysisTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RepositoryAnalysis _repositoryAnalysis;

        /// <summary>
        /// Gets and sets the property AnalysisTypes. 
        /// <para>
        /// They types of analysis performed during a repository analysis or a pull request review.
        /// You can specify either <c>Security</c>, <c>CodeQuality</c>, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AnalysisTypes
        {
            get { return this._analysisTypes; }
            set { this._analysisTypes = value; }
        }

        // Check to see if AnalysisTypes property is set
        internal bool IsSetAnalysisTypes()
        {
            return this._analysisTypes != null && (this._analysisTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RepositoryAnalysis. 
        /// <para>
        /// A code review that analyzes all code under a specified branch in an associated repository.
        /// The associated repository is specified using its ARN in <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">CreateCodeReview</a>.
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