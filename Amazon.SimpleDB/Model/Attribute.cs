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

        /// <summary>
        /// Gets and sets the Name property.
        /// The name of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField ; }
            set { this.nameField= value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <returns>this instance</returns>
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
            return  this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// The value of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.valueField ; }
            set { this.valueField= value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>this instance</returns>
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
            return  this.valueField != null;
        }

    }
}
