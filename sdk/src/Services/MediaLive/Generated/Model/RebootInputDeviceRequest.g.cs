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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the RebootInputDevice operation. Send a reboot command
    /// to the specified input device. The device will begin rebooting within a few seconds
    /// of sending the command. When the reboot is complete, the device’s connection status
    /// will change to connected.
    /// </summary>
    public partial class RebootInputDeviceRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property Force. Force a reboot of an input device. If the device
        /// is streaming, it will stop streaming and begin rebooting within a few seconds of sending
        /// the command. If the device was streaming prior to the reboot, the device will resume
        /// streaming when the reboot completes.
        /// </summary>
        public RebootInputDeviceForce Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force != null;

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of the input device to reboot.
        /// For example, hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required = true)]
        public string InputDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the InputDeviceId property is set.
        /// </summary>
        internal bool IsSetInputDeviceId() => this.InputDeviceId != null;
    }
}
