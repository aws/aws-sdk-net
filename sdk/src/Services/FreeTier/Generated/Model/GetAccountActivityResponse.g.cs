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

namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// This is the response object from the GetAccountActivity operation.
    /// </summary>
    public partial class GetAccountActivityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        ///  A unique identifier that identifies the activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ActivityId property is set.
        /// </summary>
        internal bool IsSetActivityId() => this.ActivityId != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        ///  The timestamp when the activity is completed. This field appears only for activities
        /// in the <c>COMPLETED</c> state. 
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  Provides detailed information about the activity and its expected outcomes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompleteInMinutes. 
        /// <para>
        ///  The estimated time to complete the activity. This is the duration in minutes. 
        /// </para>
        /// </summary>
        public int? EstimatedTimeToCompleteInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeToCompleteInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeToCompleteInMinutes() => this.EstimatedTimeToCompleteInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The time by which the activity must be completed to receive a reward. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstructionsUrl. 
        /// <para>
        ///  The URL resource that provides guidance on activity requirements and completion.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string InstructionsUrl { get; set; }

        /// <summary>
        /// Checks to see if the InstructionsUrl property is set.
        /// </summary>
        internal bool IsSetInstructionsUrl() => this.InstructionsUrl != null;

        /// <summary>
        /// Gets and sets the property Reward. 
        /// <para>
        ///  A reward granted upon activity completion. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityReward Reward { get; set; }

        /// <summary>
        /// Checks to see if the Reward property is set.
        /// </summary>
        internal bool IsSetReward() => this.Reward != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        ///  The timestamp when the activity started. This field appears only for activities in
        /// the <c>IN_PROGRESS</c> or <c>COMPLETED</c> states. 
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current activity status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  A short activity title. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
