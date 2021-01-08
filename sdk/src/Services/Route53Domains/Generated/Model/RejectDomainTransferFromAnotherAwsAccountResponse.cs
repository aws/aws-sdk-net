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
    /// The RejectDomainTransferFromAnotherAwsAccount response includes the following element.
    /// </summary>
    public partial class RejectDomainTransferFromAnotherAwsAccountResponse : AmazonWebServiceResponse
    {
        private string _operationId;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The identifier that <code>TransferDomainToAnotherAwsAccount</code> returned to track
        /// the progress of the request. Because the transfer request was rejected, the value
        /// is no longer valid, and you can't use <code>GetOperationDetail</code> to query the
        /// operation status.
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