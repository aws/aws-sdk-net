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
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of possible values a sensor can take.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment in addition to the description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The specified data type of the sensor. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DeprecationMessage. 
        /// <para>
        /// The deprecation message for the node or the branch that was moved or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DeprecationMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationMessage property is set.
        /// </summary>
        internal bool IsSetDeprecationMessage() => this.DeprecationMessage != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of a sensor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the sensor. For example, the fully qualified name of a
        /// sensor might be <c>Vehicle.Body.Engine.Battery</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the FullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetFullyQualifiedName() => this.FullyQualifiedName != null;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The specified possible maximum value of the sensor.
        /// </para>
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The specified possible minimum value of the sensor.
        /// </para>
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;

        /// <summary>
        /// Gets and sets the property StructFullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the struct node for a sensor if the data type of the actuator
        /// is <c>Struct</c> or <c>StructArray</c>. For example, the struct fully qualified name
        /// of a sensor might be <c>Vehicle.ADAS.CameraStruct</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public string StructFullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the StructFullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetStructFullyQualifiedName() => this.StructFullyQualifiedName != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The scientific unit of measurement for data collected by the sensor.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
