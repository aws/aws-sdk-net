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
    /// This is the response object from the PostCommentForComparedCommit operation.
    /// </summary>
    public partial class PostCommentForComparedCommitResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AfterBlobId. 
        /// <para>
        /// In the directionality you established, the blob ID of the after blob.
        /// </para>
        /// </summary>
        public string AfterBlobId { get; set; }

        /// <summary>
        /// Checks to see if the AfterBlobId property is set.
        /// </summary>
        internal bool IsSetAfterBlobId() => this.AfterBlobId != null;

        /// <summary>
        /// Gets and sets the property AfterCommitId. 
        /// <para>
        /// In the directionality you established, the full commit ID of the after commit.
        /// </para>
        /// </summary>
        public string AfterCommitId { get; set; }

        /// <summary>
        /// Checks to see if the AfterCommitId property is set.
        /// </summary>
        internal bool IsSetAfterCommitId() => this.AfterCommitId != null;

        /// <summary>
        /// Gets and sets the property BeforeBlobId. 
        /// <para>
        /// In the directionality you established, the blob ID of the before blob.
        /// </para>
        /// </summary>
        public string BeforeBlobId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeBlobId property is set.
        /// </summary>
        internal bool IsSetBeforeBlobId() => this.BeforeBlobId != null;

        /// <summary>
        /// Gets and sets the property BeforeCommitId. 
        /// <para>
        /// In the directionality you established, the full commit ID of the before commit.
        /// </para>
        /// </summary>
        public string BeforeCommitId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeCommitId property is set.
        /// </summary>
        internal bool IsSetBeforeCommitId() => this.BeforeCommitId != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The content of the comment you posted.
        /// </para>
        /// </summary>
        public Comment Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the comment in the comparison between the two commits.
        /// </para>
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you posted a comment on the comparison between commits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
