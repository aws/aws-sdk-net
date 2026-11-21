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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the ListPrincipalsForPolicy operation. Lists the Amazon
    /// Quick Sight principals that have a governance policy. This operation returns paginated
    /// results. A page can contain fewer results than <c>MaxResults</c>, or none, and still
    /// include a <c>NextToken</c>. Continue to call the operation until the response doesn't
    /// include a <c>NextToken</c>. We recommend that you use pagination to make sure that
    /// the operation returns quickly and successfully. <para> Results are eventually consistent
    /// and might not reflect recent changes. If the policy has no assignments, the response
    /// contains an empty <c>Principals</c> list. If the policy doesn't exist, the request
    /// fails with a <c>ResourceNotFoundException</c>. </para>
    /// </summary>
    public partial class ListPrincipalsForPolicyRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Valid range is 1–100. If
        /// you don't specify a value, the operation returns up to 100 results.
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
        /// The token returned by a previous call. Use it to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// An optional filter that limits the results to principals of the specified type. If
        /// you don't specify a value, the operation returns principals of all types. You can
        /// specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>USER</c> – An Amazon Quick Sight user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUP</c> – An Amazon Quick Sight group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> – The Amazon Quick Sight account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;
    }
}
