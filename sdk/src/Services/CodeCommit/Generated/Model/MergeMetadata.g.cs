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
    /// Returns information about a merge or potential merge between a source reference and
    /// a destination reference in a pull request.
    /// </summary>
    public partial class MergeMetadata
    {
        /// <summary>
        /// Gets and sets the property IsMerged. 
        /// <para>
        /// A Boolean value indicating whether the merge has been made.
        /// </para>
        /// </summary>
        public bool? IsMerged { get; set; }

        /// <summary>
        /// Checks to see if the IsMerged property is set.
        /// </summary>
        internal bool IsSetIsMerged() => this.IsMerged.HasValue;

        /// <summary>
        /// Gets and sets the property MergeCommitId. 
        /// <para>
        /// The commit ID for the merge commit, if any.
        /// </para>
        /// </summary>
        public string MergeCommitId { get; set; }

        /// <summary>
        /// Checks to see if the MergeCommitId property is set.
        /// </summary>
        internal bool IsSetMergeCommitId() => this.MergeCommitId != null;

        /// <summary>
        /// Gets and sets the property MergeOption. 
        /// <para>
        /// The merge strategy used in the merge.
        /// </para>
        /// </summary>
        public MergeOptionTypeEnum MergeOption { get; set; }

        /// <summary>
        /// Checks to see if the MergeOption property is set.
        /// </summary>
        internal bool IsSetMergeOption() => this.MergeOption != null;

        /// <summary>
        /// Gets and sets the property MergedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who merged the branches.
        /// </para>
        /// </summary>
        public string MergedBy { get; set; }

        /// <summary>
        /// Checks to see if the MergedBy property is set.
        /// </summary>
        internal bool IsSetMergedBy() => this.MergedBy != null;
    }
}
