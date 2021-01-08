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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the GetInsightEvents operation.
    /// </summary>
    public partial class GetInsightEventsResponse : AmazonWebServiceResponse
    {
        private List<InsightEvent> _insightEvents = new List<InsightEvent>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InsightEvents. 
        /// <para>
        /// A detailed description of the event. This includes the time of the event, client and
        /// root cause impact statistics, and the top anomalous service at the time of the event.
        /// </para>
        /// </summary>
        public List<InsightEvent> InsightEvents
        {
            get { return this._insightEvents; }
            set { this._insightEvents = value; }
        }

        // Check to see if InsightEvents property is set
        internal bool IsSetInsightEvents()
        {
            return this._insightEvents != null && this._insightEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this token to retrieve the next page of insight events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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