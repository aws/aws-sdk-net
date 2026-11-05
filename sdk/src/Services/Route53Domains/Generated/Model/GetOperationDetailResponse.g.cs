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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// This is the response object from the GetOperationDetail operation.
    /// </summary>
    public partial class GetOperationDetailResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        ///  The date when the operation was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Detailed information on the status including possible errors.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The identifier for the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the requested operation in the system.
        /// </para>
        /// </summary>
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusFlag. 
        /// <para>
        ///  Lists any outstanding operations that require customer action. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING_ACCEPTANCE</c>: The operation is waiting for acceptance from the account
        /// that is receiving the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_CUSTOMER_ACTION</c>: The operation is waiting for customer action, for
        /// example, returning an email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_AUTHORIZATION</c>: The operation is waiting for the form of authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ResendOperationAuthorization.html">ResendOperationAuthorization</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_PAYMENT_VERIFICATION</c>: The operation is waiting for the payment method
        /// to validate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_SUPPORT_CASE</c>: The operation includes a support case and is waiting
        /// for its resolution.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusFlag StatusFlag { get; set; }

        /// <summary>
        /// Checks to see if the StatusFlag property is set.
        /// </summary>
        internal bool IsSetStatusFlag() => this.StatusFlag != null;

        /// <summary>
        /// Gets and sets the property SubmittedDate. 
        /// <para>
        /// The date when the request was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedDate property is set.
        /// </summary>
        internal bool IsSetSubmittedDate() => this.SubmittedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of operation that was requested.
        /// </para>
        /// </summary>
        public OperationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
