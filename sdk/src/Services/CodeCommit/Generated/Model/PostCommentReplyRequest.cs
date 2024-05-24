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
    /// Container for the parameters to the PostCommentReply operation.
    /// Posts a comment in reply to an existing comment on a comparison between commits or
    /// a pull request.
    /// </summary>
    public partial class PostCommentReplyRequest : AmazonCodeCommitRequest
    {
        private string _clientRequestToken;
        private string _content;
        private string _inReplyTo;

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
        /// The contents of your reply to a comment.
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
        /// Gets and sets the property InReplyTo. 
        /// <para>
        /// The system-generated ID of the comment to which you want to reply. To get this ID,
        /// use <a>GetCommentsForComparedCommit</a> or <a>GetCommentsForPullRequest</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InReplyTo
        {
            get { return this._inReplyTo; }
            set { this._inReplyTo = value; }
        }

        // Check to see if InReplyTo property is set
        internal bool IsSetInReplyTo()
        {
            return this._inReplyTo != null;
        }

    }
}