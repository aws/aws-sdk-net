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
    /// Container for the parameters to the DeleteCampaign operation. Permanently deletes
    /// a campaign, its assets and their stored files. A hard delete with no undo: the campaign
    /// leaves ListCampaigns and every read of it returns ResourceNotFoundException. Its tags
    /// are removed with it. Refused with ConflictException while the campaign has a live
    /// asset (`CAMPAIGN_HAS_ACTIVE_ASSETS`), because deleting the record would orphan what
    /// the delivery platform still serves or sends: deactivate those assets first. Also refused
    /// while an activation task is running (`CAMPAIGN_ACTIVATION_IN_PROGRESS`). A completed
    /// campaign can be deleted. Idempotent in effect: deleting a campaign that is already
    /// gone returns ResourceNotFoundException, and nothing is left behind by a retry.
    /// </summary>
    public partial class DeleteCampaignRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign to delete.
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
    }
}
