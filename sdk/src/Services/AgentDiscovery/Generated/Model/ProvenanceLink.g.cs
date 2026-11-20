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

namespace Amazon.AgentDiscovery.Model
{
    /// <summary>
    /// Lineage of a record (AI Catalog Provenance Link Object), with only its required members.
    /// </summary>
    public partial class ProvenanceLink
    {
        /// <summary>
        /// Gets and sets the property Relation. How the contributor got the record.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvenanceRelation Relation { get; set; }

        /// <summary>
        /// Checks to see if the Relation property is set.
        /// </summary>
        internal bool IsSetRelation() => this.Relation != null;

        /// <summary>
        /// Gets and sets the property SourceId. The source of the record. Not always a URI. On
        /// `publishedFrom` it's the value of the record's `identifier` union member, `identifier.uri`
        /// or `identifier.domain`, unchanged. On `discoveredFrom` it's the name the registry
        /// gave the partner source when it was configured for crawling, not a URL.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;
    }
}
