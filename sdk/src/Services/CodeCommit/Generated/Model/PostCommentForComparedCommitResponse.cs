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
    /// This is the response object from the PostCommentForComparedCommit operation.
    /// </summary>
    public partial class PostCommentForComparedCommitResponse : AmazonWebServiceResponse
    {
        private string _afterBlobId;
        private string _afterCommitId;
        private string _beforeBlobId;
        private string _beforeCommitId;
        private Comment _comment;
        private Location _location;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AfterBlobId. 
        /// <para>
        /// In the directionality you established, the blob ID of the after blob.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AfterCommitId. 
        /// <para>
        /// In the directionality you established, the full commit ID of the after commit.
        /// </para>
        /// </summary>
        public string AfterCommitId
        {
            get { return this._afterCommitId; }
            set { this._afterCommitId = value; }
        }

        // Check to see if AfterCommitId property is set
        internal bool IsSetAfterCommitId()
        {
            return this._afterCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeBlobId. 
        /// <para>
        /// In the directionality you established, the blob ID of the before blob.
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
        /// Gets and sets the property BeforeCommitId. 
        /// <para>
        /// In the directionality you established, the full commit ID of the before commit.
        /// </para>
        /// </summary>
        public string BeforeCommitId
        {
            get { return this._beforeCommitId; }
            set { this._beforeCommitId = value; }
        }

        // Check to see if BeforeCommitId property is set
        internal bool IsSetBeforeCommitId()
        {
            return this._beforeCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The content of the comment you posted.
        /// </para>
        /// </summary>
        public Comment Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the comment in the comparison between the two commits.
        /// </para>
        /// </summary>
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you posted a comment on the comparison between commits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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