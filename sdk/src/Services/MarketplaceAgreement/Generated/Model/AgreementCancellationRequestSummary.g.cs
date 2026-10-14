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
    /// Summary view of an agreement cancellation request.
    /// </summary>
    public partial class AgreementCancellationRequestSummary
    {
        /// <summary>
        /// Gets and sets the property AgreementCancellationRequestId. 
        /// <para>
        /// The unique identifier of the cancellation request.
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
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// The type of agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Checks to see if the AgreementType property is set.
        /// </summary>
        internal bool IsSetAgreementType() => this.AgreementType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which the agreement was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the cancellation request was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason code provided for the cancellation.
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
        /// The current status of the cancellation request. Possible values include <c>PENDING_APPROVAL</c>,
        /// <c>APPROVED</c>, <c>REJECTED</c>, <c>CANCELLED</c>, and <c>VALIDATION_FAILED</c>.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the cancellation request was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
