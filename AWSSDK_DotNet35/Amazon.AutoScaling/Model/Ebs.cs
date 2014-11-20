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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an Amazon EBS volume.
    /// </summary>
    public partial class Ebs
    {
        private bool? _deleteOnTermination;
        private int? _iops;
        private string _snapshotId;
        private int? _volumeSize;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether to delete the volume on instance termination.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
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
        /// For Provisioned IOPS (SSD) volumes only. The number of I/O operations per second (IOPS)
        /// to provision for the volume.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Range is 100 to 4000.
        /// </para>
        ///  
        /// <para>
        /// Default: None
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
        /// The ID of the snapshot.
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
        /// The volume size, in gigabytes.
        /// </para>
        ///  
        /// <para>
        /// Valid values: If the volume type is <code>io1</code>, the minimum size of the volume
        /// is 10 GiB. If you specify <code>SnapshotId</code> and <code>VolumeSize</code>, <code>VolumeSize</code>
        /// must be equal to or larger than the size of the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Default: If you create a volume from a snapshot and you don't specify a volume size,
        /// the default is the size of the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Required: Required when the volume type is <code>io1</code>. 
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
        /// The volume type.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>standard | io1 | gp2</code>
        /// </para>
        ///  
        /// <para>
        /// Default: <code>standard</code>
        /// </para>
        /// </summary>
        public string VolumeType
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