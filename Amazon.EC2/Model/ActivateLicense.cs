/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{

    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class ActivateLicense
    {    
        private string licenseIdField;
        private Decimal? capacityField;

        /// <summary>
        /// Gets and sets the licenseId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "licenseId")]
        public string licenseId
        {
            get { return this.licenseIdField; }
            set { this.licenseIdField = value; }
        }

        /// <summary>
        /// Sets the licenseId property
        /// </summary>
        /// <param name="licenseId">licenseId property</param>
        /// <returns>this instance</returns>
        public ActivateLicense WithlicenseId(string licenseId)
        {
            this.licenseIdField = licenseId;
            return this;
        }

        /// <summary>
        /// Checks if licenseId property is set
        /// </summary>
        /// <returns>true if licenseId property is set</returns>
        public bool IsSetlicenseId()
        {
            return this.licenseIdField != null;
        }

        /// <summary>
        /// Gets and sets the capacity property.
        /// </summary>
        [XmlElementAttribute(ElementName = "capacity")]
        public Decimal capacity
        {
            get { return this.capacityField.GetValueOrDefault(); }
            set { this.capacityField = value; }
        }

        /// <summary>
        /// Sets the capacity property
        /// </summary>
        /// <param name="capacity">capacity property</param>
        /// <returns>this instance</returns>
        public ActivateLicense Withcapacity(Decimal capacity)
        {
            this.capacityField = capacity;
            return this;
        }

        /// <summary>
        /// Checks if capacity property is set
        /// </summary>
        /// <returns>true if capacity property is set</returns>
        public bool IsSetcapacity()
        {
            return this.capacityField.HasValue;
        }

    }
}
