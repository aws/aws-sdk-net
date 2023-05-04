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
    /// The result of a <code>DescribeDomainNodes</code> request. Contains information about
    /// the nodes on the requested domain.
    /// </summary>
    public partial class DescribeDomainNodesResponse : AmazonWebServiceResponse
    {
        private List<DomainNodesStatus> _domainNodesStatusList = new List<DomainNodesStatus>();

        /// <summary>
        /// Gets and sets the property DomainNodesStatusList. 
        /// <para>
        /// Contains nodes information list <code>DomainNodesStatusList</code> with details about
        /// the all nodes on the requested domain.
        /// </para>
        /// </summary>
        public List<DomainNodesStatus> DomainNodesStatusList
        {
            get { return this._domainNodesStatusList; }
            set { this._domainNodesStatusList = value; }
        }

        // Check to see if DomainNodesStatusList property is set
        internal bool IsSetDomainNodesStatusList()
        {
            return this._domainNodesStatusList != null && this._domainNodesStatusList.Count > 0; 
        }

    }
}