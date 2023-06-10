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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// An input component that reports the environmental condition of a vehicle.
    /// 
    ///  <note> 
    /// <para>
    /// You can collect data about fluid levels, temperatures, vibrations, or battery voltage
    /// from sensors.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Sensor
    {
        private List<string> _allowedValues = new List<string>();
        private string _comment;
        private NodeDataType _dataType;
        private string _deprecationMessage;
        private string _description;
        private string _fullyQualifiedName;
        private double? _max;
        private double? _min;
        private string _unit;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of possible values a sensor can take.
        /// </para>
        /// </summary>
        public List<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && this._allowedValues.Count > 0; 
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
        /// The specified data type of the sensor. 
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
        /// A brief description of a sensor.
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
        /// The fully qualified name of the sensor. For example, the fully qualified name of a
        /// sensor might be <code>Vehicle.Body.Engine.Battery</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The specified possible maximum value of the sensor.
        /// </para>
        /// </summary>
        public double Max
        {
            get { return this._max.GetValueOrDefault(); }
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
        /// The specified possible minimum value of the sensor.
        /// </para>
        /// </summary>
        public double Min
        {
            get { return this._min.GetValueOrDefault(); }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The scientific unit of measurement for data collected by the sensor.
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