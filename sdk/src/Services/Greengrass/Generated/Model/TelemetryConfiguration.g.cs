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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Configuration settings for running telemetry.
    /// </summary>
    public partial class TelemetryConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSyncStatus. Synchronization status of the
        /// device reported configuration with the desired configuration.
        /// </summary>
        public ConfigurationSyncStatus ConfigurationSyncStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSyncStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationSyncStatus() => this.ConfigurationSyncStatus != null;

        /// <summary>
        /// Gets and sets the property Telemetry. Configure telemetry to be on or off.
        /// </summary>
        [AWSProperty(Required = true)]
        public Telemetry Telemetry { get; set; }

        /// <summary>
        /// Checks to see if the Telemetry property is set.
        /// </summary>
        internal bool IsSetTelemetry() => this.Telemetry != null;
    }
}
