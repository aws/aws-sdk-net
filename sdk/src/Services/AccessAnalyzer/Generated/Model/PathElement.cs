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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// A single element in a path through the JSON representation of a policy.
    /// </summary>
    public partial class PathElement
    {
        private int? _index;
        private string _key;
        private Substring _substring;
        private string _value;

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// Refers to an index in a JSON array.
        /// </para>
        /// </summary>
        public int? Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Refers to a key in a JSON object.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Substring. 
        /// <para>
        /// Refers to a substring of a literal string in a JSON object.
        /// </para>
        /// </summary>
        public Substring Substring
        {
            get { return this._substring; }
            set { this._substring = value; }
        }

        // Check to see if Substring property is set
        internal bool IsSetSubstring()
        {
            return this._substring != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Refers to the value associated with a given key in a JSON object.
        /// </para>
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