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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The LoRaWAN information used with the multicast session.
    /// </summary>
    public partial class LoRaWANMulticastSession
    {
        private int? _dlDr;
        private int? _dlFreq;
        private int? _pingSlotPeriod;
        private DateTime? _sessionStartTime;
        private int? _sessionTimeout;

        /// <summary>
        /// Gets and sets the property DlDr.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? DlDr
        {
            get { return this._dlDr; }
            set { this._dlDr = value; }
        }

        // Check to see if DlDr property is set
        internal bool IsSetDlDr()
        {
            return this._dlDr.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DlFreq.
        /// </summary>
        [AWSProperty(Min=100000000, Max=1000000000)]
        public int? DlFreq
        {
            get { return this._dlFreq; }
            set { this._dlFreq = value; }
        }

        // Check to see if DlFreq property is set
        internal bool IsSetDlFreq()
        {
            return this._dlFreq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PingSlotPeriod. 
        /// <para>
        /// The PingSlotPeriod value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=4096)]
        public int? PingSlotPeriod
        {
            get { return this._pingSlotPeriod; }
            set { this._pingSlotPeriod = value; }
        }

        // Check to see if PingSlotPeriod property is set
        internal bool IsSetPingSlotPeriod()
        {
            return this._pingSlotPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionStartTime.
        /// </summary>
        public DateTime? SessionStartTime
        {
            get { return this._sessionStartTime; }
            set { this._sessionStartTime = value; }
        }

        // Check to see if SessionStartTime property is set
        internal bool IsSetSessionStartTime()
        {
            return this._sessionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionTimeout.
        /// </summary>
        [AWSProperty(Min=60, Max=172800)]
        public int? SessionTimeout
        {
            get { return this._sessionTimeout; }
            set { this._sessionTimeout = value; }
        }

        // Check to see if SessionTimeout property is set
        internal bool IsSetSessionTimeout()
        {
            return this._sessionTimeout.HasValue; 
        }

    }
}