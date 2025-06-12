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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the ListRegisteredSubscriptionProviders operation.
    /// List Bring Your Own License (BYOL) subscription registration resources for your account.
    /// </summary>
    public partial class ListRegisteredSubscriptionProvidersRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _subscriptionProviderSources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum items to return in a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the nextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SubscriptionProviderSources. 
        /// <para>
        /// To filter your results, specify which subscription providers to return in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubscriptionProviderSources
        {
            get { return this._subscriptionProviderSources; }
            set { this._subscriptionProviderSources = value; }
        }

        // Check to see if SubscriptionProviderSources property is set
        internal bool IsSetSubscriptionProviderSources()
        {
            return this._subscriptionProviderSources != null && (this._subscriptionProviderSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}