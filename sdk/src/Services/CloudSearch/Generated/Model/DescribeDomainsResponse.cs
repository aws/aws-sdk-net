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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>DescribeDomains</code> request. Contains the status of the domains
    /// specified in the request or all domains owned by the account.
    /// </summary>
    public partial class DescribeDomainsResponse : AmazonWebServiceResponse
    {
        private List<DomainStatus> _domainStatusList = new List<DomainStatus>();

        /// <summary>
        /// Gets and sets the property DomainStatusList.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DomainStatus> DomainStatusList
        {
            get { return this._domainStatusList; }
            set { this._domainStatusList = value; }
        }

        // Check to see if DomainStatusList property is set
        internal bool IsSetDomainStatusList()
        {
            return this._domainStatusList != null && this._domainStatusList.Count > 0; 
        }

    }
}