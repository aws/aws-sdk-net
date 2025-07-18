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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the GetOutpostBillingInformation operation.
    /// </summary>
    public partial class GetOutpostBillingInformationResponse : AmazonWebServiceResponse
    {
        private string _contractEndDate;
        private string _nextToken;
        private List<Subscription> _subscriptions = AWSConfigs.InitializeCollections ? new List<Subscription>() : null;

        /// <summary>
        /// Gets and sets the property ContractEndDate. 
        /// <para>
        /// The date the current contract term ends for the specified Outpost. You must start
        /// the renewal or decommission process at least 5 business days before the current term
        /// for your Amazon Web Services Outposts ends. Failing to complete these steps at least
        /// 5 business days before the current term ends might result in unanticipated charges.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ContractEndDate
        {
            get { return this._contractEndDate; }
            set { this._contractEndDate = value; }
        }

        // Check to see if ContractEndDate property is set
        internal bool IsSetContractEndDate()
        {
            return this._contractEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The subscription details for the specified Outpost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subscription> Subscriptions
        {
            get { return this._subscriptions; }
            set { this._subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this._subscriptions != null && (this._subscriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}