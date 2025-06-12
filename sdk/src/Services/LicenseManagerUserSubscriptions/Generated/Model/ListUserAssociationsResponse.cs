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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// This is the response object from the ListUserAssociations operation.
    /// </summary>
    public partial class ListUserAssociationsResponse : AmazonWebServiceResponse
    {
        private List<InstanceUserSummary> _instanceUserSummaries = AWSConfigs.InitializeCollections ? new List<InstanceUserSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InstanceUserSummaries. 
        /// <para>
        /// Metadata that describes the list user association operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceUserSummary> InstanceUserSummaries
        {
            get { return this._instanceUserSummaries; }
            set { this._instanceUserSummaries = value; }
        }

        // Check to see if InstanceUserSummaries property is set
        internal bool IsSetInstanceUserSummaries()
        {
            return this._instanceUserSummaries != null && (this._instanceUserSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for paginated responses. When this field isn't empty, there are
        /// additional elements that the service hasn't included in this request. Use this token
        /// with the next request to retrieve additional objects.
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

    }
}