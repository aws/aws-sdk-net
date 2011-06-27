/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Information about the EBS block device.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class EbsBlockDevice
    {    
        private string snapshotIdField;
        private Decimal? volumeSizeField;
        private bool? deleteOnTerminationField;

        /// <summary>
        /// Gets and sets the SnapshotId property.
        /// The ID of the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the SnapshotId property
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the VolumeSize property.
        /// Size of the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeSize")]
        public Decimal VolumeSize
        {
            get { return this.volumeSizeField.GetValueOrDefault(); }
            set { this.volumeSizeField = value; }
        }

        /// <summary>
        /// Sets the VolumeSize property
        /// </summary>
        /// <param name="volumeSize">Size of the volume.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the DeleteOnTermination property.
        /// Whether the EBS block device is deleted on
        /// instance termination.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets the DeleteOnTermination property
        /// </summary>
        /// <param name="deleteOnTermination">Whether the EBS block device is deleted on
        /// instance termination.</param>
        /// <returns>this instance</returns>
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

    }
}
