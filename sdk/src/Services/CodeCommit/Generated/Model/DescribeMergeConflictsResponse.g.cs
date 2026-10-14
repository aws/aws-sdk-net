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
    /// This is the response object from the DescribeMergeConflicts operation.
    /// </summary>
    public partial class DescribeMergeConflictsResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property ConflictMetadata. 
        /// <para>
        /// Contains metadata about the conflicts found in the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConflictMetadata ConflictMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ConflictMetadata property is set.
        /// </summary>
        internal bool IsSetConflictMetadata() => this.ConflictMetadata != null;

        /// <summary>
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the destination commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationCommitId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommitId property is set.
        /// </summary>
        internal bool IsSetDestinationCommitId() => this.DestinationCommitId != null;

        /// <summary>
        /// Gets and sets the property MergeHunks. 
        /// <para>
        /// A list of merge hunks of the differences between the files or lines.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MergeHunk> MergeHunks { get; set; } = AWSConfigs.InitializeCollections ? new List<MergeHunk>() : null;

        /// <summary>
        /// Checks to see if the MergeHunks property is set.
        /// </summary>
        internal bool IsSetMergeHunks() => this.MergeHunks != null && (this.MergeHunks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID of the source commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceCommitId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitId property is set.
        /// </summary>
        internal bool IsSetSourceCommitId() => this.SourceCommitId != null;
    }
}
