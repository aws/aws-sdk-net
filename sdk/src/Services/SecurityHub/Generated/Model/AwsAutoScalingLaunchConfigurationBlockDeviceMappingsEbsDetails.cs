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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Parameters that are used to automatically set up EBS volumes when an instance is launched.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationBlockDeviceMappingsEbsDetails
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _snapshotId;
        private int? _volumeSize;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Whether to delete the volume when the instance is terminated.
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether to encrypt the volume.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of input/output (I/O) operations per second (IOPS) to provision for the
        /// volume.
        /// </para>
        ///  
        /// <para>
        /// Only supported for <code>gp3</code> or <code>io1</code> volumes. Required for <code>io1</code>
        /// volumes. Not used with <code>standard</code>, <code>gp2</code>, <code>st1</code>,
        /// or <code>sc1</code> volumes.
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
        /// The snapshot ID of the volume to use.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>VolumeSize</code> or <code>SnapshotId</code>.
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
        /// The volume size, in GiBs. The following are the supported volumes sizes for each volume
        /// type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// gp2 and gp3: 1-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// io1: 4-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// st1 and sc1: 125-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// standard: 1-1,024
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must specify either <code>SnapshotId</code> or <code>VolumeSize</code>. If you
        /// specify both <code>SnapshotId</code> and <code>VolumeSize</code>, the volume size
        /// must be equal or greater than the size of the snapshot.
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
        /// The volume type. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>gp3</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sc1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>st1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>standard</code> 
        /// </para>
        ///  </li> </ul>
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