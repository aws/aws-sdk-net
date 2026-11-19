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
    /// One asset that exists as a result of this call.
    /// </summary>
    public partial class BatchCreateCampaignAssetResult
    {
        /// <summary>
        /// Gets and sets the property Id. The asset's identifier, derived from (CampaignId, SourceAssetTemplateId)
        /// rather than minted, so the same entry always resolves to the same id.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Layout. For a multi-layout blueprint, the asset's layout
        /// options, so a client can render the first layout picker without reading each asset
        /// back. Nothing is selected at creation. Absent for a single-layout blueprint.
        /// </summary>
        public CampaignAssetLayout Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property SourceAssetTemplateId. The entry's request identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SourceAssetTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAssetTemplateId property is set.
        /// </summary>
        internal bool IsSetSourceAssetTemplateId() => this.SourceAssetTemplateId != null;
    }
}
