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
    /// Activates a license.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ActivateLicenseRequest
    {    
        private string licenseIdField;
        private Decimal? capacityField;

        /// <summary>
        /// Gets and sets the LicenseId property.
        /// Specifies the ID for the specific license to
        /// activate against.
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
        /// <param name="licenseId">Specifies the ID for the specific license to
        /// activate against.</param>
        /// <returns>this instance</returns>
        public ActivateLicenseRequest WithLicenseId(string licenseId)
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
        /// Gets and sets the Capacity property.
        /// Specifies the additional number of licenses to
        /// activate.
        /// </summary>
        [XmlElementAttribute(ElementName = "Capacity")]
        public Decimal Capacity
        {
            get { return this.capacityField.GetValueOrDefault(); }
            set { this.capacityField = value; }
        }

        /// <summary>
        /// Sets the Capacity property
        /// </summary>
        /// <param name="capacity">Specifies the additional number of licenses to
        /// activate.</param>
        /// <returns>this instance</returns>
        public ActivateLicenseRequest WithCapacity(Decimal capacity)
        {
            this.capacityField = capacity;
            return this;
        }

        /// <summary>
        /// Checks if Capacity property is set
        /// </summary>
        /// <returns>true if Capacity property is set</returns>
        public bool IsSetCapacity()
        {
            return this.capacityField.HasValue;
        }

    }
}
