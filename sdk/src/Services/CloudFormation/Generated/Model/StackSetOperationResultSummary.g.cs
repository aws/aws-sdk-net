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
    /// The structure that contains information about a specified operation's results for
    /// a given account in a given Region.
    /// </summary>
    public partial class StackSetOperationResultSummary
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// [Self-managed permissions] The name of the Amazon Web Services account for this operation
        /// result.
        /// </para>
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property AccountGateResult. 
        /// <para>
        /// The results of the account gate function CloudFormation invokes, if present, before
        /// proceeding with StackSet operations in an account.
        /// </para>
        /// </summary>
        public AccountGateResult AccountGateResult { get; set; }

        /// <summary>
        /// Checks to see if the AccountGateResult property is set.
        /// </summary>
        internal bool IsSetAccountGateResult() => this.AccountGateResult != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// [Service-managed permissions] The organization root ID or organizational unit (OU)
        /// IDs that you specified for <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeploymentTargets.html">DeploymentTargets</a>.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the Amazon Web Services Region for this operation result.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result status of the StackSet operation for the given account in the given Region.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CANCELLED</c>: The operation in the specified account and Region has been canceled.
        /// This is either because a user has stopped the StackSet operation, or because the failure
        /// tolerance of the StackSet operation has been exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The operation in the specified account and Region failed.
        /// </para>
        ///  
        /// <para>
        /// If the StackSet operation fails in enough accounts within a Region, the failure tolerance
        /// for the StackSet operation as a whole might be exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: The operation in the specified account and Region is currently in
        /// progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: The operation in the specified account and Region has yet to start.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The operation in the specified account and Region completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetOperationResultStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the assigned result status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
