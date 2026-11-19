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
    /// Summary representation of a campaign for list operations.
    /// </summary>
    public partial class CampaignSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. The campaign ARN. Present on the summary so a caller
        /// can tag a campaign straight from a list result without a GetCampaign per row — the
        /// same reason the audit timestamps are here.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CampaignId. The campaign identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. Creation timestamp. Present on the summary so
        /// a caller can order a list by recency without reading each campaign in full.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndOn. The last day of the campaign's run window.
        /// </summary>
        public string EndOn { get; set; }

        /// <summary>
        /// Checks to see if the EndOn property is set.
        /// </summary>
        internal bool IsSetEndOn() => this.EndOn != null;

        /// <summary>
        /// Gets and sets the property Language. The language the campaign's assets are written
        /// and typeset in. See `Campaign$Language`.
        /// </summary>
        public AssetLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartOn. The first day of the campaign's run window.
        /// </summary>
        public string StartOn { get; set; }

        /// <summary>
        /// Checks to see if the StartOn property is set.
        /// </summary>
        internal bool IsSetStartOn() => this.StartOn != null;

        /// <summary>
        /// Gets and sets the property State. The campaign's state, derived on every read from
        /// `EndOn` and its assets. See `CampaignState`.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. Last update timestamp. Present on the summary
        /// for the same reason as CreatedAt.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
