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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// This is the response object from the DisassociateDelegationSignerFromDomain operation.
    /// </summary>
    public partial class DisassociateDelegationSignerFromDomainResponse : AmazonWebServiceResponse
    {
        private string _operationId;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// Identifier for tracking the progress of the request. To query the operation status,
        /// use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

    }
}