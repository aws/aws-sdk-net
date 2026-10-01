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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// The attributes of an <c>Endpoint</c>.
    /// </summary>
    public partial class EndpointAttributes
    {
        /// <summary>
        /// Gets and sets the property DeviceToken. 
        /// <para>
        /// The device token for the GCM, APNS, and APNS_SANDBOX endpoint types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1600)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// Checks to see if the DeviceToken property is set.
        /// </summary>
        internal bool IsSetDeviceToken() => this.DeviceToken != null;

        /// <summary>
        /// Gets and sets the property VoipDeviceToken. 
        /// <para>
        /// The VOIP device token for the APNS and APNS_SANDBOX endpoint types.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1600)]
        public string VoipDeviceToken { get; set; }

        /// <summary>
        /// Checks to see if the VoipDeviceToken property is set.
        /// </summary>
        internal bool IsSetVoipDeviceToken() => this.VoipDeviceToken != null;
    }
}
