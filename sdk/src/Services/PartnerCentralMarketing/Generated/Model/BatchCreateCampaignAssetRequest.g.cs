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
    /// Container for the parameters to the BatchCreateCampaignAsset operation. Instantiates
    /// one or more of the campaign template's blueprints as assets of this campaign. The
    /// only asset-create operation: DG-038 deleted the singular CreateCampaignAsset, and
    /// AWS Batch Operations makes exposing a singular alongside a batch optional ("which
    /// MAY actually be exposed in addition"). It also replaced kit instantiation -- CreateCampaign
    /// creates zero assets, so this is the only path by which an asset comes into existence.
    /// Errors here are whole-request only, and nothing is written when one is thrown. Per-entry
    /// failures ride in the response's `Errors` list with a 200. ServiceQuotaExceededException
    /// is deliberately absent: a campaign holds at most one asset per blueprint (I-15), so
    /// the ceiling is the size of the bound kit and a request of unique valid entries cannot
    /// exceed it.
    /// </summary>
    public partial class BatchCreateCampaignAssetRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 200)]
        public string CampaignIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignIdentifier() => this.CampaignIdentifier != null;

        /// <summary>
        /// Gets and sets the property Catalog. The catalog (AWS or Sandbox).
        /// </summary>
        [AWSProperty(Required = true)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Entries. The blueprints to instantiate, one entry each.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<BatchCreateCampaignAssetEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchCreateCampaignAssetEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
