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
    /// This is the response object from the GetAutoScalingGroupRecommendations operation.
    /// </summary>
    public partial class GetAutoScalingGroupRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<AutoScalingGroupRecommendation> _autoScalingGroupRecommendations = new List<AutoScalingGroupRecommendation>();
        private List<GetRecommendationError> _errors = new List<GetRecommendationError>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupRecommendations. 
        /// <para>
        /// An array of objects that describe Auto Scaling group recommendations.
        /// </para>
        /// </summary>
        public List<AutoScalingGroupRecommendation> AutoScalingGroupRecommendations
        {
            get { return this._autoScalingGroupRecommendations; }
            set { this._autoScalingGroupRecommendations = value; }
        }

        // Check to see if AutoScalingGroupRecommendations property is set
        internal bool IsSetAutoScalingGroupRecommendations()
        {
            return this._autoScalingGroupRecommendations != null && this._autoScalingGroupRecommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of objects that describe errors of the request.
        /// </para>
        ///  
        /// <para>
        /// For example, an error is returned if you request recommendations for an unsupported
        /// Auto Scaling group.
        /// </para>
        /// </summary>
        public List<GetRecommendationError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of Auto Scaling group recommendations.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of Auto Scaling group recommendations
        /// to return.
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