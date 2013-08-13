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
    /// Details for an import instance task.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportInstanceTaskDetailsType
    {    
        private List<ImportInstanceVolumeDetailItemType> volumesField;
        private string instanceIdField;
        private string platformField;
        private string descriptionField;

        /// <summary>
        /// A list of instance volumes for import.
        /// </summary>
        [XmlElementAttribute(ElementName = "Volumes")]
        public List<ImportInstanceVolumeDetailItemType> Volumes
        {
            get
            {
                if (this.volumesField == null)
                {
                    this.volumesField = new List<ImportInstanceVolumeDetailItemType>();
                }
                return this.volumesField;
            }
            set { this.volumesField = value; }
        }

        /// <summary>
        /// Sets the list of instance volumes for import.
        /// </summary>
        /// <param name="list">A list of instance volumes for import. Each volume's information is wrapped in an item element.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportInstanceTaskDetailsType WithVolumes(params ImportInstanceVolumeDetailItemType[] list)
        {
            foreach (ImportInstanceVolumeDetailItemType item in list)
            {
                Volumes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Volumes property is set
        /// </summary>
        /// <returns>true if Volumes property is set</returns>
        public bool IsSetVolumes()
        {
            return (Volumes.Count > 0);
        }

        /// <summary>
        /// The ID of the resulting instance in Amazon EC2.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the resulting instance in Amazon EC2.
        /// </summary>
        /// <param name="instanceId">The ID of the resulting instance in Amazon EC2.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportInstanceTaskDetailsType WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Instance operating system.
        /// </summary>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platformField; }
            set { this.platformField = value; }
        }

        /// <summary>
        /// Sets the instance operating system.
        /// </summary>
        /// <param name="platform">Instance operating system.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportInstanceTaskDetailsType WithPlatform(string platform)
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

        /// <summary>
        /// Description of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the instance.
        /// </summary>
        /// <param name="description">Optional description of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ImportInstanceTaskDetailsType WithDescription(string description)
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

    }
}
