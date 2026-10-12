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
    /// Returns information about comments on the comparison between two commits.
    /// </summary>
    public partial class CommentsForComparedCommit
    {
        /// <summary>
        /// Gets and sets the property AfterBlobId. 
        /// <para>
        /// The full blob ID of the commit used to establish the after of the comparison.
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
        /// The full commit ID of the commit used to establish the after of the comparison.
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
        /// The full blob ID of the commit used to establish the before of the comparison.
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
        /// The full commit ID of the commit used to establish the before of the comparison.
        /// </para>
        /// </summary>
        public string BeforeCommitId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeCommitId property is set.
        /// </summary>
        internal bool IsSetBeforeCommitId() => this.BeforeCommitId != null;

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// An array of comment objects. Each comment object contains information about a comment
        /// on the comparison between commits.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Comment> Comments { get; set; } = AWSConfigs.InitializeCollections ? new List<Comment>() : null;

        /// <summary>
        /// Checks to see if the Comments property is set.
        /// </summary>
        internal bool IsSetComments() => this.Comments != null && (this.Comments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Location information about the comment on the comparison, including the file name,
        /// line number, and whether the version of the file where the comment was made is BEFORE
        /// or AFTER.
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
        /// The name of the repository that contains the compared commits.
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
