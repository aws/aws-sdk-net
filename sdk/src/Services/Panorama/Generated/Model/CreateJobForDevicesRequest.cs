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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJobForDevices operation.
    /// Creates a job to run on a device. A job can update a device's software or reboot it.
    /// </summary>
    public partial class CreateJobForDevicesRequest : AmazonPanoramaRequest
    {
        private List<string> _deviceIds = new List<string>();
        private DeviceJobConfig _deviceJobConfig;
        private JobType _jobType;

        /// <summary>
        /// Gets and sets the property DeviceIds. 
        /// <para>
        /// ID of target device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> DeviceIds
        {
            get { return this._deviceIds; }
            set { this._deviceIds = value; }
        }

        // Check to see if DeviceIds property is set
        internal bool IsSetDeviceIds()
        {
            return this._deviceIds != null && this._deviceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceJobConfig. 
        /// <para>
        /// Configuration settings for a software update job.
        /// </para>
        /// </summary>
        public DeviceJobConfig DeviceJobConfig
        {
            get { return this._deviceJobConfig; }
            set { this._deviceJobConfig = value; }
        }

        // Check to see if DeviceJobConfig property is set
        internal bool IsSetDeviceJobConfig()
        {
            return this._deviceJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

    }
}