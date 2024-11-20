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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Duration for InfluxDB parameters in Timestream for InfluxDB.
    /// </summary>
    public partial class Duration
    {
        private DurationType _durationType;
        private long? _value;

        /// <summary>
        /// Gets and sets the property DurationType. 
        /// <para>
        /// The type of duration for InfluxDB parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DurationType DurationType
        {
            get { return this._durationType; }
            set { this._durationType = value; }
        }

        // Check to see if DurationType property is set
        internal bool IsSetDurationType()
        {
            return this._durationType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of duration for InfluxDB parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}