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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration that consists of the <c>ScheduleExpression</c> and the <c>DurationInMinutes</c>
    /// details that specify the scheduling to record from a camera, or local media file,
    /// onto the Edge Agent. If the <c>ScheduleConfig</c> is not provided in the <c>UploaderConfig</c>,
    /// then the Edge Agent will upload at regular intervals (every 1 hour).
    /// </summary>
    public partial class UploaderConfig
    {
        private ScheduleConfig _scheduleConfig;

        /// <summary>
        /// Gets and sets the property ScheduleConfig. 
        /// <para>
        /// The configuration that consists of the <c>ScheduleExpression</c> and the <c>DurationInMinutes</c>
        /// details that specify the scheduling to record from a camera, or local media file,
        /// onto the Edge Agent. If the <c>ScheduleConfig</c> is not provided in this <c>UploaderConfig</c>,
        /// then the Edge Agent will upload at regular intervals (every 1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleConfig ScheduleConfig
        {
            get { return this._scheduleConfig; }
            set { this._scheduleConfig = value; }
        }

        // Check to see if ScheduleConfig property is set
        internal bool IsSetScheduleConfig()
        {
            return this._scheduleConfig != null;
        }

    }
}