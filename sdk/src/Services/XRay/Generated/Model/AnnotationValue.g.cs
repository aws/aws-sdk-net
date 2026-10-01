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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Value of a segment annotation. Has one of three value types: Number, Boolean, or String.
    /// </summary>
    public partial class AnnotationValue
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// Value for a Boolean annotation.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// Value for a Number annotation.
        /// </para>
        /// </summary>
        public double? NumberValue { get; set; }

        /// <summary>
        /// Checks to see if the NumberValue property is set.
        /// </summary>
        internal bool IsSetNumberValue() => this.NumberValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// Value for a String annotation.
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
