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
    /// This is the response object from the GetConnectorTelemetryManifest operation.
    /// </summary>
    public partial class GetConnectorTelemetryManifestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        /// The time when the telemetry manifest was last updated, in milliseconds since the Unix
        /// epoch.
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the telemetry manifest. Pass this value as <c>ExpectedVersion</c>
        /// when you next call <c>PutConnectorTelemetryManifest</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
