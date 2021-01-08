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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the ListProtocolsLists operation.
    /// </summary>
    public partial class ListProtocolsListsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProtocolsListDataSummary> _protocolsLists = new List<ProtocolsListDataSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <code>MaxResults</code> in your list request, and you have
        /// more objects than the maximum, AWS Firewall Manager returns this token in the response.
        /// You can use this token in subsequent requests to retrieve the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property ProtocolsLists. 
        /// <para>
        /// An array of <code>ProtocolsListDataSummary</code> objects.
        /// </para>
        /// </summary>
        public List<ProtocolsListDataSummary> ProtocolsLists
        {
            get { return this._protocolsLists; }
            set { this._protocolsLists = value; }
        }

        // Check to see if ProtocolsLists property is set
        internal bool IsSetProtocolsLists()
        {
            return this._protocolsLists != null && this._protocolsLists.Count > 0; 
        }

    }
}