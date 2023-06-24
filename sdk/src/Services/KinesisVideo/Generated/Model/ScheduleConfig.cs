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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This API enables you to specify the duration that the camera, or local media file,
    /// should record onto the Edge Agent. The <code>ScheduleConfig</code> consists of the
    /// <code>ScheduleExpression</code> and the <code>DurationInMinutes</code> attributes.
    /// 
    /// 
    ///  
    /// <para>
    /// If the <code>ScheduleExpression</code> is not provided, then the Edge Agent will always
    /// be set to recording mode.
    /// </para>
    /// </summary>
    public partial class ScheduleConfig
    {
        private int? _durationInSeconds;
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The total duration to record the media. If the <code>ScheduleExpression</code> attribute
        /// is provided, then the <code>DurationInSeconds</code> attribute should also be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=3600)]
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The Quartz cron expression that takes care of scheduling jobs to record from the camera,
        /// or local media file, onto the Edge Agent. If the <code>ScheduleExpression</code> is
        /// not provided for the <code>RecorderConfig</code>, then the Edge Agent will always
        /// be set to recording mode.
        /// </para>
        ///  
        /// <para>
        /// For more information about Quartz, refer to the <a href="http://www.quartz-scheduler.org/documentation/quartz-2.3.0/tutorials/crontrigger.html">
        /// <i>Cron Trigger Tutorial</i> </a> page to understand the valid expressions and its
        /// use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=100)]
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

    }
}