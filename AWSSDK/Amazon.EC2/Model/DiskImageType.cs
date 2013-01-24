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
    /// Details about a disk image.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DiskImageType
    {    
        private DiskImageDetailType imageField;
        private string descriptionField;
        private DiskImageVolumeType volumeField;

        /// <summary>
        /// Details about the format of the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Image")]
        public DiskImageDetailType Image
        {
            get { return this.imageField; }
            set { this.imageField = value; }
        }

        /// <summary>
        /// Sets details about the format of the image.
        /// </summary>
        /// <param name="image">Details about the format of the image.</param>
        /// <returns>this instance</returns>
        public DiskImageType WithImage(DiskImageDetailType image)
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
        /// Description of the disk image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the disk image.
        /// </summary>
        /// <param name="description">Optional description of the disk image.</param>
        /// <returns>this instance</returns>
        public DiskImageType WithDescription(string description)
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
        /// Details about the size of the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Volume")]
        public DiskImageVolumeType Volume
        {
            get { return this.volumeField; }
            set { this.volumeField = value; }
        }

        /// <summary>
        /// Sets details about the size of the image.
        /// </summary>
        /// <param name="volume">Details about the size of the image.</param>
        /// <returns>this instance</returns>
        public DiskImageType WithVolume(DiskImageVolumeType volume)
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
