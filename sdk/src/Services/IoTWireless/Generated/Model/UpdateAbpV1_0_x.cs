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
    public partial class UpdateAbpV1_0_x
    {
        private int? _fCntStart;

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

    }
}