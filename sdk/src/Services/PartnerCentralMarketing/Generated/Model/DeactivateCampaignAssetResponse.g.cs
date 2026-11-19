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
    /// This is the response object from the DeactivateCampaignAsset operation.
    /// </summary>
    public partial class DeactivateCampaignAssetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Id. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastActivationStatus. How the most recent *activation*
        /// attempt ended, which a stop does not change. Read with state, it is what separates
        /// a stopped asset (INACTIVE + SUCCEEDED) from one never activated (INACTIVE, this member
        /// absent). Omitted until a first activation has been attempted.
        /// </summary>
        public AttemptStatus LastActivationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastActivationStatus property is set.
        /// </summary>
        internal bool IsSetLastActivationStatus() => this.LastActivationStatus != null;

        /// <summary>
        /// Gets and sets the property State. The asset's lifecycle position — INACTIVE once the
        /// stop is confirmed.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. Why the asset sits where it does. Present
        /// when LastActivationStatus is FAILED, or on a deliberate INACTIVE.
        /// </summary>
        public CampaignAssetStateReason StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
