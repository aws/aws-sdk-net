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
    /// Container for the parameters to the GetBlobDifferences operation.
    /// Returns a structured, line-level diff between two blob versions in a repository. The
    /// diff is returned as an ordered list of hunks, where each hunk represents a contiguous
    /// run of changed lines together with any surrounding unchanged context lines.
    /// 
    ///  
    /// <para>
    /// Results are paginated. Use <c>MaxResults</c> and <c>NextToken</c> to retrieve additional
    /// pages.
    /// </para>
    ///  
    /// <para>
    /// For the typical usage workflow, see <a>GetDifferences</a>.
    /// </para>
    /// </summary>
    public partial class GetBlobDifferencesRequest : AmazonCodeCommitRequest
    {
        private string _afterBlobId;
        private string _beforeBlobId;
        private int? _contextLines;
        private bool? _ignoreWhitespace;
        private int? _maxResults;
        private string _nextToken;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AfterBlobId. 
        /// <para>
        /// The ID of the "after" (destination) blob in the diff. Typically the value of <c>afterBlob.blobId</c>
        /// from a <c>Difference</c> object returned by <a>GetDifferences</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AfterBlobId
        {
            get { return this._afterBlobId; }
            set { this._afterBlobId = value; }
        }

        // Check to see if AfterBlobId property is set
        internal bool IsSetAfterBlobId()
        {
            return this._afterBlobId != null;
        }

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
        public string BeforeBlobId
        {
            get { return this._beforeBlobId; }
            set { this._beforeBlobId = value; }
        }

        // Check to see if BeforeBlobId property is set
        internal bool IsSetBeforeBlobId()
        {
            return this._beforeBlobId != null;
        }

        /// <summary>
        /// Gets and sets the property ContextLines. 
        /// <para>
        /// The number of unchanged lines of context to include before and after each block of
        /// changes in a hunk. Valid values are 0 through 20. Defaults to <c>3</c>.
        /// </para>
        /// </summary>
        public int? ContextLines
        {
            get { return this._contextLines; }
            set { this._contextLines = value; }
        }

        // Check to see if ContextLines property is set
        internal bool IsSetContextLines()
        {
            return this._contextLines.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreWhitespace. 
        /// <para>
        /// Specifies whether to ignore whitespace-only changes when computing the diff. When
        /// <c>true</c>, the operation treats lines that differ only in whitespace as unchanged.
        /// Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IgnoreWhitespace
        {
            get { return this._ignoreWhitespace; }
            set { this._ignoreWhitespace = value; }
        }

        // Check to see if IgnoreWhitespace property is set
        internal bool IsSetIgnoreWhitespace()
        {
            return this._ignoreWhitespace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of <c>DiffHunk</c> entries to return in a single response page.
        /// Defaults to <c>100</c>.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that returns the next batch of results when present in a request.
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
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the blobs to compare.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}