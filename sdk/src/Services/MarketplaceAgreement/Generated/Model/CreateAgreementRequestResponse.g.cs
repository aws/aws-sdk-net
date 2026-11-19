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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// This is the response object from the CreateAgreementRequest operation.
    /// </summary>
    public partial class CreateAgreementRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgreementRequestId. 
        /// <para>
        /// The unique identifier of the agreement request created. Use this identifier with <c>AcceptAgreementRequest</c>
        /// to accept the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementRequestId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementRequestId property is set.
        /// </summary>
        internal bool IsSetAgreementRequestId() => this.AgreementRequestId != null;

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// The type of agreement (for example, <c>PurchaseAgreement</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Checks to see if the AgreementType property is set.
        /// </summary>
        internal bool IsSetAgreementType() => this.AgreementType != null;

        /// <summary>
        /// Gets and sets the property ApprovalRequirement. 
        /// <para>
        /// Indicates whether the agreement request requires approval before it can be accepted.
        /// Values are <c>REQUIRED</c> and <c>NOT_REQUIRED</c>.
        /// </para>
        /// </summary>
        public ApprovalRequirement ApprovalRequirement { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRequirement property is set.
        /// </summary>
        internal bool IsSetApprovalRequirement() => this.ApprovalRequirement != null;

        /// <summary>
        /// Gets and sets the property ChargeSummary. 
        /// <para>
        /// Provides details of the charges associated with the agreement request. This is only
        /// applicable when a request is created for <c>PurchaseAgreement</c>.
        /// </para>
        /// </summary>
        public ChargeSummary ChargeSummary { get; set; }

        /// <summary>
        /// Checks to see if the ChargeSummary property is set.
        /// </summary>
        internal bool IsSetChargeSummary() => this.ChargeSummary != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the agreement request was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agreement request. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRAFT</c> – The agreement request has been created but not yet submitted for approval.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_APPROVAL</c> – The agreement request is waiting for one or more approvers
        /// to decide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPROVED</c> – All required approvals have been granted, but the agreement request
        /// wasn't accepted automatically. Call <c>AcceptAgreementRequest</c> to accept it. If
        /// the call fails, its error explains why.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTED</c> – The agreement request has been accepted and the resulting agreement
        /// has been created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> – At least one approver rejected the agreement request. It won't
        /// proceed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> – The agreement request was cancelled before completion, by the
        /// acceptor or because the acceptor's account left its AWS organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AgreementRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
