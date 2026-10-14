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
    /// Returns information about a pull request.
    /// </summary>
    public partial class PullRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalRules. 
        /// <para>
        /// The approval rules applied to the pull request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApprovalRule> ApprovalRules { get; set; } = AWSConfigs.InitializeCollections ? new List<ApprovalRule>() : null;

        /// <summary>
        /// Checks to see if the ApprovalRules property is set.
        /// </summary>
        internal bool IsSetApprovalRules() => this.ApprovalRules != null && (this.ApprovalRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the pull request.
        /// </para>
        /// </summary>
        public string AuthorArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorArn property is set.
        /// </summary>
        internal bool IsSetAuthorArn() => this.AuthorArn != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that, when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request is received
        /// with the same parameters and a token is included, the request returns information
        /// about the initial request that used that token.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the pull request was originally created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-defined description of the pull request. This description can be used to
        /// clarify what should be reviewed and other details of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastActivityDate. 
        /// <para>
        /// The day and time of the last user or system activity on the pull request, in timestamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Checks to see if the LastActivityDate property is set.
        /// </summary>
        internal bool IsSetLastActivityDate() => this.LastActivityDate.HasValue;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request. 
        /// </para>
        /// </summary>
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;

        /// <summary>
        /// Gets and sets the property PullRequestStatus. 
        /// <para>
        /// The status of the pull request. Pull request status can only change from <c>OPEN</c>
        /// to <c>CLOSED</c>.
        /// </para>
        /// </summary>
        public PullRequestStatusEnum PullRequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestStatus property is set.
        /// </summary>
        internal bool IsSetPullRequestStatus() => this.PullRequestStatus != null;

        /// <summary>
        /// Gets and sets the property PullRequestTargets. 
        /// <para>
        /// The targets of the pull request, including the source branch and destination branch
        /// for the pull request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PullRequestTarget> PullRequestTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<PullRequestTarget>() : null;

        /// <summary>
        /// Checks to see if the PullRequestTargets property is set.
        /// </summary>
        internal bool IsSetPullRequestTargets() => this.PullRequestTargets != null && (this.PullRequestTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The system-generated revision ID for the pull request.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The user-defined title of the pull request. This title is displayed in the list of
        /// pull requests to other repository users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
