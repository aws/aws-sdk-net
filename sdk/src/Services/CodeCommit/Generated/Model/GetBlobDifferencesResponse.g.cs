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
    /// This is the response object from the GetBlobDifferences operation.
    /// </summary>
    public partial class GetBlobDifferencesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AfterBlobSize. 
        /// <para>
        /// The size, in bytes, of the blob identified by <c>afterBlobId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? AfterBlobSize { get; set; }

        /// <summary>
        /// Checks to see if the AfterBlobSize property is set.
        /// </summary>
        internal bool IsSetAfterBlobSize() => this.AfterBlobSize.HasValue;

        /// <summary>
        /// Gets and sets the property BeforeBlobSize. 
        /// <para>
        /// The size, in bytes, of the blob identified by <c>beforeBlobId</c>. Returns <c>0</c>
        /// when you do not specify <c>beforeBlobId</c>.
        /// </para>
        /// </summary>
        public long? BeforeBlobSize { get; set; }

        /// <summary>
        /// Checks to see if the BeforeBlobSize property is set.
        /// </summary>
        internal bool IsSetBeforeBlobSize() => this.BeforeBlobSize.HasValue;

        /// <summary>
        /// Gets and sets the property Hunks. 
        /// <para>
        /// An ordered list of diff hunks. Each hunk represents a contiguous run of changed and
        /// adjacent context lines. The list is empty when the blobs are identical or when the
        /// content is binary. The list is also empty when a paginated request has already returned
        /// all hunks in earlier pages, in which case <c>NextToken</c> is also <c>null</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public List<DiffHunk> Hunks { get; set; } = AWSConfigs.InitializeCollections ? new List<DiffHunk>() : null;

        /// <summary>
        /// Checks to see if the Hunks property is set.
        /// </summary>
        internal bool IsSetHunks() => this.Hunks != null && (this.Hunks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsBinary. 
        /// <para>
        /// Specifies whether the operation treated the diff content as binary. When <c>true</c>,
        /// the operation does not compute a line-level diff and <c>hunks</c> is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsBinary { get; set; }

        /// <summary>
        /// Checks to see if the IsBinary property is set.
        /// </summary>
        internal bool IsSetIsBinary() => this.IsBinary.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of <c>DiffHunk</c>
        /// entries. <c>null</c> when the response contains the final page of the diff.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
