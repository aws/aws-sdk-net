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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public Tag() { }

        /// <summary>
        /// Instantiates Tag with the parameterized properties
        /// </summary>
        /// <param name="key">The key of the tag.   Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters.    May not begin with <c>aws:</c>.</param>
        /// <param name="value">The value of the tag.   Constraints: Tag values are case-sensitive and accept a maximum of 256 Unicode characters.</param>
        public Tag(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Instantiates Tag with the parameterized properties
        /// </summary>
        /// <param name="key">The key of the tag.   Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters.    May not begin with <c>aws:</c>.</param>
        public Tag(string key)
        {
            this.Key = key;
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
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

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
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
