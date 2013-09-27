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
    /// Details for an import volume task.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportVolumeTaskDetailsType
    {    
        private Decimal? bytesConvertedField;
        private string availabilityZoneField;
        private string descriptionField;
        private DiskImageDescriptionType imageField;
        private DiskImageVolumeDescriptionType volumeField;

        /// <summary>
        /// Number of bytes converted so far.
        /// </summary>
        [XmlElementAttribute(ElementName = "BytesConverted")]
        public Decimal BytesConverted
        {
            get { return this.bytesConvertedField.GetValueOrDefault(); }
            set { this.bytesConvertedField = value; }
        }

        /// <summary>
        /// Sets the number of bytes converted so far.
        /// </summary>
        /// <param name="bytesConverted">Number of bytes converted so far.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportVolumeTaskDetailsType WithBytesConverted(Decimal bytesConverted)
        {
            this.bytesConvertedField = bytesConverted;
            return this;
        }

        /// <summary>
        /// Checks if BytesConverted property is set
        /// </summary>
        /// <returns>true if BytesConverted property is set</returns>
        public bool IsSetBytesConverted()
        {
            return this.bytesConvertedField.HasValue;
        }

        /// <summary>
        /// The Availability Zone where the resulting volume will reside.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone where the resulting volume will reside.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone where the resulting volume will reside.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportVolumeTaskDetailsType WithAvailabilityZone(string availabilityZone)
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
        /// Task description.
        /// This description is one you provided when starting the import volume task.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the task description.
        /// </summary>
        /// <param name="description">Description you provided when starting the import volume task.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportVolumeTaskDetailsType WithDescription(string description)
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
        /// Information about the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Image")]
        public DiskImageDescriptionType Image
        {
            get { return this.imageField; }
            set { this.imageField = value; }
        }

        /// <summary>
        /// Sets the information about the image.
        /// </summary>
        /// <param name="image">Information about the image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportVolumeTaskDetailsType WithImage(DiskImageDescriptionType image)
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
        /// Information about the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "Volume")]
        public DiskImageVolumeDescriptionType Volume
        {
            get { return this.volumeField; }
            set { this.volumeField = value; }
        }

        /// <summary>
        /// Sets the information about the volume.
        /// </summary>
        /// <param name="volume">Information about the volume.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportVolumeTaskDetailsType WithVolume(DiskImageVolumeDescriptionType volume)
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
