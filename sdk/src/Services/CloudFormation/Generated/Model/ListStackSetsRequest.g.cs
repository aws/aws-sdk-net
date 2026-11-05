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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStackSets operation. Returns summary information
    /// about StackSets that are associated with the user. <note> <para> This API provides
    /// <i>strongly consistent</i> reads meaning it will always return the most up-to-date
    /// data. </para> </note> <ul> <li> <para> [Self-managed permissions] If you set the <c>CallAs</c>
    /// parameter to <c>SELF</c> while signed in to your Amazon Web Services account, <c>ListStackSets</c>
    /// returns all self-managed StackSets in your Amazon Web Services account. </para> </li>
    /// <li> <para> [Service-managed permissions] If you set the <c>CallAs</c> parameter to
    /// <c>SELF</c> while signed in to the organization's management account, <c>ListStackSets</c>
    /// returns all StackSets in the management account. </para> </li> <li> <para> [Service-managed
    /// permissions] If you set the <c>CallAs</c> parameter to <c>DELEGATED_ADMIN</c> while
    /// signed in to your member account, <c>ListStackSets</c> returns all StackSets with
    /// service-managed permissions in the management account. </para> </li> </ul>
    /// </summary>
    public partial class ListStackSetsRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the management account or as a delegated administrator in a member account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs { get; set; }

        /// <summary>
        /// Checks to see if the CallAs property is set.
        /// </summary>
        internal bool IsSetCallAs() => this.CallAs != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the StackSets that you want to get summary information about.
        /// </para>
        /// </summary>
        public StackSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
