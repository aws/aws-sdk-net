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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// </summary>
    public partial class Attribute
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public Attribute() { }

        /// <summary>
        /// Instantiates Attribute with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="value">The value of the attribute.</param>
        public Attribute(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets and sets the property AlternateNameEncoding. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string AlternateNameEncoding { get; set; }

        /// <summary>
        /// Checks to see if the AlternateNameEncoding property is set.
        /// </summary>
        internal bool IsSetAlternateNameEncoding() => this.AlternateNameEncoding != null;

        /// <summary>
        /// Gets and sets the property AlternateValueEncoding. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string AlternateValueEncoding { get; set; }

        /// <summary>
        /// Checks to see if the AlternateValueEncoding property is set.
        /// </summary>
        internal bool IsSetAlternateValueEncoding() => this.AlternateValueEncoding != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the attribute.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Value. The value of the attribute.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
