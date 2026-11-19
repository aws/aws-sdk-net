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
    /// Container for the parameters to the PutConnectorTelemetryManifest operation. Creates
    /// or replaces the telemetry manifest of a connector. The telemetry manifest declares
    /// which resources in your cloud provider to collect telemetry from and which telemetry
    /// types to collect. To avoid overwriting changes made by another caller, specify <c>ExpectedVersion</c>.
    /// </summary>
    public partial class PutConnectorTelemetryManifestRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the operation completes
        /// no more than one time. If you use an Amazon Web Services SDK, the SDK generates this
        /// value and reuses it on retries. If this token matches a previous request with the
        /// same telemetry manifest, the service returns the stored version without an error.
        /// If you use the same token with a different telemetry manifest, the service returns
        /// a <c>ValidationException</c>. This operation is idempotent when you use the same token
        /// and parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The version of the telemetry manifest that you expect to replace, as returned by <c>GetConnectorTelemetryManifest</c>.
        /// Omit this value when you create the first telemetry manifest. If the value doesn't
        /// match the current version, the request fails with a <c>ConflictException</c>.
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The telemetry manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TelemetryManifest Manifest { get; set; }

        /// <summary>
        /// Checks to see if the Manifest property is set.
        /// </summary>
        internal bool IsSetManifest() => this.Manifest != null;
    }
}
