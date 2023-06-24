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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecommendationSummaries operation.
    /// Returns the optimization findings for an account.
    /// 
    ///  
    /// <para>
    /// It returns the number of:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon EC2 instances in an account that are <code>Underprovisioned</code>, <code>Overprovisioned</code>,
    /// or <code>Optimized</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Auto Scaling groups in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EBS volumes in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lambda functions in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ECS services in an account that are <code>Underprovisioned</code>, <code>Overprovisioned</code>,
    /// or <code>Optimized</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetRecommendationSummariesRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The ID of the Amazon Web Services account for which to return recommendation summaries.
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account of an organization, use this parameter to
        /// specify the member account for which you want to return recommendation summaries.
        /// </para>
        ///  
        /// <para>
        /// Only one account ID can be specified per request.
        /// </para>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendation summaries to return with a single request.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another request with the returned <code>nextToken</code>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to advance to the next page of recommendation summaries.
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