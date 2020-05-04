/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// This is the response object from the ListTunnels operation.
    /// </summary>
    public partial class ListTunnelsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TunnelSummary> _tunnelSummaries = new List<TunnelSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to used to retrieve the next set of results.
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
        /// Gets and sets the property TunnelSummaries. 
        /// <para>
        /// A short description of the tunnels in an AWS account.
        /// </para>
        /// </summary>
        public List<TunnelSummary> TunnelSummaries
        {
            get { return this._tunnelSummaries; }
            set { this._tunnelSummaries = value; }
        }

        // Check to see if TunnelSummaries property is set
        internal bool IsSetTunnelSummaries()
        {
            return this._tunnelSummaries != null && this._tunnelSummaries.Count > 0; 
        }

    }
}