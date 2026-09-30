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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a device where a user has logged into Wickr, containing information about
    /// the device's type, status, and login history.
    /// </summary>
    public partial class BasicDeviceObject
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique application ID for the Wickr app on this device.
        /// </para>
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp when the device first appeared in the Wickr database.
        /// </para>
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created != null;

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp when the device last successfully logged into Wickr. This is also used
        /// to determine SSO idle time.
        /// </para>
        /// </summary>
        public string LastLogin { get; set; }

        /// <summary>
        /// Checks to see if the LastLogin property is set.
        /// </summary>
        internal bool IsSetLastLogin() => this.LastLogin != null;

        /// <summary>
        /// Gets and sets the property StatusText. 
        /// <para>
        /// The current status of the device, either 'Active' or 'Reset' depending on whether
        /// the device is currently active or has been marked for reset.
        /// </para>
        /// </summary>
        public string StatusText { get; set; }

        /// <summary>
        /// Checks to see if the StatusText property is set.
        /// </summary>
        internal bool IsSetStatusText() => this.StatusText != null;

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// Indicates whether the device is suspended.
        /// </para>
        /// </summary>
        public bool? Suspend { get; set; }

        /// <summary>
        /// Checks to see if the Suspend property is set.
        /// </summary>
        internal bool IsSetSuspend() => this.Suspend.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The operating system of the device (e.g., 'MacOSX', 'Windows', 'iOS', 'Android').
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
