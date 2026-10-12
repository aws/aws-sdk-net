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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Represents a ROS 2 compliant primitive type message of the complex data structure.
    /// </summary>
    public partial class ROS2PrimitiveMessageDefinition
    {
        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with scaling, the calculation
        /// is <c>value = raw_value * scaling + offset</c>.
        /// </para>
        /// </summary>
        public double? Offset { get; set; }

        /// <summary>
        /// Checks to see if the Offset property is set.
        /// </summary>
        internal bool IsSetOffset() => this.Offset.HasValue;

        /// <summary>
        /// Gets and sets the property PrimitiveType. 
        /// <para>
        /// The primitive type (integer, floating point, boolean, etc.) for the ROS 2 primitive
        /// message definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ROS2PrimitiveType PrimitiveType { get; set; }

        /// <summary>
        /// Checks to see if the PrimitiveType property is set.
        /// </summary>
        internal bool IsSetPrimitiveType() => this.PrimitiveType != null;

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// A multiplier used to decode the message.
        /// </para>
        /// </summary>
        public double? Scaling { get; set; }

        /// <summary>
        /// Checks to see if the Scaling property is set.
        /// </summary>
        internal bool IsSetScaling() => this.Scaling.HasValue;

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// An optional attribute specifying the upper bound for <c>STRING</c> and <c>WSTRING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public long? UpperBound { get; set; }

        /// <summary>
        /// Checks to see if the UpperBound property is set.
        /// </summary>
        internal bool IsSetUpperBound() => this.UpperBound.HasValue;
    }
}
