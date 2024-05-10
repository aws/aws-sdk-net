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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
        private string _installedVersion;
        private string _installingVersion;
        private string _installState;

        /// <summary>
        /// Gets and sets the property InstalledVersion. 
        /// <para>
        /// The version of the software currently installed on the device.
        /// </para>
        /// </summary>
        public string InstalledVersion
        {
            get { return this._installedVersion; }
            set { this._installedVersion = value; }
        }

        // Check to see if InstalledVersion property is set
        internal bool IsSetInstalledVersion()
        {
            return this._installedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstallingVersion. 
        /// <para>
        /// The version of the software being installed on the device.
        /// </para>
        /// </summary>
        public string InstallingVersion
        {
            get { return this._installingVersion; }
            set { this._installingVersion = value; }
        }

        // Check to see if InstallingVersion property is set
        internal bool IsSetInstallingVersion()
        {
            return this._installingVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstallState. 
        /// <para>
        /// The state of the software that is installed or that is being installed on the device.
        /// </para>
        /// </summary>
        public string InstallState
        {
            get { return this._installState; }
            set { this._installState = value; }
        }

        // Check to see if InstallState property is set
        internal bool IsSetInstallState()
        {
            return this._installState != null;
        }

    }
}