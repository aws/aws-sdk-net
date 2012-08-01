/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Creates a new import volume task using metadata from the specified disk image.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportVolumeRequest
    {    
        private string availabilityZoneField;
        private DiskImageDetailType imageField;
        private string descriptionField;
        private DiskImageVolumeType volumeField;

        /// <summary>
        /// Gets and sets the AvailabilityZone property.
        /// Availability Zone where the resulting Amazon EBS volume will reside.
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
        /// <param name="availabilityZone">Availability Zone where the resulting Amazon EBS volume will reside.</param>
        /// <returns>this instance</returns>
        public ImportVolumeRequest WithAvailabilityZone(string availabilityZone)
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
        /// Gets and sets the Image property.
        /// Details about the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Image")]
        public DiskImageDetailType Image
        {
            get { return this.imageField; }
            set { this.imageField = value; }
        }

        /// <summary>
        /// Sets the Image property
        /// </summary>
        /// <param name="image">Details about the image.</param>
        /// <returns>this instance</returns>
        public ImportVolumeRequest WithImage(DiskImageDetailType image)
        {
            this.imageField = image;
            return this;
        }

        /// <summary>
        /// Checks if Image property is set
        /// </summary>
        /// <returns>true if Image property is set</returns>
        public bool IsSetImage()
        {
            return this.imageField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// Optional description of the volume being imported.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Optional description of the volume being imported.</param>
        /// <returns>this instance</returns>
        public ImportVolumeRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// Gets and sets the Volume property.
        /// Details about the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "Volume")]
        public DiskImageVolumeType Volume
        {
            get { return this.volumeField; }
            set { this.volumeField = value; }
        }

        /// <summary>
        /// Sets the Volume property
        /// </summary>
        /// <param name="volume">Details about the volume.</param>
        /// <returns>this instance</returns>
        public ImportVolumeRequest WithVolume(DiskImageVolumeType volume)
        {
            this.volumeField = volume;
            return this;
        }

        /// <summary>
        /// Checks if Volume property is set
        /// </summary>
        /// <returns>true if Volume property is set</returns>
        public bool IsSetVolume()
        {
            return this.volumeField != null;
        }

    }
}
