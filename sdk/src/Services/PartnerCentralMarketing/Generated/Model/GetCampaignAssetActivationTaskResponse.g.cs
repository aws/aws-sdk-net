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
    /// This is the response object from the GetCampaignAssetActivationTask operation.
    /// </summary>
    public partial class GetCampaignAssetActivationTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Assets. One entry per asset the request named, in the order
        /// named. An asset refused up front is FAILED from the first response, with its reason.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<CampaignAssetActivationOutcome> Assets { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignAssetActivationOutcome>() : null;

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null && (this.Assets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CampaignId. The campaign's id. Canonical: because `CampaignIdentifier`
        /// accepts an id or an ARN, echoing this tells a caller who passed an ARN what the id
        /// is. The task's own id is `TaskId`.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property EndedAt. When the task reached a terminal status. Absent
        /// while IN_PROGRESS.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. When the task was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. Opaque correlation value for the task. Echoed so
        /// a caller can tell the task it started from a later one that superseded it. Never an
        /// input: the campaign is what addresses a task, because a campaign has at most one.
        /// </summary>
        [AWSProperty(Required = true, Min = 18, Max = 18)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. The task's status over every asset it names,
        /// refused ones included: one refused and one succeeded is PARTIAL_FAILURE.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetActivationTaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
