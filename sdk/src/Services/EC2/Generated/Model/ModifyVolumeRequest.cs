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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVolume operation.
    /// You can modify several parameters of an existing EBS volume, including volume size,
    /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
    /// EC2 instance type, you might be able to apply these changes without stopping the instance
    /// or detaching the volume from it. For more information about modifying EBS volumes,
    /// see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-modify-volume.html">Amazon
    /// EBS Elastic Volumes</a> in the <i>Amazon EBS User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you complete a resize operation on your volume, you need to extend the volume's
    /// file-system size to take advantage of the new storage capacity. For more information,
    /// see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recognize-expanded-volume-linux.html">Extend
    /// the file system</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-modifications.html">Monitor
    /// the progress of volume modifications</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// With previous-generation instance types, resizing an EBS volume might require detaching
    /// and reattaching the volume or stopping and restarting the instance.
    /// </para>
    ///  
    /// <para>
    /// After modifying a volume, you must wait at least six hours and ensure that the volume
    /// is in the <c>in-use</c> or <c>available</c> state before you can modify the same volume.
    /// This is sometimes referred to as a cooldown period.
    /// </para>
    /// </summary>
    public partial class ModifyVolumeRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _iops;
        private bool? _multiAttachEnabled;
        private int? _size;
        private int? _throughput;
        private string _volumeId;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The target IOPS rate of the volume. This parameter is valid only for <c>gp3</c>, <c>io1</c>,
        /// and <c>io2</c> volumes.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported values for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp3</c>: 3,000 - 80,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c>: 100 - 64,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io2</c>: 100 - 256,000 IOPS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For <c>io2</c> volumes, you can achieve up to 256,000 IOPS on <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">instances
        /// built on the Nitro System</a>. On other instances, you can achieve performance up
        /// to 32,000 IOPS.
        /// </para>
        ///  
        /// <para>
        /// Default: The existing value is retained if you keep the same volume type. If you change
        /// the volume type to <c>io1</c>, <c>io2</c>, or <c>gp3</c>, the default is 3,000.
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
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
        /// can attach the volume to up to 16 <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">
        /// Nitro-based instances</a> in the same Availability Zone. This parameter is supported
        /// with <c>io1</c> and <c>io2</c> volumes only. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volumes-multi.html">
        /// Amazon EBS Multi-Attach</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? MultiAttachEnabled
        {
            get { return this._multiAttachEnabled; }
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
        ///  <c>gp2</c>: 1 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gp3</c>: 1 - 65,536 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c>: 4 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io2</c>: 4 - 65,536 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>st1</c> and <c>sc1</c>: 125 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c>: 1 - 1024 GiB
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: The existing size is retained.
        /// </para>
        /// </summary>
        public int? Size
        {
            get { return this._size; }
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
        /// The target throughput of the volume, in MiB/s. This parameter is valid only for <c>gp3</c>
        /// volumes. The maximum value is 2,000.
        /// </para>
        ///  
        /// <para>
        /// Default: The existing value is retained if the source and target volume type is <c>gp3</c>.
        /// Otherwise, the default value is 125.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 125. Maximum value of 2,000.
        /// </para>
        /// </summary>
        public int? Throughput
        {
            get { return this._throughput; }
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
        /// The target EBS volume type of the volume. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volume-types.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: The existing type is retained.
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