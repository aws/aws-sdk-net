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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifyVolume operation.
    /// You can modify several parameters of an existing EBS volume, including volume size,
    /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
    /// EC2 instance type, you may be able to apply these changes without stopping the instance
    /// or detaching the volume from it. For more information about modifying an EBS volume
    /// running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
    /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
    /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
    /// the Size, IOPS, or Type of an EBS Volume on Windows</a>. 
    /// 
    ///  
    /// <para>
    ///  When you complete a resize operation on your volume, you need to extend the volume's
    /// file-system size to take advantage of the new storage capacity. For information about
    /// extending a Linux file system, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extending
    /// a Linux File System</a>. For information about extending a Windows file system, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extending
    /// a Windows File System</a>. 
    /// </para>
    ///  
    /// <para>
    ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
    /// For information about CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
    /// CloudWatch Events User Guide</a>. You can also track the status of a modification
    /// using the <a>DescribeVolumesModifications</a> API. For information about tracking
    /// status changes using either method, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
    /// Volume Modifications</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// With previous-generation instance types, resizing an EBS volume may require detaching
    /// and reattaching the volume or stopping and restarting the instance. For more information
    /// about modifying an EBS volume running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
    /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
    /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
    /// the Size, IOPS, or Type of an EBS Volume on Windows</a>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// If you reach the maximum volume modification rate per volume limit, you will need
    /// to wait at least six hours before applying further modifications to the affected EBS
    /// volume.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyVolumeRequest : AmazonEC2Request
    {
        private int? _iops;
        private int? _size;
        private string _volumeId;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Target IOPS rate of the volume to be modified.
        /// </para>
        ///  
        /// <para>
        /// Only valid for Provisioned IOPS SSD (<code>io1</code>) volumes. For more information
        /// about <code>io1</code> IOPS configuration, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html#EBSVolumeTypes_piops">http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html#EBSVolumeTypes_piops</a>.
        /// </para>
        ///  
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
        /// Gets and sets the property Size. 
        /// <para>
        /// Target size in GiB of the volume to be modified. Target volume size must be greater
        /// than or equal to than the existing size of the volume. For information about available
        /// EBS volume sizes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html</a>.
        /// </para>
        ///  
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

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// Target EBS volume type of the volume to be modified
        /// </para>
        ///  
        /// <para>
        ///  The API does not support modifications for volume type <code>standard</code>. You
        /// also cannot change the type of a volume to <code>standard</code>. 
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