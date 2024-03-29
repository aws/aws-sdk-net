/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the Amazon S3 object key name to filter on. An object key name is the name
    /// assigned to an object in your Amazon S3 bucket. You specify whether to filter on the
    /// suffix or prefix of the object key name. A prefix is a specific string of characters
    /// at the beginning of an object key name, which you can use to organize objects. For
    /// example, you can start the key names of related objects with a prefix, such as <c>2023-</c>
    /// or <c>engineering/</c>. Then, you can use <c>FilterRule</c> to find objects in a bucket
    /// with key names that have the same prefix. A suffix is similar to a prefix, but it
    /// is at the end of the object key name instead of at the beginning.
    /// </summary>
    public class FilterRule
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Constructs an empty FilterRule.
        /// </summary>
        public FilterRule()
            : this(null, null)
        { }

        /// <summary>
        /// Constructs a FilterRule with a specific name and value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public FilterRule(string name, string value)
        {
            this._name = name;
            this._value = value;
        }

        /// <summary>
        /// The name of the filter rule.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// The value of the filter rule.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }
    }
}
