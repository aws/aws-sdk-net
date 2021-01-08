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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// This is the response object from the ListDomains operation.
    /// </summary>
    public partial class ListDomainsResponse : AmazonWebServiceResponse
    {
        private List<string> _domainNames = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainNames. A list of domain names that match the expression.
        /// </summary>
        public List<string> DomainNames
        {
            get { return this._domainNames; }
            set { this._domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this._domainNames != null && this._domainNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. An opaque token indicating that there are more
        /// domains than the specified <code>MaxNumberOfDomains</code> still available.
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