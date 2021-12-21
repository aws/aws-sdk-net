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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// This is the response object from the ListEulaAcceptances operation.
    /// </summary>
    public partial class ListEulaAcceptancesResponse : AmazonWebServiceResponse
    {
        private List<EulaAcceptance> _eulaAcceptances = new List<EulaAcceptance>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EulaAcceptances. 
        /// <para>
        /// A collection of EULA acceptances.
        /// </para>
        /// </summary>
        public List<EulaAcceptance> EulaAcceptances
        {
            get { return this._eulaAcceptances; }
            set { this._eulaAcceptances = value; }
        }

        // Check to see if EulaAcceptances property is set
        internal bool IsSetEulaAcceptances()
        {
            return this._eulaAcceptances != null && this._eulaAcceptances.Count > 0; 
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