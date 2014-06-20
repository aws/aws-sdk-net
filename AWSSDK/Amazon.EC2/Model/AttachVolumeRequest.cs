/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AttachVolume operation.
    /// <para>Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the instance with the specified device name.</para>
    /// <para>Encrypted Amazon EBS volumes may only be attached to instances that support Amazon EBS encryption. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html" >Amazon EBS Encryption</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para> <para>For a list of supported device names, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html" >Attaching an Amazon EBS Volume to an Instance</a> . Any
    /// device names that aren't reserved for instance store volumes can be used for Amazon EBS volumes. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html" >Amazon EC2 Instance Store</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para> <para>If a volume has an AWS Marketplace product code:</para>
    /// <ul>
    /// <li>The volume can only be attached as the root device of a stopped instance.</li>
    /// <li>You must be subscribed to the AWS Marketplace code that is on the volume.</li>
    /// <li>The configuration (instance type, operating system) of the instance must support that specific AWS Marketplace code. For example, you
    /// cannot take a volume from a Windows instance and attach it to a Linux instance.</li>
    /// <li>AWS Marketplace product codes are copied from the volume to the instance.</li>
    /// 
    /// </ul>
    /// <para>For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000"
    /// >https://aws.amazon.com/marketplace/help/200900000</a> . For more information about how to use the AWS Marketplace, see <a
    /// href="https://aws.amazon.com/marketplace" >AWS Marketplace</a> .</para> <para>For more information about Amazon EBS volumes, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html" >Attaching Amazon EBS Volumes</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AttachVolumeRequest : EC2Request
    {    
        private string volumeIdField;
        private string instanceIdField;
        private string deviceField;

        /// <summary>
        /// The ID of the Amazon EBS volume.
        /// The volume and instance must be within the same Availability Zone and the
        /// instance must be running.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Amazon EBS volume.
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachVolumeRequest WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// The ID of the instance to which the volume attaches.
        /// The volume and instance must be within the same Availability Zone
        /// and the instance must be running.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance to which the volume attaches.
        /// </summary>
        /// <param name="instanceId">The ID of the instance to which the volume
        /// attaches.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachVolumeRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// The device name as exposed to the instance (e.g., /dev/sdh, or xvdh).
        /// </summary>
        [XmlElementAttribute(ElementName = "Device")]
        public string Device
        {
            get { return this.deviceField; }
            set { this.deviceField = value; }
        }

        /// <summary>
        /// Sets the device name as exposed to the instance (e.g., /dev/sdh, or xvdh).
        /// </summary>
        /// <param name="device">Specifies how the device is exposed to the
        /// instance (e.g., /dev/sdh).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachVolumeRequest WithDevice(string device)
        {
            this.deviceField = device;
            return this;
        }

        /// <summary>
        /// Checks if Device property is set
        /// </summary>
        /// <returns>true if Device property is set</returns>
        public bool IsSetDevice()
        {
            return this.deviceField != null;
        }

    }
}
