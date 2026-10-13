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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrustedTokenIssuers operation. Lists all the
    /// trusted token issuers configured in an instance of IAM Identity Center.
    /// </summary>
    public partial class ListTrustedTokenIssuersRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Specifies the ARN of the instance of IAM Identity Center with the trusted token issuer
        /// configurations that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the total number of results that you want included in each response. If
        /// additional items exist beyond the number you specify, the <c>NextToken</c> response
        /// element is returned with a value (not null). Include the specified value as the <c>NextToken</c>
        /// request parameter in the next call to the operation to get the next set of results.
        /// Note that the service might return fewer results than the maximum even when there
        /// are more results available. You should check <c>NextToken</c> after every operation
        /// to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>NextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>NextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
