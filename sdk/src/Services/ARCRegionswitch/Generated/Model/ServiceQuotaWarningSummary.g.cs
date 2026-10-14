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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// A service quota warning for a plan. Region switch creates a warning when the applied
    /// quota value in one Region of a plan is lower than the value for the matching resource
    /// in another Region or account in the plan, or when it can't complete a service quota
    /// check.
    /// </summary>
    public partial class ServiceQuotaWarningSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the plan that the warning applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The ID of the support case associated with the quota increase request, if Region switch
        /// submitted one for this quota.
        /// </para>
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property LastCheckedAt. 
        /// <para>
        /// The time (UTC) when Region switch last checked this quota.
        /// </para>
        /// </summary>
        public DateTime? LastCheckedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastCheckedAt property is set.
        /// </summary>
        internal bool IsSetLastCheckedAt() => this.LastCheckedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan that the warning applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The quota code of the quota that the warning applies to, as defined in Service Quotas.
        /// </para>
        /// </summary>
        public string QuotaCode { get; set; }

        /// <summary>
        /// Checks to see if the QuotaCode property is set.
        /// </summary>
        internal bool IsSetQuotaCode() => this.QuotaCode != null;

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// The name of the quota that the warning applies to, as defined in Service Quotas.
        /// </para>
        /// </summary>
        public string QuotaName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaName property is set.
        /// </summary>
        internal bool IsSetQuotaName() => this.QuotaName != null;

        /// <summary>
        /// Gets and sets the property QuotaRegion. 
        /// <para>
        /// The Amazon Web Services Region that the quota applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuotaRegion { get; set; }

        /// <summary>
        /// Checks to see if the QuotaRegion property is set.
        /// </summary>
        internal bool IsSetQuotaRegion() => this.QuotaRegion != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the quota increase request that Region switch submitted, if it submitted
        /// one for this quota.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code of the service that the quota belongs to, as defined in Service Quotas.
        /// For example, <c>ec2</c>.
        /// </para>
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service quota warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceQuotaWarningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WarningCreatedAt. 
        /// <para>
        /// The time (UTC) when Region switch created this warning.
        /// </para>
        /// </summary>
        public DateTime? WarningCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the WarningCreatedAt property is set.
        /// </summary>
        internal bool IsSetWarningCreatedAt() => this.WarningCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A message that describes the service quota warning.
        /// </para>
        /// </summary>
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;
    }
}
