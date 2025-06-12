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
    /// This is the response object from the ListInstances operation.
    /// </summary>
    public partial class ListInstancesResponse : AmazonWebServiceResponse
    {
        private List<InstanceSummary> _instanceSummaries = AWSConfigs.InitializeCollections ? new List<InstanceSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InstanceSummaries. 
        /// <para>
        /// An array of <c>InstanceSummary</c> resources that contain details about the instances
        /// that provide user-based subscriptions and also meet the request criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceSummary> InstanceSummaries
        {
            get { return this._instanceSummaries; }
            set { this._instanceSummaries = value; }
        }

        // Check to see if InstanceSummaries property is set
        internal bool IsSetInstanceSummaries()
        {
            return this._instanceSummaries != null && (this._instanceSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
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