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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// ABP device object for LoRaWAN specification v1.1
    /// </summary>
    public partial class AbpV1_1
    {
        /// <summary>
        /// Gets and sets the property DevAddr. 
        /// <para>
        /// The DevAddr value.
        /// </para>
        /// </summary>
        public string DevAddr { get; set; }

        /// <summary>
        /// Checks to see if the DevAddr property is set.
        /// </summary>
        internal bool IsSetDevAddr() => this.DevAddr != null;

        /// <summary>
        /// Gets and sets the property FCntStart. 
        /// <para>
        /// The FCnt init value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? FCntStart { get; set; }

        /// <summary>
        /// Checks to see if the FCntStart property is set.
        /// </summary>
        internal bool IsSetFCntStart() => this.FCntStart.HasValue;

        /// <summary>
        /// Gets and sets the property SessionKeys. 
        /// <para>
        /// Session keys for ABP v1.1
        /// </para>
        /// </summary>
        public SessionKeysAbpV1_1 SessionKeys { get; set; }

        /// <summary>
        /// Checks to see if the SessionKeys property is set.
        /// </summary>
        internal bool IsSetSessionKeys() => this.SessionKeys != null;
    }
}
