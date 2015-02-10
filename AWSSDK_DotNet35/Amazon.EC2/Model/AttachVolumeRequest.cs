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
    /// Container for the parameters to the AttachVolume operation.
    /// Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the
    /// instance with the specified device name.
    /// 
    ///  
    /// <para>
    /// Encrypted Amazon EBS volumes may only be attached to instances that support Amazon
    /// EBS encryption. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
    /// an Amazon EBS Volume to an Instance</a>. Any device names that aren't reserved for
    /// instance store volumes can be used for Amazon EBS volumes. For more information, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
    /// EC2 Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// If a volume has an AWS Marketplace product code:
    /// </para>
    ///  <ul> <li>The volume can be attached only to a stopped instance.</li> <li>AWS Marketplace
    /// product codes are copied from the volume to the instance.</li> <li>You must be subscribed
    /// to the product.</li> <li>The instance type and operating system of the instance must
    /// support the product. For example, you can't detach a volume from a Windows instance
    /// and attach it to a Linux instance.</li> </ul> 
    /// <para>
    /// For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000">Introducing
    /// AWS Marketplace</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
    /// Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class AttachVolumeRequest : AmazonEC2Request
    {
        private string _device;
        private string _instanceId;
        private string _volumeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AttachVolumeRequest() { }

        /// <summary>
        /// Instantiates AttachVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume. The volume and instance must be within the same Availability Zone.</param>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="device">The device name to expose to the instance (for example, <code>/dev/sdh</code> or <code>xvdh</code>).</param>
        public AttachVolumeRequest(string volumeId, string instanceId, string device)
        {
            _volumeId = volumeId;
            _instanceId = instanceId;
            _device = device;
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name to expose to the instance (for example, <code>/dev/sdh</code> or <code>xvdh</code>).
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
        /// The ID of the Amazon EBS volume. The volume and instance must be within the same Availability
        /// Zone.
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