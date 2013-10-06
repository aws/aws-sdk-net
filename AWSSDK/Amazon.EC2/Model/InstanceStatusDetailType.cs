/*
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
    /// Instance Status Detail Type
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceStatusDetailType
    {
        private string nameField;
        private string statusField;
        private string impairedSinceField;

        /// <summary>
        /// The type of instance status detail.
        /// Valid Values: reachability 
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the type of instance status detail.
        /// </summary>
        /// <param name="name">
        /// The type of instance status detail.
        /// Valid Values: reachability 
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusDetailType WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if the Name property is set.
        /// </summary>
        /// <returns>true if the Name property is set</returns>
        public bool IsSetName()
        {
            return !string.IsNullOrEmpty(this.nameField);
        }

        /// <summary>
        /// The status.
        /// Valid Values: passed | failed | insufficient-data
        /// </summary>
        [XmlElement(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status.
        /// </summary>
        /// <param name="status">
        /// Valid Values: passed | failed | insufficient-data
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusDetailType WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set.
        /// </summary>
        /// <returns>true if the Status property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// The time when a status check failed.
        /// For an instance that was launched and impaired, this is the time when the instance was launched.
        /// </summary>
        [XmlElement(ElementName = "ImpairedSince")]
        public string ImpairedSince
        {
            get { return this.impairedSinceField; }
            set { this.impairedSinceField = value; }
        }

        /// <summary>
        /// Sets the time when a status check failed.
        /// </summary>
        /// <param name="impairedSince">The time of the status check failure</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusDetailType WithImpairedSince(string impairedSince)
        {
            this.impairedSinceField = impairedSince;
            return this;
        }

        /// <summary>
        /// Checks if the ImpairedSince property is set.
        /// </summary>
        /// <returns>True if the ImpairedSince property is set</returns>
        public bool IsSetImpairedSince()
        {
            return !string.IsNullOrEmpty(this.impairedSinceField);
        }
    }
}
