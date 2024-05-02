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
    /// The parameters that comprise the parameter group.
    /// </summary>
    public partial class Parameters
    {
        private InfluxDBv2Parameters _influxDBv2;

        /// <summary>
        /// Gets and sets the property InfluxDBv2. 
        /// <para>
        /// All the customer-modifiable InfluxDB v2 parameters in Timestream for InfluxDB.
        /// </para>
        /// </summary>
        public InfluxDBv2Parameters InfluxDBv2
        {
            get { return this._influxDBv2; }
            set { this._influxDBv2 = value; }
        }

        // Check to see if InfluxDBv2 property is set
        internal bool IsSetInfluxDBv2()
        {
            return this._influxDBv2 != null;
        }

    }
}