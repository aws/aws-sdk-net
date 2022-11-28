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
    /// GSM object for network measurement reports.
    /// </summary>
    public partial class GsmNmrObj
    {
        private int? _bcch;
        private int? _bsic;
        private GlobalIdentity _globalIdentity;
        private int? _rxLevel;

        /// <summary>
        /// Gets and sets the property Bcch. 
        /// <para>
        /// GSM broadcast control channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1023)]
        public int Bcch
        {
            get { return this._bcch.GetValueOrDefault(); }
            set { this._bcch = value; }
        }

        // Check to see if Bcch property is set
        internal bool IsSetBcch()
        {
            return this._bcch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Bsic. 
        /// <para>
        /// GSM base station identity code (BSIC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public int Bsic
        {
            get { return this._bsic.GetValueOrDefault(); }
            set { this._bsic = value; }
        }

        // Check to see if Bsic property is set
        internal bool IsSetBsic()
        {
            return this._bsic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalIdentity. 
        /// <para>
        /// Global identity information of the GSM object.
        /// </para>
        /// </summary>
        public GlobalIdentity GlobalIdentity
        {
            get { return this._globalIdentity; }
            set { this._globalIdentity = value; }
        }

        // Check to see if GlobalIdentity property is set
        internal bool IsSetGlobalIdentity()
        {
            return this._globalIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property RxLevel. 
        /// <para>
        /// Rx level, which is the received signal power, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-110, Max=-25)]
        public int RxLevel
        {
            get { return this._rxLevel.GetValueOrDefault(); }
            set { this._rxLevel = value; }
        }

        // Check to see if RxLevel property is set
        internal bool IsSetRxLevel()
        {
            return this._rxLevel.HasValue; 
        }

    }
}