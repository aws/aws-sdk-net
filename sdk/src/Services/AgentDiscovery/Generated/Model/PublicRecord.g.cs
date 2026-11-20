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
    /// A public record returned by search. Only the record's public descriptors are included.
    /// </summary>
    public partial class PublicRecord
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. When the record was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. A description of the record.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Descriptors. Every PUBLIC descriptor slot the record was
        /// published with, as published: each slot's `source`, inline `data`, `version` and nested
        /// `additionalData`, the `custom` slot included. Absent on a record discovered at a partner
        /// source; ARD serves the partner's cards.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 32)]
        public Dictionary<string, DescriptorEntry> Descriptors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DescriptorEntry>() : null;

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null && (this.Descriptors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. The record's display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Domain.
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public Identifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property RecordType. The kind of resource the record describes,
        /// such as an agent, a tool, or a skill.
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordType RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. The record's version string, set by its
        /// publisher. Left off when the record has none, for example a discovered record whose
        /// source carries no version.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion != null;

        /// <summary>
        /// Gets and sets the property TrustManifests. Trust Manifests (AI Catalog Trust Manifest
        /// Object), today only the registry's own, `contributor` `did:web:agent-registry.global.api.aws`.
        /// Its one provenance link says how the registry got the record: `relation` is `publishedFrom`
        /// for a record its owner published and `discoveredFrom` for one the registry discovered
        /// at a partner source, with `sourceId` as `ProvenanceLink.sourceId` describes. The `provenance`
        /// filter takes the same values (see `ProvenanceRelation`). It's left off when the registry
        /// can't name the source: a `federatedFrom` record until the index carries the peer registry,
        /// a discovered record with no source, or a missing or unknown origin. The manifest is
        /// unsigned, so it attributes the claim to the registry and doesn't authenticate it.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<TrustManifest> TrustManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<TrustManifest>() : null;

        /// <summary>
        /// Checks to see if the TrustManifests property is set.
        /// </summary>
        internal bool IsSetTrustManifests() => this.TrustManifests != null && (this.TrustManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. When the record was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
