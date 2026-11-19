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
    /// Provides visibility into the role provisioning stage of a StackSet operation, including
    /// per-account progress counts and a completion percentage. For operations that do not
    /// provision IAM roles in target accounts, the <c>Status</c> is <c>NOT_APPLICABLE</c>
    /// and the progress counts are omitted.
    /// </summary>
    public partial class RoleProvisioning
    {
        /// <summary>
        /// Gets and sets the property CompletedAccountsCount. 
        /// <para>
        /// The number of accounts that have finished role provisioning, including both succeeded
        /// and failed accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CompletedAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAccountsCount property is set.
        /// </summary>
        internal bool IsSetCompletedAccountsCount() => this.CompletedAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedAccountsCount. 
        /// <para>
        /// The number of accounts for which role provisioning failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailedAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedAccountsCount property is set.
        /// </summary>
        internal bool IsSetFailedAccountsCount() => this.FailedAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property PendingAccountsCount. 
        /// <para>
        /// The number of accounts that are still awaiting role provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PendingAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingAccountsCount property is set.
        /// </summary>
        internal bool IsSetPendingAccountsCount() => this.PendingAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property PercentageCompleted. 
        /// <para>
        /// The percentage of accounts that have completed role provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? PercentageCompleted { get; set; }

        /// <summary>
        /// Checks to see if the PercentageCompleted property is set.
        /// </summary>
        internal bool IsSetPercentageCompleted() => this.PercentageCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the role provisioning stage can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c>: The operation does not provision roles. This includes self-managed
        /// operations and service-managed operations whose configuration does not require role
        /// provisioning.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c>: Role provisioning has not started. The operation has not begun
        /// resolving target accounts, or it failed or stopped before the total number of target
        /// accounts was resolved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: Role provisioning is actively processing target accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: Role provisioning finished and succeeded for all target accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL_SUCCESS</c>: Role provisioning finished, but succeeded for only a subset
        /// of target accounts; one or more accounts failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: Role provisioning finished and failed for all target accounts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StageStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SucceededAccountsCount. 
        /// <para>
        /// The number of accounts for which role provisioning succeeded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SucceededAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededAccountsCount property is set.
        /// </summary>
        internal bool IsSetSucceededAccountsCount() => this.SucceededAccountsCount.HasValue;
    }
}
