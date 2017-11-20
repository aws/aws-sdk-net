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
    /// Returns information about a pull request event.
    /// </summary>
    public partial class PullRequestEvent
    {
        private string _actorArn;
        private DateTime? _eventDate;
        private PullRequestEventType _pullRequestEventType;
        private string _pullRequestId;
        private PullRequestMergedStateChangedEventMetadata _pullRequestMergedStateChangedEventMetadata;
        private PullRequestSourceReferenceUpdatedEventMetadata _pullRequestSourceReferenceUpdatedEventMetadata;
        private PullRequestStatusChangedEventMetadata _pullRequestStatusChangedEventMetadata;

        /// <summary>
        /// Gets and sets the property ActorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user whose actions resulted in the event. Examples
        /// include updating the pull request with additional commits or changing the status of
        /// a pull request.
        /// </para>
        /// </summary>
        public string ActorArn
        {
            get { return this._actorArn; }
            set { this._actorArn = value; }
        }

        // Check to see if ActorArn property is set
        internal bool IsSetActorArn()
        {
            return this._actorArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventDate. 
        /// <para>
        /// The day and time of the pull request event, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime EventDate
        {
            get { return this._eventDate.GetValueOrDefault(); }
            set { this._eventDate = value; }
        }

        // Check to see if EventDate property is set
        internal bool IsSetEventDate()
        {
            return this._eventDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PullRequestEventType. 
        /// <para>
        /// The type of the pull request event, for example a status change event (PULL_REQUEST_STATUS_CHANGED)
        /// or update event (PULL_REQUEST_SOURCE_REFERENCE_UPDATED).
        /// </para>
        /// </summary>
        public PullRequestEventType PullRequestEventType
        {
            get { return this._pullRequestEventType; }
            set { this._pullRequestEventType = value; }
        }

        // Check to see if PullRequestEventType property is set
        internal bool IsSetPullRequestEventType()
        {
            return this._pullRequestEventType != null;
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
        /// Gets and sets the property PullRequestMergedStateChangedEventMetadata. 
        /// <para>
        /// Information about the change in mergability state for the pull request event.
        /// </para>
        /// </summary>
        public PullRequestMergedStateChangedEventMetadata PullRequestMergedStateChangedEventMetadata
        {
            get { return this._pullRequestMergedStateChangedEventMetadata; }
            set { this._pullRequestMergedStateChangedEventMetadata = value; }
        }

        // Check to see if PullRequestMergedStateChangedEventMetadata property is set
        internal bool IsSetPullRequestMergedStateChangedEventMetadata()
        {
            return this._pullRequestMergedStateChangedEventMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestSourceReferenceUpdatedEventMetadata. 
        /// <para>
        /// Information about the updated source branch for the pull request event. 
        /// </para>
        /// </summary>
        public PullRequestSourceReferenceUpdatedEventMetadata PullRequestSourceReferenceUpdatedEventMetadata
        {
            get { return this._pullRequestSourceReferenceUpdatedEventMetadata; }
            set { this._pullRequestSourceReferenceUpdatedEventMetadata = value; }
        }

        // Check to see if PullRequestSourceReferenceUpdatedEventMetadata property is set
        internal bool IsSetPullRequestSourceReferenceUpdatedEventMetadata()
        {
            return this._pullRequestSourceReferenceUpdatedEventMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestStatusChangedEventMetadata. 
        /// <para>
        /// Information about the change in status for the pull request event.
        /// </para>
        /// </summary>
        public PullRequestStatusChangedEventMetadata PullRequestStatusChangedEventMetadata
        {
            get { return this._pullRequestStatusChangedEventMetadata; }
            set { this._pullRequestStatusChangedEventMetadata = value; }
        }

        // Check to see if PullRequestStatusChangedEventMetadata property is set
        internal bool IsSetPullRequestStatusChangedEventMetadata()
        {
            return this._pullRequestStatusChangedEventMetadata != null;
        }

    }
}