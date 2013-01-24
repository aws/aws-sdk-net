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
    public class ReplaceableAttribute
    {
        private string nameField;
        private string valueField;
        private bool? replaceField;

        /// <summary>
        /// Gets and sets the Name property.
        /// Name of attribute associated with an item. Allowed characters are all UTF-8 characters valid
        /// in XML documents. Control characters and any sequences that are not valid in XML are not allowed. These
        /// strings can be up to 1024 bytes long.
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
        /// <param name="name">Name of attribute associated with an item. Allowed characters are all UTF-8 characters valid
        /// in XML documents. Control characters and any sequences that are not valid in XML are not allowed. These
        /// strings can be up to 1024 bytes long.</param>
        /// <returns>this instance</returns>
        public ReplaceableAttribute WithName(string name)
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
        /// Value of the attribute associated with an item. Similar to columns on a spreadsheet, attributes represent
        /// categories of data that can be assigned to items. Allowed characters are all UTF-8 characters valid in
        /// XML documents. Control characters and any sequences that are not valid in XML are not allowed. These strings
        /// can be up to 1024 bytes long.
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
        /// <param name="value">Value of the attribute associated with an item. Similar to columns on a spreadsheet, attributes represent
        /// categories of data that can be assigned to items. Allowed characters are all UTF-8 characters valid in
        /// XML documents. Control characters and any sequences that are not valid in XML are not allowed. These strings
        /// can be up to 1024 bytes long.</param>
        /// <returns>this instance</returns>
        public ReplaceableAttribute WithValue(string value)
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
        /// Gets and sets the Replace property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Replace")]
        public bool Replace
        {
            get { return this.replaceField.GetValueOrDefault(); }
            set { this.replaceField = value; }
        }

        /// <summary>
        /// Sets the Replace property
        /// </summary>
        /// <param name="replace">Replace property</param>
        /// <returns>this instance</returns>
        public ReplaceableAttribute WithReplace(bool replace)
        {
            this.replaceField = replace;
            return this;
        }

        /// <summary>
        /// Checks if Replace property is set
        /// </summary>
        /// <returns>true if Replace property is set</returns>
        public bool IsSetReplace()
        {
            return this.replaceField.HasValue;
        }

    }
}
