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
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    ///A key value pair.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class KeyValue
    {
        private string keyField;
        private string valueField;

        /// <summary>
        /// Gets and sets the Key property.
        /// Name of a parameter that is paired with a value in a KeyValue pair.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">Name of a parameter that is paired with a value in a KeyValue pair.</param>
        /// <returns>this instance</returns>
        public KeyValue WithKey(string key)
        {
            this.keyField = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set
        /// </summary>
        /// <returns>true if Key property is set</returns>
        public bool IsSetKey()
        {
            return this.keyField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// Value of a parameter that is paired with a key in a KeyValue pair.
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
        /// <param name="value">Value of a parameter that is paired with a key in a KeyValue pair.</param>
        /// <returns>this instance</returns>
        public KeyValue WithValue(string value)
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

    }
}
