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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the RequestServiceQuotaIncrease operation.
    /// </summary>
    public partial class RequestServiceQuotaIncreaseResponse : AmazonWebServiceResponse
    {
        private RequestedServiceQuotaChange _requestedQuota;

        /// <summary>
        /// Gets and sets the property RequestedQuota. 
        /// <para>
        /// Information about the quota increase request.
        /// </para>
        /// </summary>
        public RequestedServiceQuotaChange RequestedQuota
        {
            get { return this._requestedQuota; }
            set { this._requestedQuota = value; }
        }

        // Check to see if RequestedQuota property is set
        internal bool IsSetRequestedQuota()
        {
            return this._requestedQuota != null;
        }

    }
}