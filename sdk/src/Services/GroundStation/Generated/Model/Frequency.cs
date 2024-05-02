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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Object that describes the frequency.
    /// </summary>
    public partial class Frequency
    {
        private FrequencyUnits _units;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// Frequency units.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FrequencyUnits Units
        {
            get { return this._units; }
            set { this._units = value; }
        }

        // Check to see if Units property is set
        internal bool IsSetUnits()
        {
            return this._units != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Frequency value. Valid values are between 2200 to 2300 MHz and 7750 to 8400 MHz for
        /// downlink and 2025 to 2120 MHz for uplink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Value
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