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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListAppComponentCompliances operation.
    /// </summary>
    public partial class ListAppComponentCompliancesResponse : AmazonWebServiceResponse
    {
        private List<AppComponentCompliance> _componentCompliances = new List<AppComponentCompliance>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComponentCompliances. 
        /// <para>
        /// The compliances for an AWS Resilience Hub Application Component, returned as an object.
        /// This object contains the names of the Application Components, compliances, costs,
        /// resiliency scores, outage scores, and more.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AppComponentCompliance> ComponentCompliances
        {
            get { return this._componentCompliances; }
            set { this._componentCompliances = value; }
        }

        // Check to see if ComponentCompliances property is set
        internal bool IsSetComponentCompliances()
        {
            return this._componentCompliances != null && this._componentCompliances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
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