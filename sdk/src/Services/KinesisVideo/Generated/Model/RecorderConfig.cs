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
    /// The recorder configuration consists of the local <code>MediaSourceConfig</code> details
    /// that are used as credentials to accesss the local media files streamed on the camera.
    /// </summary>
    public partial class RecorderConfig
    {
        private MediaSourceConfig _mediaSourceConfig;
        private ScheduleConfig _scheduleConfig;

        /// <summary>
        /// Gets and sets the property MediaSourceConfig. 
        /// <para>
        /// The configuration details that consist of the credentials required (<code>MediaUriSecretArn</code>
        /// and <code>MediaUriType</code>) to access the media files streamed to the camera. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaSourceConfig MediaSourceConfig
        {
            get { return this._mediaSourceConfig; }
            set { this._mediaSourceConfig = value; }
        }

        // Check to see if MediaSourceConfig property is set
        internal bool IsSetMediaSourceConfig()
        {
            return this._mediaSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfig. 
        /// <para>
        /// The configuration that consists of the <code>ScheduleExpression</code> and the <code>DurationInMinutes</code>
        /// details that specify the scheduling to record from a camera, or local media file,
        /// onto the Edge Agent. If the <code>ScheduleExpression</code> attribute is not provided,
        /// then the Edge Agent will always be set to recording mode.
        /// </para>
        /// </summary>
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