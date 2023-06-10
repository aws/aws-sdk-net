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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// This is the response object from the ListSolNetworkOperations operation.
    /// </summary>
    public partial class ListSolNetworkOperationsResponse : AmazonWebServiceResponse
    {
        private List<ListSolNetworkOperationsInfo> _networkOperations = new List<ListSolNetworkOperationsInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property NetworkOperations. 
        /// <para>
        /// Lists network operation occurrences. Lifecycle management operations are deploy, update,
        /// or delete operations.
        /// </para>
        /// </summary>
        public List<ListSolNetworkOperationsInfo> NetworkOperations
        {
            get { return this._networkOperations; }
            set { this._networkOperations = value; }
        }

        // Check to see if NetworkOperations property is set
        internal bool IsSetNetworkOperations()
        {
            return this._networkOperations != null && this._networkOperations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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