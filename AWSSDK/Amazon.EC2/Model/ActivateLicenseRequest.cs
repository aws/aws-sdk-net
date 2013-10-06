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
    /// Activates a specific number of licenses for a 90-day period.
    /// Activations can be done against a specific license ID.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ActivateLicenseRequest : EC2Request
    {    
        private string licenseIdField;
        private Decimal? capacityField;

        /// <summary>
        /// The ID for the specific license to activate against.
        /// </summary>
        [XmlElementAttribute(ElementName = "LicenseId")]
        public string LicenseId
        {
            get { return this.licenseIdField; }
            set { this.licenseIdField = value; }
        }

        /// <summary>
        /// Sets the ID for the specific license to activate against.
        /// </summary>
        /// <param name="licenseId">Specifies the ID for the specific license to
        /// activate against.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The additional number of licenses to activate.
        /// </summary>
        [XmlElementAttribute(ElementName = "Capacity")]
        public Decimal Capacity
        {
            get { return this.capacityField.GetValueOrDefault(); }
            set { this.capacityField = value; }
        }

        /// <summary>
        /// Sets the additional number of licenses to activate.
        /// </summary>
        /// <param name="capacity">Specifies the additional number of licenses to
        /// activate.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
