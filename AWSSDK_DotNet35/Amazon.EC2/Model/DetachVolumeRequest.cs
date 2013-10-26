/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DetachVolume operation.
    /// <para> Detach a previously attached volume from a running instance. </para>
    /// </summary>
    public partial class DetachVolumeRequest : AmazonEC2Request
    {
        private string volumeId;
        private string instanceId;
        private string device;
        private bool? force;


        /// <summary>
        /// The ID of the volume to detach.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// The ID of the instance from which to detach the the specified volume.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The device name to which the volume is attached on the specified instance.
        ///  
        /// </summary>
        public string Device
        {
            get { return this.device; }
            set { this.device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this.device != null;
        }

        /// <summary>
        /// Forces detachment if the previous detachment attempt did not occur cleanly (logging into an instance, unmounting the volume, and detaching
        /// normally). This option can lead to data loss or a corrupted file system. Use this option only as a last resort to detach a volume from a
        /// failed instance. The instance will not have an opportunity to flush file system caches nor file system meta data. If you use this option,
        /// you must perform file system check and repair procedures.
        ///  
        /// </summary>
        public bool Force
        {
            get { return this.force ?? default(bool); }
            set { this.force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this.force.HasValue;
        }

    }
}
    
