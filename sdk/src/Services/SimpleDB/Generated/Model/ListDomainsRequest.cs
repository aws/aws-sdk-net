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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomains operation.
    /// The <c>ListDomains</c> operation lists all domains associated with the Access Key
    /// ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
    /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c>
    /// domains. Calling <c>ListDomains</c> successive times with the <c>NextToken</c> provided
    /// by the operation returns up to <c>MaxNumberOfDomains</c> more domain names with each
    /// successive operation call.
    /// </summary>
    public partial class ListDomainsRequest : AmazonSimpleDBRequest
    {
        private int? _maxNumberOfDomains;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListDomainsRequest() { }

        /// <summary>
        /// Gets and sets the property MaxNumberOfDomains. The maximum number of domain names
        /// you want returned. The range is 1 to 100. The default setting is 100.
        /// </summary>
        public int? MaxNumberOfDomains
        {
            get { return this._maxNumberOfDomains; }
            set { this._maxNumberOfDomains = value; }
        }

        // Check to see if MaxNumberOfDomains property is set
        internal bool IsSetMaxNumberOfDomains()
        {
            return this._maxNumberOfDomains.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. A string informing Amazon SimpleDB where to
        /// start the next list of domain names.
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