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
    /// Container for the parameters to the PutProfileOutboundRequestBatch operation.
    /// Takes in a list of profile outbound requests to be placed as part of an outbound campaign.
    /// This API is idempotent.
    /// </summary>
    public partial class PutProfileOutboundRequestBatchRequest : AmazonConnectCampaignsV2Request
    {
        private string _id;
        private List<ProfileOutboundRequest> _profileOutboundRequests = AWSConfigs.InitializeCollections ? new List<ProfileOutboundRequest>() : null;

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileOutboundRequests.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<ProfileOutboundRequest> ProfileOutboundRequests
        {
            get { return this._profileOutboundRequests; }
            set { this._profileOutboundRequests = value; }
        }

        // Check to see if ProfileOutboundRequests property is set
        internal bool IsSetProfileOutboundRequests()
        {
            return this._profileOutboundRequests != null && (this._profileOutboundRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}