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
    /// Container for the parameters to the DescribeScheduledActions operation.
    /// Gets information about the scheduled actions that haven't run or that have not reached
    /// their end time.
    /// 
    ///  
    /// <para>
    /// To describe the scaling activities for scheduled actions that have already run, call
    /// the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeScalingActivities.html">DescribeScalingActivities</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class DescribeScheduledActionsRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private DateTime? _endTime;
        private int? _maxRecords;
        private string _nextToken;
        private List<string> _scheduledActionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// this property is ignored.
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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <c>50</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
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
        /// The names of one or more scheduled actions. If you omit this property, all scheduled
        /// actions are described. If you specify an unknown scheduled action, it is ignored with
        /// no error.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 50 actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScheduledActionNames
        {
            get { return this._scheduledActionNames; }
            set { this._scheduledActionNames = value; }
        }

        // Check to see if ScheduledActionNames property is set
        internal bool IsSetScheduledActionNames()
        {
            return this._scheduledActionNames != null && (this._scheduledActionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The earliest scheduled start time to return. If scheduled action names are provided,
        /// this property is ignored.
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

    }
}