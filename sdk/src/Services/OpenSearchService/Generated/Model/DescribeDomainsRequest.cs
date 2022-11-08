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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDomains operation.
    /// Returns domain configuration information about the specified Amazon OpenSearch Service
    /// domains.
    /// </summary>
    public partial class DescribeDomainsRequest : AmazonOpenSearchServiceRequest
    {
        private List<string> _domainNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DomainNames. 
        /// <para>
        /// Array of OpenSearch Service domain names that you want information about. If you don't
        /// specify any domains, OpenSearch Service returns information about all domains owned
        /// by the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}