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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecommendationResources operation.
    /// List Resources of a Recommendation
    /// </summary>
    public partial class ListRecommendationResourcesRequest : AmazonTrustedAdvisorRequest
    {
        private ExclusionStatus _exclusionStatus;
        private int? _maxResults;
        private string _nextToken;
        private string _recommendationIdentifier;
        private string _regionCode;
        private ResourceStatus _status;

        /// <summary>
        /// Gets and sets the property ExclusionStatus. 
        /// <para>
        /// The exclusion status of the resource
        /// </para>
        /// </summary>
        public ExclusionStatus ExclusionStatus
        {
            get { return this._exclusionStatus; }
            set { this._exclusionStatus = value; }
        }

        // Check to see if ExclusionStatus property is set
        internal bool IsSetExclusionStatus()
        {
            return this._exclusionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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
        /// Gets and sets the property RecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=200)]
        public string RecommendationIdentifier
        {
            get { return this._recommendationIdentifier; }
            set { this._recommendationIdentifier = value; }
        }

        // Check to see if RecommendationIdentifier property is set
        internal bool IsSetRecommendationIdentifier()
        {
            return this._recommendationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RegionCode. 
        /// <para>
        /// The AWS Region code of the resource
        /// </para>
        /// </summary>
        public string RegionCode
        {
            get { return this._regionCode; }
            set { this._regionCode = value; }
        }

        // Check to see if RegionCode property is set
        internal bool IsSetRegionCode()
        {
            return this._regionCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}