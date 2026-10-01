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
    /// A description of the stream's edge configuration that will be used to sync with the
    /// Edge Agent IoT Greengrass component. The Edge Agent component will run on an IoT Hub
    /// Device setup at your premise.
    /// </summary>
    public partial class EdgeConfig
    {
        /// <summary>
        /// Gets and sets the property DeletionConfig. 
        /// <para>
        /// The deletion configuration is made up of the retention time (<c>EdgeRetentionInHours</c>)
        /// and local size configuration (<c>LocalSizeConfig</c>) details that are used to make
        /// the deletion.
        /// </para>
        /// </summary>
        public DeletionConfig DeletionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeletionConfig property is set.
        /// </summary>
        internal bool IsSetDeletionConfig() => this.DeletionConfig != null;

        /// <summary>
        /// Gets and sets the property HubDeviceArn. 
        /// <para>
        /// The "<b>Internet of Things (IoT) Thing</b>" Arn of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string HubDeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the HubDeviceArn property is set.
        /// </summary>
        internal bool IsSetHubDeviceArn() => this.HubDeviceArn != null;

        /// <summary>
        /// Gets and sets the property RecorderConfig. 
        /// <para>
        /// The recorder configuration consists of the local <c>MediaSourceConfig</c> details,
        /// that are used as credentials to access the local media files streamed on the camera.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecorderConfig RecorderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RecorderConfig property is set.
        /// </summary>
        internal bool IsSetRecorderConfig() => this.RecorderConfig != null;

        /// <summary>
        /// Gets and sets the property UploaderConfig. 
        /// <para>
        /// The uploader configuration contains the <c>ScheduleExpression</c> details that are
        /// used to schedule upload jobs for the recorded media files from the Edge Agent to a
        /// Kinesis Video Stream.
        /// </para>
        /// </summary>
        public UploaderConfig UploaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the UploaderConfig property is set.
        /// </summary>
        internal bool IsSetUploaderConfig() => this.UploaderConfig != null;
    }
}
