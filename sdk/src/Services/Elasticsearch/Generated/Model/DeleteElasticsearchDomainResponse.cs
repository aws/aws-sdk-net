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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The result of a <code>DeleteElasticsearchDomain</code> request. Contains the status
    /// of the pending deletion, or no status if the domain and all of its resources have
    /// been deleted.
    /// </summary>
    public partial class DeleteElasticsearchDomainResponse : AmazonWebServiceResponse
    {
        private ElasticsearchDomainStatus _domainStatus;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        /// The status of the Elasticsearch domain being deleted.
        /// </para>
        /// </summary>
        public ElasticsearchDomainStatus DomainStatus
        {
            get { return this._domainStatus; }
            set { this._domainStatus = value; }
        }

        // Check to see if DomainStatus property is set
        internal bool IsSetDomainStatus()
        {
            return this._domainStatus != null;
        }

    }
}