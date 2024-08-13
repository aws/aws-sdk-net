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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes scaling activity, which is a long-running process that represents a change
    /// to your Auto Scaling group, such as changing its size or replacing an instance.
    /// </summary>
    public partial class Activity
    {
        private string _activityId;
        private string _autoScalingGroupARN;
        private string _autoScalingGroupName;
        private string _autoScalingGroupState;
        private string _cause;
        private string _description;
        private string _details;
        private DateTime? _endTime;
        private int? _progress;
        private DateTime? _startTime;
        private ScalingActivityStatusCode _statusCode;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        /// The ID of the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AutoScalingGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string AutoScalingGroupARN
        {
            get { return this._autoScalingGroupARN; }
            set { this._autoScalingGroupARN = value; }
        }

        // Check to see if AutoScalingGroupARN property is set
        internal bool IsSetAutoScalingGroupARN()
        {
            return this._autoScalingGroupARN != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupState. 
        /// <para>
        /// The state of the Auto Scaling group, which is either <c>InService</c> or <c>Deleted</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string AutoScalingGroupState
        {
            get { return this._autoScalingGroupState; }
            set { this._autoScalingGroupState = value; }
        }

        // Check to see if AutoScalingGroupState property is set
        internal bool IsSetAutoScalingGroupState()
        {
            return this._autoScalingGroupState != null;
        }

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The reason the activity began.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1023)]
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A friendly, more verbose description of the activity.
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
        /// Gets and sets the property Details. 
        /// <para>
        /// The details about the activity.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the activity.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// A value between 0 and 100 that indicates the progress of the activity.
        /// </para>
        /// </summary>
        public int? Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The current status of the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingActivityStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A friendly, more verbose description of the activity status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}