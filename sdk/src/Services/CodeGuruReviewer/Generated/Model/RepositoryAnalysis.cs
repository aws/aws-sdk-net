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
    /// A code review type that analyzes all code under a specified branch in an associated
    /// repository. The associated repository is specified using its ARN when you call <a
    /// href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CreateCodeReview">CreateCodeReview</a>.
    /// </summary>
    public partial class RepositoryAnalysis
    {
        private RepositoryHeadSourceCodeType _repositoryHead;
        private SourceCodeType _sourceCodeType;

        /// <summary>
        /// Gets and sets the property RepositoryHead. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// that specifies the tip of a branch in an associated repository.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property SourceCodeType.
        /// </summary>
        public SourceCodeType SourceCodeType
        {
            get { return this._sourceCodeType; }
            set { this._sourceCodeType = value; }
        }

        // Check to see if SourceCodeType property is set
        internal bool IsSetSourceCodeType()
        {
            return this._sourceCodeType != null;
        }

    }
}