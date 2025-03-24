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
    /// This is the response object from the GetManagedThingCapabilities operation.
    /// </summary>
    public partial class GetManagedThingCapabilitiesResponse : AmazonWebServiceResponse
    {
        private string _capabilities;
        private CapabilityReport _capabilityReport;
        private string _managedThingId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities of the device such as light bulb.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property CapabilityReport. 
        /// <para>
        /// A report of the capabilities for the managed thing.
        /// </para>
        /// </summary>
        public CapabilityReport CapabilityReport
        {
            get { return this._capabilityReport; }
            set { this._capabilityReport = value; }
        }

        // Check to see if CapabilityReport property is set
        internal bool IsSetCapabilityReport()
        {
            return this._capabilityReport != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The id of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

    }
}