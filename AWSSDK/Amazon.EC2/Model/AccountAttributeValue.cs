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
    public class AccountAttributeValue
    {
        private string attributeValueField;

        /// <summary>
        /// Value of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValue")]
        public string AttributeValue
        {
            get { return this.attributeValueField; }
            set { this.attributeValueField = value; }
        }

        /// <summary>
        /// Sets the value of the attribute.
        /// </summary>
        /// <param name="attributeValue">Value of the attribute.</param>
        /// <returns>this instance</returns>
        public AccountAttributeValue WithAttributeValue(string attributeValue)
        {
            this.attributeValueField = attributeValue;
            return this;
        }

        /// <summary>
        /// Checks if AttributeValue property is set
        /// </summary>
        /// <returns>true if AttributeValue property is set</returns>
        public bool IsSetAttributeValue()
        {
            return this.attributeValueField != null;
        }

    }
}
