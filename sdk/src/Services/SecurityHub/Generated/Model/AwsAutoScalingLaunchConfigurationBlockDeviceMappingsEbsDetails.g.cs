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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Parameters that are used to automatically set up EBS volumes when an instance is launched.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationBlockDeviceMappingsEbsDetails
    {
        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Whether to delete the volume when the instance is terminated.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether to encrypt the volume.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of input/output (I/O) operations per second (IOPS) to provision for the
        /// volume.
        /// </para>
        ///  
        /// <para>
        /// Only supported for <c>gp3</c> or <c>io1</c> volumes. Required for <c>io1</c> volumes.
        /// Not used with <c>standard</c>, <c>gp2</c>, <c>st1</c>, or <c>sc1</c> volumes.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID of the volume to use.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>VolumeSize</c> or <c>SnapshotId</c>.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

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
        /// You must specify either <c>SnapshotId</c> or <c>VolumeSize</c>. If you specify both
        /// <c>SnapshotId</c> and <c>VolumeSize</c>, the volume size must be equal or greater
        /// than the size of the snapshot.
        /// </para>
        /// </summary>
        public int? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gp3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sc1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>st1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
