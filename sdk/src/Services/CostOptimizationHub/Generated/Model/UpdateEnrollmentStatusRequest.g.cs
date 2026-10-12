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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnrollmentStatus operation. Updates the
    /// enrollment (opt in and opt out) status of an account to the Cost Optimization Hub
    /// service. <para> If the account is a management account of an organization, this action
    /// can also be used to enroll member accounts of the organization. </para> <para> You
    /// must have the appropriate permissions to opt in to Cost Optimization Hub and to view
    /// its recommendations. When you opt in, Cost Optimization Hub automatically creates
    /// a service-linked role in your account to access its data. </para>
    /// </summary>
    public partial class UpdateEnrollmentStatusRequest : AmazonCostOptimizationHubRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// Indicates whether to enroll member accounts of the organization if the account is
        /// the management account or delegated administrator.
        /// </para>
        /// </summary>
        public bool? IncludeMemberAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMemberAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeMemberAccounts() => this.IncludeMemberAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Sets the account status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrollmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
