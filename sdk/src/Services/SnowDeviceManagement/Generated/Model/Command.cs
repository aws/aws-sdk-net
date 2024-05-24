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
    /// The command given to the device to execute.
    /// </summary>
    public partial class Command
    {
        private Reboot _reboot;
        private Unlock _unlock;

        /// <summary>
        /// Gets and sets the property Reboot. 
        /// <para>
        /// Reboots the device.
        /// </para>
        /// </summary>
        public Reboot Reboot
        {
            get { return this._reboot; }
            set { this._reboot = value; }
        }

        // Check to see if Reboot property is set
        internal bool IsSetReboot()
        {
            return this._reboot != null;
        }

        /// <summary>
        /// Gets and sets the property Unlock. 
        /// <para>
        /// Unlocks the device.
        /// </para>
        /// </summary>
        public Unlock Unlock
        {
            get { return this._unlock; }
            set { this._unlock = value; }
        }

        // Check to see if Unlock property is set
        internal bool IsSetUnlock()
        {
            return this._unlock != null;
        }

    }
}