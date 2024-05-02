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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
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
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Attribute
    {
        private string _alternateNameEncoding;
        private string _alternateValueEncoding;
        private string _name;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Attribute() { }

        /// <summary>
        /// Instantiates Attribute with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="value">The value of the attribute.</param>
        public Attribute(string name, string value)
        {
            _name = name;
            _value = value;
        }

        /// <summary>
        /// Gets and sets the property AlternateNameEncoding. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string AlternateNameEncoding
        {
            get { return this._alternateNameEncoding; }
            set { this._alternateNameEncoding = value; }
        }

        // Check to see if AlternateNameEncoding property is set
        internal bool IsSetAlternateNameEncoding()
        {
            return this._alternateNameEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property AlternateValueEncoding. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string AlternateValueEncoding
        {
            get { return this._alternateValueEncoding; }
            set { this._alternateValueEncoding = value; }
        }

        // Check to see if AlternateValueEncoding property is set
        internal bool IsSetAlternateValueEncoding()
        {
            return this._alternateValueEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the attribute.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Value. The value of the attribute.
        /// </summary>
        [AWSProperty(Required=true)]
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