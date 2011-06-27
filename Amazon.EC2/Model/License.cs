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
    ///A software license that can be associated with an Amazon EC2
    ///instance when launched (ex. a Microsoft Windows license).
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class License
    {    
        private string licenseIdField;
        private string typeField;
        private string poolField;
        private List<LicenseCapacity> licenseCapacityField;
        private List<Tag> tagField;

        /// <summary>
        /// Gets and sets the LicenseId property.
        /// The unique ID identifying the license.
        /// </summary>
        [XmlElementAttribute(ElementName = "LicenseId")]
        public string LicenseId
        {
            get { return this.licenseIdField; }
            set { this.licenseIdField = value; }
        }

        /// <summary>
        /// Sets the LicenseId property
        /// </summary>
        /// <param name="licenseId">The unique ID identifying the license.</param>
        /// <returns>this instance</returns>
        public License WithLicenseId(string licenseId)
        {
            this.licenseIdField = licenseId;
            return this;
        }

        /// <summary>
        /// Checks if LicenseId property is set
        /// </summary>
        /// <returns>true if LicenseId property is set</returns>
        public bool IsSetLicenseId()
        {
            return this.licenseIdField != null;
        }

        /// <summary>
        /// Gets and sets the Type property.
        /// The license type (ex. "Microsoft/Windows/Standard").
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The license type (ex. "Microsoft/Windows/Standard").</param>
        /// <returns>this instance</returns>
        public License WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// Gets and sets the Pool property.
        /// The name of the pool in which the license is kept.
        /// </summary>
        [XmlElementAttribute(ElementName = "Pool")]
        public string Pool
        {
            get { return this.poolField; }
            set { this.poolField = value; }
        }

        /// <summary>
        /// Sets the Pool property
        /// </summary>
        /// <param name="pool">The name of the pool in which the license is kept.</param>
        /// <returns>this instance</returns>
        public License WithPool(string pool)
        {
            this.poolField = pool;
            return this;
        }

        /// <summary>
        /// Checks if Pool property is set
        /// </summary>
        /// <returns>true if Pool property is set</returns>
        public bool IsSetPool()
        {
            return this.poolField != null;
        }

        /// <summary>
        /// Gets and sets the LicenseCapacity property.
        /// The capacities available for this license,
        /// indicating how many licenses are in use, how many are available,
        /// how many Amazon EC2 instances can be supported, etc.
        /// </summary>
        [XmlElementAttribute(ElementName = "LicenseCapacity")]
        public List<LicenseCapacity> LicenseCapacity
        {
            get
            {
                if (this.licenseCapacityField == null)
                {
                    this.licenseCapacityField = new List<LicenseCapacity>();
                }
                return this.licenseCapacityField;
            }
            set { this.licenseCapacityField = value; }
        }

        /// <summary>
        /// Sets the LicenseCapacity property
        /// </summary>
        /// <param name="list">The capacities available for this license,
        /// indicating how many licenses are in use, how many are available,
        /// how many Amazon EC2 instances can be supported, etc.</param>
        /// <returns>this instance</returns>
        public License WithLicenseCapacity(params LicenseCapacity[] list)
        {
            foreach (LicenseCapacity item in list)
            {
                LicenseCapacity.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LicenseCapacity property is set
        /// </summary>
        /// <returns>true if LicenseCapacity property is set</returns>
        public bool IsSetLicenseCapacity()
        {
            return (LicenseCapacity.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Tag property.
        /// A list of tags for the License.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">A list of tags for the License.</param>
        /// <returns>this instance</returns>
        public License WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
