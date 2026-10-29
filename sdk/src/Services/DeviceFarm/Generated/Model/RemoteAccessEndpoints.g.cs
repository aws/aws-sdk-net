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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the remote endpoints for viewing and controlling a device during a remote
    /// access session.
    /// </summary>
    public partial class RemoteAccessEndpoints
    {
        /// <summary>
        /// Gets and sets the property InteractiveEndpoint. 
        /// <para>
        /// URL for viewing and interacting with the device during the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string InteractiveEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the InteractiveEndpoint property is set.
        /// </summary>
        internal bool IsSetInteractiveEndpoint() => this.InteractiveEndpoint != null;

        /// <summary>
        /// Gets and sets the property RemoteDriverEndpoint. 
        /// <para>
        /// URL for controlling the device using WebDriver-compliant clients, like Appium, during
        /// the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string RemoteDriverEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDriverEndpoint property is set.
        /// </summary>
        internal bool IsSetRemoteDriverEndpoint() => this.RemoteDriverEndpoint != null;
    }
}
