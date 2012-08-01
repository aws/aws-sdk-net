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
    /// Product Code
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ProductCode
    {
        private string productCodeIdField;
        private string typeField;

        /// <summary>
        /// Gets and sets the ProductCodeId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCodeId")]
        public string ProductCodeId
        {
            get { return this.productCodeIdField; }
            set { this.productCodeIdField = value; }
        }

        /// <summary>
        /// Sets the ProductCodeId property
        /// </summary>
        /// <param name="productCodeId">The product code</param>
        /// <returns>this instance</returns>
        public ProductCode WithProductCodeId(string productCodeId)
        {
            this.productCodeIdField = productCodeId;
            return this;
        }

        /// <summary>
        /// Checks if ProductCodeId property is set
        /// </summary>
        /// <returns>true if ProductCodeId property is set</returns>
        public bool IsSetProductCodeId()
        {
            return !string.IsNullOrEmpty(this.productCodeIdField);
        }

        /// <summary>
        /// Gets and sets the ProductType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string ProductType
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the ProductType property
        /// </summary>
        /// <param name="productType">The product type</param>
        /// <returns>this instance</returns>
        public ProductCode WithProductType(string productType)
        {
            this.typeField = productType;
            return this;
        }

        /// <summary>
        /// Checks if ProductType property is set
        /// </summary>
        /// <returns>true if ProductType property is set</returns>
        public bool IsSetProductType()
        {
            return !string.IsNullOrEmpty(this.typeField);
        }
    }
}
