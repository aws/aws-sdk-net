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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// A scaling Activity is a long-running process that             represents
    /// a change to your AutoScalingGroup,             such as changing the size of the group.
    ///             It can also be a process to replace an instance,             or a process
    /// to perform any other long-running operations             supported by the API.
    /// </summary>
    public partial class Activity
    {
        private string _activityId;
        private string _autoScalingGroupName;
        private string _cause;
        private string _description;
        private string _details;
        private DateTime? _endTime;
        private int? _progress;
        private DateTime? _startTime;
        private string _statusCode;
        private string _statusMessage;


        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        ///         Specifies the ID of the activity.        
        /// </para>
        /// </summary>
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }


        /// <summary>
        /// Sets the ActivityId property
        /// </summary>
        /// <param name="activityId">The value to set for the ActivityId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithActivityId(string activityId)
        {
            this._activityId = activityId;
            return this;
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this._activityId != null;
        }


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///             The name of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        ///         Contains the reason the activity was begun.        
        /// </para>
        /// </summary>
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }


        /// <summary>
        /// Sets the Cause property
        /// </summary>
        /// <param name="cause">The value to set for the Cause property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithCause(string cause)
        {
            this._cause = cause;
            return this;
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///             Contains a friendly, more verbose description of the scaling activity.
        ///        
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        ///             Contains details of the scaling activity.        
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }


        /// <summary>
        /// Sets the Details property
        /// </summary>
        /// <param name="details">The value to set for the Details property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithDetails(string details)
        {
            this._details = details;
            return this;
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }


        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///         Provides the end time of this activity.        
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }


        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The value to set for the EndTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithEndTime(DateTime endTime)
        {
            this._endTime = endTime;
            return this;
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        ///         Specifies a value between 0 and 100 that indicates the progress of the   
        ///     activity.        
        /// </para>
        /// </summary>
        public int Progress
        {
            get { return this._progress.GetValueOrDefault(); }
            set { this._progress = value; }
        }


        /// <summary>
        /// Sets the Progress property
        /// </summary>
        /// <param name="progress">The value to set for the Progress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithProgress(int progress)
        {
            this._progress = progress;
            return this;
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///         Provides the start time of this activity.        
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }


        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithStartTime(DateTime startTime)
        {
            this._startTime = startTime;
            return this;
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        ///         Contains the current status of the activity.        
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }


        /// <summary>
        /// Sets the StatusCode property
        /// </summary>
        /// <param name="statusCode">The value to set for the StatusCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithStatusCode(string statusCode)
        {
            this._statusCode = statusCode;
            return this;
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }


        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///         Contains a friendly, more verbose description of the activity status.    
        ///    
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }


        /// <summary>
        /// Sets the StatusMessage property
        /// </summary>
        /// <param name="statusMessage">The value to set for the StatusMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Activity WithStatusMessage(string statusMessage)
        {
            this._statusMessage = statusMessage;
            return this;
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}