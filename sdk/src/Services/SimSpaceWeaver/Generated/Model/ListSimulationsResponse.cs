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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// This is the response object from the ListSimulations operation.
    /// </summary>
    public partial class ListSimulationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SimulationMetadata> _simulations = new List<SimulationMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If SimSpace Weaver returns <code>nextToken</code>, there are more results available.
        /// The value of <code>nextToken</code> is a unique pagination token for each page. To
        /// retrieve the next page, call the operation again using the returned token. Keep all
        /// other arguments unchanged. If no results remain, <code>nextToken</code> is set to
        /// <code>null</code>. Each pagination token expires after 24 hours. If you provide a
        /// token that isn't valid, you receive an <i>HTTP 400 ValidationException</i> error.
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
        /// Gets and sets the property Simulations. 
        /// <para>
        /// The list of simulations.
        /// </para>
        /// </summary>
        public List<SimulationMetadata> Simulations
        {
            get { return this._simulations; }
            set { this._simulations = value; }
        }

        // Check to see if Simulations property is set
        internal bool IsSetSimulations()
        {
            return this._simulations != null && this._simulations.Count > 0; 
        }

    }
}