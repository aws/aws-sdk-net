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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// This is the response object from the DescribeScalingPlanResources operation.
    /// </summary>
    public partial class DescribeScalingPlanResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScalingPlanResource> _scalingPlanResources = new List<ScalingPlanResource>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required to get the next set of results. This value is <code>null</code>
        /// if there are no more results to return.
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
        /// Gets and sets the property ScalingPlanResources. 
        /// <para>
        /// Information about the scalable resources.
        /// </para>
        /// </summary>
        public List<ScalingPlanResource> ScalingPlanResources
        {
            get { return this._scalingPlanResources; }
            set { this._scalingPlanResources = value; }
        }

        // Check to see if ScalingPlanResources property is set
        internal bool IsSetScalingPlanResources()
        {
            return this._scalingPlanResources != null && this._scalingPlanResources.Count > 0; 
        }

    }
}