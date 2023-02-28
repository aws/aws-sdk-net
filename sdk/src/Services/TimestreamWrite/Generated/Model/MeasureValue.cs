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
    /// Represents the data attribute of the time series. For example, the CPU utilization
    /// of an EC2 instance or the RPM of a wind turbine are measures. MeasureValue has both
    /// name and value. 
    /// 
    ///  
    /// <para>
    ///  MeasureValue is only allowed for type <code>MULTI</code>. Using <code>MULTI</code>
    /// type, you can pass multiple data attributes associated with the same time series in
    /// a single record 
    /// </para>
    /// </summary>
    public partial class MeasureValue
    {
        private string _name;
        private MeasureValueType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the MeasureValue. 
        /// </para>
        ///  
        /// <para>
        ///  For constraints on MeasureValue names, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html#limits.naming">
        /// Naming Constraints</a> in the Amazon Timestream Developer Guide.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Contains the data type of the MeasureValue for the time-series data point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MeasureValueType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value for the MeasureValue. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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