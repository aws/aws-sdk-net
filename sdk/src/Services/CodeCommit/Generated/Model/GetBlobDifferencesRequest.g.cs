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
    /// Container for the parameters to the GetBlobDifferences operation. Returns a structured,
    /// line-level diff between two blob versions in a repository. The diff is returned as
    /// an ordered list of hunks, where each hunk represents a contiguous run of changed lines
    /// together with any surrounding unchanged context lines. <para> Results are paginated.
    /// Use <c>MaxResults</c> and <c>NextToken</c> to retrieve additional pages. </para> <para>
    /// For the typical usage workflow, see <a>GetDifferences</a>. </para>
    /// </summary>
    public partial class GetBlobDifferencesRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property AfterBlobId. 
        /// <para>
        /// The ID of the "after" (destination) blob in the diff. Typically the value of <c>afterBlob.blobId</c>
        /// from a <c>Difference</c> object returned by <a>GetDifferences</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AfterBlobId { get; set; }

        /// <summary>
        /// Checks to see if the AfterBlobId property is set.
        /// </summary>
        internal bool IsSetAfterBlobId() => this.AfterBlobId != null;

        /// <summary>
        /// Gets and sets the property BeforeBlobId. 
        /// <para>
        /// The ID of the "before" (source) blob in the diff. Typically the value of <c>beforeBlob.blobId</c>
        /// from a <c>Difference</c> object returned by <a>GetDifferences</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the operation returns a diff against an empty before-state.
        /// This is equivalent to treating the file as newly added.
        /// </para>
        /// </summary>
        public string BeforeBlobId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeBlobId property is set.
        /// </summary>
        internal bool IsSetBeforeBlobId() => this.BeforeBlobId != null;

        /// <summary>
        /// Gets and sets the property ContextLines. 
        /// <para>
        /// The number of unchanged lines of context to include before and after each block of
        /// changes in a hunk. Valid values are 0 through 20. Defaults to <c>3</c>.
        /// </para>
        /// </summary>
        public int? ContextLines { get; set; }

        /// <summary>
        /// Checks to see if the ContextLines property is set.
        /// </summary>
        internal bool IsSetContextLines() => this.ContextLines.HasValue;

        /// <summary>
        /// Gets and sets the property IgnoreWhitespace. 
        /// <para>
        /// Specifies whether to ignore whitespace-only changes when computing the diff. When
        /// <c>true</c>, the operation treats lines that differ only in whitespace as unchanged.
        /// Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IgnoreWhitespace { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreWhitespace property is set.
        /// </summary>
        internal bool IsSetIgnoreWhitespace() => this.IgnoreWhitespace.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of <c>DiffHunk</c> entries to return in a single response page.
        /// Defaults to <c>100</c>.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that returns the next batch of results when present in a request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the blobs to compare.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
