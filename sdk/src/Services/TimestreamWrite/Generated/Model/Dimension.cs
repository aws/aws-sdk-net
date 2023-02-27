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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents the metadata attributes of the time series. For example, the name and Availability
    /// Zone of an EC2 instance or the name of the manufacturer of a wind turbine are dimensions.
    /// </summary>
    public partial class Dimension
    {
        private DimensionValueType _dimensionValueType;
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property DimensionValueType. 
        /// <para>
        /// The data type of the dimension for the time-series data point.
        /// </para>
        /// </summary>
        public DimensionValueType DimensionValueType
        {
            get { return this._dimensionValueType; }
            set { this._dimensionValueType = value; }
        }

        // Check to see if DimensionValueType property is set
        internal bool IsSetDimensionValueType()
        {
            return this._dimensionValueType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Dimension represents the metadata attributes of the time series. For example, the
        /// name and Availability Zone of an EC2 instance or the name of the manufacturer of a
        /// wind turbine are dimensions. 
        /// </para>
        ///  
        /// <para>
        /// For constraints on dimension names, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html#limits.naming">Naming
        /// Constraints</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}