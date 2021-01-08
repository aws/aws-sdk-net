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
    /// This is the response object from the GetEC2InstanceRecommendations operation.
    /// </summary>
    public partial class GetEC2InstanceRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<GetRecommendationError> _errors = new List<GetRecommendationError>();
        private List<InstanceRecommendation> _instanceRecommendations = new List<InstanceRecommendation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of objects that describe errors of the request.
        /// </para>
        ///  
        /// <para>
        /// For example, an error is returned if you request recommendations for an instance of
        /// an unsupported instance family.
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
        /// Gets and sets the property InstanceRecommendations. 
        /// <para>
        /// An array of objects that describe instance recommendations.
        /// </para>
        /// </summary>
        public List<InstanceRecommendation> InstanceRecommendations
        {
            get { return this._instanceRecommendations; }
            set { this._instanceRecommendations = value; }
        }

        // Check to see if InstanceRecommendations property is set
        internal bool IsSetInstanceRecommendations()
        {
            return this._instanceRecommendations != null && this._instanceRecommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of instance recommendations.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of instance recommendations to return.
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