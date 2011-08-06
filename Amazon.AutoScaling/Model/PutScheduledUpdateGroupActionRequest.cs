/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the PutScheduledUpdateGroupAction operation.
    /// <para> Creates a scheduled scaling action for a Auto Scaling group. If you leave a parameter unspecified, the corresponding value remains
    /// unchanged in the affected Auto Scaling group. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutScheduledUpdateGroupAction"/>
    public class PutScheduledUpdateGroupActionRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private string scheduledActionName;
        private DateTime? time;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;

        /// <summary>
        /// The name or ARN of the Auto Scaling Group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
        }
            

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;       
        }

        /// <summary>
        /// The name of this scaling action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this.scheduledActionName; }
            set { this.scheduledActionName = value; }
        }

        /// <summary>
        /// Sets the ScheduledActionName property
        /// </summary>
        /// <param name="scheduledActionName">The value to set for the ScheduledActionName property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithScheduledActionName(string scheduledActionName)
        {
            this.scheduledActionName = scheduledActionName;
            return this;
        }
            

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this.scheduledActionName != null;       
        }

        /// <summary>
        /// The time for this action to start.
        ///  
        /// </summary>
        public DateTime Time
        {
            get { return this.time ?? default(DateTime); }
            set { this.time = value; }
        }

        /// <summary>
        /// Sets the Time property
        /// </summary>
        /// <param name="time">The value to set for the Time property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithTime(DateTime time)
        {
            this.time = time;
            return this;
        }
            

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this.time.HasValue;       
        }

        /// <summary>
        /// The minimum size for the new Auto Scaling group.
        ///  
        /// </summary>
        public int MinSize
        {
            get { return this.minSize ?? default(int); }
            set { this.minSize = value; }
        }

        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">The value to set for the MinSize property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithMinSize(int minSize)
        {
            this.minSize = minSize;
            return this;
        }
            

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this.minSize.HasValue;       
        }

        /// <summary>
        /// The maximum size for the Auto Scaling group.
        ///  
        /// </summary>
        public int MaxSize
        {
            get { return this.maxSize ?? default(int); }
            set { this.maxSize = value; }
        }

        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">The value to set for the MaxSize property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithMaxSize(int maxSize)
        {
            this.maxSize = maxSize;
            return this;
        }
            

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this.maxSize.HasValue;       
        }

        /// <summary>
        /// The number of EC2 instances that should be running in the group.
        ///  
        /// </summary>
        public int DesiredCapacity
        {
            get { return this.desiredCapacity ?? default(int); }
            set { this.desiredCapacity = value; }
        }

        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">The value to set for the DesiredCapacity property </param>
        /// <returns>this instance</returns>
        public PutScheduledUpdateGroupActionRequest WithDesiredCapacity(int desiredCapacity)
        {
            this.desiredCapacity = desiredCapacity;
            return this;
        }
            

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this.desiredCapacity.HasValue;       
        }
    }
}
    
