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
    /// Container for the parameters to the ListOrganizationRecommendations operation.
    /// List a filterable set of Recommendations within an Organization. This API only supports
    /// prioritized recommendations.
    /// </summary>
    public partial class ListOrganizationRecommendationsRequest : AmazonTrustedAdvisorRequest
    {
        private DateTime? _afterLastUpdatedAt;
        private string _awsService;
        private DateTime? _beforeLastUpdatedAt;
        private string _checkIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private RecommendationPillar _pillar;
        private RecommendationSource _source;
        private RecommendationStatus _status;
        private RecommendationType _type;

        /// <summary>
        /// Gets and sets the property AfterLastUpdatedAt. 
        /// <para>
        /// After the last update of the Recommendation
        /// </para>
        /// </summary>
        public DateTime? AfterLastUpdatedAt
        {
            get { return this._afterLastUpdatedAt; }
            set { this._afterLastUpdatedAt = value; }
        }

        // Check to see if AfterLastUpdatedAt property is set
        internal bool IsSetAfterLastUpdatedAt()
        {
            return this._afterLastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// The aws service associated with the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeLastUpdatedAt. 
        /// <para>
        /// Before the last update of the Recommendation
        /// </para>
        /// </summary>
        public DateTime? BeforeLastUpdatedAt
        {
            get { return this._beforeLastUpdatedAt; }
            set { this._beforeLastUpdatedAt = value; }
        }

        // Check to see if BeforeLastUpdatedAt property is set
        internal bool IsSetBeforeLastUpdatedAt()
        {
            return this._beforeLastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckIdentifier. 
        /// <para>
        /// The check identifier of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=64)]
        public string CheckIdentifier
        {
            get { return this._checkIdentifier; }
            set { this._checkIdentifier = value; }
        }

        // Check to see if CheckIdentifier property is set
        internal bool IsSetCheckIdentifier()
        {
            return this._checkIdentifier != null;
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
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The pillar of the Recommendation
        /// </para>
        /// </summary>
        public RecommendationPillar Pillar
        {
            get { return this._pillar; }
            set { this._pillar = value; }
        }

        // Check to see if Pillar property is set
        internal bool IsSetPillar()
        {
            return this._pillar != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the Recommendation
        /// </para>
        /// </summary>
        public RecommendationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Recommendation
        /// </para>
        /// </summary>
        public RecommendationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Recommendation
        /// </para>
        /// </summary>
        public RecommendationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}