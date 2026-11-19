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
    public partial class ReplaceableAttribute
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ReplaceableAttribute() { }

        /// <summary>
        /// Instantiates ReplaceableAttribute with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the replaceable attribute.</param>
        /// <param name="value">The value of the replaceable attribute.</param>
        /// <param name="replace">A flag specifying whether or not to replace the attribute/value pair or to add a new attribute/value pair. The default setting is <c>false</c>.</param>
        public ReplaceableAttribute(string name, string value, bool? replace)
        {
            this.Name = name;
            this.Value = value;
            this.Replace = replace;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the replaceable attribute.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Replace. A flag specifying whether or not to replace the
        /// attribute/value pair or to add a new attribute/value pair. The default setting is
        /// <c>false</c>.
        /// </summary>
        public bool? Replace { get; set; }

        /// <summary>
        /// Checks to see if the Replace property is set.
        /// </summary>
        internal bool IsSetReplace() => this.Replace.HasValue;

        /// <summary>
        /// Gets and sets the property Value. The value of the replaceable attribute.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
