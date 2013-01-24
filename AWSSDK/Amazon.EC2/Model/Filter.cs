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
    ///<summary>
    ///A filter used to limit results when describing tags.
    ///Multiple values can be specified per filter. 
    ///A tag must match at least one of the specified values for it to be
    ///returned from an operation.
    ///
    ///Wildcards can be included in filter values; 
    ///* specifies that zero or more characters
    ///must match, and ? specifies that exactly one
    ///character must match.Use a backslash to escape special characters.
    ///For example, a filter value of \*amazon\?\\
    ///specifies the literal string *amazon?\.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Filter
    {    
        private string nameField;
        private List<string> valueField;

        /// <summary>
        /// The name of the filter.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the name of the filter.
        /// </summary>
        /// <param name="name">Specifies the name of the filter.</param>
        /// <returns>this instance</returns>
        public Filter WithName(string name)
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
        /// One or more values for the filter.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public List<string> Value
        {
            get
            {
                if (this.valueField == null)
                {
                    this.valueField = new List<string>();
                }
                return this.valueField;
            }
            set { this.valueField = value; }
        }

        /// <summary>
        /// Sets values for the filter.
        /// </summary>
        /// <param name="list">Contains one or more values for the filter.</param>
        /// <returns>this instance</returns>
        public Filter WithValue(params string[] list)
        {
            foreach (string item in list)
            {
                Value.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return (Value.Count > 0);
        }

    }
}
