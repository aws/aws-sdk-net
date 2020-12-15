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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a AWS IoT Greengrass core device, which is an AWS IoT thing
    /// that runs the AWS IoT Greengrass Core software.
    /// </summary>
    public partial class CoreDevice
    {
        private string _coreDeviceThingName;
        private DateTime? _lastStatusUpdateTimestamp;
        private CoreDeviceStatus _status;

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the AWS IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CoreDeviceThingName
        {
            get { return this._coreDeviceThingName; }
            set { this._coreDeviceThingName = value; }
        }

        // Check to see if CoreDeviceThingName property is set
        internal bool IsSetCoreDeviceThingName()
        {
            return this._coreDeviceThingName != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusUpdateTimestamp. 
        /// <para>
        /// The time at which the core device's status last updated, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime LastStatusUpdateTimestamp
        {
            get { return this._lastStatusUpdateTimestamp.GetValueOrDefault(); }
            set { this._lastStatusUpdateTimestamp = value; }
        }

        // Check to see if LastStatusUpdateTimestamp property is set
        internal bool IsSetLastStatusUpdateTimestamp()
        {
            return this._lastStatusUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core device. Core devices can have the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HEALTHY</code> – The AWS IoT Greengrass Core software and all components run
        /// on the core device without issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNHEALTHY</code> – The AWS IoT Greengrass Core software or a component is in
        /// a failed state on the core device.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CoreDeviceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}