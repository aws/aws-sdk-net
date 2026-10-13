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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to include certain types of GitHub content.
    /// You can configure to index repository files only, or also include issues and pull
    /// requests, comments, and comment attachments.
    /// </summary>
    public partial class GitHubDocumentCrawlProperties
    {
        /// <summary>
        /// Gets and sets the property CrawlIssue. 
        /// <para>
        ///  <c>TRUE</c> to index all issues within a repository.
        /// </para>
        /// </summary>
        public bool? CrawlIssue { get; set; }

        /// <summary>
        /// Checks to see if the CrawlIssue property is set.
        /// </summary>
        internal bool IsSetCrawlIssue() => this.CrawlIssue.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlIssueComment. 
        /// <para>
        ///  <c>TRUE</c> to index all comments on issues.
        /// </para>
        /// </summary>
        public bool? CrawlIssueComment { get; set; }

        /// <summary>
        /// Checks to see if the CrawlIssueComment property is set.
        /// </summary>
        internal bool IsSetCrawlIssueComment() => this.CrawlIssueComment.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlIssueCommentAttachment. 
        /// <para>
        ///  <c>TRUE</c> to include all comment attachments for issues.
        /// </para>
        /// </summary>
        public bool? CrawlIssueCommentAttachment { get; set; }

        /// <summary>
        /// Checks to see if the CrawlIssueCommentAttachment property is set.
        /// </summary>
        internal bool IsSetCrawlIssueCommentAttachment() => this.CrawlIssueCommentAttachment.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlPullRequest. 
        /// <para>
        ///  <c>TRUE</c> to index all pull requests within a repository.
        /// </para>
        /// </summary>
        public bool? CrawlPullRequest { get; set; }

        /// <summary>
        /// Checks to see if the CrawlPullRequest property is set.
        /// </summary>
        internal bool IsSetCrawlPullRequest() => this.CrawlPullRequest.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlPullRequestComment. 
        /// <para>
        ///  <c>TRUE</c> to index all comments on pull requests.
        /// </para>
        /// </summary>
        public bool? CrawlPullRequestComment { get; set; }

        /// <summary>
        /// Checks to see if the CrawlPullRequestComment property is set.
        /// </summary>
        internal bool IsSetCrawlPullRequestComment() => this.CrawlPullRequestComment.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlPullRequestCommentAttachment. 
        /// <para>
        ///  <c>TRUE</c> to include all comment attachments for pull requests.
        /// </para>
        /// </summary>
        public bool? CrawlPullRequestCommentAttachment { get; set; }

        /// <summary>
        /// Checks to see if the CrawlPullRequestCommentAttachment property is set.
        /// </summary>
        internal bool IsSetCrawlPullRequestCommentAttachment() => this.CrawlPullRequestCommentAttachment.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlRepositoryDocuments. 
        /// <para>
        ///  <c>TRUE</c> to index all files with a repository.
        /// </para>
        /// </summary>
        public bool? CrawlRepositoryDocuments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlRepositoryDocuments property is set.
        /// </summary>
        internal bool IsSetCrawlRepositoryDocuments() => this.CrawlRepositoryDocuments.HasValue;
    }
}
