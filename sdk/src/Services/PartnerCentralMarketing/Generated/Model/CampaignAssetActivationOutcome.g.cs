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
    /// How one asset named in a task is going.
    /// </summary>
    public partial class CampaignAssetActivationOutcome
    {
        /// <summary>
        /// Gets and sets the property CampaignAssetId. The asset this outcome belongs to.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string CampaignAssetId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignAssetId property is set.
        /// </summary>
        internal bool IsSetCampaignAssetId() => this.CampaignAssetId != null;

        /// <summary>
        /// Gets and sets the property Message. A description of `Reason` for display. Don't parse
        /// it. For a mailing-credit shortfall it states the credits needed and remaining.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Reason. Why the activation did not succeed. Present when
        /// status is FAILED.
        /// </summary>
        public CampaignAssetStateReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. This asset's contribution to the task's status.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetActivationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
