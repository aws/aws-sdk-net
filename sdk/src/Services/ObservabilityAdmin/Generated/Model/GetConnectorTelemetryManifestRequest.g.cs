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
    /// Container for the parameters to the GetConnectorTelemetryManifest operation. Retrieves
    /// the telemetry manifest of a connector and its current version. If the connector has
    /// no telemetry manifest, this operation returns a <c>ResourceNotFoundException</c>.
    /// </summary>
    public partial class GetConnectorTelemetryManifestRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorIdentifier. 
        /// <para>
        /// The connector. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of the connector
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ConnectorIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorIdentifier property is set.
        /// </summary>
        internal bool IsSetConnectorIdentifier() => this.ConnectorIdentifier != null;
    }
}
