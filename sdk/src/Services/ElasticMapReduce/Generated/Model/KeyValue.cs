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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A key-value pair.
    /// </summary>
    public partial class KeyValue
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public KeyValue() { }

        /// <summary>
        /// Instantiates KeyValue with the parameterized properties
        /// </summary>
        /// <param name="key">The unique identifier of a key-value pair.</param>
        /// <param name="value">The value part of the identified key.</param>
        public KeyValue(string key, string value)
        {
            _key = key;
            _value = value;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The unique identifier of a key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value part of the identified key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
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