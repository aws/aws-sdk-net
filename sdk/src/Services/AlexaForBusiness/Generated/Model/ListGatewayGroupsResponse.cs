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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the ListGatewayGroups operation.
    /// </summary>
    public partial class ListGatewayGroupsResponse : AmazonWebServiceResponse
    {
        private List<GatewayGroupSummary> _gatewayGroups = new List<GatewayGroupSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GatewayGroups. 
        /// <para>
        /// The gateway groups in the list.
        /// </para>
        /// </summary>
        public List<GatewayGroupSummary> GatewayGroups
        {
            get { return this._gatewayGroups; }
            set { this._gatewayGroups = value; }
        }

        // Check to see if GatewayGroups property is set
        internal bool IsSetGatewayGroups()
        {
            return this._gatewayGroups != null && this._gatewayGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to paginate though multiple pages of gateway group summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1100)]
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