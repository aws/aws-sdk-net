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
    /// Container for the parameters to the PostCommentForComparedCommit operation.
    /// Posts a comment on the comparison between two commits.
    /// </summary>
    public partial class PostCommentForComparedCommitRequest : AmazonCodeCommitRequest
    {
        private string _afterCommitId;
        private string _beforeCommitId;
        private string _clientRequestToken;
        private string _content;
        private Location _location;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AfterCommitId. 
        /// <para>
        /// To establish the directionality of the comparison, the full commit ID of the after
        /// commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property BeforeCommitId. 
        /// <para>
        /// To establish the directionality of the comparison, the full commit ID of the before
        /// commit. Required for commenting on any commit unless that commit is the initial commit.
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that, when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request is received
        /// with the same parameters and a token is included, the request returns information
        /// about the initial request that used that token.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the comment you want to make.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the comparison where you want to comment.
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
        /// The name of the repository where you want to post a comment on the comparison between
        /// commits.
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