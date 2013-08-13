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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Account attribute description
    /// </summary>
    public class AccountAttribute
    {
        private string attributeNameField;
        private List<AccountAttributeValue> attributeValuesField;


        /// <summary>
        /// Name of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public string AttributeName
        {
            get { return this.attributeNameField; }
            set { this.attributeNameField = value; }
        }

        /// <summary>
        /// Sets the name of the attribute.
        /// </summary>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccountAttribute WithAttributeName(string attributeName)
        {
            this.attributeNameField = attributeName;
            return this;
        }

        /// <summary>
        /// Checks if AttributeName property is set
        /// </summary>
        /// <returns>true if AttributeName property is set</returns>
        public bool IsSetAttributeName()
        {
            return this.attributeNameField != null;
        }


        /// <summary>
        /// Attribute values
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValues")]
        public List<AccountAttributeValue> AttributeValues
        {
            get
            {
                if (this.attributeValuesField == null)
                {
                    this.attributeValuesField = new List<AccountAttributeValue>();
                }
                return this.attributeValuesField;
            }
            set { this.attributeValuesField = value; }
        }

        /// <summary>
        /// Sets the attribute values
        /// </summary>
        /// <param name="list">Attribute values</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccountAttribute WithAttributeValues(params AccountAttributeValue[] list)
        {
            foreach (AccountAttributeValue item in list)
            {
                AttributeValues.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AttributeValues property is set
        /// </summary>
        /// <returns>true if AttributeValues property is set</returns>
        public bool IsSetAttributeValues()
        {
            return (AttributeValues.Count > 0);
        }

    }
}
