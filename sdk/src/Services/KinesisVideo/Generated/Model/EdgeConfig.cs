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
    /// A description of the stream's edge configuration that will be used to sync with the
    /// Edge Agent IoT Greengrass component. The Edge Agent component will run on an IoT Hub
    /// Device setup at your premise.
    /// </summary>
    public partial class EdgeConfig
    {
        private DeletionConfig _deletionConfig;
        private string _hubDeviceArn;
        private RecorderConfig _recorderConfig;
        private UploaderConfig _uploaderConfig;

        /// <summary>
        /// Gets and sets the property DeletionConfig. 
        /// <para>
        /// The deletion configuration is made up of the retention time (<code>EdgeRetentionInHours</code>)
        /// and local size configuration (<code>LocalSizeConfig</code>) details that are used
        /// to make the deletion.
        /// </para>
        /// </summary>
        public DeletionConfig DeletionConfig
        {
            get { return this._deletionConfig; }
            set { this._deletionConfig = value; }
        }

        // Check to see if DeletionConfig property is set
        internal bool IsSetDeletionConfig()
        {
            return this._deletionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HubDeviceArn. 
        /// <para>
        /// The "<b>Internet of Things (IoT) Thing</b>" Arn of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string HubDeviceArn
        {
            get { return this._hubDeviceArn; }
            set { this._hubDeviceArn = value; }
        }

        // Check to see if HubDeviceArn property is set
        internal bool IsSetHubDeviceArn()
        {
            return this._hubDeviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecorderConfig. 
        /// <para>
        /// The recorder configuration consists of the local <code>MediaSourceConfig</code> details,
        /// that are used as credentials to access the local media files streamed on the camera.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecorderConfig RecorderConfig
        {
            get { return this._recorderConfig; }
            set { this._recorderConfig = value; }
        }

        // Check to see if RecorderConfig property is set
        internal bool IsSetRecorderConfig()
        {
            return this._recorderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UploaderConfig. 
        /// <para>
        /// The uploader configuration contains the <code>ScheduleExpression</code> details that
        /// are used, to schedule upload jobs for the recorded media files from the Edge Agent,
        /// to a Kinesis Video Stream.
        /// </para>
        /// </summary>
        public UploaderConfig UploaderConfig
        {
            get { return this._uploaderConfig; }
            set { this._uploaderConfig = value; }
        }

        // Check to see if UploaderConfig property is set
        internal bool IsSetUploaderConfig()
        {
            return this._uploaderConfig != null;
        }

    }
}