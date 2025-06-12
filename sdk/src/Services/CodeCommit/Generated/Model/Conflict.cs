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
    /// Information about conflicts in a merge operation.
    /// </summary>
    public partial class Conflict
    {
        private ConflictMetadata _conflictMetadata;
        private List<MergeHunk> _mergeHunks = AWSConfigs.InitializeCollections ? new List<MergeHunk>() : null;

        /// <summary>
        /// Gets and sets the property ConflictMetadata. 
        /// <para>
        /// Metadata about a conflict in a merge operation.
        /// </para>
        /// </summary>
        public ConflictMetadata ConflictMetadata
        {
            get { return this._conflictMetadata; }
            set { this._conflictMetadata = value; }
        }

        // Check to see if ConflictMetadata property is set
        internal bool IsSetConflictMetadata()
        {
            return this._conflictMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property MergeHunks. 
        /// <para>
        /// A list of hunks that contain the differences between files or lines causing the conflict.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MergeHunk> MergeHunks
        {
            get { return this._mergeHunks; }
            set { this._mergeHunks = value; }
        }

        // Check to see if MergeHunks property is set
        internal bool IsSetMergeHunks()
        {
            return this._mergeHunks != null && (this._mergeHunks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}