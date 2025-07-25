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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure containing summary information about a device discovery job, including its
    /// identifier, type, and status.
    /// </summary>
    public partial class DeviceDiscoverySummary
    {
        private DiscoveryType _discoveryType;
        private string _id;
        private DeviceDiscoveryStatus _status;

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// The type of discovery process used to find devices.
        /// </para>
        /// </summary>
        public DiscoveryType DiscoveryType
        {
            get { return this._discoveryType; }
            set { this._discoveryType = value; }
        }

        // Check to see if DiscoveryType property is set
        internal bool IsSetDiscoveryType()
        {
            return this._discoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the device discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the device discovery job.
        /// </para>
        /// </summary>
        public DeviceDiscoveryStatus Status
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