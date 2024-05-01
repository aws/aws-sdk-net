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
    /// A general abstraction of a signal. A node can be specified as an actuator, attribute,
    /// branch, or sensor.
    /// </summary>
    public partial class Node
    {
        private Actuator _actuator;
        private Attribute _attribute;
        private Branch _branch;
        private CustomProperty _property;
        private Sensor _sensor;
        private CustomStruct _struct;

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
        public Actuator Actuator
        {
            get { return this._actuator; }
            set { this._actuator = value; }
        }

        // Check to see if Actuator property is set
        internal bool IsSetActuator()
        {
            return this._actuator != null;
        }

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
        public Attribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

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
        public Branch Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// Represents a member of the complex data structure. The <c>datatype</c> of the property
        /// can be either primitive or another <c>struct</c>.
        /// </para>
        /// </summary>
        public CustomProperty Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

        /// <summary>
        /// Gets and sets the property Sensor.
        /// </summary>
        public Sensor Sensor
        {
            get { return this._sensor; }
            set { this._sensor = value; }
        }

        // Check to see if Sensor property is set
        internal bool IsSetSensor()
        {
            return this._sensor != null;
        }

        /// <summary>
        /// Gets and sets the property Struct. 
        /// <para>
        /// Represents a complex or higher-order data structure.
        /// </para>
        /// </summary>
        public CustomStruct Struct
        {
            get { return this._struct; }
            set { this._struct = value; }
        }

        // Check to see if Struct property is set
        internal bool IsSetStruct()
        {
            return this._struct != null;
        }

    }
}