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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the DescribeMergeConflicts operation.
    /// </summary>
    public partial class DescribeMergeConflictsResponse : AmazonWebServiceResponse
    {
        private string _baseCommitId;
        private ConflictMetadata _conflictMetadata;
        private string _destinationCommitId;
        private List<MergeHunk> _mergeHunks = new List<MergeHunk>();
        private string _nextToken;
        private string _sourceCommitId;

        /// <summary>
        /// Gets and sets the property BaseCommitId. 
        /// <para>
        /// The commit ID of the merge base.
        /// </para>
        /// </summary>
        public string BaseCommitId
        {
            get { return this._baseCommitId; }
            set { this._baseCommitId = value; }
        }

        // Check to see if BaseCommitId property is set
        internal bool IsSetBaseCommitId()
        {
            return this._baseCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictMetadata. 
        /// <para>
        /// Contains metadata about the conflicts found in the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the destination commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationCommitId
        {
            get { return this._destinationCommitId; }
            set { this._destinationCommitId = value; }
        }

        // Check to see if DestinationCommitId property is set
        internal bool IsSetDestinationCommitId()
        {
            return this._destinationCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property MergeHunks. 
        /// <para>
        /// A list of merge hunks of the differences between the files or lines.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MergeHunk> MergeHunks
        {
            get { return this._mergeHunks; }
            set { this._mergeHunks = value; }
        }

        // Check to see if MergeHunks property is set
        internal bool IsSetMergeHunks()
        {
            return this._mergeHunks != null && this._mergeHunks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID of the source commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceCommitId
        {
            get { return this._sourceCommitId; }
            set { this._sourceCommitId = value; }
        }

        // Check to see if SourceCommitId property is set
        internal bool IsSetSourceCommitId()
        {
            return this._sourceCommitId != null;
        }

    }
}