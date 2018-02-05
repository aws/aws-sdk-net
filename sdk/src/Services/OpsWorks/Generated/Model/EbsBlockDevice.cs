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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes an Amazon EBS volume. This data type maps directly to the Amazon EC2 <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_EbsBlockDevice.html">EbsBlockDevice</a>
    /// data type.
    /// </summary>
    public partial class EbsBlockDevice
    {
        private bool? _deleteOnTermination;
        private int? _iops;
        private string _snapshotId;
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Whether the volume is deleted on instance termination.
        /// </para>
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this._deleteOnTermination.GetValueOrDefault(); }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) that the volume supports. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_EbsBlockDevice.html">EbsBlockDevice</a>.
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
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The volume size, in GiB. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_EbsBlockDevice.html">EbsBlockDevice</a>.
        /// </para>
        /// </summary>
        public int VolumeSize
        {
            get { return this._volumeSize.GetValueOrDefault(); }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. <code>gp2</code> for General Purpose (SSD) volumes, <code>io1</code>
        /// for Provisioned IOPS (SSD) volumes, <code>st1</code> for Throughput Optimized hard
        /// disk drives (HDD), <code>sc1</code> for Cold HDD,and <code>standard</code> for Magnetic
        /// volumes.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>io1</code> volume type, you must also specify a value for
        /// the <code>Iops</code> attribute. The maximum ratio of provisioned IOPS to requested
        /// volume size (in GiB) is 50:1. AWS uses the default volume size (in GiB) specified
        /// in the AMI attributes to set IOPS to 50 x (volume size).
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