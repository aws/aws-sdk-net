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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ScheduledTriggerProperties
    {
        private DataPullMode _dataPullMode;
        private DateTime? _firstExecutionFrom;
        private DateTime? _scheduleEndTime;
        private string _scheduleExpression;
        private long? _scheduleOffset;
        private DateTime? _scheduleStartTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property DataPullMode.
        /// </summary>
        public DataPullMode DataPullMode
        {
            get { return this._dataPullMode; }
            set { this._dataPullMode = value; }
        }

        // Check to see if DataPullMode property is set
        internal bool IsSetDataPullMode()
        {
            return this._dataPullMode != null;
        }

        /// <summary>
        /// Gets and sets the property FirstExecutionFrom.
        /// </summary>
        public DateTime FirstExecutionFrom
        {
            get { return this._firstExecutionFrom.GetValueOrDefault(); }
            set { this._firstExecutionFrom = value; }
        }

        // Check to see if FirstExecutionFrom property is set
        internal bool IsSetFirstExecutionFrom()
        {
            return this._firstExecutionFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleEndTime.
        /// </summary>
        public DateTime ScheduleEndTime
        {
            get { return this._scheduleEndTime.GetValueOrDefault(); }
            set { this._scheduleEndTime = value; }
        }

        // Check to see if ScheduleEndTime property is set
        internal bool IsSetScheduleEndTime()
        {
            return this._scheduleEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression.
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleOffset.
        /// </summary>
        [AWSProperty(Min=0, Max=36000)]
        public long ScheduleOffset
        {
            get { return this._scheduleOffset.GetValueOrDefault(); }
            set { this._scheduleOffset = value; }
        }

        // Check to see if ScheduleOffset property is set
        internal bool IsSetScheduleOffset()
        {
            return this._scheduleOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleStartTime.
        /// </summary>
        public DateTime ScheduleStartTime
        {
            get { return this._scheduleStartTime.GetValueOrDefault(); }
            set { this._scheduleStartTime = value; }
        }

        // Check to see if ScheduleStartTime property is set
        internal bool IsSetScheduleStartTime()
        {
            return this._scheduleStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone.
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

    }
}