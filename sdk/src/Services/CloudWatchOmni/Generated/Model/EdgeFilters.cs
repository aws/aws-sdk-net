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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
        private string _edgeId;
        private EdgeType _edgeType;
        private string _from;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<KeyFilter> _telemetryAttributes = AWSConfigs.InitializeCollections ? new List<KeyFilter>() : null;
        private string _to;

        /// <summary>
        /// Gets and sets the property EdgeId. 
        /// <para>
        /// Match only the edge with this identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EdgeId
        {
            get { return this._edgeId; }
            set { this._edgeId = value; }
        }

        // Check to see if EdgeId property is set
        internal bool IsSetEdgeId()
        {
            return this._edgeId != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeType. 
        /// <para>
        /// Match only edges of this relationship kind.
        /// </para>
        /// </summary>
        public EdgeType EdgeType
        {
            get { return this._edgeType; }
            set { this._edgeType = value; }
        }

        // Check to see if EdgeType property is set
        internal bool IsSetEdgeType()
        {
            return this._edgeType != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// Match only edges originating from this node identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// Match edges carrying any of these operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Match edges contributed by any of these discovery sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TelemetryAttributes. 
        /// <para>
        /// Match edges by their OpenTelemetry (OTel) telemetry attributes. Not yet enforced:
        /// currently accepted but ignored (does not filter), matching nodeFilters.telemetryAttributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<KeyFilter> TelemetryAttributes
        {
            get { return this._telemetryAttributes; }
            set { this._telemetryAttributes = value; }
        }

        // Check to see if TelemetryAttributes property is set
        internal bool IsSetTelemetryAttributes()
        {
            return this._telemetryAttributes != null && (this._telemetryAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Match only edges pointing to this node identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

    }
}