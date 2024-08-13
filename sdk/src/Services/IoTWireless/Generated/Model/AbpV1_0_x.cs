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
    /// ABP device object for LoRaWAN specification v1.0.x
    /// </summary>
    public partial class AbpV1_0_x
    {
        private string _devAddr;
        private int? _fCntStart;
        private SessionKeysAbpV1_0_x _sessionKeys;

        /// <summary>
        /// Gets and sets the property DevAddr. 
        /// <para>
        /// The DevAddr value.
        /// </para>
        /// </summary>
        public string DevAddr
        {
            get { return this._devAddr; }
            set { this._devAddr = value; }
        }

        // Check to see if DevAddr property is set
        internal bool IsSetDevAddr()
        {
            return this._devAddr != null;
        }

        /// <summary>
        /// Gets and sets the property FCntStart. 
        /// <para>
        /// The FCnt init value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? FCntStart
        {
            get { return this._fCntStart; }
            set { this._fCntStart = value; }
        }

        // Check to see if FCntStart property is set
        internal bool IsSetFCntStart()
        {
            return this._fCntStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionKeys. 
        /// <para>
        /// Session keys for ABP v1.0.x
        /// </para>
        /// </summary>
        public SessionKeysAbpV1_0_x SessionKeys
        {
            get { return this._sessionKeys; }
            set { this._sessionKeys = value; }
        }

        // Check to see if SessionKeys property is set
        internal bool IsSetSessionKeys()
        {
            return this._sessionKeys != null;
        }

    }
}