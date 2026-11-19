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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// One blueprint to instantiate. Carries nothing but the blueprint's identity, and that
    /// is the point rather than a saving: category, name, FileFormat and platform are all
    /// derived from the named blueprint, so no caller has a member with which to contradict
    /// the pinned schema (asset design section 3.1). There is deliberately no per-entry ClientToken.
    /// AWS Batch Operations requires a *request identifier* per entry -- "a request identifier
    /// CAN either be a resource identifier or a client idempotency token" -- and SourceAssetTemplateIdentifier
    /// is a resource identifier, unique across entries and echoed in this entry's error.
    /// Idempotency is structural rather than token-based: an asset id is derived from (CampaignId,
    /// SourceAssetTemplateId), so a replayed entry resolves to the same asset (I-16).
    /// </summary>
    public partial class BatchCreateCampaignAssetEntry
    {
        /// <summary>
        /// Gets and sets the property SourceAssetTemplateIdentifier. The asset template to instantiate,
        /// as returned by GetCampaignTemplate in CampaignTemplate.AssetTemplates[].id. Must belong
        /// to the campaign's own campaign template. An asset's editable field schema is copied
        /// from this blueprint at creation and pinned, so an asset without one could be neither
        /// validated on update nor made live. Also this entry's request identifier: it MUST be
        /// unique across the request's entries, since a campaign holds at most one asset per
        /// blueprint (I-15) and two entries naming the same blueprint could not both succeed.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SourceAssetTemplateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceAssetTemplateIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceAssetTemplateIdentifier() => this.SourceAssetTemplateIdentifier != null;
    }
}
