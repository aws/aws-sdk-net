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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Information about the software on the device.
    /// </summary>
    public partial class SoftwareInformation
    {
        /// <summary>
        /// Gets and sets the property InstallState. 
        /// <para>
        /// The state of the software that is installed or that is being installed on the device.
        /// </para>
        /// </summary>
        public string InstallState { get; set; }

        /// <summary>
        /// Checks to see if the InstallState property is set.
        /// </summary>
        internal bool IsSetInstallState() => this.InstallState != null;

        /// <summary>
        /// Gets and sets the property InstalledVersion. 
        /// <para>
        /// The version of the software currently installed on the device.
        /// </para>
        /// </summary>
        public string InstalledVersion { get; set; }

        /// <summary>
        /// Checks to see if the InstalledVersion property is set.
        /// </summary>
        internal bool IsSetInstalledVersion() => this.InstalledVersion != null;

        /// <summary>
        /// Gets and sets the property InstallingVersion. 
        /// <para>
        /// The version of the software being installed on the device.
        /// </para>
        /// </summary>
        public string InstallingVersion { get; set; }

        /// <summary>
        /// Checks to see if the InstallingVersion property is set.
        /// </summary>
        internal bool IsSetInstallingVersion() => this.InstallingVersion != null;
    }
}
