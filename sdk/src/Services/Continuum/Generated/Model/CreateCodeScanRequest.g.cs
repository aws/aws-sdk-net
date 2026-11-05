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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeScan operation. Creates an explicit
    /// scan request for one environment. CP creates durable work before any queue delivery
    /// occurs. Retrying a request that succeeded, with the same clientToken on the same environment,
    /// returns the original scan instead of starting another one. Token handling is not yet
    /// atomic: requests with the same token that run at the same time, or a retry after a
    /// request that failed partway through, can leave an additional scan, which may end in
    /// the FAILED state with a message that it was superseded. Deleting the environment makes
    /// its tokens unusable; a later request with one of them returns ResourceNotFoundException.
    /// Each environment can have a limited number of scans in progress at the same time.
    /// Once that limit is enforced, a request that would exceed it returns ServiceQuotaExceededException;
    /// wait for a scan to finish (ListCodeScans shows each scan's status), then retry.
    /// </summary>
    public partial class CreateCodeScanRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. An optional token identifying one scan request
        /// for this environment. SDKs generate a token when omitted. If a request reaches the
        /// service without a token, the service generates one for that request, so each request
        /// without a token starts a new scan. To retry a request after a lost response, supply
        /// the same token on the same environment; once a request with that token has succeeded,
        /// a retry returns the original scan. Concurrent requests with the same token, or a retry
        /// after a request that failed partway through, can leave an additional scan, which may
        /// end FAILED as superseded. A token is bound to its scan for as long as the service
        /// retains the scan's build record, with no shorter expiry. Deleting the environment
        /// makes the binding inaccessible: a later request with the token returns ResourceNotFoundException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. Environment to scan.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;
    }
}
