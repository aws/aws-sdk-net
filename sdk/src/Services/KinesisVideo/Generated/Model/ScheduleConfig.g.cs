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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This API enables you to specify the duration that the camera, or local media file,
    /// should record onto the Edge Agent. The <c>ScheduleConfig</c> consists of the <c>ScheduleExpression</c>
    /// and the <c>DurationInMinutes</c> attributes. 
    /// 
    ///  
    /// <para>
    /// If the <c>ScheduleConfig</c> is not provided in the <c>RecorderConfig</c>, then the
    /// Edge Agent will always be set to recording mode.
    /// </para>
    ///  
    /// <para>
    /// If the <c>ScheduleConfig</c> is not provided in the <c>UploaderConfig</c>, then the
    /// Edge Agent will upload at regular intervals (every 1 hour).
    /// </para>
    /// </summary>
    public partial class ScheduleConfig
    {
        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The total duration to record the media. If the <c>ScheduleExpression</c> attribute
        /// is provided, then the <c>DurationInSeconds</c> attribute should also be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 3600)]
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The Quartz cron expression that takes care of scheduling jobs to record from the camera,
        /// or local media file, onto the Edge Agent. If the <c>ScheduleExpression</c> is not
        /// provided for the <c>RecorderConfig</c>, then the Edge Agent will always be set to
        /// recording mode.
        /// </para>
        ///  
        /// <para>
        /// For more information about Quartz, refer to the <a href="https://www.quartz-scheduler.org/documentation/quartz-2.3.0/tutorials/crontrigger.html">
        /// <i>Cron Trigger Tutorial</i> </a> page to understand the valid expressions and its
        /// use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 100)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;
    }
}
