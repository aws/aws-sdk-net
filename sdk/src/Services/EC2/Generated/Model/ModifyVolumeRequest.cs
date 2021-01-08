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
    /// Container for the parameters to the ModifyVolume operation.
    /// You can modify several parameters of an existing EBS volume, including volume size,
    /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
    /// EC2 instance type, you might be able to apply these changes without stopping the instance
    /// or detaching the volume from it. For more information about modifying an EBS volume
    /// running Linux, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
    /// the size, IOPS, or type of an EBS volume on Linux</a>. For more information about
    /// modifying an EBS volume running Windows, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
    /// the size, IOPS, or type of an EBS volume on Windows</a>.
    /// 
    ///  
    /// <para>
    ///  When you complete a resize operation on your volume, you need to extend the volume's
    /// file-system size to take advantage of the new storage capacity. For information about
    /// extending a Linux file system, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extending
    /// a Linux file system</a>. For information about extending a Windows file system, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extending
    /// a Windows file system</a>. 
    /// </para>
    ///  
    /// <para>
    ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
    /// For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
    /// CloudWatch Events User Guide</a>. You can also track the status of a modification
    /// using <a>DescribeVolumesModifications</a>. For information about tracking status changes
    /// using either method, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
    /// volume modifications</a>. 
    /// </para>
    ///  
    /// <para>
    /// With previous-generation instance types, resizing an EBS volume might require detaching
    /// and reattaching the volume or stopping and restarting the instance. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modify-volume.html">Amazon
    /// EBS Elastic Volumes</a> (Linux) or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-modify-volume.html">Amazon
    /// EBS Elastic Volumes</a> (Windows).
    /// </para>
    ///  
    /// <para>
    /// If you reach the maximum volume modification rate per volume limit, you will need
    /// to wait at least six hours before applying further modifications to the affected EBS
    /// volume.
    /// </para>
    /// </summary>
    public partial class ModifyVolumeRequest : AmazonEC2Request
    {
        private int? _iops;
        private bool? _multiAttachEnabled;
        private int? _size;
        private int? _throughput;
        private string _volumeId;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The target IOPS rate of the volume. This parameter is valid only for <code>gp3</code>,
        /// <code>io1</code>, and <code>io2</code> volumes.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported values for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp3</code>: 3,000-16,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code>: 100-64,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io2</code>: 100-64,000 IOPS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: If no IOPS value is specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAttachEnabled. 
        /// <para>
        /// Specifies whether to enable Amazon EBS Multi-Attach. If you enable Multi-Attach, you
        /// can attach the volume to up to 16 <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">
        /// Nitro-based instances</a> in the same Availability Zone. This parameter is supported
        /// with <code>io1</code> and <code>io2</code> volumes only. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-volumes-multi.html">
        /// Amazon EBS Multi-Attach</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public bool MultiAttachEnabled
        {
            get { return this._multiAttachEnabled.GetValueOrDefault(); }
            set { this._multiAttachEnabled = value; }
        }

        // Check to see if MultiAttachEnabled property is set
        internal bool IsSetMultiAttachEnabled()
        {
            return this._multiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The target size of the volume, in GiB. The target volume size must be greater than
        /// or equal to the existing size of the volume.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported volumes sizes for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp2</code> and <code>gp3</code>: 1-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code> and <code>io2</code>: 4-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>st1</code> and <code>sc1</code>: 125-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>standard</code>: 1-1,024
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: If no size is specified, the existing size is retained.
        /// </para>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The target throughput of the volume, in MiB/s. This parameter is valid only for <code>gp3</code>
        /// volumes. The maximum value is 1,000.
        /// </para>
        ///  
        /// <para>
        /// Default: If no throughput value is specified, the existing value is retained.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 125. Maximum value of 1000.
        /// </para>
        /// </summary>
        public int Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
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

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The target EBS volume type of the volume. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: If no type is specified, the existing type is retained.
        /// </para>
        /// </summary>
        public VolumeType VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}