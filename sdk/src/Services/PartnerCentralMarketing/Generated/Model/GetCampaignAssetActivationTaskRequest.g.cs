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
    /// Container for the parameters to the GetCampaignAssetActivationTask operation. Reads
    /// a campaign's current activation task. Keyed on the **campaign**, with no task identifier,
    /// because a campaign has at most one activation task: runs are serialised, so there
    /// is no collection to address into. The caller always holds the task id anyway, because
    /// Start returned it — the id is a correlation value, not an address. Returns the campaign's
    /// most recent task. A new task overwrites the previous one, so this is not a history:
    /// the durable per-asset record is on the assets themselves. Returns ResourceNotFoundException
    /// when the campaign has never had a task, or when its last one has expired.
    /// </summary>
    public partial class GetCampaignAssetActivationTaskRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign whose current task to
        /// read. This addresses the task, and also authorizes the call.
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
