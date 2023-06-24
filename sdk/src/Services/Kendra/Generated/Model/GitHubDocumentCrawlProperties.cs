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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to include certain types of GitHub content.
    /// You can configure to index repository files only, or also include issues and pull
    /// requests, comments, and comment attachments.
    /// </summary>
    public partial class GitHubDocumentCrawlProperties
    {
        private bool? _crawlIssue;
        private bool? _crawlIssueComment;
        private bool? _crawlIssueCommentAttachment;
        private bool? _crawlPullRequest;
        private bool? _crawlPullRequestComment;
        private bool? _crawlPullRequestCommentAttachment;
        private bool? _crawlRepositoryDocuments;

        /// <summary>
        /// Gets and sets the property CrawlIssue. 
        /// <para>
        ///  <code>TRUE</code> to index all issues within a repository.
        /// </para>
        /// </summary>
        public bool CrawlIssue
        {
            get { return this._crawlIssue.GetValueOrDefault(); }
            set { this._crawlIssue = value; }
        }

        // Check to see if CrawlIssue property is set
        internal bool IsSetCrawlIssue()
        {
            return this._crawlIssue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlIssueComment. 
        /// <para>
        ///  <code>TRUE</code> to index all comments on issues.
        /// </para>
        /// </summary>
        public bool CrawlIssueComment
        {
            get { return this._crawlIssueComment.GetValueOrDefault(); }
            set { this._crawlIssueComment = value; }
        }

        // Check to see if CrawlIssueComment property is set
        internal bool IsSetCrawlIssueComment()
        {
            return this._crawlIssueComment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlIssueCommentAttachment. 
        /// <para>
        ///  <code>TRUE</code> to include all comment attachments for issues.
        /// </para>
        /// </summary>
        public bool CrawlIssueCommentAttachment
        {
            get { return this._crawlIssueCommentAttachment.GetValueOrDefault(); }
            set { this._crawlIssueCommentAttachment = value; }
        }

        // Check to see if CrawlIssueCommentAttachment property is set
        internal bool IsSetCrawlIssueCommentAttachment()
        {
            return this._crawlIssueCommentAttachment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlPullRequest. 
        /// <para>
        ///  <code>TRUE</code> to index all pull requests within a repository.
        /// </para>
        /// </summary>
        public bool CrawlPullRequest
        {
            get { return this._crawlPullRequest.GetValueOrDefault(); }
            set { this._crawlPullRequest = value; }
        }

        // Check to see if CrawlPullRequest property is set
        internal bool IsSetCrawlPullRequest()
        {
            return this._crawlPullRequest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlPullRequestComment. 
        /// <para>
        ///  <code>TRUE</code> to index all comments on pull requests.
        /// </para>
        /// </summary>
        public bool CrawlPullRequestComment
        {
            get { return this._crawlPullRequestComment.GetValueOrDefault(); }
            set { this._crawlPullRequestComment = value; }
        }

        // Check to see if CrawlPullRequestComment property is set
        internal bool IsSetCrawlPullRequestComment()
        {
            return this._crawlPullRequestComment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlPullRequestCommentAttachment. 
        /// <para>
        ///  <code>TRUE</code> to include all comment attachments for pull requests.
        /// </para>
        /// </summary>
        public bool CrawlPullRequestCommentAttachment
        {
            get { return this._crawlPullRequestCommentAttachment.GetValueOrDefault(); }
            set { this._crawlPullRequestCommentAttachment = value; }
        }

        // Check to see if CrawlPullRequestCommentAttachment property is set
        internal bool IsSetCrawlPullRequestCommentAttachment()
        {
            return this._crawlPullRequestCommentAttachment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlRepositoryDocuments. 
        /// <para>
        ///  <code>TRUE</code> to index all files with a repository.
        /// </para>
        /// </summary>
        public bool CrawlRepositoryDocuments
        {
            get { return this._crawlRepositoryDocuments.GetValueOrDefault(); }
            set { this._crawlRepositoryDocuments = value; }
        }

        // Check to see if CrawlRepositoryDocuments property is set
        internal bool IsSetCrawlRepositoryDocuments()
        {
            return this._crawlRepositoryDocuments.HasValue; 
        }

    }
}