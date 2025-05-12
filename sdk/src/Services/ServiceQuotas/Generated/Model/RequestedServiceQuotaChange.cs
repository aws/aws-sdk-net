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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Information about a quota increase request.
    /// </summary>
    public partial class RequestedServiceQuotaChange
    {
        private string _caseId;
        private DateTime? _created;
        private double? _desiredValue;
        private bool? _globalQuota;
        private string _id;
        private DateTime? _lastUpdated;
        private string _quotaArn;
        private string _quotaCode;
        private QuotaContextInfo _quotaContext;
        private string _quotaName;
        private AppliedLevelEnum _quotaRequestedAtLevel;
        private string _requester;
        private string _serviceCode;
        private string _serviceName;
        private RequestStatus _status;
        private string _unit;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The case ID.
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
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time when the quota increase request was received and the case ID was
        /// created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredValue. 
        /// <para>
        /// The new, increased value for the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000000)]
        public double? DesiredValue
        {
            get { return this._desiredValue; }
            set { this._desiredValue = value; }
        }

        // Check to see if DesiredValue property is set
        internal bool IsSetDesiredValue()
        {
            return this._desiredValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalQuota. 
        /// <para>
        /// Indicates whether the quota is global.
        /// </para>
        /// </summary>
        public bool? GlobalQuota
        {
            get { return this._globalQuota; }
            set { this._globalQuota = value; }
        }

        // Check to see if GlobalQuota property is set
        internal bool IsSetGlobalQuota()
        {
            return this._globalQuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time of the most recent change.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuotaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota.
        /// </para>
        /// </summary>
        public string QuotaArn
        {
            get { return this._quotaArn; }
            set { this._quotaArn = value; }
        }

        // Check to see if QuotaArn property is set
        internal bool IsSetQuotaArn()
        {
            return this._quotaArn != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the quota identifier. To find the quota code for a specific quota, use the
        /// <a>ListServiceQuotas</a> operation, and look for the <c>QuotaCode</c> response in
        /// the output for the quota you want.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property QuotaContext. 
        /// <para>
        /// The context for this service quota.
        /// </para>
        /// </summary>
        public QuotaContextInfo QuotaContext
        {
            get { return this._quotaContext; }
            set { this._quotaContext = value; }
        }

        // Check to see if QuotaContext property is set
        internal bool IsSetQuotaContext()
        {
            return this._quotaContext != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// Specifies the quota name.
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
        /// Gets and sets the property QuotaRequestedAtLevel. 
        /// <para>
        /// Filters the response to return quota requests for the <c>ACCOUNT</c>, <c>RESOURCE</c>,
        /// or <c>ALL</c> levels. <c>ACCOUNT</c> is the default.
        /// </para>
        /// </summary>
        public AppliedLevelEnum QuotaRequestedAtLevel
        {
            get { return this._quotaRequestedAtLevel; }
            set { this._quotaRequestedAtLevel = value; }
        }

        // Check to see if QuotaRequestedAtLevel property is set
        internal bool IsSetQuotaRequestedAtLevel()
        {
            return this._quotaRequestedAtLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Requester. 
        /// <para>
        /// The IAM identity of the requester.
        /// </para>
        /// </summary>
        public string Requester
        {
            get { return this._requester; }
            set { this._requester = value; }
        }

        // Check to see if Requester property is set
        internal bool IsSetRequester()
        {
            return this._requester != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service identifier. To find the service code value for an Amazon Web
        /// Services service, use the <a>ListServices</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Specifies the service name.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the quota increase request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The quota increase request is under review by Amazon Web Services.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CASE_OPENED</c>: Service Quotas opened a support case to process the quota increase
        /// request. Follow-up on the support case for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPROVED</c>: The quota increase request is approved. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c>: The quota increase request can't be approved by Service Quotas. Contact
        /// Amazon Web Services Support for more details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT APPROVED</c>: The quota increase request can't be approved by Service Quotas.
        /// Contact Amazon Web Services Support for more details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CASE_CLOSED</c>: The support case associated with this quota increase request
        /// was closed. Check the support case correspondence for the outcome of your quota request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_REQUEST</c>: Service Quotas couldn't process your resource-level quota
        /// increase request because the Amazon Resource Name (ARN) specified as part of the <c>ContextId</c>
        /// is invalid.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RequestStatus Status
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}