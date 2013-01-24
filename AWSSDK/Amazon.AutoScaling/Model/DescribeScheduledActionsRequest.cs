/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeScheduledActions operation.
    /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
    /// see the activity record returned in DescribeScalingActivities. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScheduledActions"/>
    public class DescribeScheduledActionsRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private List<string> scheduledActionNames = new List<string>();
        private DateTime? startTime;
        private DateTime? endTime;
        private string nextToken;
        private int? maxRecords;

        /// <summary>
        /// The name of the Auto Scaling group.
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
        public DescribeScheduledActionsRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// A list of scheduled actions to be described. If this list is omitted, all scheduled actions are described. The list of requested scheduled
        /// actions cannot contain more than 50 items. If an auto scaling group name is provided, the results are limited to that group. If unknown
        /// scheduled actions are requested, they are ignored with no error.
        ///  
        /// </summary>
        public List<string> ScheduledActionNames
        {
            get { return this.scheduledActionNames; }
            set { this.scheduledActionNames = value; }
        }
        /// <summary>
        /// Adds elements to the ScheduledActionNames collection
        /// </summary>
        /// <param name="scheduledActionNames">The values to add to the ScheduledActionNames collection </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithScheduledActionNames(params string[] scheduledActionNames)
        {
            foreach (string element in scheduledActionNames)
            {
                this.scheduledActionNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ScheduledActionNames collection
        /// </summary>
        /// <param name="scheduledActionNames">The values to add to the ScheduledActionNames collection </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithScheduledActionNames(IEnumerable<string> scheduledActionNames)
        {
            foreach (string element in scheduledActionNames)
            {
                this.scheduledActionNames.Add(element);
            }

            return this;
        }

        // Check to see if ScheduledActionNames property is set
        internal bool IsSetScheduledActionNames()
        {
            return this.scheduledActionNames.Count > 0;       
        }

        /// <summary>
        /// The earliest scheduled start time to return. If scheduled action names are provided, this field will be ignored.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithStartTime(DateTime startTime)
        {
            this.startTime = startTime;
            return this;
        }
            

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;       
        }

        /// <summary>
        /// The latest scheduled start time to return. If scheduled action names are provided, this field is ignored.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The value to set for the EndTime property </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithEndTime(DateTime endTime)
        {
            this.endTime = endTime;
            return this;
        }
            

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;       
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }

        /// <summary>
        /// The maximum number of scheduled actions to return.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 50</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeScheduledActionsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }
    }
}
    
