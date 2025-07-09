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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
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
namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// This is the response object from the GetAccountActivity operation.
    /// </summary>
    public partial class GetAccountActivityResponse : AmazonWebServiceResponse
    {
        private string _activityId;
        private DateTime? _completedAt;
        private string _description;
        private int? _estimatedTimeToCompleteInMinutes;
        private DateTime? _expiresAt;
        private string _instructionsUrl;
        private ActivityReward _reward;
        private DateTime? _startedAt;
        private ActivityStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        ///  A unique identifier that identifies the activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this._activityId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        ///  The timestamp when the activity is completed. This field appears only for activities
        /// in the <c>COMPLETED</c> state. 
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  Provides detailed information about the activity and its expected outcomes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property EstimatedTimeToCompleteInMinutes. 
        /// <para>
        ///  The estimated time to complete the activity. This is the duration in minutes. 
        /// </para>
        /// </summary>
        public int? EstimatedTimeToCompleteInMinutes
        {
            get { return this._estimatedTimeToCompleteInMinutes; }
            set { this._estimatedTimeToCompleteInMinutes = value; }
        }

        // Check to see if EstimatedTimeToCompleteInMinutes property is set
        internal bool IsSetEstimatedTimeToCompleteInMinutes()
        {
            return this._estimatedTimeToCompleteInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The time by which the activity must be completed to receive a reward. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstructionsUrl. 
        /// <para>
        ///  The URL resource that provides guidance on activity requirements and completion.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string InstructionsUrl
        {
            get { return this._instructionsUrl; }
            set { this._instructionsUrl = value; }
        }

        // Check to see if InstructionsUrl property is set
        internal bool IsSetInstructionsUrl()
        {
            return this._instructionsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Reward. 
        /// <para>
        ///  A reward granted upon activity completion. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivityReward Reward
        {
            get { return this._reward; }
            set { this._reward = value; }
        }

        // Check to see if Reward property is set
        internal bool IsSetReward()
        {
            return this._reward != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        ///  The timestamp when the activity started. This field appears only for activities in
        /// the <c>IN_PROGRESS</c> or <c>COMPLETED</c> states. 
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current activity status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  A short activity title. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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