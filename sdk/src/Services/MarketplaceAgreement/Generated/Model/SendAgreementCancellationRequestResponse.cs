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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
    /// This is the response object from the SendAgreementCancellationRequest operation.
    /// </summary>
    public partial class SendAgreementCancellationRequestResponse : AmazonWebServiceResponse
    {
        private string _agreementCancellationRequestId;
        private string _agreementId;
        private DateTime? _createdAt;
        private string _description;
        private AgreementCancellationRequestReasonCode _reasonCode;
        private AgreementCancellationRequestStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgreementCancellationRequestId. 
        /// <para>
        /// The unique identifier for the created cancellation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementCancellationRequestId
        {
            get { return this._agreementCancellationRequestId; }
            set { this._agreementCancellationRequestId = value; }
        }

        // Check to see if AgreementCancellationRequestId property is set
        internal bool IsSetAgreementCancellationRequestId()
        {
            return this._agreementCancellationRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the cancellation request was created, as a POSIX timestamp (Unix epoch
        /// seconds).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the cancellation reason, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason code provided for the cancellation.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cancellation request. The initial status is <c>PENDING_APPROVAL</c>.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the cancellation request was last updated, as a POSIX timestamp (Unix
        /// epoch seconds).
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}