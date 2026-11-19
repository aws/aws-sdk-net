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
    /// Container for the parameters to the GetCampaignAssetExportTask operation. Retrieves
    /// a campaign asset export task by its identifier, reporting its status and, when the
    /// task is COMPLETED, a freshly minted short-lived presigned URL for downloading the
    /// ZIP archive. The download URL is minted on each call and is valid for at most 15 minutes;
    /// clients should download promptly rather than caching it. When the task has FAILED,
    /// FailureReason explains why. Poll this operation (roughly every 2-5 seconds) until
    /// the task reaches a terminal state.
    /// </summary>
    public partial class GetCampaignAssetExportTaskRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetExportTaskIdentifier. The export task to retrieve:
        /// the `Id` StartCampaignAssetExportTask returned (`etsk-…`). An id only. An export task
        /// has no ARN: none is returned, recorded or authorized on (the read authorizes on its
        /// campaign), so there is no ARN to accept (DG-063 D-35).
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignAssetExportTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CampaignAssetExportTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetCampaignAssetExportTaskIdentifier() => this.CampaignAssetExportTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property CampaignIdentifier. The campaign that owns the export task.
        /// Accepts the campaign id or ARN. Required so the read is authorized on campaign/{CampaignId};
        /// the task must belong to this campaign or the request resolves to not-found.
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
