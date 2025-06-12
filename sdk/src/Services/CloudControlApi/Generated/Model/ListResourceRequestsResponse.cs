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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
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
namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// This is the response object from the ListResourceRequests operation.
    /// </summary>
    public partial class ListResourceRequestsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProgressEvent> _resourceRequestStatusSummaries = AWSConfigs.InitializeCollections ? new List<ProgressEvent>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all of the remaining results, <c>NextToken</c> is set
        /// to a token. To retrieve the next set of results, call <c>ListResources</c> again and
        /// assign that token to the request object's <c>NextToken</c> parameter. If the request
        /// returns all results, <c>NextToken</c> is set to null.
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

        /// <summary>
        /// Gets and sets the property ResourceRequestStatusSummaries. 
        /// <para>
        /// The requests that match the specified filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProgressEvent> ResourceRequestStatusSummaries
        {
            get { return this._resourceRequestStatusSummaries; }
            set { this._resourceRequestStatusSummaries = value; }
        }

        // Check to see if ResourceRequestStatusSummaries property is set
        internal bool IsSetResourceRequestStatusSummaries()
        {
            return this._resourceRequestStatusSummaries != null && (this._resourceRequestStatusSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}