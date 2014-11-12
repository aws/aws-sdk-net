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
    /// This data type stores information about a            scheduled update
    /// to an Auto Scaling group.
    /// </summary>
    public partial class ScheduledUpdateGroupAction
    {
        private string _autoScalingGroupName;
        private int? _desiredCapacity;
        private DateTime? _endTime;
        private int? _maxSize;
        private int? _minSize;
        private string _recurrence;
        private string _scheduledActionARN;
        private string _scheduledActionName;
        private DateTime? _startTime;
        private DateTime? _time;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///             The name of the Auto Scaling group to be updated.        
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
        public ScheduledUpdateGroupAction WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        ///             The number of instances you prefer to maintain in your            Auto
        /// Scaling group.                    
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }


        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">The value to set for the DesiredCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithDesiredCapacity(int desiredCapacity)
        {
            this._desiredCapacity = desiredCapacity;
            return this;
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///             The time that the action is scheduled to end.            This value can
        /// be up to one month in the future.        
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
        public ScheduledUpdateGroupAction WithEndTime(DateTime endTime)
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
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///             The maximum size of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }


        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">The value to set for the MaxSize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithMaxSize(int maxSize)
        {
            this._maxSize = maxSize;
            return this;
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        ///             The minimum size of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }


        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">The value to set for the MinSize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithMinSize(int minSize)
        {
            this._minSize = minSize;
            return this;
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        ///             The regular schedule that an action occurs.        
        /// </para>
        /// </summary>
        public string Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }


        /// <summary>
        /// Sets the Recurrence property
        /// </summary>
        /// <param name="recurrence">The value to set for the Recurrence property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithRecurrence(string recurrence)
        {
            this._recurrence = recurrence;
            return this;
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }


        /// <summary>
        /// Gets and sets the property ScheduledActionARN. 
        /// <para>
        ///             The Amazon Resource Name (ARN) of this scheduled action.        
        /// </para>
        /// </summary>
        public string ScheduledActionARN
        {
            get { return this._scheduledActionARN; }
            set { this._scheduledActionARN = value; }
        }


        /// <summary>
        /// Sets the ScheduledActionARN property
        /// </summary>
        /// <param name="scheduledActionARN">The value to set for the ScheduledActionARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithScheduledActionARN(string scheduledActionARN)
        {
            this._scheduledActionARN = scheduledActionARN;
            return this;
        }

        // Check to see if ScheduledActionARN property is set
        internal bool IsSetScheduledActionARN()
        {
            return this._scheduledActionARN != null;
        }


        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        ///             The name of this scheduled action.        
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this._scheduledActionName; }
            set { this._scheduledActionName = value; }
        }


        /// <summary>
        /// Sets the ScheduledActionName property
        /// </summary>
        /// <param name="scheduledActionName">The value to set for the ScheduledActionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithScheduledActionName(string scheduledActionName)
        {
            this._scheduledActionName = scheduledActionName;
            return this;
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this._scheduledActionName != null;
        }


        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///             The time that the action is scheduled to begin.            This value
        /// can be up to one month in the future.        
        /// </para>
        ///         
        /// <para>
        /// When <code>StartTime</code> and <code>EndTime</code> are specified with <code>Recurrence</code>,
        /// they form the boundaries of when the recurring            action will start and stop.
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
        public ScheduledUpdateGroupAction WithStartTime(DateTime startTime)
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
        /// Gets and sets the property Time. 
        /// <para>
        ///             <code>Time</code> is deprecated.
        /// </para>
        ///         
        /// <para>
        /// The time that the action is scheduled to begin.            <code>Time</code> is an
        /// alias for <code>StartTime</code>.        
        /// </para>
        /// </summary>
        public DateTime Time
        {
            get { return this._time.GetValueOrDefault(); }
            set { this._time = value; }
        }


        /// <summary>
        /// Sets the Time property
        /// </summary>
        /// <param name="time">The value to set for the Time property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduledUpdateGroupAction WithTime(DateTime time)
        {
            this._time = time;
            return this;
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}