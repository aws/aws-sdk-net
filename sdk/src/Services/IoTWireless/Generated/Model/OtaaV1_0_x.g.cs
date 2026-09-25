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
    /// OTAA device object for v1.0.x
    /// </summary>
    public partial class OtaaV1_0_x
    {
        /// <summary>
        /// Gets and sets the property AppEui. 
        /// <para>
        /// The AppEUI value. You specify this value when using LoRaWAN versions v1.0.2 or v1.0.3.
        /// </para>
        /// </summary>
        public string AppEui { get; set; }

        /// <summary>
        /// Checks to see if the AppEui property is set.
        /// </summary>
        internal bool IsSetAppEui() => this.AppEui != null;

        /// <summary>
        /// Gets and sets the property AppKey. 
        /// <para>
        /// The AppKey value.
        /// </para>
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// Checks to see if the AppKey property is set.
        /// </summary>
        internal bool IsSetAppKey() => this.AppKey != null;

        /// <summary>
        /// Gets and sets the property GenAppKey. 
        /// <para>
        /// The GenAppKey value.
        /// </para>
        /// </summary>
        public string GenAppKey { get; set; }

        /// <summary>
        /// Checks to see if the GenAppKey property is set.
        /// </summary>
        internal bool IsSetGenAppKey() => this.GenAppKey != null;

        /// <summary>
        /// Gets and sets the property JoinEui. 
        /// <para>
        /// The JoinEUI value. You specify this value instead of the AppEUI when using LoRaWAN
        /// version v1.0.4.
        /// </para>
        /// </summary>
        public string JoinEui { get; set; }

        /// <summary>
        /// Checks to see if the JoinEui property is set.
        /// </summary>
        internal bool IsSetJoinEui() => this.JoinEui != null;
    }
}
