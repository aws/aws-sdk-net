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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a tag.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Tag() { }

        /// <summary>
        /// Instantiates Tag with the parameterized properties
        /// </summary>
        /// <param name="key">The key of the tag. Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters. May not begin with <c>aws:</c>.</param>
        /// <param name="value">The value of the tag. Constraints: Tag values are case-sensitive and accept a maximum of 256 Unicode characters.</param>
        public Tag(string key, string value)
        {
            _key = key;
            _value = value;
        }

        /// <summary>
        /// Instantiates Tag with the parameterized properties
        /// </summary>
        /// <param name="key">The key of the tag. Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters. May not begin with <c>aws:</c>.</param>
        public Tag(string key)
        {
            _key = key;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the tag.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters.
        /// May not begin with <c>aws:</c>.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the tag.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Tag values are case-sensitive and accept a maximum of 256 Unicode characters.
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