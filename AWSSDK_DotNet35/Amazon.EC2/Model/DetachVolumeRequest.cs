/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems
    /// on the device within your operating system before detaching the volume. Failure to
    /// do so results in the volume being stuck in a busy state while detaching.
    /// 
    ///  
    /// <para>
    /// If an Amazon EBS volume is the root device of an instance, it can't be detached while
    /// the instance is running. To detach the root volume, stop the instance first.
    /// </para>
    ///  
    /// <para>
    /// When a volume with an AWS Marketplace product code is detached from an instance, the
    /// product code is no longer associated with the instance.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detaching
    /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DetachVolumeRequest : AmazonEC2Request
    {
        private string _device;
        private bool? _force;
        private string _instanceId;
        private string _volumeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DetachVolumeRequest() { }

        /// <summary>
        /// Instantiates DetachVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeId">The ID of the volume.</param>
        public DetachVolumeRequest(string volumeId)
        {
            _volumeId = volumeId;
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name.
        /// </para>
        /// </summary>
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces detachment if the previous detachment attempt did not occur cleanly (for example,
        /// logging into an instance, unmounting the volume, and detaching normally). This option
        /// can lead to data loss or a corrupted file system. Use this option only as a last resort
        /// to detach a volume from a failed instance. The instance won't have an opportunity
        /// to flush file system caches or file system metadata. If you use this option, you must
        /// perform file system check and repair procedures.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}