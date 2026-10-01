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
    /// A type of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
    /// that specifies the commit diff for a pull request on an associated repository. The
    /// <c>SourceCommit</c> and <c>DestinationCommit</c> fields are required to do a pull
    /// request code review.
    /// </summary>
    public partial class CommitDiffSourceCodeType
    {
        /// <summary>
        /// Gets and sets the property DestinationCommit. 
        /// <para>
        /// The SHA of the destination commit used to generate a commit diff. This field is required
        /// for a pull request code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string DestinationCommit { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommit property is set.
        /// </summary>
        internal bool IsSetDestinationCommit() => this.DestinationCommit != null;

        /// <summary>
        /// Gets and sets the property MergeBaseCommit. 
        /// <para>
        /// The SHA of the merge base of a commit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string MergeBaseCommit { get; set; }

        /// <summary>
        /// Checks to see if the MergeBaseCommit property is set.
        /// </summary>
        internal bool IsSetMergeBaseCommit() => this.MergeBaseCommit != null;

        /// <summary>
        /// Gets and sets the property SourceCommit. 
        /// <para>
        /// The SHA of the source commit used to generate a commit diff. This field is required
        /// for a pull request code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string SourceCommit { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommit property is set.
        /// </summary>
        internal bool IsSetSourceCommit() => this.SourceCommit != null;
    }
}
