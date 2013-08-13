/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A tag, consisting of a Key and Value
    /// </summary>
    public class Tag
    {
        private string key;
        private string value;

        public override string ToString()
        {
            return String.Concat("Tag: Key = ", key, " Value = ", value);
        }


        /// <summary>
        /// The key identifying the tag.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key identifying the tag.
        /// </summary>
        /// <param name="key">Tag key</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Tag WithKey(string key)
        {
            this.key = key;
            return this;
        }

        /// <summary>
        /// Checks if the Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return this.key != null;
        }


        /// <summary>
        /// The value of the tag.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Sets the value of the tag.
        /// </summary>
        /// <param name="value">Tag value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Tag WithValue(string value)
        {
            this.value = value;
            return this;
        }

        /// <summary>
        /// Checks if the Value property is set.
        /// </summary>
        /// <returns>true if Value property is set.</returns>
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        internal string ToXML()
        {
            string xml = string.Format("<Tag><Key>{0}</Key><Value>{1}</Value></Tag>", this.Key, this.Value);
            return xml;
        }

    }
}
