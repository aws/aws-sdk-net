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
    /// This is the response object from the GetCampaignAssetExportTask operation.
    /// </summary>
    public partial class GetCampaignAssetExportTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. When the task was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DownloadUrl. Presigned GET URL for the ZIP archive. Present
        /// only when status is COMPLETED. Freshly minted on each call and short-lived (&lt;=15
        /// minutes).
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. When DownloadUrl expires. Present only when
        /// status is COMPLETED.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. Why the task failed. Present only when status
        /// is FAILED.
        /// </summary>
        public CampaignAssetExportFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. The export task identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Status. The task's state.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetExportTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
