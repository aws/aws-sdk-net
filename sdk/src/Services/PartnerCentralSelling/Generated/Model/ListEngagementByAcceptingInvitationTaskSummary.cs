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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Specifies a subset of fields associated with tasks related to accepting an engagement
    /// invitation.
    /// </summary>
    public partial class ListEngagementByAcceptingInvitationTaskSummary
    {
        private string _engagementInvitationId;
        private string _message;
        private string _opportunityId;
        private ReasonCode _reasonCode;
        private string _resourceSnapshotJobId;
        private DateTime? _startTime;
        private string _taskArn;
        private string _taskId;
        private TaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property EngagementInvitationId. 
        /// <para>
        ///  The unique identifier of the engagement invitation that was accepted. 
        /// </para>
        /// </summary>
        public string EngagementInvitationId
        {
            get { return this._engagementInvitationId; }
            set { this._engagementInvitationId = value; }
        }

        // Check to see if EngagementInvitationId property is set
        internal bool IsSetEngagementInvitationId()
        {
            return this._engagementInvitationId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  Detailed message describing the failure and possible recovery steps. 
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property OpportunityId. 
        /// <para>
        ///  Unique identifier of opportunity that was created. 
        /// </para>
        /// </summary>
        public string OpportunityId
        {
            get { return this._opportunityId; }
            set { this._opportunityId = value; }
        }

        // Check to see if OpportunityId property is set
        internal bool IsSetOpportunityId()
        {
            return this._opportunityId != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        ///  A code pointing to the specific reason for the failure. 
        /// </para>
        /// </summary>
        public ReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSnapshotJobId. 
        /// <para>
        ///  Unique identifier of the resource snapshot job that was created. 
        /// </para>
        /// </summary>
        public string ResourceSnapshotJobId
        {
            get { return this._resourceSnapshotJobId; }
            set { this._resourceSnapshotJobId = value; }
        }

        // Check to see if ResourceSnapshotJobId property is set
        internal bool IsSetResourceSnapshotJobId()
        {
            return this._resourceSnapshotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  Task start timestamp. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that uniquely identifies the task. 
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  Unique identifier of the task. 
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        ///  Status of the task. 
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}