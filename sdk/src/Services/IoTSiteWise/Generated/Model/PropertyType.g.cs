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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a property type, which can be one of <c>attribute</c>, <c>measurement</c>,
    /// <c>metric</c>, or <c>transform</c>.
    /// </summary>
    public partial class PropertyType
    {
        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Specifies an asset attribute property. An attribute generally contains static information,
        /// such as the serial number of an <a href="https://en.wikipedia.org/wiki/Internet_of_things#Industrial_applications">IIoT</a>
        /// wind turbine.
        /// </para>
        /// </summary>
        public Attribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property Measurement. 
        /// <para>
        /// Specifies an asset measurement property. A measurement represents a device's raw sensor
        /// data stream, such as timestamped temperature values or timestamped power values.
        /// </para>
        /// </summary>
        public Measurement Measurement { get; set; }

        /// <summary>
        /// Checks to see if the Measurement property is set.
        /// </summary>
        internal bool IsSetMeasurement() => this.Measurement != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// Specifies an asset metric property. A metric contains a mathematical expression that
        /// uses aggregate functions to process all input data points over a time interval and
        /// output a single data point, such as to calculate the average hourly temperature.
        /// </para>
        /// </summary>
        public Metric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property Transform. 
        /// <para>
        /// Specifies an asset transform property. A transform contains a mathematical expression
        /// that maps a property's data points from one form to another, such as a unit conversion
        /// from Celsius to Fahrenheit.
        /// </para>
        /// </summary>
        public Transform Transform { get; set; }

        /// <summary>
        /// Checks to see if the Transform property is set.
        /// </summary>
        internal bool IsSetTransform() => this.Transform != null;
    }
}
