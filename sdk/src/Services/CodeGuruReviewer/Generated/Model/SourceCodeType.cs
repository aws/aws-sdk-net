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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
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
        private BranchDiffSourceCodeType _branchDiff;
        private CommitDiffSourceCodeType _commitDiff;
        private RepositoryHeadSourceCodeType _repositoryHead;
        private RequestMetadata _requestMetadata;
        private S3BucketRepository _s3BucketRepository;

        /// <summary>
        /// Gets and sets the property BranchDiff. 
        /// <para>
        /// A type of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// that specifies a source branch name and a destination branch name in an associated
        /// repository.
        /// </para>
        /// </summary>
        public BranchDiffSourceCodeType BranchDiff
        {
            get { return this._branchDiff; }
            set { this._branchDiff = value; }
        }

        // Check to see if BranchDiff property is set
        internal bool IsSetBranchDiff()
        {
            return this._branchDiff != null;
        }

        /// <summary>
        /// Gets and sets the property CommitDiff. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_SourceCodeType">SourceCodeType</a>
        /// that specifies a commit diff created by a pull request on an associated repository.
        /// </para>
        /// </summary>
        public CommitDiffSourceCodeType CommitDiff
        {
            get { return this._commitDiff; }
            set { this._commitDiff = value; }
        }

        // Check to see if CommitDiff property is set
        internal bool IsSetCommitDiff()
        {
            return this._commitDiff != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryHead.
        /// </summary>
        public RepositoryHeadSourceCodeType RepositoryHead
        {
            get { return this._repositoryHead; }
            set { this._repositoryHead = value; }
        }

        // Check to see if RepositoryHead property is set
        internal bool IsSetRepositoryHead()
        {
            return this._repositoryHead != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMetadata. 
        /// <para>
        /// Metadata that is associated with a code review. This applies to any type of code review
        /// supported by CodeGuru Reviewer. The <c>RequestMetadaa</c> field captures any event
        /// metadata. For example, it might capture metadata associated with an event trigger,
        /// such as a push or a pull request.
        /// </para>
        /// </summary>
        public RequestMetadata RequestMetadata
        {
            get { return this._requestMetadata; }
            set { this._requestMetadata = value; }
        }

        // Check to see if RequestMetadata property is set
        internal bool IsSetRequestMetadata()
        {
            return this._requestMetadata != null;
        }

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
        public S3BucketRepository S3BucketRepository
        {
            get { return this._s3BucketRepository; }
            set { this._s3BucketRepository = value; }
        }

        // Check to see if S3BucketRepository property is set
        internal bool IsSetS3BucketRepository()
        {
            return this._s3BucketRepository != null;
        }

    }
}