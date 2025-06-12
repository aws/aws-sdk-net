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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the ListAddonSubscriptions operation.
    /// </summary>
    public partial class ListAddonSubscriptionsResponse : AmazonWebServiceResponse
    {
        private List<AddonSubscription> _addonSubscriptions = AWSConfigs.InitializeCollections ? new List<AddonSubscription>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AddonSubscriptions. 
        /// <para>
        /// The list of ingress endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonSubscription> AddonSubscriptions
        {
            get { return this._addonSubscriptions; }
            set { this._addonSubscriptions = value; }
        }

        // Check to see if AddonSubscriptions property is set
        internal bool IsSetAddonSubscriptions()
        {
            return this._addonSubscriptions != null && (this._addonSubscriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If NextToken is returned, there are more results available. The value of NextToken
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page.
        /// </para>
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

    }
}