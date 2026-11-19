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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the GetMergeCasesStatus operation. Returns the merge
    /// status of a case. Use this operation to track a merge that you started with <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_StartMergeCases.html">StartMergeCases</a>,
    /// or to check whether a case is part of a merge before you modify it. <para> The operation
    /// returns the following, depending on the case: </para> <ul> <li> <para> For the primary
    /// case or the secondary case of a merge that is running, it returns <c>IN_PROGRESS</c>.
    /// </para> </li> <li> <para> For a case that was merged into another case as the secondary
    /// case, it returns <c>COMPLETED</c>. </para> </li> <li> <para> For any other case, it
    /// returns a <c>ResourceNotFoundException</c>. This includes the primary case after its
    /// merge finishes. </para> </li> </ul> <para> <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Connect
    /// Customer endpoints and quotas</a>. </para>
    /// </summary>
    public partial class GetMergeCasesStatusRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The unique identifier of the case. This can be the primary case or the secondary case
        /// of a merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;
    }
}
