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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
        private string _accountId;
        private string _caseId;
        private DateTime? _lastCheckedAt;
        private string _planArn;
        private string _quotaCode;
        private string _quotaName;
        private string _quotaRegion;
        private string _requestId;
        private string _serviceCode;
        private ServiceQuotaWarningStatus _status;
        private DateTime? _warningCreatedAt;
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the plan that the warning applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The ID of the support case associated with the quota increase request, if Region switch
        /// submitted one for this quota.
        /// </para>
        /// </summary>
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property LastCheckedAt. 
        /// <para>
        /// The time (UTC) when Region switch last checked this quota.
        /// </para>
        /// </summary>
        public DateTime? LastCheckedAt
        {
            get { return this._lastCheckedAt; }
            set { this._lastCheckedAt = value; }
        }

        // Check to see if LastCheckedAt property is set
        internal bool IsSetLastCheckedAt()
        {
            return this._lastCheckedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan that the warning applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanArn
        {
            get { return this._planArn; }
            set { this._planArn = value; }
        }

        // Check to see if PlanArn property is set
        internal bool IsSetPlanArn()
        {
            return this._planArn != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The quota code of the quota that the warning applies to, as defined in Service Quotas.
        /// </para>
        /// </summary>
        public string QuotaCode
        {
            get { return this._quotaCode; }
            set { this._quotaCode = value; }
        }

        // Check to see if QuotaCode property is set
        internal bool IsSetQuotaCode()
        {
            return this._quotaCode != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// The name of the quota that the warning applies to, as defined in Service Quotas.
        /// </para>
        /// </summary>
        public string QuotaName
        {
            get { return this._quotaName; }
            set { this._quotaName = value; }
        }

        // Check to see if QuotaName property is set
        internal bool IsSetQuotaName()
        {
            return this._quotaName != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaRegion. 
        /// <para>
        /// The Amazon Web Services Region that the quota applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuotaRegion
        {
            get { return this._quotaRegion; }
            set { this._quotaRegion = value; }
        }

        // Check to see if QuotaRegion property is set
        internal bool IsSetQuotaRegion()
        {
            return this._quotaRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the quota increase request that Region switch submitted, if it submitted
        /// one for this quota.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code of the service that the quota belongs to, as defined in Service Quotas.
        /// For example, <c>ec2</c>.
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service quota warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceQuotaWarningStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WarningCreatedAt. 
        /// <para>
        /// The time (UTC) when Region switch created this warning.
        /// </para>
        /// </summary>
        public DateTime? WarningCreatedAt
        {
            get { return this._warningCreatedAt; }
            set { this._warningCreatedAt = value; }
        }

        // Check to see if WarningCreatedAt property is set
        internal bool IsSetWarningCreatedAt()
        {
            return this._warningCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A message that describes the service quota warning.
        /// </para>
        /// </summary>
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

    }
}