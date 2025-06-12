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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
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
namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// PutDialRequestBatchResponse
    /// </summary>
    public partial class PutDialRequestBatchResponse : AmazonWebServiceResponse
    {
        private List<FailedRequest> _failedRequests = AWSConfigs.InitializeCollections ? new List<FailedRequest>() : null;
        private List<SuccessfulRequest> _successfulRequests = AWSConfigs.InitializeCollections ? new List<SuccessfulRequest>() : null;

        /// <summary>
        /// Gets and sets the property FailedRequests.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<FailedRequest> FailedRequests
        {
            get { return this._failedRequests; }
            set { this._failedRequests = value; }
        }

        // Check to see if FailedRequests property is set
        internal bool IsSetFailedRequests()
        {
            return this._failedRequests != null && (this._failedRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulRequests.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<SuccessfulRequest> SuccessfulRequests
        {
            get { return this._successfulRequests; }
            set { this._successfulRequests = value; }
        }

        // Check to see if SuccessfulRequests property is set
        internal bool IsSetSuccessfulRequests()
        {
            return this._successfulRequests != null && (this._successfulRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}