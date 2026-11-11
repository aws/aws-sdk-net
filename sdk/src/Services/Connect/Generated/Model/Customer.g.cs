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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the Customer on the contact.
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// Gets and sets the property Capabilities.
        /// </summary>
        public ParticipantCapabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property DeviceInfo. 
        /// <para>
        /// Information regarding Customer’s device.
        /// </para>
        /// </summary>
        public DeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// Checks to see if the DeviceInfo property is set.
        /// </summary>
        internal bool IsSetDeviceInfo() => this.DeviceInfo != null;
    }
}
