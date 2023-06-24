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
    /// Container for the parameters to the GetECSServiceRecommendations operation.
    /// Returns Amazon ECS service recommendations. 
    /// 
    ///  
    /// <para>
    ///  Compute Optimizer generates recommendations for Amazon ECS services on Fargate that
    /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
    /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetECSServiceRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = new List<string>();
        private List<ECSServiceRecommendationFilter> _filters = new List<ECSServiceRecommendationFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _serviceArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  Return the Amazon ECS service recommendations to the specified Amazon Web Services
        /// account IDs. 
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account or the delegated administrator of an organization,
        /// use this parameter to return the Amazon ECS service recommendations to specific member
        /// accounts.
        /// </para>
        ///  
        /// <para>
        /// You can only specify one account ID per request.
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
        /// Gets and sets the property Filters. 
        /// <para>
        ///  An array of objects to specify a filter that returns a more specific list of Amazon
        /// ECS service recommendations. 
        /// </para>
        /// </summary>
        public List<ECSServiceRecommendationFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of Amazon ECS service recommendations to return with a single
        /// request. 
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
        ///  The token to advance to the next page of Amazon ECS service recommendations. 
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

        /// <summary>
        /// Gets and sets the property ServiceArns. 
        /// <para>
        ///  The ARN that identifies the Amazon ECS service. 
        /// </para>
        ///  
        /// <para>
        ///  The following is the format of the ARN: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:ecs:region:aws_account_id:service/cluster-name/service-name</code>
        /// 
        /// </para>
        /// </summary>
        public List<string> ServiceArns
        {
            get { return this._serviceArns; }
            set { this._serviceArns = value; }
        }

        // Check to see if ServiceArns property is set
        internal bool IsSetServiceArns()
        {
            return this._serviceArns != null && this._serviceArns.Count > 0; 
        }

    }
}