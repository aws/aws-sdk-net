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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the ListNetworkConnectorVersions operation. Returns
    /// a paginated list of the versions of a network connector. Each configuration update
    /// creates a new immutable version; this operation lists those versions for the connector
    /// you specify. You can optionally filter results by version state. Use the <c>Marker</c>
    /// parameter from a previous response to retrieve the next page of results. <para> Each
    /// item in the response includes the version-qualified ARN, version number, current state,
    /// and last modified timestamp for that version. To retrieve the current (latest) configuration
    /// of the connector, use <c>GetNetworkConnector</c>; to inspect a specific version, call
    /// <c>GetNetworkConnector</c> with a version-qualified identifier. </para>
    /// </summary>
    public partial class ListNetworkConnectorVersionsRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the network connector whose versions you want to list. You can specify
        /// the connector ID, name, or full ARN. Specify an unqualified identifier — this operation
        /// lists all versions of the connector, not a specific version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token from a previous <c>ListNetworkConnectorVersions</c> response.
        /// Use this value to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of versions to return per page. Valid range: 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Optional filter to return only versions in the specified state (for example, <c>ACTIVE</c>
        /// or <c>FAILED</c>).
        /// </para>
        /// </summary>
        public NetworkConnectorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
