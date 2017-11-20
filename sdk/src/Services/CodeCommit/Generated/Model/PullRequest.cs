/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a pull request.
    /// </summary>
    public partial class PullRequest
    {
        private string _authorArn;
        private string _clientRequestToken;
        private DateTime? _creationDate;
        private string _description;
        private DateTime? _lastActivityDate;
        private string _pullRequestId;
        private PullRequestStatusEnum _pullRequestStatus;
        private List<PullRequestTarget> _pullRequestTargets = new List<PullRequestTarget>();
        private string _title;

        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the pull request.
        /// </para>
        /// </summary>
        public string AuthorArn
        {
            get { return this._authorArn; }
            set { this._authorArn = value; }
        }

        // Check to see if AuthorArn property is set
        internal bool IsSetAuthorArn()
        {
            return this._authorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request is received
        /// with the same parameters and a token is included, the request will return information
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the pull request was originally created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-defined description of the pull request. This description can be used to
        /// clarify what should be reviewed and other details of the request.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivityDate. 
        /// <para>
        /// The day and time of the last user or system activity on the pull request, in timestamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime LastActivityDate
        {
            get { return this._lastActivityDate.GetValueOrDefault(); }
            set { this._lastActivityDate = value; }
        }

        // Check to see if LastActivityDate property is set
        internal bool IsSetLastActivityDate()
        {
            return this._lastActivityDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request. 
        /// </para>
        /// </summary>
        public string PullRequestId
        {
            get { return this._pullRequestId; }
            set { this._pullRequestId = value; }
        }

        // Check to see if PullRequestId property is set
        internal bool IsSetPullRequestId()
        {
            return this._pullRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestStatus. 
        /// <para>
        /// The status of the pull request. Pull request status can only change from <code>OPEN</code>
        /// to <code>CLOSED</code>.
        /// </para>
        /// </summary>
        public PullRequestStatusEnum PullRequestStatus
        {
            get { return this._pullRequestStatus; }
            set { this._pullRequestStatus = value; }
        }

        // Check to see if PullRequestStatus property is set
        internal bool IsSetPullRequestStatus()
        {
            return this._pullRequestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestTargets. 
        /// <para>
        /// The targets of the pull request, including the source branch and destination branch
        /// for the pull request.
        /// </para>
        /// </summary>
        public List<PullRequestTarget> PullRequestTargets
        {
            get { return this._pullRequestTargets; }
            set { this._pullRequestTargets = value; }
        }

        // Check to see if PullRequestTargets property is set
        internal bool IsSetPullRequestTargets()
        {
            return this._pullRequestTargets != null && this._pullRequestTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The user-defined title of the pull request. This title is displayed in the list of
        /// pull requests to other users of the repository.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}