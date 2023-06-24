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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Beaconing parameters for configuring the wireless gateways.
    /// </summary>
    public partial class Beaconing
    {
        private int? _dataRate;
        private List<int> _frequencies = new List<int>();

        /// <summary>
        /// Gets and sets the property DataRate. 
        /// <para>
        /// The data rate for gateways that are sending the beacons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int DataRate
        {
            get { return this._dataRate.GetValueOrDefault(); }
            set { this._dataRate = value; }
        }

        // Check to see if DataRate property is set
        internal bool IsSetDataRate()
        {
            return this._dataRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequencies. 
        /// <para>
        /// The frequency list for the gateways to send the beacons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<int> Frequencies
        {
            get { return this._frequencies; }
            set { this._frequencies = value; }
        }

        // Check to see if Frequencies property is set
        internal bool IsSetFrequencies()
        {
            return this._frequencies != null && this._frequencies.Count > 0; 
        }

    }
}