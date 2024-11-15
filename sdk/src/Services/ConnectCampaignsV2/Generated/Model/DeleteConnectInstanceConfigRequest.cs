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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConnectInstanceConfig operation.
    /// Deletes a connect instance config from the specified AWS account.
    /// </summary>
    public partial class DeleteConnectInstanceConfigRequest : AmazonConnectCampaignsV2Request
    {
        private CampaignDeletionPolicy _campaignDeletionPolicy;
        private string _connectInstanceId;

        /// <summary>
        /// Gets and sets the property CampaignDeletionPolicy.
        /// </summary>
        public CampaignDeletionPolicy CampaignDeletionPolicy
        {
            get { return this._campaignDeletionPolicy; }
            set { this._campaignDeletionPolicy = value; }
        }

        // Check to see if CampaignDeletionPolicy property is set
        internal bool IsSetCampaignDeletionPolicy()
        {
            return this._campaignDeletionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectInstanceId.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ConnectInstanceId
        {
            get { return this._connectInstanceId; }
            set { this._connectInstanceId = value; }
        }

        // Check to see if ConnectInstanceId property is set
        internal bool IsSetConnectInstanceId()
        {
            return this._connectInstanceId != null;
        }

    }
}