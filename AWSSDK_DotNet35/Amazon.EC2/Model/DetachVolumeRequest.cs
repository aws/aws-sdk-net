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
    /// <para>Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems on the device within your operating system
    /// before detaching the volume. Failure to do so results in the volume being stuck in a busy state while detaching.</para> <para>If an Amazon
    /// EBS volume is the root device of an instance, it can't be detached while the instance is running. To detach the root volume, stop the
    /// instance first.</para> <para>If the root volume is detached from an instance with an AWS Marketplace product code, then the AWS Marketplace
    /// product codes from that volume are no longer associated with the instance.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html" >Detaching an Amazon EBS Volume</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DetachVolumeRequest : AmazonEC2Request
    {
        private string volumeId;
        private string instanceId;
        private string device;
        private bool? force;


        /// <summary>
        /// The ID of the volume.
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
        /// The ID of the instance.
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
        /// The device name.
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
        /// Forces detachment if the previous detachment attempt did not occur cleanly (for example, logging into an instance, unmounting the volume,
        /// and detaching normally). This option can lead to data loss or a corrupted file system. Use this option only as a last resort to detach a
        /// volume from a failed instance. The instance won't have an opportunity to flush file system caches or file system metadata. If you use this
        /// option, you must perform file system check and repair procedures.
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
    
