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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Contains the list of Business Support subscription contracts that match the request
    /// filters.
    /// </summary>
    public partial class ListBusinessSupportSubscriptionHistoryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<BusinessSupportSubscriptionContract> _subscriptionContracts = AWSConfigs.InitializeCollections ? new List<BusinessSupportSubscriptionContract>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionContracts. 
        /// <para>
        /// The list of Business Support subscription contracts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<BusinessSupportSubscriptionContract> SubscriptionContracts
        {
            get { return this._subscriptionContracts; }
            set { this._subscriptionContracts = value; }
        }

        // Check to see if SubscriptionContracts property is set
        internal bool IsSetSubscriptionContracts()
        {
            return this._subscriptionContracts != null && (this._subscriptionContracts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}