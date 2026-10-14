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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the ListMemberAccounts operation. Returns a <c>MemberAccounts</c>
    /// object that lists the member accounts in the administrator's Amazon Web Services organization.
    /// <para> Either an Firewall Manager administrator or the organization's management account
    /// can make this request. </para>
    /// </summary>
    public partial class ListMemberAccountsRequest : AmazonFMSRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the number of member account IDs that you want Firewall Manager to return
        /// for this request. If you have more IDs than the number that you specify for <c>MaxResults</c>,
        /// the response includes a <c>NextToken</c> value that you can use to get another batch
        /// of member account IDs.
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
        /// If you specify a value for <c>MaxResults</c> and you have more account IDs than the
        /// number that you specify for <c>MaxResults</c>, Firewall Manager returns a <c>NextToken</c>
        /// value in the response that allows you to list another group of IDs. For the second
        /// and subsequent <c>ListMemberAccountsRequest</c> requests, specify the value of <c>NextToken</c>
        /// from the previous response to get information about another batch of member account
        /// IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
