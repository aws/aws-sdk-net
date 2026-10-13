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

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Information about a quota increase request.
    /// </summary>
    public partial class RequestedServiceQuotaChange
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The case ID.
        /// </para>
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time when the quota increase request was received and the case ID was
        /// created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredValue. 
        /// <para>
        /// The new, increased value for the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000000)]
        public double? DesiredValue { get; set; }

        /// <summary>
        /// Checks to see if the DesiredValue property is set.
        /// </summary>
        internal bool IsSetDesiredValue() => this.DesiredValue.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalQuota. 
        /// <para>
        /// Indicates whether the quota is global.
        /// </para>
        /// </summary>
        public bool? GlobalQuota { get; set; }

        /// <summary>
        /// Checks to see if the GlobalQuota property is set.
        /// </summary>
        internal bool IsSetGlobalQuota() => this.GlobalQuota.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time of the most recent change.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property QuotaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota.
        /// </para>
        /// </summary>
        public string QuotaArn { get; set; }

        /// <summary>
        /// Checks to see if the QuotaArn property is set.
        /// </summary>
        internal bool IsSetQuotaArn() => this.QuotaArn != null;

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the quota identifier. To find the quota code for a specific quota, use the
        /// <a>ListServiceQuotas</a> operation, and look for the <c>QuotaCode</c> response in
        /// the output for the quota you want.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuotaCode { get; set; }

        /// <summary>
        /// Checks to see if the QuotaCode property is set.
        /// </summary>
        internal bool IsSetQuotaCode() => this.QuotaCode != null;

        /// <summary>
        /// Gets and sets the property QuotaContext. 
        /// <para>
        /// The context for this service quota.
        /// </para>
        /// </summary>
        public QuotaContextInfo QuotaContext { get; set; }

        /// <summary>
        /// Checks to see if the QuotaContext property is set.
        /// </summary>
        internal bool IsSetQuotaContext() => this.QuotaContext != null;

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// Specifies the quota name.
        /// </para>
        /// </summary>
        public string QuotaName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaName property is set.
        /// </summary>
        internal bool IsSetQuotaName() => this.QuotaName != null;

        /// <summary>
        /// Gets and sets the property QuotaRequestedAtLevel. 
        /// <para>
        /// Filters the response to return quota requests for the <c>ACCOUNT</c>, <c>RESOURCE</c>,
        /// or <c>ALL</c> levels. <c>ACCOUNT</c> is the default.
        /// </para>
        /// </summary>
        public AppliedLevelEnum QuotaRequestedAtLevel { get; set; }

        /// <summary>
        /// Checks to see if the QuotaRequestedAtLevel property is set.
        /// </summary>
        internal bool IsSetQuotaRequestedAtLevel() => this.QuotaRequestedAtLevel != null;

        /// <summary>
        /// Gets and sets the property RequestType. 
        /// <para>
        /// The type of quota increase request. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AutomaticManagement</c> - The request was automatically created by Service Quotas
        /// Automatic Management when quota utilization approached the limit.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If this field is not present, the request was manually created by a user.
        /// </para>
        /// </summary>
        public RequestType RequestType { get; set; }

        /// <summary>
        /// Checks to see if the RequestType property is set.
        /// </summary>
        internal bool IsSetRequestType() => this.RequestType != null;

        /// <summary>
        /// Gets and sets the property Requester. 
        /// <para>
        /// The IAM identity of the requester.
        /// </para>
        /// </summary>
        public string Requester { get; set; }

        /// <summary>
        /// Checks to see if the Requester property is set.
        /// </summary>
        internal bool IsSetRequester() => this.Requester != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service identifier. To find the service code value for an Amazon Web
        /// Services service, use the <a>ListServices</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Specifies the service name.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

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
        public RequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
