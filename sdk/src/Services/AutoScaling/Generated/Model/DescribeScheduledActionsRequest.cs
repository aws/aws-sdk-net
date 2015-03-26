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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Lists the actions scheduled for your Auto Scaling group that haven't been executed.
    /// To list the actions that were already executed, use <a>DescribeScalingActivities</a>.
    /// </summary>
    public partial class DescribeScheduledActionsRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private DateTime? _endTime;
        private int? _maxRecords;
        private string _nextToken;
        private List<string> _scheduledActionNames = new List<string>();
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The latest scheduled start time to return. If scheduled action names are provided,
        /// this parameter is ignored.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionNames. 
        /// <para>
        /// Describes one or more scheduled actions. If you omit this list, the call describes
        /// all scheduled actions. If you specify an unknown scheduled action it is ignored with
        /// no error.
        /// </para>
        ///  
        /// <para>
        /// You can describe up to a maximum of 50 instances with a single call. If there are
        /// more items to return, the call returns a token. To get the next set of items, repeat
        /// the call with the returned token in the <code>NextToken</code> parameter.
        /// </para>
        /// </summary>
        public List<string> ScheduledActionNames
        {
            get { return this._scheduledActionNames; }
            set { this._scheduledActionNames = value; }
        }

        // Check to see if ScheduledActionNames property is set
        internal bool IsSetScheduledActionNames()
        {
            return this._scheduledActionNames != null && this._scheduledActionNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The earliest scheduled start time to return. If scheduled action names are provided,
        /// this parameter is ignored.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}