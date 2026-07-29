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
    /// Container for the parameters to the ListRecommendationsForResource operation.
    /// List all Trusted Advisor recommendations for a given AWS resource ARN.
    /// </summary>
    public partial class ListRecommendationsForResourceRequest : AmazonTrustedAdvisorRequest
    {
        private string _awsResourceArn;
        private string _checkArn;
        private RecommendationLanguage _language;
        private int? _maxResults;
        private string _nextToken;
        private RecommendationPillar _pillar;
        private ResourceStatus _status;

        /// <summary>
        /// Gets and sets the property AwsResourceArn. 
        /// <para>
        /// The ARN of the AWS resource to query recommendations for
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AwsResourceArn
        {
            get { return this._awsResourceArn; }
            set { this._awsResourceArn = value; }
        }

        // Check to see if AwsResourceArn property is set
        internal bool IsSetAwsResourceArn()
        {
            return this._awsResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property CheckArn. 
        /// <para>
        /// The AWS Trusted Advisor Check ARN that relates to the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CheckArn
        {
            get { return this._checkArn; }
            set { this._checkArn = value; }
        }

        // Check to see if CheckArn property is set
        internal bool IsSetCheckArn()
        {
            return this._checkArn != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language that you want your recommendations to appear in.
        /// </para>
        /// </summary>
        public RecommendationLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
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
        /// The pillar that the recommendation belongs to
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Recommendation Resource
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