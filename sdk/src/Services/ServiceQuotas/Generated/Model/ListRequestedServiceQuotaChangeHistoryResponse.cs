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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the ListRequestedServiceQuotaChangeHistory operation.
    /// </summary>
    public partial class ListRequestedServiceQuotaChangeHistoryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RequestedServiceQuotaChange> _requestedQuotas = new List<RequestedServiceQuotaChange>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present in the response, this value indicates there's more output available that
        /// what's included in the current response. This can occur even when the response includes
        /// no values at all, such as when you ask for a filtered view of a very long list. Use
        /// this value in the <code>NextToken</code> request parameter in a subsequent call to
        /// the operation to continue processing and get the next part of the output. You should
        /// repeat this until the <code>NextToken</code> response element comes back empty (as
        /// <code>null</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property RequestedQuotas. 
        /// <para>
        /// Returns a list of service quota requests.
        /// </para>
        /// </summary>
        public List<RequestedServiceQuotaChange> RequestedQuotas
        {
            get { return this._requestedQuotas; }
            set { this._requestedQuotas = value; }
        }

        // Check to see if RequestedQuotas property is set
        internal bool IsSetRequestedQuotas()
        {
            return this._requestedQuotas != null && this._requestedQuotas.Count > 0; 
        }

    }
}