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
    /// This is the response object from the CancelAgreementCancellationRequest operation.
    /// </summary>
    public partial class CancelAgreementCancellationRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgreementCancellationRequestId. 
        /// <para>
        /// The unique identifier of the cancelled cancellation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementCancellationRequestId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementCancellationRequestId property is set.
        /// </summary>
        internal bool IsSetAgreementCancellationRequestId() => this.AgreementCancellationRequestId != null;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with this cancellation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the cancellation request was originally created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the original cancellation reason, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The original reason code provided when the cancellation request was created.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status of the cancellation request, which is <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional context about the cancellation request status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the cancellation request was cancelled.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
