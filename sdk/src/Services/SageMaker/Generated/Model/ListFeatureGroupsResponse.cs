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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListFeatureGroups operation.
    /// </summary>
    public partial class ListFeatureGroupsResponse : AmazonWebServiceResponse
    {
        private List<FeatureGroupSummary> _featureGroupSummaries = new List<FeatureGroupSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FeatureGroupSummaries. 
        /// <para>
        /// A summary of feature groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FeatureGroupSummary> FeatureGroupSummaries
        {
            get { return this._featureGroupSummaries; }
            set { this._featureGroupSummaries = value; }
        }

        // Check to see if FeatureGroupSummaries property is set
        internal bool IsSetFeatureGroupSummaries()
        {
            return this._featureGroupSummaries != null && this._featureGroupSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of <code>ListFeatureGroups</code> results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=8192)]
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