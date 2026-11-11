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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes how to interpret an application-defined timestamp value from an MQTT message
    /// payload and the precision of that value.
    /// </summary>
    public partial class TimestreamTimestamp
    {
        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The precision of the timestamp value that results from the expression described in
        /// <c>value</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>SECONDS</c> | <c>MILLISECONDS</c> | <c>MICROSECONDS</c> | <c>NANOSECONDS</c>.
        /// The default is <c>MILLISECONDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// An expression that returns a long epoch time value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
