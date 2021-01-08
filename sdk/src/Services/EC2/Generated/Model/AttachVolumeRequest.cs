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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AttachVolume operation.
    /// Attaches an EBS volume to a running or stopped instance and exposes it to the instance
    /// with the specified device name.
    /// 
    ///  
    /// <para>
    /// Encrypted EBS volumes must be attached to instances that support Amazon EBS encryption.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you attach an EBS volume, you must make it available. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-using-volumes.html">Making
    /// an EBS volume available for use</a>.
    /// </para>
    ///  
    /// <para>
    /// If a volume has an AWS Marketplace product code:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The volume can be attached only to a stopped instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Marketplace product codes are copied from the volume to the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must be subscribed to the product.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The instance type and operating system of the instance must support the product. For
    /// example, you can't detach a volume from a Windows instance and attach it to a Linux
    /// instance.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
    /// Amazon EBS volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// <param name="volumeId">The ID of the EBS volume. The volume and instance must be within the same Availability Zone.</param>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="device">The device name (for example, <code>/dev/sdh</code> or <code>xvdh</code>).</param>
        public AttachVolumeRequest(string volumeId, string instanceId, string device)
        {
            _volumeId = volumeId;
            _instanceId = instanceId;
            _device = device;
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name (for example, <code>/dev/sdh</code> or <code>xvdh</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// The ID of the EBS volume. The volume and instance must be within the same Availability
        /// Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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