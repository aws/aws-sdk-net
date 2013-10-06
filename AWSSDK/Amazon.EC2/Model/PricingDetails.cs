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
    /// Pricing Details
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class PricingDetails
    {
        private Decimal? priceField;
        private int? countField;

        /// <summary>
        /// Price per instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Price")]
        public Decimal Price
        {
            get { return this.priceField.GetValueOrDefault(); }
            set { this.priceField = value; }
        }

        /// <summary>
        /// Checks if the Price property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetPrice()
        {
            return this.priceField != null;
        }

        /// <summary>
        /// Number of instances available for the price.
        /// </summary>
        [XmlElementAttribute(ElementName = "Count")]
        public int Count
        {
            get { return this.countField.GetValueOrDefault(); }
            set { this.countField = value; }
        }

        /// <summary>
        /// Checks if the Count property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetCount()
        {
            return this.countField != null;
        }
    }
}
