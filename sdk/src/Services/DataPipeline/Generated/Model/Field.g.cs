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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// A key-value pair that describes a property of a pipeline object. The value is specified
    /// as either a string value (<c>StringValue</c>) or a reference to another object (<c>RefValue</c>)
    /// but not as both.
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The field identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property RefValue. 
        /// <para>
        /// The field value, expressed as the identifier of another object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RefValue { get; set; }

        /// <summary>
        /// Checks to see if the RefValue property is set.
        /// </summary>
        internal bool IsSetRefValue() => this.RefValue != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The field value, expressed as a String.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
