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
    /// A signal that represents a vehicle device such as the engine, heater, and door locks.
    /// Data from an actuator reports the state of a certain vehicle device.
    /// 
    ///  <note> 
    /// <para>
    ///  Updating actuator data can change the state of a device. For example, you can turn
    /// on or off the heater by updating its actuator data.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Actuator
    {
        private List<string> _allowedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _assignedValue;
        private string _comment;
        private NodeDataType _dataType;
        private string _deprecationMessage;
        private string _description;
        private string _fullyQualifiedName;
        private double? _max;
        private double? _min;
        private string _structFullyQualifiedName;
        private string _unit;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of possible values an actuator can take.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && (this._allowedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssignedValue. 
        /// <para>
        /// A specified value for the actuator.
        /// </para>
        /// </summary>
        [Obsolete("assignedValue is no longer in use")]
        public string AssignedValue
        {
            get { return this._assignedValue; }
            set { this._assignedValue = value; }
        }

        // Check to see if AssignedValue property is set
        internal bool IsSetAssignedValue()
        {
            return this._assignedValue != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment in addition to the description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The specified data type of the actuator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecationMessage. 
        /// <para>
        /// The deprecation message for the node or the branch that was moved or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DeprecationMessage
        {
            get { return this._deprecationMessage; }
            set { this._deprecationMessage = value; }
        }

        // Check to see if DeprecationMessage property is set
        internal bool IsSetDeprecationMessage()
        {
            return this._deprecationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the actuator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the actuator. For example, the fully qualified name of
        /// an actuator might be <c>Vehicle.Front.Left.Door.Lock</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string FullyQualifiedName
        {
            get { return this._fullyQualifiedName; }
            set { this._fullyQualifiedName = value; }
        }

        // Check to see if FullyQualifiedName property is set
        internal bool IsSetFullyQualifiedName()
        {
            return this._fullyQualifiedName != null;
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The specified possible maximum value of an actuator.
        /// </para>
        /// </summary>
        public double? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The specified possible minimum value of an actuator.
        /// </para>
        /// </summary>
        public double? Min
        {
            get { return this._min; }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StructFullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the struct node for the actuator if the data type of the
        /// actuator is <c>Struct</c> or <c>StructArray</c>. For example, the struct fully qualified
        /// name of an actuator might be <c>Vehicle.Door.LockStruct</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string StructFullyQualifiedName
        {
            get { return this._structFullyQualifiedName; }
            set { this._structFullyQualifiedName = value; }
        }

        // Check to see if StructFullyQualifiedName property is set
        internal bool IsSetStructFullyQualifiedName()
        {
            return this._structFullyQualifiedName != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The scientific unit for the actuator.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}