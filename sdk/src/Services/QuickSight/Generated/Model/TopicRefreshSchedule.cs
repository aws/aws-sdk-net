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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a topic refresh schedule.
    /// </summary>
    public partial class TopicRefreshSchedule
    {
        private bool? _basedOnSpiceSchedule;
        private bool? _isEnabled;
        private string _repeatAt;
        private DateTime? _startingAt;
        private string _timezone;
        private TopicScheduleType _topicScheduleType;

        /// <summary>
        /// Gets and sets the property BasedOnSpiceSchedule. 
        /// <para>
        /// A Boolean value that controls whether to schedule runs at the same schedule that is
        /// specified in SPICE dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? BasedOnSpiceSchedule
        {
            get { return this._basedOnSpiceSchedule; }
            set { this._basedOnSpiceSchedule = value; }
        }

        // Check to see if BasedOnSpiceSchedule property is set
        internal bool IsSetBasedOnSpiceSchedule()
        {
            return this._basedOnSpiceSchedule.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A Boolean value that controls whether to schedule is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepeatAt. 
        /// <para>
        /// The time of day when the refresh should run, for example, Monday-Sunday.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RepeatAt
        {
            get { return this._repeatAt; }
            set { this._repeatAt = value; }
        }

        // Check to see if RepeatAt property is set
        internal bool IsSetRepeatAt()
        {
            return this._repeatAt != null;
        }

        /// <summary>
        /// Gets and sets the property StartingAt. 
        /// <para>
        /// The starting date and time for the refresh schedule.
        /// </para>
        /// </summary>
        public DateTime? StartingAt
        {
            get { return this._startingAt; }
            set { this._startingAt = value; }
        }

        // Check to see if StartingAt property is set
        internal bool IsSetStartingAt()
        {
            return this._startingAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone that you want the refresh schedule to use.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property TopicScheduleType. 
        /// <para>
        /// The type of refresh schedule. Valid values for this structure are <c>HOURLY</c>, <c>DAILY</c>,
        /// <c>WEEKLY</c>, and <c>MONTHLY</c>.
        /// </para>
        /// </summary>
        public TopicScheduleType TopicScheduleType
        {
            get { return this._topicScheduleType; }
            set { this._topicScheduleType = value; }
        }

        // Check to see if TopicScheduleType property is set
        internal bool IsSetTopicScheduleType()
        {
            return this._topicScheduleType != null;
        }

    }
}