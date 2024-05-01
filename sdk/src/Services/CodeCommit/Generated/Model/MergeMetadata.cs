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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private bool? _isMerged;
        private string _mergeCommitId;
        private string _mergedBy;
        private MergeOptionTypeEnum _mergeOption;

        /// <summary>
        /// Gets and sets the property IsMerged. 
        /// <para>
        /// A Boolean value indicating whether the merge has been made.
        /// </para>
        /// </summary>
        public bool? IsMerged
        {
            get { return this._isMerged; }
            set { this._isMerged = value; }
        }

        // Check to see if IsMerged property is set
        internal bool IsSetIsMerged()
        {
            return this._isMerged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MergeCommitId. 
        /// <para>
        /// The commit ID for the merge commit, if any.
        /// </para>
        /// </summary>
        public string MergeCommitId
        {
            get { return this._mergeCommitId; }
            set { this._mergeCommitId = value; }
        }

        // Check to see if MergeCommitId property is set
        internal bool IsSetMergeCommitId()
        {
            return this._mergeCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property MergedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who merged the branches.
        /// </para>
        /// </summary>
        public string MergedBy
        {
            get { return this._mergedBy; }
            set { this._mergedBy = value; }
        }

        // Check to see if MergedBy property is set
        internal bool IsSetMergedBy()
        {
            return this._mergedBy != null;
        }

        /// <summary>
        /// Gets and sets the property MergeOption. 
        /// <para>
        /// The merge strategy used in the merge.
        /// </para>
        /// </summary>
        public MergeOptionTypeEnum MergeOption
        {
            get { return this._mergeOption; }
            set { this._mergeOption = value; }
        }

        // Check to see if MergeOption property is set
        internal bool IsSetMergeOption()
        {
            return this._mergeOption != null;
        }

    }
}