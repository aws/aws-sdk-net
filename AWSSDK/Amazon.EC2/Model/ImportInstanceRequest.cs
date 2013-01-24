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
    /// Creates a new import instance task using metadata from the specified disk image.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportInstanceRequest
    {    
        private string descriptionField;
        private ImportInstanceLaunchSpecificationType launchSpecificationField;
        private List<DiskImageType> diskImageField;
        private string platformField;

        /// <summary>
        /// Description of the instance being imported
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the instance being imported
        /// </summary>
        /// <param name="description">Description of the instance being imported</param>
        /// <returns>this instance</returns>
        public ImportInstanceRequest WithDescription(string description)
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
        /// Additional launch instance information.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchSpecification")]
        public ImportInstanceLaunchSpecificationType LaunchSpecification
        {
            get { return this.launchSpecificationField; }
            set { this.launchSpecificationField = value; }
        }

        /// <summary>
        /// Sets additional launch instance information.
        /// </summary>
        /// <param name="launchSpecification">Specifies additional launch instance information.</param>
        /// <returns>this instance</returns>
        public ImportInstanceRequest WithLaunchSpecification(ImportInstanceLaunchSpecificationType launchSpecification)
        {
            this.launchSpecificationField = launchSpecification;
            return this;
        }

        /// <summary>
        /// Checks if LaunchSpecification property is set
        /// </summary>
        /// <returns>true if LaunchSpecification property is set</returns>
        public bool IsSetLaunchSpecification()
        {
            return this.launchSpecificationField != null;
        }

        /// <summary>
        /// Details about the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "DiskImage")]
        public List<DiskImageType> DiskImage
        {
            get
            {
                if (this.diskImageField == null)
                {
                    this.diskImageField = new List<DiskImageType>();
                }
                return this.diskImageField;
            }
            set { this.diskImageField = value; }
        }

        /// <summary>
        /// Sets details about the image.
        /// </summary>
        /// <param name="list">Details about the image.</param>
        /// <returns>this instance</returns>
        public ImportInstanceRequest WithDiskImage(params DiskImageType[] list)
        {
            foreach (DiskImageType item in list)
            {
                DiskImage.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DiskImage property is set
        /// </summary>
        /// <returns>true if DiskImage property is set</returns>
        public bool IsSetDiskImage()
        {
            return (DiskImage.Count > 0);
        }

        /// <summary>
        /// The EC2 instance operating system.
        /// 
        /// Valid Value: Windows
        /// </summary>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platformField; }
            set { this.platformField = value; }
        }

        /// <summary>
        /// Sets the EC2 instance operating system.
        /// </summary>
        /// <param name="platform">The EC2 instance operating system.
        /// 
        /// Valid Value: Windows</param>
        /// <returns>this instance</returns>
        public ImportInstanceRequest WithPlatform(string platform)
        {
            this.platformField = platform;
            return this;
        }

        /// <summary>
        /// Checks if Platform property is set
        /// </summary>
        /// <returns>true if Platform property is set</returns>
        public bool IsSetPlatform()
        {
            return this.platformField != null;
        }

    }
}
