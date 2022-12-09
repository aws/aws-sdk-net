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
    /// A signal that represents static information about the vehicle, such as engine type
    /// or manufacturing date.
    /// </summary>
    public partial class Attribute
    {
        private List<string> _allowedValues = new List<string>();
        private string _assignedValue;
        private NodeDataType _dataType;
        private string _defaultValue;
        private string _description;
        private string _fullyQualifiedName;
        private double? _max;
        private double? _min;
        private string _unit;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of possible values an attribute can be assigned.
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
        /// Gets and sets the property AssignedValue. 
        /// <para>
        /// A specified value for the attribute.
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
        /// Gets and sets the property DataType. 
        /// <para>
        /// The specified data type of the attribute. 
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
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the attribute.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the attribute.
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
        /// The fully qualified name of the attribute. For example, the fully qualified name of
        /// an attribute might be <code>Vehicle.Body.Engine.Type</code>.
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
        /// The specified possible maximum value of the attribute.
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
        /// The specified possible minimum value of the attribute.
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
        /// The scientific unit for the attribute.
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