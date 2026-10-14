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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about an Amazon Web Services account's enrollment and association
    /// status with Compute Optimizer Automation.
    /// </summary>
    public partial class AccountInfo
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The ID of the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp when the account's Automation enrollment status was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationRuleMode. 
        /// <para>
        /// Specifies whether the management account can create Automation rules that implement
        /// optimization actions for this account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationRuleMode OrganizationRuleMode { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRuleMode property is set.
        /// </summary>
        internal bool IsSetOrganizationRuleMode() => this.OrganizationRuleMode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The enrollment status of the account: Active, Inactive, Pending, or Failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrollmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current Automation enrollment status. 
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
