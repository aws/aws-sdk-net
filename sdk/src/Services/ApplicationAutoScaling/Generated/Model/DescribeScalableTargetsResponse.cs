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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeScalableTargets operation.
    /// </summary>
    public partial class DescribeScalableTargetsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScalableTarget> _scalableTargets = new List<ScalableTarget>();

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
        /// Gets and sets the property ScalableTargets. 
        /// <para>
        /// The scalable targets that match the request parameters.
        /// </para>
        /// </summary>
        public List<ScalableTarget> ScalableTargets
        {
            get { return this._scalableTargets; }
            set { this._scalableTargets = value; }
        }

        // Check to see if ScalableTargets property is set
        internal bool IsSetScalableTargets()
        {
            return this._scalableTargets != null && this._scalableTargets.Count > 0; 
        }

    }
}