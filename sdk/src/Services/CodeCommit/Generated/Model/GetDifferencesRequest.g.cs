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
    /// Container for the parameters to the GetDifferences operation. Returns information
    /// about the differences in a valid commit specifier (such as a branch, tag, HEAD, commit
    /// ID, or other fully qualified reference). Results can be limited to a specified path.
    /// <para> For line-level diff details, pass the <c>beforeBlob.blobId</c> and <c>afterBlob.blobId</c>
    /// values from a <c>Difference</c> object to <a>GetBlobDifferences</a>. </para>
    /// </summary>
    public partial class GetDifferencesRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property AfterCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AfterCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the AfterCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetAfterCommitSpecifier() => this.AfterCommitSpecifier != null;

        /// <summary>
        /// Gets and sets the property AfterPath. 
        /// <para>
        /// The file path in which to check differences. Limits the results to this path. Can
        /// also be used to specify the changed name of a directory or folder, if it has changed.
        /// If not specified, differences are shown for all paths.
        /// </para>
        /// </summary>
        public string AfterPath { get; set; }

        /// <summary>
        /// Checks to see if the AfterPath property is set.
        /// </summary>
        internal bool IsSetAfterPath() => this.AfterPath != null;

        /// <summary>
        /// Gets and sets the property BeforeCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, the full commit ID). Optional. If not specified, all changes before
        /// the <c>afterCommitSpecifier</c> value are shown. If you do not use <c>beforeCommitSpecifier</c>
        /// in your request, consider limiting the results with <c>maxResults</c>.
        /// </para>
        /// </summary>
        public string BeforeCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the BeforeCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetBeforeCommitSpecifier() => this.BeforeCommitSpecifier != null;

        /// <summary>
        /// Gets and sets the property BeforePath. 
        /// <para>
        /// The file path in which to check for differences. Limits the results to this path.
        /// Can also be used to specify the previous name of a directory or folder. If <c>beforePath</c>
        /// and <c>afterPath</c> are not specified, differences are shown for all paths.
        /// </para>
        /// </summary>
        public string BeforePath { get; set; }

        /// <summary>
        /// Checks to see if the BeforePath property is set.
        /// </summary>
        internal bool IsSetBeforePath() => this.BeforePath != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results.
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
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results.
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
        /// The name of the repository where you want to get differences.
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
