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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the GetCostEstimation operation.
    /// </summary>
    public partial class GetCostEstimationResponse : AmazonWebServiceResponse
    {
        private List<ServiceResourceCost> _costs = new List<ServiceResourceCost>();
        private string _nextToken;
        private CostEstimationResourceCollectionFilter _resourceCollection;
        private CostEstimationStatus _status;
        private CostEstimationTimeRange _timeRange;
        private double? _totalCost;

        /// <summary>
        /// Gets and sets the property Costs. 
        /// <para>
        /// An array of <code>ResourceCost</code> objects that each contains details about the
        /// monthly cost estimate to analyze one of your Amazon Web Services resources.
        /// </para>
        /// </summary>
        public List<ServiceResourceCost> Costs
        {
            get { return this._costs; }
            set { this._costs = value; }
        }

        // Check to see if Costs property is set
        internal bool IsSetCosts()
        {
            return this._costs != null && this._costs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property ResourceCollection. 
        /// <para>
        /// The collection of the Amazon Web Services resources used to create your monthly DevOps
        /// Guru cost estimate.
        /// </para>
        /// </summary>
        public CostEstimationResourceCollectionFilter ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of creating this cost estimate. If it's still in progress, the status <code>ONGOING</code>
        /// is returned. If it is finished, the status <code>COMPLETED</code> is returned.
        /// </para>
        /// </summary>
        public CostEstimationStatus Status
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
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The start and end time of the cost estimation.
        /// </para>
        /// </summary>
        public CostEstimationTimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCost. 
        /// <para>
        /// The estimated monthly cost to analyze the Amazon Web Services resources. This value
        /// is the sum of the estimated costs to analyze each resource in the <code>Costs</code>
        /// object in this response.
        /// </para>
        /// </summary>
        public double TotalCost
        {
            get { return this._totalCost.GetValueOrDefault(); }
            set { this._totalCost = value; }
        }

        // Check to see if TotalCost property is set
        internal bool IsSetTotalCost()
        {
            return this._totalCost.HasValue; 
        }

    }
}