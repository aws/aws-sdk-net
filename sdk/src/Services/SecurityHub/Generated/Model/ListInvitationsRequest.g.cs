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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListInvitations operation. <note> <para> We recommend
    /// using Organizations instead of Security Hub CSPM invitations to manage your member
    /// accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
    /// Security Hub CSPM administrator and member accounts with Organizations</a> in the
    /// <i>Security Hub CSPM User Guide</i>. </para> </note> <para> Lists all Security Hub
    /// CSPM membership invitations that were sent to the calling account. </para> <para>
    /// Only accounts that are managed by invitation can use this operation. Accounts that
    /// are managed using the integration with Organizations don't receive invitations. </para>
    /// </summary>
    public partial class ListInvitationsRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in the response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that is required for pagination. On your first call to the <c>ListInvitations</c>
        /// operation, set the value of this parameter to <c>NULL</c>.
        /// </para>
        ///  
        /// <para>
        /// For subsequent calls to the operation, to continue listing data, set the value of
        /// this parameter to the value returned from the previous response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
