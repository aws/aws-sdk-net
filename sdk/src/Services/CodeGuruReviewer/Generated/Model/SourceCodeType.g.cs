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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Specifies the source code that is analyzed in a code review.
    /// </summary>
    public partial class SourceCodeType
    {
        /// <summary>
        /// Gets and sets the property BranchDiff. 
        /// <para>
        /// A type of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// that specifies a source branch name and a destination branch name in an associated
        /// repository.
        /// </para>
        /// </summary>
        public BranchDiffSourceCodeType BranchDiff { get; set; }

        /// <summary>
        /// Checks to see if the BranchDiff property is set.
        /// </summary>
        internal bool IsSetBranchDiff() => this.BranchDiff != null;

        /// <summary>
        /// Gets and sets the property CommitDiff. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// that specifies a commit diff created by a pull request on an associated repository.
        /// </para>
        /// </summary>
        public CommitDiffSourceCodeType CommitDiff { get; set; }

        /// <summary>
        /// Checks to see if the CommitDiff property is set.
        /// </summary>
        internal bool IsSetCommitDiff() => this.CommitDiff != null;

        /// <summary>
        /// Gets and sets the property RepositoryHead.
        /// </summary>
        public RepositoryHeadSourceCodeType RepositoryHead { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryHead property is set.
        /// </summary>
        internal bool IsSetRepositoryHead() => this.RepositoryHead != null;

        /// <summary>
        /// Gets and sets the property RequestMetadata. 
        /// <para>
        /// Metadata that is associated with a code review. This applies to any type of code review
        /// supported by CodeGuru Reviewer. The <c>RequestMetadaa</c> field captures any event
        /// metadata. For example, it might capture metadata associated with an event trigger,
        /// such as a push or a pull request.
        /// </para>
        /// </summary>
        public RequestMetadata RequestMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RequestMetadata property is set.
        /// </summary>
        internal bool IsSetRequestMetadata() => this.RequestMetadata != null;

        /// <summary>
        /// Gets and sets the property S3BucketRepository. 
        /// <para>
        /// Information about an associated repository in an S3 bucket that includes its name
        /// and an <c>S3RepositoryDetails</c> object. The <c>S3RepositoryDetails</c> object includes
        /// the name of an S3 bucket, an S3 key for a source code .zip file, and an S3 key for
        /// a build artifacts .zip file. <c>S3BucketRepository</c> is required in <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// for <c>S3BucketRepository</c> based code reviews.
        /// </para>
        /// </summary>
        public S3BucketRepository S3BucketRepository { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketRepository property is set.
        /// </summary>
        internal bool IsSetS3BucketRepository() => this.S3BucketRepository != null;
    }
}
