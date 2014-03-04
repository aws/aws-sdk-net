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
    /// Information about an EBS block device.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class EbsBlockDevice
    {    
        private string snapshotIdField;
        private Decimal? volumeSizeField;
        private bool? deleteOnTerminationField;
        private string volumeTypeField;
        private string iopsField;

        /// <summary>
        /// The ID of the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the snapshot.
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EbsBlockDevice WithSnapshotId(string snapshotId)
        {
            this.snapshotIdField = snapshotId;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotId property is set
        /// </summary>
        /// <returns>true if SnapshotId property is set</returns>
        public bool IsSetSnapshotId()
        {
            return this.snapshotIdField != null;
        }

        /// <summary>
        /// Size of the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeSize")]
        public Decimal VolumeSize
        {
            get { return this.volumeSizeField.GetValueOrDefault(); }
            set { this.volumeSizeField = value; }
        }

        /// <summary>
        /// Sets the size of the volume.
        /// </summary>
        /// <param name="volumeSize">Size of the volume.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EbsBlockDevice WithVolumeSize(Decimal volumeSize)
        {
            this.volumeSizeField = volumeSize;
            return this;
        }

        /// <summary>
        /// Checks if VolumeSize property is set
        /// </summary>
        /// <returns>true if VolumeSize property is set</returns>
        public bool IsSetVolumeSize()
        {
            return this.volumeSizeField.HasValue;
        }

        /// <summary>
        /// Whether the EBS block device is deleted on instance termination.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the EBS block device is deleted on instance termination.
        /// </summary>
        /// <param name="deleteOnTermination">Whether the EBS block device is deleted on
        /// instance termination.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EbsBlockDevice WithDeleteOnTermination(bool deleteOnTermination)
        {
            this.deleteOnTerminationField = deleteOnTermination;
            return this;
        }

        /// <summary>
        /// Checks if DeleteOnTermination property is set
        /// </summary>
        /// <returns>true if DeleteOnTermination property is set</returns>
        public bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTerminationField.HasValue;
        }

        /// <summary>
        /// Quantity of desired throughput in IOPS.
        /// </summary>
        [XmlElementAttribute(ElementName = "IOPS")]
        public string IOPS
        {
            get { return this.iopsField; }
            set { this.iopsField = value; }
        }

        /// <summary>
        /// Sets quantity of desired throughput in IOPS.
        /// </summary>
        /// <param name="iops">Quantity of desired throughput in IOPS</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EbsBlockDevice WithIOPS(string iops)
        {
            this.iopsField = iops;
            return this;
        }

        /// <summary>
        /// Checks if IOPS property is set
        /// </summary>
        /// <returns>True if IOPS property is set</returns>
        public bool IsSetIOPS()
        {
            return this.iopsField != null;
        }

        /// <summary>
        /// The volume type.
        /// Constraints: may be either "io1" or "standard".
        /// If VolumeType != "io1", IOPS property cannot be set.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeType")]
        public string VolumeType
        {
            get { return this.volumeTypeField; }
            set { this.volumeTypeField = value; }
        }

        /// <summary>
        /// Sets the volume type.
        /// </summary>
        /// <param name="volumeType">Volume Type.
        /// Constraints: may be either "io1" or "standard".
        /// If VolumeType != "io1", IOPS property cannot be set.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EbsBlockDevice WithVolumeType(string volumeType)
        {
            this.volumeTypeField = volumeType;
            return this;
        }

        /// <summary>
        /// Checks if VolumeType property is set
        /// </summary>
        /// <returns>True if VolumeType property is set</returns>
        public bool IsSetVolumeType()
        {
            return this.volumeTypeField != null;
        }
    }
}
