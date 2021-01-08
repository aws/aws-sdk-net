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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDomainControllers operation.
    /// </summary>
    public partial class DescribeDomainControllersResponse : AmazonWebServiceResponse
    {
        private List<DomainController> _domainControllers = new List<DomainController>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainControllers. 
        /// <para>
        /// List of the <a>DomainController</a> objects that were retrieved.
        /// </para>
        /// </summary>
        public List<DomainController> DomainControllers
        {
            get { return this._domainControllers; }
            set { this._domainControllers = value; }
        }

        // Check to see if DomainControllers property is set
        internal bool IsSetDomainControllers()
        {
            return this._domainControllers != null && this._domainControllers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, more results are available. Pass this value for the <code>NextToken</code>
        /// parameter in a subsequent call to <a>DescribeDomainControllers</a> retrieve the next
        /// set of items.
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