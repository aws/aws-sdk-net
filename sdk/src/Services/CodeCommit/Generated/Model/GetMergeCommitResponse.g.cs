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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetMergeCommit operation.
    /// </summary>
    public partial class GetMergeCommitResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaseCommitId. 
        /// <para>
        /// The commit ID of the merge base.
        /// </para>
        /// </summary>
        public string BaseCommitId { get; set; }

        /// <summary>
        /// Checks to see if the BaseCommitId property is set.
        /// </summary>
        internal bool IsSetBaseCommitId() => this.BaseCommitId != null;

        /// <summary>
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the destination commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        public string DestinationCommitId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommitId property is set.
        /// </summary>
        internal bool IsSetDestinationCommitId() => this.DestinationCommitId != null;

        /// <summary>
        /// Gets and sets the property MergedCommitId. 
        /// <para>
        /// The commit ID for the merge commit created when the source branch was merged into
        /// the destination branch. If the fast-forward merge strategy was used, there is no merge
        /// commit.
        /// </para>
        /// </summary>
        public string MergedCommitId { get; set; }

        /// <summary>
        /// Checks to see if the MergedCommitId property is set.
        /// </summary>
        internal bool IsSetMergedCommitId() => this.MergedCommitId != null;

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID of the source commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        public string SourceCommitId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitId property is set.
        /// </summary>
        internal bool IsSetSourceCommitId() => this.SourceCommitId != null;
    }
}
