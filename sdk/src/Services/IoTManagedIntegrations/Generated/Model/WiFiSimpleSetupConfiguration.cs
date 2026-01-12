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
    /// The Wi-Fi Simple Setup configuration for the managed thing, which defines provisioning
    /// capabilities and timeout settings.
    /// </summary>
    public partial class WiFiSimpleSetupConfiguration
    {
        private bool? _enableAsProvisionee;
        private bool? _enableAsProvisioner;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property EnableAsProvisionee. 
        /// <para>
        /// Indicates whether the device can act as a provisionee in Wi-Fi Simple Setup, allowing
        /// it to be configured by other devices.
        /// </para>
        /// </summary>
        public bool EnableAsProvisionee
        {
            get { return this._enableAsProvisionee.GetValueOrDefault(); }
            set { this._enableAsProvisionee = value; }
        }

        // Check to see if EnableAsProvisionee property is set
        internal bool IsSetEnableAsProvisionee()
        {
            return this._enableAsProvisionee.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableAsProvisioner. 
        /// <para>
        /// Indicates whether the device can act as a provisioner in Wi-Fi Simple Setup, allowing
        /// it to configure other devices.
        /// </para>
        /// </summary>
        public bool EnableAsProvisioner
        {
            get { return this._enableAsProvisioner.GetValueOrDefault(); }
            set { this._enableAsProvisioner = value; }
        }

        // Check to see if EnableAsProvisioner property is set
        internal bool IsSetEnableAsProvisioner()
        {
            return this._enableAsProvisioner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The timeout duration in minutes for Wi-Fi Simple Setup. Valid range is 5 to 15 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=15)]
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}