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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Criteria for filtering edges in a context graph query.
    /// </summary>
    public partial class EdgeFilters
    {
        /// <summary>
        /// Gets and sets the property EdgeId. Match only the edge with this identifier.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EdgeId { get; set; }

        /// <summary>
        /// Checks to see if the EdgeId property is set.
        /// </summary>
        internal bool IsSetEdgeId() => this.EdgeId != null;

        /// <summary>
        /// Gets and sets the property EdgeType. Match only edges of this relationship kind.
        /// </summary>
        public EdgeType EdgeType { get; set; }

        /// <summary>
        /// Checks to see if the EdgeType property is set.
        /// </summary>
        internal bool IsSetEdgeType() => this.EdgeType != null;

        /// <summary>
        /// Gets and sets the property From. Match only edges originating from this node identifier.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property Operations. Match edges carrying any of these operations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sources. Match edges contributed by any of these discovery
        /// sources.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryAttributes. Match edges by their OpenTelemetry
        /// (OTel) telemetry attributes. Not yet enforced: currently accepted but ignored (does
        /// not filter), matching nodeFilters.telemetryAttributes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<KeyFilter> TelemetryAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyFilter>() : null;

        /// <summary>
        /// Checks to see if the TelemetryAttributes property is set.
        /// </summary>
        internal bool IsSetTelemetryAttributes() => this.TelemetryAttributes != null && (this.TelemetryAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property To. Match only edges pointing to this node identifier.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;
    }
}
