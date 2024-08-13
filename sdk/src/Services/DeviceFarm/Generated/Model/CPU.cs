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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the amount of CPU that an app is using on a physical device. Does not represent
    /// system-wide CPU usage.
    /// </summary>
    public partial class CPU
    {
        private string _architecture;
        private double? _clock;
        private string _frequency;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU's architecture (for example, x86 or ARM).
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Clock. 
        /// <para>
        /// The clock speed of the device's CPU, expressed in hertz (Hz). For example, a 1.2 GHz
        /// CPU is expressed as 1200000000.
        /// </para>
        /// </summary>
        public double? Clock
        {
            get { return this._clock; }
            set { this._clock = value; }
        }

        // Check to see if Clock property is set
        internal bool IsSetClock()
        {
            return this._clock.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The CPU's frequency.
        /// </para>
        /// </summary>
        public string Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

    }
}