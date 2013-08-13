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
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleDB.Model
{
    ///<summary>
    ///An attribute associated with an item. Similar to columns on a spreadsheet, attributes represent
    ///categories of data that can be assigned to items.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class Attribute
    {
        private string nameField;
        private string valueField;
        private string nameEncodingField;
        private string valueEncodingField;

        /// <summary>
        /// Gets and sets the Name property.
        /// The name of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Attribute WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// The value of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Attribute WithValue(string value)
        {
            this.valueField = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return this.valueField != null;
        }

        /// <summary>
        /// Gets and sets the NameEncoding property.
        /// The encoding for the attribute's name. For example: base64
        /// </summary>
        [XmlElementAttribute(ElementName = "NameEncoding")]
        public string NameEncoding
        {
            get { return this.nameEncodingField; }
            set { this.nameEncodingField = value; }
        }

        /// <summary>
        /// Sets the NameEncoding property
        /// </summary>
        /// <param name="nameEncoding">The encoding for the attribute's name. For example: base64</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Attribute WithNameEncoding(string nameEncoding)
        {
            this.nameEncodingField = nameEncoding;
            return this;
        }

        /// <summary>
        /// Checks if NameEncoding property is set
        /// </summary>
        /// <returns>true if NameEncoding property is set</returns>
        public bool IsSetNameEncoding()
        {
            return this.nameEncodingField != null;
        }

        /// <summary>
        /// Gets and sets the ValueEncoding property.
        /// The encoding for the attribute's value. For example: base64
        /// </summary>
        [XmlElementAttribute(ElementName = "ValueEncoding")]
        public string ValueEncoding
        {
            get { return this.valueEncodingField; }
            set { this.valueEncodingField = value; }
        }

        /// <summary>
        /// Sets the ValueEncoding property
        /// </summary>
        /// <param name="valueEncoding">The encoding for the attribute's value. For example: base64</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Attribute WithValueEncoding(string valueEncoding)
        {
            this.valueEncodingField = valueEncoding;
            return this;
        }

        /// <summary>
        /// Checks if ValueEncoding property is set
        /// </summary>
        /// <returns>true if ValueEncoding property is set</returns>
        public bool IsSetValueEncoding()
        {
            return this.valueEncodingField != null;
        }

    }
}
