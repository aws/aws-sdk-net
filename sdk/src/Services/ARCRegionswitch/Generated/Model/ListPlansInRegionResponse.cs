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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the ListPlansInRegion operation.
    /// </summary>
    public partial class ListPlansInRegionResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<AbbreviatedPlan> _plans = AWSConfigs.InitializeCollections ? new List<AbbreviatedPlan>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Plans. 
        /// <para>
        /// The plans that were requested.
        /// </para>
        /// </summary>
        public List<AbbreviatedPlan> Plans
        {
            get { return this._plans; }
            set { this._plans = value; }
        }

        // Check to see if Plans property is set
        internal bool IsSetPlans()
        {
            return this._plans != null && (this._plans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}