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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Account.Model
{
    /// <summary>
    /// This is the response object from the ListRegions operation.
    /// </summary>
    public partial class ListRegionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Region> _regions = new List<Region>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there is more data to be returned, this will be populated. It should be passed
        /// into the <code>next-token</code> request parameter of <code>list-regions</code>.
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// This is a list of Regions for a given account, or if the filtered parameter was used,
        /// a list of Regions that match the filter criteria set in the <code>filter</code> parameter.
        /// </para>
        /// </summary>
        public List<Region> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

    }
}