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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetInsightSelectors operation.
    /// </summary>
    public partial class GetInsightSelectorsResponse : AmazonWebServiceResponse
    {
        private List<InsightSelector> _insightSelectors = new List<InsightSelector>();
        private string _trailARN;

        /// <summary>
        /// Gets and sets the property InsightSelectors. 
        /// <para>
        /// A JSON string that contains the insight types you want to log on a trail. In this
        /// release, <code>ApiErrorRateInsight</code> and <code>ApiCallRateInsight</code> are
        /// supported as insight types.
        /// </para>
        /// </summary>
        public List<InsightSelector> InsightSelectors
        {
            get { return this._insightSelectors; }
            set { this._insightSelectors = value; }
        }

        // Check to see if InsightSelectors property is set
        internal bool IsSetInsightSelectors()
        {
            return this._insightSelectors != null && this._insightSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a trail for which you want to get Insights selectors.
        /// </para>
        /// </summary>
        public string TrailARN
        {
            get { return this._trailARN; }
            set { this._trailARN = value; }
        }

        // Check to see if TrailARN property is set
        internal bool IsSetTrailARN()
        {
            return this._trailARN != null;
        }

    }
}