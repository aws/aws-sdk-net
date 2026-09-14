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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Condensed provenance entry for list results — the key triple only (no sourceDetails
    /// union). Enough to display and client-side-filter lineage without the full-read config
    /// payload.
    /// </summary>
    public partial class ProvenanceSummary
    {
        /// <summary>
        /// Gets and sets the property Relation.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvenanceRelation Relation { get; set; }

        /// <summary>
        /// Checks to see if the Relation property is set.
        /// </summary>
        internal bool IsSetRelation() => this.Relation != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The identifier of the upstream source that the registry record was detected from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the upstream source that the registry record was detected from.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
