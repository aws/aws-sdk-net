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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the ListRecommenders operation.
    /// </summary>
    public partial class ListRecommendersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecommenderSummary> _recommenders = AWSConfigs.InitializeCollections ? new List<RecommenderSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token for getting the next set of recommenders (if they exist).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1500)]
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
        /// Gets and sets the property Recommenders. 
        /// <para>
        /// A list of the recommenders.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<RecommenderSummary> Recommenders
        {
            get { return this._recommenders; }
            set { this._recommenders = value; }
        }

        // Check to see if Recommenders property is set
        internal bool IsSetRecommenders()
        {
            return this._recommenders != null && (this._recommenders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}