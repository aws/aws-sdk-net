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
    /// Creates a new Amazon EBS volume that can be attached to any Amazon EC2
    /// instance in the same Availability Zone.
    /// Any AWS Marketplace product codes from the snapshot are propagated to the volume.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVolumeRequest
    {    
        private string sizeField;
        private string snapshotIdField;
        private string availabilityZoneField;
        private string volumeTypeField;
        private string iopsField;

        /// <summary>
        /// The size of the volume, in GiBs.
        /// Required if you are not creating a volume from a snapshot.
        ///
        /// Valid Values: 1-1024
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public string Size
        {
            get { return this.sizeField; }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the size of the volume, in GiBs.
        /// </summary>
        /// <param name="size">The size of the volume, in GiBs. Required if
        /// you are not creating
        /// a volume from a snapshot.
        ///
        /// Valid Values: 1-1024</param>
        /// <returns>this instance</returns>
        public CreateVolumeRequest WithSize(string size)
        {
            this.sizeField = size;
            return this;
        }

        /// <summary>
        /// Checks if Size property is set
        /// </summary>
        /// <returns>true if Size property is set</returns>
        public bool IsSetSize()
        {
            return this.sizeField != null;
        }

        /// <summary>
        /// The snapshot from which to create the new volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the snapshot from which to create the new volume.
        /// </summary>
        /// <param name="snapshotId">The snapshot from which to create the new
        /// volume.</param>
        /// <returns>this instance</returns>
        public CreateVolumeRequest WithSnapshotId(string snapshotId)
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
        /// The Availability Zone in which to create the new volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone in which to create the new volume.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the
        /// new volume.</param>
        /// <returns>this instance</returns>
        public CreateVolumeRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The number of I/O operations per second (IOPS) that the volume supports.
        /// Range is 100 to 1000.
        /// </summary>
        [XmlElementAttribute(ElementName = "IOPS")]
        public string IOPS
        {
            get { return this.iopsField; }
            set { this.iopsField = value; }
        }

        /// <summary>
        /// Sets the number of I/O operations per second (IOPS) that the volume supports.
        /// </summary>
        /// <param name="iops">Quantity of desired throughput in IOPS</param>
        /// <returns>this instance</returns>
        public CreateVolumeRequest WithIOPS(string iops)
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
        /// Value may be either "io1" or "standard".
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
        public CreateVolumeRequest WithVolumeType(string volumeType)
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
