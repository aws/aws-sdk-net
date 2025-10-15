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
    /// Percent or Absolute Long for InfluxDB parameters
    /// </summary>
    public partial class PercentOrAbsoluteLong
    {
        private long? _absolute;
        private string _percent;

        /// <summary>
        /// Gets and sets the property Absolute. 
        /// <para>
        /// Absolute long for InfluxDB parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1610612736000)]
        public long Absolute
        {
            get { return this._absolute.GetValueOrDefault(); }
            set { this._absolute = value; }
        }

        // Check to see if Absolute property is set
        internal bool IsSetAbsolute()
        {
            return this._absolute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Percent. 
        /// <para>
        /// Percent for InfluxDB parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=4)]
        public string Percent
        {
            get { return this._percent; }
            set { this._percent = value; }
        }

        // Check to see if Percent property is set
        internal bool IsSetPercent()
        {
            return this._percent != null;
        }

    }
}