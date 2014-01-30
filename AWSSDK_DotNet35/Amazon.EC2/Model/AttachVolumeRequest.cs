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
    /// Container for the parameters to the AttachVolume operation.
    /// <para>Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the instance with the specified device name.</para>
    /// <para>For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html"
    /// >Attaching an Amazon EBS Volume to an Instance</a> . Any device names that aren't reserved for instance store volumes can be used for Amazon
    /// EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html" >Amazon EC2
    /// Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If a volume has an AWS Marketplace product
    /// code:</para>
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
    public partial class AttachVolumeRequest : AmazonEC2Request
    {
        private string volumeId;
        private string instanceId;
        private string device;


        /// <summary>
        /// The ID of the Amazon EBS volume. The volume and instance must be within the same Availability Zone.
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
        /// The device name to expose to the instance (for example, <c>/dev/sdh</c> or <c>xvdh</c>).
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

    }
}
    
