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
    /// <summary>
    /// Creates a new Amazon EBS volume to which any
    /// Amazon EC2 instance can attach
    /// within the same Availability Zone.
    /// For more information about Amazon
    /// EBS, go to the Amazon Elastic
    /// Compute Cloud Developer Guide.
    ///
    /// You must specify an Availability
    /// Zone when creating a volume. The
    /// volume and the instance to which it
    /// attaches must be in the same Availability Zone.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class CreateVolumeRequest
    {    
        private string sizeField;
        private string snapshotIdField;
        private string availabilityZoneField;

        /// <summary>
        /// Gets and sets the Size property.
        /// The size of the volume, in GiBs. Required if
        /// you are not creating
        /// a volume from a snapshot.
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
        /// Sets the Size property
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
        /// Gets and sets the SnapshotId property.
        /// The snapshot from which to create the new
        /// volume.
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
        /// Gets and sets the AvailabilityZone property.
        /// The Availability Zone in which to create the
        /// new volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
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

    }
}
