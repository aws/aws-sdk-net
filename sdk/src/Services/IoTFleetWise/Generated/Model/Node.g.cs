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
    /// A general abstraction of a signal. A node can be specified as an actuator, attribute,
    /// branch, or sensor.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// Gets and sets the property Actuator. 
        /// <para>
        /// Information about a node specified as an actuator.
        /// </para>
        ///  <note> 
        /// <para>
        /// An actuator is a digital representation of a vehicle device.
        /// </para>
        ///  </note>
        /// </summary>
        public Actuator Actuator { get; set; }

        /// <summary>
        /// Checks to see if the Actuator property is set.
        /// </summary>
        internal bool IsSetActuator() => this.Actuator != null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Information about a node specified as an attribute.
        /// </para>
        ///  <note> 
        /// <para>
        /// An attribute represents static information about a vehicle.
        /// </para>
        ///  </note>
        /// </summary>
        public Attribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// Information about a node specified as a branch.
        /// </para>
        ///  <note> 
        /// <para>
        /// A group of signals that are defined in a hierarchical structure.
        /// </para>
        ///  </note>
        /// </summary>
        public Branch Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// Represents a member of the complex data structure. The <c>datatype</c> of the property
        /// can be either primitive or another <c>struct</c>.
        /// </para>
        /// </summary>
        public CustomProperty Property { get; set; }

        /// <summary>
        /// Checks to see if the Property property is set.
        /// </summary>
        internal bool IsSetProperty() => this.Property != null;

        /// <summary>
        /// Gets and sets the property Sensor.
        /// </summary>
        public Sensor Sensor { get; set; }

        /// <summary>
        /// Checks to see if the Sensor property is set.
        /// </summary>
        internal bool IsSetSensor() => this.Sensor != null;

        /// <summary>
        /// Gets and sets the property Struct. 
        /// <para>
        /// Represents a complex or higher-order data structure.
        /// </para>
        /// </summary>
        public CustomStruct Struct { get; set; }

        /// <summary>
        /// Checks to see if the Struct property is set.
        /// </summary>
        internal bool IsSetStruct() => this.Struct != null;
    }
}
