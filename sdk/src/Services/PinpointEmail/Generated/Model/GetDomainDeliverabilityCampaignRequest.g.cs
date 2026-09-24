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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetDomainDeliverabilityCampaign operation. Retrieve
    /// all the deliverability data for a specific campaign. This data is available for a
    /// campaign only if the campaign sent email by using a domain that the Deliverability
    /// dashboard is enabled for (<c>PutDeliverabilityDashboardOption</c> operation).
    /// </summary>
    public partial class GetDomainDeliverabilityCampaignRequest : AmazonPinpointEmailRequest
    {
        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The unique identifier for the campaign. Amazon Pinpoint automatically generates and
        /// assigns this identifier to a campaign. This value is not the same as the campaign
        /// identifier that Amazon Pinpoint assigns to campaigns that you create and manage by
        /// using the Amazon Pinpoint API or the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;
    }
}
