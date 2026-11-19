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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Declares which resources in a cloud provider to collect telemetry from and which telemetry
    /// types to collect.
    /// </summary>
    public partial class TelemetryManifest
    {
        /// <summary>
        /// Gets and sets the property Infrastructure. 
        /// <para>
        /// The choices for the infrastructure that the setup creates in your cloud provider,
        /// such as the subscription that contains the Event Hubs and their size. If you omit
        /// this value, the setup uses default settings. If an <c>AzureScopeItem</c> collects
        /// <c>ResourceLogs</c>, you must specify at least the Azure <c>SubscriptionId</c>.
        /// </para>
        /// </summary>
        public TelemetryManifestInfrastructure Infrastructure { get; set; }

        /// <summary>
        /// Checks to see if the Infrastructure property is set.
        /// </summary>
        internal bool IsSetInfrastructure() => this.Infrastructure != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The resources to collect telemetry from and the telemetry types to collect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TelemetryManifestSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
