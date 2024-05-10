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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private double? _offset;
        private ROS2PrimitiveType _primitiveType;
        private double? _scaling;
        private long? _upperBound;

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with scaling, the calculation
        /// is <c>value = raw_value * scaling + offset</c>.
        /// </para>
        /// </summary>
        public double? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimitiveType. 
        /// <para>
        /// The primitive type (integer, floating point, boolean, etc.) for the ROS 2 primitive
        /// message definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ROS2PrimitiveType PrimitiveType
        {
            get { return this._primitiveType; }
            set { this._primitiveType = value; }
        }

        // Check to see if PrimitiveType property is set
        internal bool IsSetPrimitiveType()
        {
            return this._primitiveType != null;
        }

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// A multiplier used to decode the message.
        /// </para>
        /// </summary>
        public double? Scaling
        {
            get { return this._scaling; }
            set { this._scaling = value; }
        }

        // Check to see if Scaling property is set
        internal bool IsSetScaling()
        {
            return this._scaling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// An optional attribute specifying the upper bound for <c>STRING</c> and <c>WSTRING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public long? UpperBound
        {
            get { return this._upperBound; }
            set { this._upperBound = value; }
        }

        // Check to see if UpperBound property is set
        internal bool IsSetUpperBound()
        {
            return this._upperBound.HasValue; 
        }

    }
}